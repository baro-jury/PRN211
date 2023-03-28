using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaraokeBar.Models;
using Microsoft.EntityFrameworkCore;

namespace KaraokeBar
{
    public partial class frmAdmin : Form
    {
        public Account CurrentAccount { get; }
        Account account = new Account();
        Bill bill = new Bill();
        Music music = new Music();
        Order order = new Order();
        Room room = new Room();
        Service service = new Service();
        TypeOfRoom typeOfRoom = new TypeOfRoom();

        public frmAdmin()
        {
            InitializeComponent();
        }

        public frmAdmin(Account a)
        {
            InitializeComponent();
            CurrentAccount = a;
        }

        #region Function
        private void LoadAccountsData()
        {
            using (var context = new KaraokeContext())
            {
                dgvAccount.DataSource = context.Accounts.
                    Select(x => new { x.DisplayName, x.UserName, x.Password, x.Permission }).
                    ToList();
                cbAccPermission.DataSource = context.Accounts.Select(x => x.Permission.ToString()).Distinct().ToList();
                cbAccPermission.Text = null;
            }
        }

        private void LoadBillsData()
        {
            using (var context = new KaraokeContext())
            {
                dgvBill.DataSource = context.Bills.
                    Select(x => new { x.BillId, x.UserName, x.OrderDate, x.PaymentMethod, x.Status }).
                    ToList();
                cbBillMethod.DataSource = context.Bills.Select(x => x.PaymentMethod.ToString()).Distinct().ToList();
                cbBillMethod.Text = null;
            }
        }

        private void LoadBillsData(string Username)
        {
            using (var context = new KaraokeContext())
            {
                dgvBill.DataSource = context.Bills.
                    Select(x => new { x.BillId, x.UserName, x.OrderDate, x.PaymentMethod, x.Status }).
                    Where(x => x.UserName.Equals(Username)).
                    ToList();
                cbBillMethod.DataSource = context.Bills.Select(x => x.PaymentMethod.ToString()).Distinct().ToList();
                cbBillMethod.Text = null;
            }
        }

        private void LoadOrdersData(int bill_id)
        {
            using (var context = new KaraokeContext())
            {
                dgvOrder.DataSource = context.Orders.
                    Select(x => new { x.BillId, x.User, x.ServiceId, x.Service.ServiceName, x.Quantity, x.TotalPayment, x.Status }).
                    Where(x => x.BillId == bill_id).
                    ToList();
                dgvOrder.Columns["BillId"].Visible = false;
                dgvOrder.Columns["ServiceId"].Visible = false;
                cbOrdUser.DataSource = context.Accounts.Select(x => x.UserName.ToString()).Distinct().ToList();
                cbOrdUser.Text = null;
                cbOrdService.DataSource = context.Services.Select(x => x.ServiceId.ToString()).Distinct().ToList();
                cbOrdService.Text = null;
            }
        }

        private void LoadMusicsData()
        {
            using (var context = new KaraokeContext())
            {
                dgvMusic.DataSource = context.Musics.ToList();
            }
        }

        private void LoadRoomTypesData()
        {
            using (var context = new KaraokeContext())
            {
                dgvRoomType.DataSource = context.TypeOfRooms.
                    Select(x => new { x.TypeId, x.TypeName }).
                    ToList();
            }
        }

        private void LoadServicesData()
        {
            using (var context = new KaraokeContext())
            {
                dgvService.DataSource = context.Services.
                    Select(x => new { x.ServiceId, x.RoomTypeNavigation.TypeName, x.ServiceName, x.Price, x.Quantity }).
                    ToList();
                cbSerRoomtype.DataSource = context.TypeOfRooms.Select(x => x.TypeId.ToString()).Distinct().ToList();
                cbSerRoomtype.Text = null;
            }
        }

        private void LoadServicesData(int Room_type)
        {
            using (var context = new KaraokeContext())
            {
                dgvService.DataSource = context.Services.
                    Select(x => new { x.ServiceId, x.RoomType, x.RoomTypeNavigation.TypeName, x.ServiceName, x.Price, x.Quantity }).
                    Where(x => x.RoomType == Room_type).
                    ToList();
                dgvService.Columns["RoomType"].Visible = false;
                cbSerRoomtype.DataSource = context.TypeOfRooms.Select(x => x.TypeId.ToString()).Distinct().ToList();
                cbSerRoomtype.Text = null;
            }
        }

        private void LoadRoomsData()
        {
            using (var context = new KaraokeContext())
            {
                dgvRoom.DataSource = context.Rooms.
                    Select(x => new { x.Floor, x.RoomNumber, x.Type, x.TypeNavigation.TypeName, x.Price, x.Status }).
                    ToList();
                dgvRoom.Columns["Type"].Visible = false;
                cbRoomType.DataSource = context.TypeOfRooms.Select(x => x.TypeId.ToString()).Distinct().ToList();
                cbRoomType.Text = null;
            }
        }

        private void dgv_Click(DataGridView dgv)
        {
            if (dgv.CurrentRow.Index != -1)
            {
                if (dgv == dgvAccount)
                {
                    account.UserName = dgvAccount.CurrentRow.Cells["Username"].Value.ToString();
                    using (var context = new KaraokeContext())
                    {
                        account = context.Accounts.FirstOrDefault(x => x.UserName == account.UserName);
                        tbAccName.Text = account.DisplayName;
                        tbAccUsername.Text = account.UserName;
                        tbAccPassword.Text = account.Password;
                        cbAccPermission.Text = account.Permission;
                    }
                }
                else if (dgv == dgvBill)
                {
                    bill.BillId = Convert.ToInt32(dgvBill.CurrentRow.Cells["BillId"].Value);
                    using (var context = new KaraokeContext())
                    {
                        bill = context.Bills.FirstOrDefault(x => x.BillId == bill.BillId);
                        tbBillId.Text = Convert.ToString(bill.BillId);
                        tbBillUser.Text = bill.UserName;
                        dtpBillDate.Value = bill.OrderDate;
                        cbBillMethod.Text = bill.PaymentMethod;
                        rbPaid.Checked = bill.Status;
                        rbNotPaid.Checked = !bill.Status;
                    }
                }
                else if (dgv == dgvMusic)
                {
                    music.MusicId = dgvMusic.CurrentRow.Cells["MusicId"].Value.ToString();
                    using (var context = new KaraokeContext())
                    {
                        music = context.Musics.FirstOrDefault(x => x.MusicId == music.MusicId);
                        tbMusicId.Text = music.MusicId;
                        tbMusicAName.ForeColor = Color.Black;
                        tbMusicAName.Text = music.AccentedName;
                        tbMusicUName.ForeColor = Color.Black;
                        tbMusicUName.Text = music.UnaccentedName;
                        tbMusicGenre.Text = music.Genre;
                        tbMusicComposer.Text = music.Composer;
                        tbMusicSinger.Text = music.Singer;
                        rtbMusicLyric.Text = music.Lyric;
                        tbMusicAbbreviation.Text = music.Abbreviation;
                        tbMusicLink.Text = music.Link;
                    }
                }
                else if (dgv == dgvOrder)
                {
                    if (dgvOrder.CurrentRow.Index != -1)
                    {
                        cbOrdUser.Text = dgvOrder.CurrentRow.Cells["User"].Value.ToString();
                        cbOrdService.Text = dgvOrder.CurrentRow.Cells["ServiceId"].Value.ToString();
                        order.Quantity = Convert.ToInt32(dgvOrder.CurrentRow.Cells["Quantity"].Value);
                        order.Status = Convert.ToBoolean(dgvOrder.CurrentRow.Cells["Status"].Value);
                    }
                }
                else if (dgv == dgvRoom)
                {
                    room.Floor = Convert.ToInt32(dgvRoom.CurrentRow.Cells["Floor"].Value);
                    room.RoomNumber = Convert.ToInt32(dgvRoom.CurrentRow.Cells["RoomNumber"].Value);
                    using (var context = new KaraokeContext())
                    {
                        room = context.Rooms.FirstOrDefault(x => x.Floor == room.Floor && x.RoomNumber == room.RoomNumber);
                        nudRoomFloor.Value = room.Floor;
                        nudRoomNumber.Value = room.RoomNumber;
                        cbRoomType.Text = Convert.ToString(room.Type);
                        nudRoomPrice.Value = room.Price;
                        rbUsing.Checked = room.Status;
                        rbIdle.Checked = !room.Status;
                    }
                }
                else if (dgv == dgvService)
                {
                    service.ServiceId = dgvService.CurrentRow.Cells["ServiceId"].Value.ToString();
                    using (var context = new KaraokeContext())
                    {
                        service = context.Services.FirstOrDefault(x => x.ServiceId == service.ServiceId);
                        tbSerId.Text = service.ServiceId;
                        cbSerRoomtype.Text = Convert.ToString(service.RoomType);
                        tbSerName.Text = service.ServiceName;
                        nudSerPrice.Value = service.Price;
                        nudSerQty.Value = service.Quantity;
                    }
                }
                else
                {
                    typeOfRoom.TypeId = Convert.ToInt32(dgvRoomType.CurrentRow.Cells["TypeId"].Value);
                    using (var context = new KaraokeContext())
                    {
                        typeOfRoom = context.TypeOfRooms.FirstOrDefault(x => x.TypeId == typeOfRoom.TypeId);
                        nudRoomtypeId.Value = typeOfRoom.TypeId;
                        tbRoomtypeName.Text = typeOfRoom.TypeName;
                    }
                }
            }
        }
        #endregion

        #region Event
        private void tcManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tcManagement.SelectedIndex)
            {
                case 0:
                    LoadAccountsData();
                    break;
                case 1:
                    LoadBillsData();
                    break;
                case 2:
                    LoadOrdersData(0);
                    break;
                case 3:
                    LoadMusicsData();
                    break;
                case 4:
                    LoadRoomTypesData();
                    break;
                case 5:
                    LoadRoomsData();
                    break;
                case 6:
                    LoadServicesData();
                    break;
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            LoadAccountsData();
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvAccount.Columns[e.ColumnIndex].Name.Equals("billCol"))
            {
                tcManagement.SelectedIndex = 1;
                LoadBillsData(dgvAccount.Rows[e.RowIndex].Cells["Username"].Value.ToString());
            }
        }

        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvBill.Columns[e.ColumnIndex].Name.Equals("orderCol"))
            {
                tcManagement.SelectedIndex = 2;
                LoadOrdersData(Convert.ToInt32(dgvBill.Rows[e.RowIndex].Cells["BillId"].Value));
            }
        }

        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvRoom.Columns[e.ColumnIndex].Name.Equals("serviceCol"))
            {
                tcManagement.SelectedIndex = 6;
                LoadServicesData(Convert.ToInt32(dgvRoom.Rows[e.RowIndex].Cells["Type"].Value));
            }
        }

        private void btCreateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                account.DisplayName = tbAccName.Text.Trim();
                account.UserName = tbAccUsername.Text.Trim();
                account.Password = tbAccPassword.Text.Trim();
                account.Permission = cbAccPermission.Text;
                using (var context = new KaraokeContext())
                {
                    context.Accounts.Add(account);
                    context.SaveChanges();
                    LoadAccountsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btReadAcc_Click(object sender, EventArgs e)
        {
            using (var context = new KaraokeContext())
            {
                dgvAccount.DataSource = context.Accounts.
                    Select(x => new { x.DisplayName, x.UserName, x.Password, x.Permission }).
                    Where(x => x.DisplayName.ToLower().Contains(tbAccName.Text.Trim().ToLower())
                    && x.UserName.ToLower().Contains(tbAccUsername.Text.Trim().ToLower())
                    //&& x.Password.ToLower().Contains(tbAccPassword.Text.Trim().ToLower())
                    && x.Permission.Contains(cbAccPermission.Text)
                    ).
                    ToList();
            }
        }

        private void btUpdateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                account.DisplayName = tbAccName.Text.Trim();
                account.UserName = tbAccUsername.Text.Trim();
                account.Password = tbAccPassword.Text.Trim();
                account.Permission = cbAccPermission.Text;
                using (var context = new KaraokeContext())
                {
                    context.Entry(account).State = EntityState.Modified;
                    context.SaveChanges();
                    LoadAccountsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btDeleteAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAccount.CurrentRow.Index != -1)
                {
                    account.UserName = dgvAccount.CurrentRow.Cells["Username"].Value.ToString();
                    using (var context = new KaraokeContext())
                    {
                        account = context.Accounts.FirstOrDefault(x => x.UserName == account.UserName);
                        context.Accounts.Remove(account);
                        context.SaveChanges();
                        LoadAccountsData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btReadBill_Click(object sender, EventArgs e)
        {
            using (var context = new KaraokeContext())
            {
                dgvBill.DataSource = context.Accounts.
                    Select(x => new { x.DisplayName, x.UserName, x.Password, x.Permission }).
                    Where(x => x.DisplayName.ToLower().Contains(tbAccName.Text.Trim().ToLower())
                    && x.UserName.ToLower().Contains(tbAccUsername.Text.Trim().ToLower())
                    //&& x.Password.ToLower().Contains(tbAccPassword.Text.Trim().ToLower())
                    && x.Permission.Contains(cbAccPermission.Text)
                    ).
                    ToList();
            }
        }

        private void btUpdateBill_Click(object sender, EventArgs e)
        {
            bill.UserName = tbBillUser.Text.Trim();
            bill.OrderDate = dtpBillDate.Value;
            bill.PaymentMethod = cbBillMethod.Text;
            bill.Status = true ? rbPaid.Checked : rbNotPaid.Checked;
            using (var context = new KaraokeContext())
            {
                context.Entry(bill).State = EntityState.Modified;
                context.SaveChanges();
                LoadBillsData();
            }
        }

        private void btReadOrd_Click(object sender, EventArgs e)
        {
            using (var context = new KaraokeContext())
            {
                dgvOrder.DataSource = context.Orders.
                    Select(x => new { x.BillId, x.User, x.ServiceId, x.Quantity, x.TotalPayment, x.Status }).
                    Where(x => x.User.Contains(cbOrdUser.Text)
                    && x.ServiceId.Contains(cbOrdService.Text)
                    && x.Quantity == nudOrdQty.Value
                    && x.Status == rbDone.Checked
                    ).
                    ToList();
            }
        }

        private void btUpdateOrd_Click(object sender, EventArgs e)
        {
            //order.User = cbOrdUser.Text;
            //order.ServiceId = cbOrdService.Text;
            //order.Quantity = Convert.ToInt32(nudOrdQty.Value);
            //order.Status = true ? rbDone.Checked : rbDoing.Checked;
            //using (var context = new KaraokeContext())
            //{+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            //    context.Entry(order).State = EntityState.Modified;
            //    context.SaveChanges();
            //    LoadOrdersData(order.BillId);
            //}
        }

        private void btDeleteOrd_Click(object sender, EventArgs e)
        {

        }

        private void btCreateMusic_Click(object sender, EventArgs e)
        {
            try
            {
                music.MusicId = tbMusicId.Text.Trim();
                music.AccentedName = tbMusicAName.Text.Trim();
                music.UnaccentedName = tbMusicUName.Text.Trim();
                music.Genre = tbMusicGenre.Text;
                music.Composer = tbMusicComposer.Text.Trim();
                music.Singer = tbMusicSinger.Text.Trim();
                music.Lyric = rtbMusicLyric.Text;
                music.Abbreviation = tbMusicAbbreviation.Text.Trim();
                music.Link = tbMusicLink.Text.Trim();
                using (var context = new KaraokeContext())
                {
                    context.Musics.Add(music);
                    context.SaveChanges();
                    LoadMusicsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btReadMusic_Click(object sender, EventArgs e)
        {
            using (var context = new KaraokeContext())
            {
                string nameSearch = tbMusicAName.Text.Trim().ToLower();
                char[] vietnameseChar = "àáâãèéêìíòóôõùúăđĩũơưăạảấầẩẫậắằẳẵặẹẻẽềềểễệỉịọỏốồổỗộớờởỡợụủứừửữựỳỵỷỹ".ToCharArray();
                bool checkVietChar = false;
                for (int i = 0; i < vietnameseChar.Length; i++)
                {
                    if (nameSearch.Contains(vietnameseChar[i]))
                    {
                        checkVietChar = true;
                        break;
                    }
                }
                dgvMusic.DataSource = context.Musics.
                    Where(x => checkVietChar ? x.AccentedName.ToLower().Contains(nameSearch) : x.UnaccentedName.ToLower().Contains(nameSearch)
                    && x.Genre.Contains(tbMusicGenre.Text.Trim().ToLower())
                    && x.Composer.ToLower().Contains(tbMusicComposer.Text.Trim().ToLower())
                    && x.Singer.ToLower().Contains(tbMusicSinger.Text.Trim().ToLower())
                    //&& x.Lyric.ToLower().Contains(rtbMusicLyric.Text.Trim().ToLower())
                    && x.Abbreviation.ToLower().Contains(tbMusicAbbreviation.Text.Trim().ToLower())
                    //&& x.Link.Contains(tbMusicLink.Text.Trim().ToLower())
                    ).
                    ToList();
            }
        }

        private void btUpdateMusic_Click(object sender, EventArgs e)
        {
            music.MusicId = tbMusicId.Text.Trim();
            music.AccentedName = tbMusicAName.Text.Trim();
            music.UnaccentedName = tbMusicUName.Text.Trim();
            music.Genre = tbMusicGenre.Text;
            music.Composer = tbMusicComposer.Text.Trim();
            music.Singer = tbMusicSinger.Text.Trim();
            music.Lyric = rtbMusicLyric.Text;
            music.Abbreviation = tbMusicAbbreviation.Text.Trim();
            music.Link = tbMusicLink.Text;
            using (var context = new KaraokeContext())
            {
                context.Entry(music).State = EntityState.Modified;
                context.SaveChanges();
                LoadMusicsData();
            }
        }

        private void btDeleteMusic_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMusic.CurrentRow.Index != -1)
                {
                    music.MusicId = dgvMusic.CurrentRow.Cells["MusicId"].Value.ToString();
                    using (var context = new KaraokeContext())
                    {
                        music = context.Musics.FirstOrDefault(x => x.MusicId == music.MusicId);
                        context.Musics.Remove(music);
                        context.SaveChanges();
                        LoadMusicsData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btCreateRoomtype_Click(object sender, EventArgs e)
        {
            try
            {
                typeOfRoom.TypeId = Convert.ToInt32(nudRoomtypeId.Value);
                typeOfRoom.TypeName = tbRoomtypeName.Text.Trim();
                using (var context = new KaraokeContext())
                {
                    context.TypeOfRooms.Add(typeOfRoom);
                    context.SaveChanges();
                    LoadRoomTypesData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btReadRoomtype_Click(object sender, EventArgs e)
        {
            using (var context = new KaraokeContext())
            {
                dgvRoomType.DataSource = context.TypeOfRooms.
                    Select(x => new { x.TypeId, x.TypeName }).
                    Where(x => x.TypeId == nudRoomtypeId.Value
                    && x.TypeName.ToLower().Contains(tbRoomtypeName.Text.Trim().ToLower())
                    ).
                    ToList();
            }
        }

        private void btUpdateRoomtype_Click(object sender, EventArgs e)
        {
            typeOfRoom.TypeId = Convert.ToInt32(nudRoomtypeId.Value);
            typeOfRoom.TypeName = tbRoomtypeName.Text.Trim();
            using (var context = new KaraokeContext())
            {
                context.Entry(typeOfRoom).State = EntityState.Modified;
                context.SaveChanges();
                LoadRoomTypesData();
            }
        }

        private void btDeleteRoomtype_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoomType.CurrentRow.Index != -1)
                {
                    typeOfRoom.TypeId = Convert.ToInt32(dgvRoomType.CurrentRow.Cells["TypeId"].Value);
                    using (var context = new KaraokeContext())
                    {
                        typeOfRoom = context.TypeOfRooms.FirstOrDefault(x => x.TypeId == typeOfRoom.TypeId);
                        context.TypeOfRooms.Remove(typeOfRoom);
                        context.SaveChanges();
                        LoadRoomTypesData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btCreateRoom_Click(object sender, EventArgs e)
        {
            try
            {
                room.Floor = Convert.ToInt32(nudRoomFloor.Value);
                room.RoomNumber = Convert.ToInt32(nudRoomNumber.Value);
                room.Type = Convert.ToInt32(cbRoomType.Text);
                room.Price = Convert.ToInt32(nudRoomPrice.Value);
                room.Status = true ? rbUsing.Checked : rbIdle.Checked;
                using (var context = new KaraokeContext())
                {
                    context.Rooms.Add(room);
                    context.SaveChanges();
                    LoadRoomsData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btReadRoom_Click(object sender, EventArgs e)
        {
            using (var context = new KaraokeContext())
            {
                dgvRoom.DataSource = context.Rooms.
                    Select(x => new { x.Floor, x.RoomNumber, x.Type, x.Price, x.Status }).
                    Where(x => x.Floor == nudRoomFloor.Value
                    && x.RoomNumber == nudRoomNumber.Value
                    && x.Type == Convert.ToInt32(cbRoomType.Text)
                    && x.Price == nudRoomPrice.Value
                    && x.Status == rbUsing.Checked
                    ).
                    ToList();
            }
        }

        private void btUpdateRoom_Click(object sender, EventArgs e)
        {
            room.Floor = Convert.ToInt32(nudRoomFloor.Value);
            room.RoomNumber = Convert.ToInt32(nudRoomNumber.Value);
            room.Type = Convert.ToInt32(cbRoomType.Text);
            room.Price = Convert.ToInt32(nudRoomPrice.Value);
            room.Status = true ? rbUsing.Checked : rbIdle.Checked;
            using (var context = new KaraokeContext())
            {
                context.Entry(room).State = EntityState.Modified;
                context.SaveChanges();
                LoadRoomsData();
            }
        }

        private void btDeleteRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoom.CurrentRow.Index != -1)
                {
                    room.Floor = Convert.ToInt32(dgvRoom.CurrentRow.Cells["Floor"].Value);
                    room.RoomNumber = Convert.ToInt32(dgvRoom.CurrentRow.Cells["RoomNumber"].Value);
                    using (var context = new KaraokeContext())
                    {
                        room = context.Rooms.FirstOrDefault(x => x.Floor == room.Floor && x.RoomNumber == room.RoomNumber);
                        context.Rooms.Remove(room);
                        context.SaveChanges();
                        LoadRoomsData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btCreateService_Click(object sender, EventArgs e)
        {
            try
            {
                service.ServiceId = tbSerId.Text.Trim();
                service.RoomType = Convert.ToInt32(cbSerRoomtype.Text);
                service.ServiceName = tbSerName.Text.Trim();
                service.Price = Convert.ToInt32(nudSerPrice.Value);
                service.Quantity = Convert.ToInt32(nudSerQty.Value);
                using (var context = new KaraokeContext())
                {
                    context.Services.Add(service);
                    context.SaveChanges();
                    LoadServicesData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void btReadService_Click(object sender, EventArgs e)
        {
            using (var context = new KaraokeContext())
            {
                dgvService.DataSource = context.Services.
                    Select(x => new { x.ServiceId, x.RoomType, x.ServiceName, x.Price, x.Quantity }).
                    Where(x => x.ServiceId.ToLower().Contains(tbSerId.Text.Trim().ToLower())
                    && x.RoomType == Convert.ToInt32(cbSerRoomtype.Text)
                    && x.ServiceName.ToLower().Contains(tbSerName.Text.Trim().ToLower())
                    && x.Price == nudSerPrice.Value
                    && x.Quantity == nudSerQty.Value
                    ).
                    ToList();
            }
        }

        private void btUpdateService_Click(object sender, EventArgs e)
        {
            service.ServiceId = tbSerId.Text.Trim();
            service.RoomType = Convert.ToInt32(cbSerRoomtype.Text);
            service.ServiceName = tbSerName.Text.Trim();
            service.Price = Convert.ToInt32(nudSerPrice.Value);
            service.Quantity = Convert.ToInt32(nudSerQty.Value);
            using (var context = new KaraokeContext())
            {
                context.Entry(service).State = EntityState.Modified;
                context.SaveChanges();
                LoadServicesData();
            }
        }

        private void btDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvService.CurrentRow.Index != -1)
                {
                    service.ServiceId = dgvService.CurrentRow.Cells["ServiceId"].Value.ToString();
                    using (var context = new KaraokeContext())
                    {
                        service = context.Services.FirstOrDefault(x => x.ServiceId == service.ServiceId);
                        context.Services.Remove(service);
                        context.SaveChanges();
                        LoadServicesData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void tbMusicAName_Enter(object sender, EventArgs e)
        {
            if (tbMusicAName.Text == "Accented Name")
            {
                tbMusicAName.Text = "";
                tbMusicAName.ForeColor = Color.Black;
            }
        }

        private void tbMusicAName_Leave(object sender, EventArgs e)
        {
            if (tbMusicAName.Text == "")
            {
                tbMusicAName.Text = "Accented Name";
                tbMusicAName.ForeColor = Color.Silver;
            }
        }

        private void tbMusicUName_Enter(object sender, EventArgs e)
        {
            if (tbMusicUName.Text == "Unaccented Name")
            {
                tbMusicUName.Text = "";
                tbMusicUName.ForeColor = Color.Black;
            }
        }

        private void tbMusicUName_Leave(object sender, EventArgs e)
        {
            if (tbMusicUName.Text == "")
            {
                tbMusicUName.Text = "Unaccented Name";
                tbMusicUName.ForeColor = Color.Silver;
            }
        }

        private void dgvAccount_Click(object sender, EventArgs e)
        {
            dgv_Click(dgvAccount);
        }

        private void dgvBill_Click(object sender, EventArgs e)
        {
            dgv_Click(dgvBill);
        }

        private void dgvOrder_Click(object sender, EventArgs e)
        {
            dgv_Click(dgvOrder);
        }

        private void dgvMusic_Click(object sender, EventArgs e)
        {
            dgv_Click(dgvMusic);
        }

        private void dgvRoomType_Click(object sender, EventArgs e)
        {
            dgv_Click(dgvRoomType);
        }

        private void dgvRoom_Click(object sender, EventArgs e)
        {
            dgv_Click(dgvRoom);
        }

        private void dgvService_Click(object sender, EventArgs e)
        {
            dgv_Click(dgvService);
        }
        #endregion
    }
}
