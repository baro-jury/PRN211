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
        //List<Order> OrderList = new KaraokeContext().Orders.ToList();
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
            }
        }

        private void LoadOrdersData(int billId)
        {
            using (var context = new KaraokeContext())
            {
                dgvOrder.DataSource = context.Orders.
                    Select(x => new { x.BillId, x.User, x.ServiceId, x.Quantity, x.TotalPayment }).
                    Where(x => x.BillId == billId && x.User.Equals(CurrentAccount.UserName)).
                    ToList();
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
            dgvOrder.Columns["serName"].DataPropertyName = "ServiceId";
            dgvOrder.Columns["serQty"].DataPropertyName = "Quantity";
            dgvOrder.Columns["total"].DataPropertyName = "TotalPayment";
            LoadServicesData();
        }

        private void dgvOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvOrder.Columns[e.ColumnIndex].Name.Equals("removeCol"))
            {
                using (var context = new KaraokeContext())
                {
                    //order.BillId = 0;
                    //order.User = CurrentAccount.UserName;
                    //order.ServiceId = dgvService.Rows[e.RowIndex].Cells["serviceidCol"].Value.ToString();
                    //order.Quantity = 1;
                    //order.Service = context.Services.FirstOrDefault(x => x.ServiceId.Equals(order.ServiceId));
                    //order.TotalPayment = order.Quantity * order.Service.Price;
                    //order.Status = false;

                    //order = context.Orders.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
                    //context.Employees.Remove(employee);
                    //context.SaveChanges();
                    //LoadOrdersData();

                    //dgvOrder.DataSource = (from ord in OrderList select new { ord.ServiceId, ord.Quantity, ord.TotalPayment }).ToList();
                }
            }
        }
        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Order> temp = OrderList;
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvService.Columns[e.ColumnIndex].Name.Equals("orderCol"))
            {
                using (var context = new KaraokeContext())
                {
                    //order.OrderId = 0;
                    order.BillId = 0;
                    order.User = CurrentAccount.UserName;
                    order.ServiceId = dgvService.Rows[e.RowIndex].Cells["serviceidCol"].Value.ToString();
                    order.Quantity = 1;
                    order.Service = context.Services.FirstOrDefault(x => x.ServiceId.Equals(order.ServiceId));
                    order.TotalPayment = order.Quantity * order.Service.Price;
                    order.Status = false;

                    context.Orders.Add(order);
                    context.SaveChanges();
                    LoadOrdersData(order.BillId);

                    //bool checkOrder = false;
                    //Order obj = temp.FirstOrDefault(x => x.ServiceId.Equals(order.ServiceId));
                    //if (obj != null)
                    //{
                    //    obj.Quantity = obj.Quantity + 1;
                    //    checkOrder = true;
                    //}

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

                    //if (!checkOrd(temp, order))
                    //{
                    //    temp.Add(order);
                    //}
                    //else
                    //{
                    //    //quantity + 1
                    //}

                    //OrderList = temp;
                    //dgvOrder.DataSource = (from ord in OrderList select new { ord.ServiceId, ord.Quantity, ord.TotalPayment }).ToList();
                }
            }
        }

        private bool checkOrd(List<Order> list, Order ord)
        {
            foreach (Order order in list)
            {
                if (ord.ServiceId.Equals(order.ServiceId))
                {
                    return true;
                }
            }
            return false;
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            //foreach (Order ord in OrderList) { 
            //    using (var context = new KaraokeContext())
            //    {
            //        context.Orders.Add(ord);
            //        context.SaveChanges();
            //    }
            //}
            this.Visible = false;
            MessageBox.Show("Order successfully!");
        }
        
        #endregion
    }
}
