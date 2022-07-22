using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KaraokeBar.Models;

namespace KaraokeBar
{
    public partial class frmMusic : Form
    {
        public Account CurrentAccount { get; }
        frmMenu menuForm = new frmMenu();

        public frmMusic()
        {
            InitializeComponent();
            //menuForm.Show();
            //menuForm.Visible = false;
        }

        public frmMusic(Account a)
        {
            InitializeComponent();
            CurrentAccount = a;
            //menuForm = new frmMenu(a);
            //menuForm.Show();
            //menuForm.Visible = false;
        }

        #region Function
        private void LoadDataForDGV()
        {
            using (var context = new KaraokeContext())
            {
                dgvMusic.DataSource = context.Musics.
                    Select(x => new { x.AccentedName, x.Genre, x.Composer, x.Singer, x.Lyric, x.Link }).
                    ToList();
                cbGenre.DataSource = context.Musics.Select(x => x.Genre.ToString()).Distinct().ToList();
                cbGenre.Text = null;
            }
        }
        #endregion

        #region Event
        private void frmMusic_Load(object sender, EventArgs e)
        {
            dgvMusic.AutoGenerateColumns = false;

            dgvMusic.Columns.Add("NameCol", "Tên bài hát");
            dgvMusic.Columns["NameCol"].DataPropertyName = "AccentedName";

            dgvMusic.Columns.Add("GenreCol", "Thể loại");
            dgvMusic.Columns["GenreCol"].DataPropertyName = "Genre";

            dgvMusic.Columns.Add("ComposerCol", "Sáng tác");
            dgvMusic.Columns["ComposerCol"].DataPropertyName = "Composer";

            dgvMusic.Columns.Add("SingerCol", "Ca sĩ");
            dgvMusic.Columns["SingerCol"].DataPropertyName = "Singer";

            dgvMusic.Columns.Add("LyricCol", "Lời bài hát");
            dgvMusic.Columns["LyricCol"].DataPropertyName = "Lyric";
            dgvMusic.Columns["LyricCol"].Width = 490;

            dgvMusic.Columns.Add("LinkCol", "Link");
            dgvMusic.Columns["LinkCol"].DataPropertyName = "Link";
            dgvMusic.Columns["LinkCol"].Visible = false;

            LoadDataForDGV();
            lbUser.Text = "Welcome, " + CurrentAccount.DisplayName;
        }

        private void dgvMusic_DoubleClick(object sender, EventArgs e)
        {
            Process.Start("explorer", Convert.ToString(dgvMusic.CurrentRow.Cells["LinkCol"].Value));
        }

        private void gbSearch_Enter(object sender, EventArgs e)
        {
            using (var context = new KaraokeContext())
            {
                string nameSearch = tbName.Text.Trim().ToLower();
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
                    && x.Abbreviation.ToLower().Contains(tbAbbreviation.Text.Trim().ToLower())
                    && x.Composer.ToLower().Contains(tbComposer.Text.Trim().ToLower())
                    && x.Genre.Contains(cbGenre.Text)
                    ).
                    ToList();
            }
        }

        private void btOrder_Click(object sender, EventArgs e)
        {
            if (!menuForm.Created)
            {
                menuForm = new frmMenu(CurrentAccount);
            }
            menuForm.Visible = true;
        }
        
        private void btCheckout_Click(object sender, EventArgs e)
        {
            if (menuForm.Created)
            {
                menuForm.tcService.SelectedIndex = 1;
                menuForm.Visible = true;
            }
        }

        #endregion
    }
}
