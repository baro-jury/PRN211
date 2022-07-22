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

namespace KaraokeBar
{
    public partial class frmAdmin : Form
    {
        public Account CurrentAccount { get; }

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
            }
        }

        private void LoadBillsData()
        {
            using (var context = new KaraokeContext())
            {
                dgvBill.DataSource = context.Bills.
                    Select(x => new { x.BillId, x.UserName, x.OrderDate, x.PaymentMethod, x.Status }).
                    ToList();
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
            }
        }

        private void LoadOrdersData(string username)
        {
            using (var context = new KaraokeContext())
            {
                dgvOrder.DataSource = context.Orders.
                    Select(x => new { x.User, x.Service.ServiceName, x.Quantity, x.TotalPayment }).
                    Where(x => x.User.Equals(username)).
                    ToList();
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
                    dgvOrder.DataSource = null;
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
                LoadOrdersData(dgvBill.Rows[e.RowIndex].Cells["Username"].Value.ToString());
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
        #endregion
    }
}
