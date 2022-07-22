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
    public partial class frmMenu : Form
    {
        public Account CurrentAccount { get; }
        List<Order> OrderList = new List<Order>();
        Order order = new Order();

        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(Account a)
        {
            InitializeComponent();
            CurrentAccount = a;
        }

        #region Function
        private void LoadServicesData()
        {
            using (var context = new KaraokeContext())
            {
                dgvService.DataSource = context.Services.Where(x => x.RoomTypeNavigation.TypeName.Equals(CurrentAccount.Permission)).ToList();
                
                //dgvService.DataSource = context.Services.
                //    Select(x => new { x.RoomTypeNavigation.TypeName, x.ServiceName, x.Price, x.Quantity }).
                //    Where(x => x.RoomTypeNavigation.TypeName.Equals(CurrentAccount.Permission)).
                //    ToList();
            }
        }
        #endregion

        #region Event
        private void frmMenu_Load(object sender, EventArgs e)
        {
            dgvService.AutoGenerateColumns = false;
            dgvService.Columns["serviceidCol"].DataPropertyName = "ServiceId";
            dgvService.Columns["nameCol"].DataPropertyName = "ServiceName";
            dgvService.Columns["priceCol"].DataPropertyName = "Price";
            dgvService.Columns["quantityCol"].DataPropertyName = "Quantity";
            dgvOrder.AutoGenerateColumns = false;
            //dgvOrder.Columns["serName"].DataPropertyName = "User";
            //dgvOrder.Columns["serPrice"].DataPropertyName = "Quantity";
            //dgvOrder.Columns["serQty"].DataPropertyName = "Quantity";
            //dgvOrder.Columns["total"].DataPropertyName = "TotalPayment";
            LoadServicesData();
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvService.Columns[e.ColumnIndex].Name.Equals("orderCol"))
            {
                List<Order> temp = OrderList;
                using (var context = new KaraokeContext())
                {
                    order.BillId = 2;
                    order.User = CurrentAccount.UserName;
                    order.ServiceId = dgvService.Rows[e.RowIndex].Cells["serviceidCol"].Value.ToString();
                    order.Quantity = 1;
                    order.Service = context.Services.FirstOrDefault(x => x.ServiceId.Equals(order.ServiceId));
                    order.TotalPayment = order.Quantity * order.Service.Price;

                    bool checkOrder = false;
                    var obj = temp.FirstOrDefault(x => x.ServiceId.Equals(order.ServiceId));
                    if (obj != null)
                    {
                        obj.Quantity = obj.Quantity + 1;
                        checkOrder = true;
                    }

                    //if (OrderList.Count != 0)
                    //{
                    //    foreach (Order o in OrderList)
                    //    {
                    //        if (o.ServiceId.Equals(order.ServiceId))
                    //        {
                    //            o.Quantity = o.Quantity + 1;
                    //            checkOrder = true;
                    //            break;
                    //        }
                    //    }
                    //}

                    if (!checkOrder)
                    {
                        temp.Add(order);
                    }
                    OrderList = temp;
                    dgvOrder.DataSource = (from ord in OrderList select new { ord.Service.ServiceName, ord.Service.Price, ord.Quantity, ord.TotalPayment }).ToList();
                }
            }
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        #endregion
    }
}
