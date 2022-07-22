namespace KaraokeBar
{
    partial class frmMusic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusic));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.btOrder = new System.Windows.Forms.Button();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.tbComposer = new System.Windows.Forms.TextBox();
            this.tbAbbreviation = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbComposer = new System.Windows.Forms.Label();
            this.lbGenre = new System.Windows.Forms.Label();
            this.lbAbbreviation = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.dgvMusic = new System.Windows.Forms.DataGridView();
            this.btCheckout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(917, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.AutoSize = true;
            this.lbUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbUser.Location = new System.Drawing.Point(1029, 483);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(51, 24);
            this.lbUser.TabIndex = 12;
            this.lbUser.Text = "User";
            // 
            // btOrder
            // 
            this.btOrder.Location = new System.Drawing.Point(764, 395);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(94, 29);
            this.btOrder.TabIndex = 10;
            this.btOrder.Text = "Order";
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // gbSearch
            // 
            this.gbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSearch.Controls.Add(this.cbGenre);
            this.gbSearch.Controls.Add(this.tbComposer);
            this.gbSearch.Controls.Add(this.tbAbbreviation);
            this.gbSearch.Controls.Add(this.tbName);
            this.gbSearch.Controls.Add(this.lbComposer);
            this.gbSearch.Controls.Add(this.lbGenre);
            this.gbSearch.Controls.Add(this.lbAbbreviation);
            this.gbSearch.Controls.Add(this.lbName);
            this.gbSearch.Location = new System.Drawing.Point(9, 351);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(715, 151);
            this.gbSearch.TabIndex = 9;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Search";
            this.gbSearch.Enter += new System.EventHandler(this.gbSearch_Enter);
            // 
            // cbGenre
            // 
            this.cbGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGenre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(467, 85);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(217, 28);
            this.cbGenre.TabIndex = 9;
            this.cbGenre.Enter += new System.EventHandler(this.gbSearch_Enter);
            // 
            // tbComposer
            // 
            this.tbComposer.Location = new System.Drawing.Point(467, 44);
            this.tbComposer.Name = "tbComposer";
            this.tbComposer.Size = new System.Drawing.Size(217, 27);
            this.tbComposer.TabIndex = 7;
            this.tbComposer.Enter += new System.EventHandler(this.gbSearch_Enter);
            // 
            // tbAbbreviation
            // 
            this.tbAbbreviation.Location = new System.Drawing.Point(147, 85);
            this.tbAbbreviation.Name = "tbAbbreviation";
            this.tbAbbreviation.Size = new System.Drawing.Size(228, 27);
            this.tbAbbreviation.TabIndex = 5;
            this.tbAbbreviation.Enter += new System.EventHandler(this.gbSearch_Enter);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(147, 44);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(228, 27);
            this.tbName.TabIndex = 4;
            this.tbName.Enter += new System.EventHandler(this.gbSearch_Enter);
            // 
            // lbComposer
            // 
            this.lbComposer.AutoSize = true;
            this.lbComposer.Location = new System.Drawing.Point(399, 47);
            this.lbComposer.Name = "lbComposer";
            this.lbComposer.Size = new System.Drawing.Size(66, 20);
            this.lbComposer.TabIndex = 3;
            this.lbComposer.Text = "Sáng tác";
            // 
            // lbGenre
            // 
            this.lbGenre.AutoSize = true;
            this.lbGenre.Location = new System.Drawing.Point(399, 88);
            this.lbGenre.Name = "lbGenre";
            this.lbGenre.Size = new System.Drawing.Size(62, 20);
            this.lbGenre.TabIndex = 2;
            this.lbGenre.Text = "Thể loại";
            // 
            // lbAbbreviation
            // 
            this.lbAbbreviation.AutoSize = true;
            this.lbAbbreviation.Location = new System.Drawing.Point(6, 88);
            this.lbAbbreviation.Name = "lbAbbreviation";
            this.lbAbbreviation.Size = new System.Drawing.Size(135, 40);
            this.lbAbbreviation.TabIndex = 1;
            this.lbAbbreviation.Text = "Tên bài hát viết tắt\r\n(VD: Trú Mưa - TM)";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(6, 47);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(82, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên bài hát";
            // 
            // dgvMusic
            // 
            this.dgvMusic.AllowUserToAddRows = false;
            this.dgvMusic.AllowUserToDeleteRows = false;
            this.dgvMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusic.Location = new System.Drawing.Point(15, 10);
            this.dgvMusic.Name = "dgvMusic";
            this.dgvMusic.ReadOnly = true;
            this.dgvMusic.RowHeadersWidth = 51;
            this.dgvMusic.RowTemplate.Height = 29;
            this.dgvMusic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMusic.Size = new System.Drawing.Size(1065, 335);
            this.dgvMusic.TabIndex = 8;
            this.dgvMusic.DoubleClick += new System.EventHandler(this.dgvMusic_DoubleClick);
            // 
            // btCheckout
            // 
            this.btCheckout.Location = new System.Drawing.Point(764, 439);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Size = new System.Drawing.Size(94, 29);
            this.btCheckout.TabIndex = 14;
            this.btCheckout.Text = "Check Out";
            this.btCheckout.UseVisualStyleBackColor = true;
            this.btCheckout.Click += new System.EventHandler(this.btCheckout_Click);
            // 
            // frmMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 516);
            this.Controls.Add(this.btCheckout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btOrder);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dgvMusic);
            this.MinimumSize = new System.Drawing.Size(1107, 563);
            this.Name = "frmMusic";
            this.Text = "Karaoke";
            this.Load += new System.EventHandler(this.frmMusic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.TextBox tbComposer;
        private System.Windows.Forms.TextBox tbAbbreviation;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbComposer;
        private System.Windows.Forms.Label lbGenre;
        private System.Windows.Forms.Label lbAbbreviation;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.DataGridView dgvMusic;
        private System.Windows.Forms.Button btCheckout;
    }
}