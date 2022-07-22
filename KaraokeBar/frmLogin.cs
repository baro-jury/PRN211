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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        #region Function
        private void Login()
        {
            using (var context = new KaraokeContext())
            {
                List<Account> Accounts = context.Accounts.
                    Where(x => x.UserName.Equals(tbUsername.Text) && x.Password.Equals(tbPassword.Text)).ToList();
                if (Accounts.Count != 0)
                {
                    Account account = Accounts[0];
                    if (account.Permission.Equals("Administrator"))
                    {
                        frmAdmin newform = new frmAdmin(account);
                        newform.FormClosed += frm_Close;
                        newform.Show();
                        this.Visible = false;
                    }
                    else
                    {
                        frmMusic newform = new frmMusic(account);
                        newform.FormClosed += frm_Close;
                        newform.Show();
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                }
            }
        }

        private void frm_Close(object sender, EventArgs e)
        {
            tbUsername.Text = null;
            tbPassword.Text = null;
            tbUsername.Select();
            this.Visible = true;
        }

        #endregion

        #region Event
        private void btLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
        #endregion
    }
}
