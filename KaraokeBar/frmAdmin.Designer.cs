namespace KaraokeBar
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.tcManagement = new System.Windows.Forms.TabControl();
            this.tabAcc = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btDeleteAcc = new System.Windows.Forms.Button();
            this.btUpdateAcc = new System.Windows.Forms.Button();
            this.btReadAcc = new System.Windows.Forms.Button();
            this.btCreateAcc = new System.Windows.Forms.Button();
            this.tbAccPassword = new System.Windows.Forms.TextBox();
            this.tbAccUsername = new System.Windows.Forms.TextBox();
            this.cbAccPermission = new System.Windows.Forms.ComboBox();
            this.tbAccName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAccPassword = new System.Windows.Forms.Label();
            this.lbAccUsername = new System.Windows.Forms.Label();
            this.lbAccName = new System.Windows.Forms.Label();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.billCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dtpBillDate = new System.Windows.Forms.DateTimePicker();
            this.rbNotPaid = new System.Windows.Forms.RadioButton();
            this.rbPaid = new System.Windows.Forms.RadioButton();
            this.tbBillUser = new System.Windows.Forms.TextBox();
            this.tbBillId = new System.Windows.Forms.TextBox();
            this.cbBillMethod = new System.Windows.Forms.ComboBox();
            this.lbBillStatus = new System.Windows.Forms.Label();
            this.lbBillMethod = new System.Windows.Forms.Label();
            this.lbBillDate = new System.Windows.Forms.Label();
            this.lbBillUser = new System.Windows.Forms.Label();
            this.lbBillId = new System.Windows.Forms.Label();
            this.btDeleteBill = new System.Windows.Forms.Button();
            this.btUpdateBill = new System.Windows.Forms.Button();
            this.btReadBill = new System.Windows.Forms.Button();
            this.btCreateBill = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.orderCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.nudOrdQty = new System.Windows.Forms.NumericUpDown();
            this.rbDoing = new System.Windows.Forms.RadioButton();
            this.rbDone = new System.Windows.Forms.RadioButton();
            this.cbOrdUser = new System.Windows.Forms.ComboBox();
            this.cbOrdService = new System.Windows.Forms.ComboBox();
            this.lbOrdStatus = new System.Windows.Forms.Label();
            this.lbOrdQty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btDeleteOrd = new System.Windows.Forms.Button();
            this.btUpdateOrd = new System.Windows.Forms.Button();
            this.btReadOrd = new System.Windows.Forms.Button();
            this.btCreateOrd = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.lbMusicUName = new System.Windows.Forms.Label();
            this.tbMusicUName = new System.Windows.Forms.TextBox();
            this.tbMusicGenre = new System.Windows.Forms.TextBox();
            this.tbMusicLink = new System.Windows.Forms.TextBox();
            this.tbMusicAbbreviation = new System.Windows.Forms.TextBox();
            this.tbMusicSinger = new System.Windows.Forms.TextBox();
            this.tbMusicAName = new System.Windows.Forms.TextBox();
            this.tbMusicId = new System.Windows.Forms.TextBox();
            this.tbMusicComposer = new System.Windows.Forms.TextBox();
            this.rtbMusicLyric = new System.Windows.Forms.RichTextBox();
            this.lbMusicLink = new System.Windows.Forms.Label();
            this.lbMusicAbbreviation = new System.Windows.Forms.Label();
            this.lbMusicLyric = new System.Windows.Forms.Label();
            this.lbMusicSinger = new System.Windows.Forms.Label();
            this.lbMusicComposer = new System.Windows.Forms.Label();
            this.lbMusicGenre = new System.Windows.Forms.Label();
            this.lbMusicAName = new System.Windows.Forms.Label();
            this.lbMusicId = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btDeleteMusic = new System.Windows.Forms.Button();
            this.btUpdateMusic = new System.Windows.Forms.Button();
            this.btReadMusic = new System.Windows.Forms.Button();
            this.btCreateMusic = new System.Windows.Forms.Button();
            this.dgvMusic = new System.Windows.Forms.DataGridView();
            this.tabRoomType = new System.Windows.Forms.TabPage();
            this.nudRoomtypeId = new System.Windows.Forms.NumericUpDown();
            this.tbRoomtypeName = new System.Windows.Forms.TextBox();
            this.lbRoomtypeName = new System.Windows.Forms.Label();
            this.lbRoomtypeId = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btDeleteRoomtype = new System.Windows.Forms.Button();
            this.btUpdateRoomtype = new System.Windows.Forms.Button();
            this.btReadRoomtype = new System.Windows.Forms.Button();
            this.btCreateRoomtype = new System.Windows.Forms.Button();
            this.dgvRoomType = new System.Windows.Forms.DataGridView();
            this.tabRoom = new System.Windows.Forms.TabPage();
            this.nudRoomNumber = new System.Windows.Forms.NumericUpDown();
            this.nudRoomFloor = new System.Windows.Forms.NumericUpDown();
            this.rbUsing = new System.Windows.Forms.RadioButton();
            this.rbIdle = new System.Windows.Forms.RadioButton();
            this.nudRoomPrice = new System.Windows.Forms.NumericUpDown();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.lbRoomStatus = new System.Windows.Forms.Label();
            this.lbRoomPrice = new System.Windows.Forms.Label();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.lbRoomNumber = new System.Windows.Forms.Label();
            this.lbRoomFloor = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btDeleteRoom = new System.Windows.Forms.Button();
            this.btUpdateRoom = new System.Windows.Forms.Button();
            this.btReadRoom = new System.Windows.Forms.Button();
            this.btCreateRoom = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.serviceCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabService = new System.Windows.Forms.TabPage();
            this.cbSerRoomtype = new System.Windows.Forms.ComboBox();
            this.nudSerQty = new System.Windows.Forms.NumericUpDown();
            this.nudSerPrice = new System.Windows.Forms.NumericUpDown();
            this.tbSerName = new System.Windows.Forms.TextBox();
            this.tbSerId = new System.Windows.Forms.TextBox();
            this.lbSerQty = new System.Windows.Forms.Label();
            this.lbSerPrice = new System.Windows.Forms.Label();
            this.lbSerName = new System.Windows.Forms.Label();
            this.lbSerRoomtype = new System.Windows.Forms.Label();
            this.lbSerId = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btDeleteService = new System.Windows.Forms.Button();
            this.btUpdateService = new System.Windows.Forms.Button();
            this.btReadService = new System.Windows.Forms.Button();
            this.btCreateService = new System.Windows.Forms.Button();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.tcManagement.SuspendLayout();
            this.tabAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrdQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tabMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).BeginInit();
            this.tabRoomType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomtypeId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).BeginInit();
            this.tabRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.tabService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.SuspendLayout();
            // 
            // tcManagement
            // 
            this.tcManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcManagement.Controls.Add(this.tabAcc);
            this.tcManagement.Controls.Add(this.tabBill);
            this.tcManagement.Controls.Add(this.tabOrder);
            this.tcManagement.Controls.Add(this.tabMusic);
            this.tcManagement.Controls.Add(this.tabRoomType);
            this.tcManagement.Controls.Add(this.tabRoom);
            this.tcManagement.Controls.Add(this.tabService);
            this.tcManagement.Location = new System.Drawing.Point(12, 12);
            this.tcManagement.Name = "tcManagement";
            this.tcManagement.SelectedIndex = 0;
            this.tcManagement.Size = new System.Drawing.Size(1158, 729);
            this.tcManagement.TabIndex = 0;
            this.tcManagement.SelectedIndexChanged += new System.EventHandler(this.tcManagement_SelectedIndexChanged);
            // 
            // tabAcc
            // 
            this.tabAcc.Controls.Add(this.pictureBox1);
            this.tabAcc.Controls.Add(this.btDeleteAcc);
            this.tabAcc.Controls.Add(this.btUpdateAcc);
            this.tabAcc.Controls.Add(this.btReadAcc);
            this.tabAcc.Controls.Add(this.btCreateAcc);
            this.tabAcc.Controls.Add(this.tbAccPassword);
            this.tabAcc.Controls.Add(this.tbAccUsername);
            this.tabAcc.Controls.Add(this.cbAccPermission);
            this.tabAcc.Controls.Add(this.tbAccName);
            this.tabAcc.Controls.Add(this.label4);
            this.tabAcc.Controls.Add(this.lbAccPassword);
            this.tabAcc.Controls.Add(this.lbAccUsername);
            this.tabAcc.Controls.Add(this.lbAccName);
            this.tabAcc.Controls.Add(this.dgvAccount);
            this.tabAcc.Location = new System.Drawing.Point(4, 29);
            this.tabAcc.Name = "tabAcc";
            this.tabAcc.Padding = new System.Windows.Forms.Padding(3);
            this.tabAcc.Size = new System.Drawing.Size(1150, 696);
            this.tabAcc.TabIndex = 0;
            this.tabAcc.Text = "Accounts";
            this.tabAcc.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(927, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btDeleteAcc
            // 
            this.btDeleteAcc.Location = new System.Drawing.Point(1022, 592);
            this.btDeleteAcc.Name = "btDeleteAcc";
            this.btDeleteAcc.Size = new System.Drawing.Size(94, 29);
            this.btDeleteAcc.TabIndex = 14;
            this.btDeleteAcc.Text = "Delete";
            this.btDeleteAcc.UseVisualStyleBackColor = true;
            this.btDeleteAcc.Click += new System.EventHandler(this.btDeleteAcc_Click);
            // 
            // btUpdateAcc
            // 
            this.btUpdateAcc.Location = new System.Drawing.Point(876, 592);
            this.btUpdateAcc.Name = "btUpdateAcc";
            this.btUpdateAcc.Size = new System.Drawing.Size(94, 29);
            this.btUpdateAcc.TabIndex = 13;
            this.btUpdateAcc.Text = "Update";
            this.btUpdateAcc.UseVisualStyleBackColor = true;
            this.btUpdateAcc.Click += new System.EventHandler(this.btUpdateAcc_Click);
            // 
            // btReadAcc
            // 
            this.btReadAcc.Location = new System.Drawing.Point(1022, 537);
            this.btReadAcc.Name = "btReadAcc";
            this.btReadAcc.Size = new System.Drawing.Size(94, 29);
            this.btReadAcc.TabIndex = 12;
            this.btReadAcc.Text = "Read";
            this.btReadAcc.UseVisualStyleBackColor = true;
            this.btReadAcc.Click += new System.EventHandler(this.btReadAcc_Click);
            // 
            // btCreateAcc
            // 
            this.btCreateAcc.Location = new System.Drawing.Point(876, 537);
            this.btCreateAcc.Name = "btCreateAcc";
            this.btCreateAcc.Size = new System.Drawing.Size(94, 29);
            this.btCreateAcc.TabIndex = 11;
            this.btCreateAcc.Text = "Create";
            this.btCreateAcc.UseVisualStyleBackColor = true;
            this.btCreateAcc.Click += new System.EventHandler(this.btCreateAcc_Click);
            // 
            // tbAccPassword
            // 
            this.tbAccPassword.Location = new System.Drawing.Point(965, 301);
            this.tbAccPassword.Name = "tbAccPassword";
            this.tbAccPassword.Size = new System.Drawing.Size(179, 27);
            this.tbAccPassword.TabIndex = 10;
            // 
            // tbAccUsername
            // 
            this.tbAccUsername.Location = new System.Drawing.Point(965, 214);
            this.tbAccUsername.Name = "tbAccUsername";
            this.tbAccUsername.Size = new System.Drawing.Size(179, 27);
            this.tbAccUsername.TabIndex = 9;
            // 
            // cbAccPermission
            // 
            this.cbAccPermission.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAccPermission.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAccPermission.FormattingEnabled = true;
            this.cbAccPermission.Location = new System.Drawing.Point(965, 385);
            this.cbAccPermission.Name = "cbAccPermission";
            this.cbAccPermission.Size = new System.Drawing.Size(179, 28);
            this.cbAccPermission.TabIndex = 8;
            // 
            // tbAccName
            // 
            this.tbAccName.Location = new System.Drawing.Point(965, 130);
            this.tbAccName.Name = "tbAccName";
            this.tbAccName.Size = new System.Drawing.Size(179, 27);
            this.tbAccName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(850, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Permission :";
            // 
            // lbAccPassword
            // 
            this.lbAccPassword.AutoSize = true;
            this.lbAccPassword.Location = new System.Drawing.Point(850, 304);
            this.lbAccPassword.Name = "lbAccPassword";
            this.lbAccPassword.Size = new System.Drawing.Size(77, 20);
            this.lbAccPassword.TabIndex = 3;
            this.lbAccPassword.Text = "Password :";
            // 
            // lbAccUsername
            // 
            this.lbAccUsername.AutoSize = true;
            this.lbAccUsername.Location = new System.Drawing.Point(850, 217);
            this.lbAccUsername.Name = "lbAccUsername";
            this.lbAccUsername.Size = new System.Drawing.Size(82, 20);
            this.lbAccUsername.TabIndex = 2;
            this.lbAccUsername.Text = "Username :";
            // 
            // lbAccName
            // 
            this.lbAccName.AutoSize = true;
            this.lbAccName.Location = new System.Drawing.Point(850, 133);
            this.lbAccName.Name = "lbAccName";
            this.lbAccName.Size = new System.Drawing.Size(109, 20);
            this.lbAccName.TabIndex = 1;
            this.lbAccName.Text = "Display Name :";
            // 
            // dgvAccount
            // 
            this.dgvAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.billCol});
            this.dgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.RowTemplate.Height = 29;
            this.dgvAccount.Size = new System.Drawing.Size(841, 690);
            this.dgvAccount.TabIndex = 0;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            this.dgvAccount.Click += new System.EventHandler(this.dgvAccount_Click);
            // 
            // billCol
            // 
            this.billCol.HeaderText = "Bills";
            this.billCol.MinimumWidth = 6;
            this.billCol.Name = "billCol";
            this.billCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.billCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.billCol.Text = "Show Bills";
            this.billCol.UseColumnTextForButtonValue = true;
            this.billCol.Width = 125;
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.pictureBox2);
            this.tabBill.Controls.Add(this.dtpBillDate);
            this.tabBill.Controls.Add(this.rbNotPaid);
            this.tabBill.Controls.Add(this.rbPaid);
            this.tabBill.Controls.Add(this.tbBillUser);
            this.tabBill.Controls.Add(this.tbBillId);
            this.tabBill.Controls.Add(this.cbBillMethod);
            this.tabBill.Controls.Add(this.lbBillStatus);
            this.tabBill.Controls.Add(this.lbBillMethod);
            this.tabBill.Controls.Add(this.lbBillDate);
            this.tabBill.Controls.Add(this.lbBillUser);
            this.tabBill.Controls.Add(this.lbBillId);
            this.tabBill.Controls.Add(this.btDeleteBill);
            this.tabBill.Controls.Add(this.btUpdateBill);
            this.tabBill.Controls.Add(this.btReadBill);
            this.tabBill.Controls.Add(this.btCreateBill);
            this.tabBill.Controls.Add(this.dgvBill);
            this.tabBill.Location = new System.Drawing.Point(4, 29);
            this.tabBill.Name = "tabBill";
            this.tabBill.Size = new System.Drawing.Size(1150, 696);
            this.tabBill.TabIndex = 5;
            this.tabBill.Text = "Bills";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(927, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // dtpBillDate
            // 
            this.dtpBillDate.Location = new System.Drawing.Point(939, 295);
            this.dtpBillDate.Name = "dtpBillDate";
            this.dtpBillDate.Size = new System.Drawing.Size(208, 27);
            this.dtpBillDate.TabIndex = 29;
            this.dtpBillDate.Value = new System.DateTime(2022, 7, 22, 19, 14, 23, 0);
            // 
            // rbNotPaid
            // 
            this.rbNotPaid.AutoSize = true;
            this.rbNotPaid.Location = new System.Drawing.Point(1060, 465);
            this.rbNotPaid.Name = "rbNotPaid";
            this.rbNotPaid.Size = new System.Drawing.Size(87, 24);
            this.rbNotPaid.TabIndex = 28;
            this.rbNotPaid.TabStop = true;
            this.rbNotPaid.Text = "Not Paid";
            this.rbNotPaid.UseVisualStyleBackColor = true;
            // 
            // rbPaid
            // 
            this.rbPaid.AutoSize = true;
            this.rbPaid.Location = new System.Drawing.Point(977, 465);
            this.rbPaid.Name = "rbPaid";
            this.rbPaid.Size = new System.Drawing.Size(58, 24);
            this.rbPaid.TabIndex = 27;
            this.rbPaid.TabStop = true;
            this.rbPaid.Text = "Paid";
            this.rbPaid.UseVisualStyleBackColor = true;
            // 
            // tbBillUser
            // 
            this.tbBillUser.Location = new System.Drawing.Point(977, 212);
            this.tbBillUser.Name = "tbBillUser";
            this.tbBillUser.Size = new System.Drawing.Size(170, 27);
            this.tbBillUser.TabIndex = 26;
            // 
            // tbBillId
            // 
            this.tbBillId.Location = new System.Drawing.Point(977, 129);
            this.tbBillId.Name = "tbBillId";
            this.tbBillId.ReadOnly = true;
            this.tbBillId.Size = new System.Drawing.Size(170, 27);
            this.tbBillId.TabIndex = 25;
            // 
            // cbBillMethod
            // 
            this.cbBillMethod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBillMethod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBillMethod.FormattingEnabled = true;
            this.cbBillMethod.Location = new System.Drawing.Point(977, 381);
            this.cbBillMethod.Name = "cbBillMethod";
            this.cbBillMethod.Size = new System.Drawing.Size(170, 28);
            this.cbBillMethod.TabIndex = 24;
            // 
            // lbBillStatus
            // 
            this.lbBillStatus.AutoSize = true;
            this.lbBillStatus.Location = new System.Drawing.Point(850, 467);
            this.lbBillStatus.Name = "lbBillStatus";
            this.lbBillStatus.Size = new System.Drawing.Size(116, 20);
            this.lbBillStatus.TabIndex = 23;
            this.lbBillStatus.Text = "Payment Status :";
            // 
            // lbBillMethod
            // 
            this.lbBillMethod.AutoSize = true;
            this.lbBillMethod.Location = new System.Drawing.Point(850, 384);
            this.lbBillMethod.Name = "lbBillMethod";
            this.lbBillMethod.Size = new System.Drawing.Size(124, 20);
            this.lbBillMethod.TabIndex = 22;
            this.lbBillMethod.Text = "Payment Method:";
            // 
            // lbBillDate
            // 
            this.lbBillDate.AutoSize = true;
            this.lbBillDate.Location = new System.Drawing.Point(850, 300);
            this.lbBillDate.Name = "lbBillDate";
            this.lbBillDate.Size = new System.Drawing.Size(86, 20);
            this.lbBillDate.TabIndex = 21;
            this.lbBillDate.Text = "Order Date:";
            // 
            // lbBillUser
            // 
            this.lbBillUser.AutoSize = true;
            this.lbBillUser.Location = new System.Drawing.Point(850, 215);
            this.lbBillUser.Name = "lbBillUser";
            this.lbBillUser.Size = new System.Drawing.Size(82, 20);
            this.lbBillUser.TabIndex = 20;
            this.lbBillUser.Text = "Username :";
            // 
            // lbBillId
            // 
            this.lbBillId.AutoSize = true;
            this.lbBillId.Location = new System.Drawing.Point(850, 132);
            this.lbBillId.Name = "lbBillId";
            this.lbBillId.Size = new System.Drawing.Size(56, 20);
            this.lbBillId.TabIndex = 19;
            this.lbBillId.Text = "Bill ID :";
            // 
            // btDeleteBill
            // 
            this.btDeleteBill.Enabled = false;
            this.btDeleteBill.Location = new System.Drawing.Point(1023, 608);
            this.btDeleteBill.Name = "btDeleteBill";
            this.btDeleteBill.Size = new System.Drawing.Size(94, 29);
            this.btDeleteBill.TabIndex = 18;
            this.btDeleteBill.Text = "Delete";
            this.btDeleteBill.UseVisualStyleBackColor = true;
            // 
            // btUpdateBill
            // 
            this.btUpdateBill.Location = new System.Drawing.Point(877, 608);
            this.btUpdateBill.Name = "btUpdateBill";
            this.btUpdateBill.Size = new System.Drawing.Size(94, 29);
            this.btUpdateBill.TabIndex = 17;
            this.btUpdateBill.Text = "Update";
            this.btUpdateBill.UseVisualStyleBackColor = true;
            this.btUpdateBill.Click += new System.EventHandler(this.btUpdateBill_Click);
            // 
            // btReadBill
            // 
            this.btReadBill.Location = new System.Drawing.Point(1023, 553);
            this.btReadBill.Name = "btReadBill";
            this.btReadBill.Size = new System.Drawing.Size(94, 29);
            this.btReadBill.TabIndex = 16;
            this.btReadBill.Text = "Read";
            this.btReadBill.UseVisualStyleBackColor = true;
            this.btReadBill.Click += new System.EventHandler(this.btReadBill_Click);
            // 
            // btCreateBill
            // 
            this.btCreateBill.Enabled = false;
            this.btCreateBill.Location = new System.Drawing.Point(877, 553);
            this.btCreateBill.Name = "btCreateBill";
            this.btCreateBill.Size = new System.Drawing.Size(94, 29);
            this.btCreateBill.TabIndex = 15;
            this.btCreateBill.Text = "Create";
            this.btCreateBill.UseVisualStyleBackColor = true;
            // 
            // dgvBill
            // 
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderCol});
            this.dgvBill.Location = new System.Drawing.Point(3, 3);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.RowTemplate.Height = 29;
            this.dgvBill.Size = new System.Drawing.Size(841, 690);
            this.dgvBill.TabIndex = 1;
            this.dgvBill.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellClick);
            this.dgvBill.Click += new System.EventHandler(this.dgvBill_Click);
            // 
            // orderCol
            // 
            this.orderCol.HeaderText = "Orders";
            this.orderCol.MinimumWidth = 6;
            this.orderCol.Name = "orderCol";
            this.orderCol.Text = "View Orders";
            this.orderCol.UseColumnTextForButtonValue = true;
            this.orderCol.Width = 125;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.pictureBox3);
            this.tabOrder.Controls.Add(this.nudOrdQty);
            this.tabOrder.Controls.Add(this.rbDoing);
            this.tabOrder.Controls.Add(this.rbDone);
            this.tabOrder.Controls.Add(this.cbOrdUser);
            this.tabOrder.Controls.Add(this.cbOrdService);
            this.tabOrder.Controls.Add(this.lbOrdStatus);
            this.tabOrder.Controls.Add(this.lbOrdQty);
            this.tabOrder.Controls.Add(this.label3);
            this.tabOrder.Controls.Add(this.label5);
            this.tabOrder.Controls.Add(this.btDeleteOrd);
            this.tabOrder.Controls.Add(this.btUpdateOrd);
            this.tabOrder.Controls.Add(this.btReadOrd);
            this.tabOrder.Controls.Add(this.btCreateOrd);
            this.tabOrder.Controls.Add(this.dgvOrder);
            this.tabOrder.Location = new System.Drawing.Point(4, 29);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Size = new System.Drawing.Size(1150, 696);
            this.tabOrder.TabIndex = 6;
            this.tabOrder.Text = "Orders";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(927, 19);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(150, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // nudOrdQty
            // 
            this.nudOrdQty.Location = new System.Drawing.Point(954, 392);
            this.nudOrdQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOrdQty.Name = "nudOrdQty";
            this.nudOrdQty.Size = new System.Drawing.Size(193, 27);
            this.nudOrdQty.TabIndex = 33;
            this.nudOrdQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbDoing
            // 
            this.rbDoing.AutoSize = true;
            this.rbDoing.Location = new System.Drawing.Point(1062, 473);
            this.rbDoing.Name = "rbDoing";
            this.rbDoing.Size = new System.Drawing.Size(71, 24);
            this.rbDoing.TabIndex = 32;
            this.rbDoing.TabStop = true;
            this.rbDoing.Text = "Doing";
            this.rbDoing.UseVisualStyleBackColor = true;
            // 
            // rbDone
            // 
            this.rbDone.AutoSize = true;
            this.rbDone.Location = new System.Drawing.Point(963, 473);
            this.rbDone.Name = "rbDone";
            this.rbDone.Size = new System.Drawing.Size(66, 24);
            this.rbDone.TabIndex = 31;
            this.rbDone.TabStop = true;
            this.rbDone.Text = "Done";
            this.rbDone.UseVisualStyleBackColor = true;
            // 
            // cbOrdUser
            // 
            this.cbOrdUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOrdUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOrdUser.FormattingEnabled = true;
            this.cbOrdUser.Location = new System.Drawing.Point(954, 177);
            this.cbOrdUser.Name = "cbOrdUser";
            this.cbOrdUser.Size = new System.Drawing.Size(193, 28);
            this.cbOrdUser.TabIndex = 30;
            // 
            // cbOrdService
            // 
            this.cbOrdService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOrdService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOrdService.FormattingEnabled = true;
            this.cbOrdService.Location = new System.Drawing.Point(954, 262);
            this.cbOrdService.Name = "cbOrdService";
            this.cbOrdService.Size = new System.Drawing.Size(193, 28);
            this.cbOrdService.TabIndex = 29;
            // 
            // lbOrdStatus
            // 
            this.lbOrdStatus.AutoSize = true;
            this.lbOrdStatus.Location = new System.Drawing.Point(850, 475);
            this.lbOrdStatus.Name = "lbOrdStatus";
            this.lbOrdStatus.Size = new System.Drawing.Size(98, 20);
            this.lbOrdStatus.TabIndex = 28;
            this.lbOrdStatus.Text = "Order Status :";
            // 
            // lbOrdQty
            // 
            this.lbOrdQty.AutoSize = true;
            this.lbOrdQty.Location = new System.Drawing.Point(850, 392);
            this.lbOrdQty.Name = "lbOrdQty";
            this.lbOrdQty.Size = new System.Drawing.Size(72, 20);
            this.lbOrdQty.TabIndex = 27;
            this.lbOrdQty.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(850, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Service ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(850, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Username :";
            // 
            // btDeleteOrd
            // 
            this.btDeleteOrd.Enabled = false;
            this.btDeleteOrd.Location = new System.Drawing.Point(1025, 638);
            this.btDeleteOrd.Name = "btDeleteOrd";
            this.btDeleteOrd.Size = new System.Drawing.Size(94, 29);
            this.btDeleteOrd.TabIndex = 18;
            this.btDeleteOrd.Text = "Delete";
            this.btDeleteOrd.UseVisualStyleBackColor = true;
            this.btDeleteOrd.Click += new System.EventHandler(this.btDeleteOrd_Click);
            // 
            // btUpdateOrd
            // 
            this.btUpdateOrd.Location = new System.Drawing.Point(879, 638);
            this.btUpdateOrd.Name = "btUpdateOrd";
            this.btUpdateOrd.Size = new System.Drawing.Size(94, 29);
            this.btUpdateOrd.TabIndex = 17;
            this.btUpdateOrd.Text = "Update";
            this.btUpdateOrd.UseVisualStyleBackColor = true;
            this.btUpdateOrd.Click += new System.EventHandler(this.btUpdateOrd_Click);
            // 
            // btReadOrd
            // 
            this.btReadOrd.Location = new System.Drawing.Point(1025, 583);
            this.btReadOrd.Name = "btReadOrd";
            this.btReadOrd.Size = new System.Drawing.Size(94, 29);
            this.btReadOrd.TabIndex = 16;
            this.btReadOrd.Text = "Read";
            this.btReadOrd.UseVisualStyleBackColor = true;
            this.btReadOrd.Click += new System.EventHandler(this.btReadOrd_Click);
            // 
            // btCreateOrd
            // 
            this.btCreateOrd.Enabled = false;
            this.btCreateOrd.Location = new System.Drawing.Point(879, 583);
            this.btCreateOrd.Name = "btCreateOrd";
            this.btCreateOrd.Size = new System.Drawing.Size(94, 29);
            this.btCreateOrd.TabIndex = 15;
            this.btCreateOrd.Text = "Create";
            this.btCreateOrd.UseVisualStyleBackColor = true;
            // 
            // dgvOrder
            // 
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(3, 3);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 29;
            this.dgvOrder.Size = new System.Drawing.Size(841, 690);
            this.dgvOrder.TabIndex = 3;
            this.dgvOrder.Click += new System.EventHandler(this.dgvOrder_Click);
            // 
            // tabMusic
            // 
            this.tabMusic.Controls.Add(this.lbMusicUName);
            this.tabMusic.Controls.Add(this.tbMusicUName);
            this.tabMusic.Controls.Add(this.tbMusicGenre);
            this.tabMusic.Controls.Add(this.tbMusicLink);
            this.tabMusic.Controls.Add(this.tbMusicAbbreviation);
            this.tabMusic.Controls.Add(this.tbMusicSinger);
            this.tabMusic.Controls.Add(this.tbMusicAName);
            this.tabMusic.Controls.Add(this.tbMusicId);
            this.tabMusic.Controls.Add(this.tbMusicComposer);
            this.tabMusic.Controls.Add(this.rtbMusicLyric);
            this.tabMusic.Controls.Add(this.lbMusicLink);
            this.tabMusic.Controls.Add(this.lbMusicAbbreviation);
            this.tabMusic.Controls.Add(this.lbMusicLyric);
            this.tabMusic.Controls.Add(this.lbMusicSinger);
            this.tabMusic.Controls.Add(this.lbMusicComposer);
            this.tabMusic.Controls.Add(this.lbMusicGenre);
            this.tabMusic.Controls.Add(this.lbMusicAName);
            this.tabMusic.Controls.Add(this.lbMusicId);
            this.tabMusic.Controls.Add(this.pictureBox4);
            this.tabMusic.Controls.Add(this.btDeleteMusic);
            this.tabMusic.Controls.Add(this.btUpdateMusic);
            this.tabMusic.Controls.Add(this.btReadMusic);
            this.tabMusic.Controls.Add(this.btCreateMusic);
            this.tabMusic.Controls.Add(this.dgvMusic);
            this.tabMusic.Location = new System.Drawing.Point(4, 29);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusic.Size = new System.Drawing.Size(1150, 696);
            this.tabMusic.TabIndex = 1;
            this.tabMusic.Text = "Musics";
            this.tabMusic.UseVisualStyleBackColor = true;
            // 
            // lbMusicUName
            // 
            this.lbMusicUName.AutoSize = true;
            this.lbMusicUName.Location = new System.Drawing.Point(850, 226);
            this.lbMusicUName.Name = "lbMusicUName";
            this.lbMusicUName.Size = new System.Drawing.Size(72, 20);
            this.lbMusicUName.TabIndex = 55;
            this.lbMusicUName.Text = "U_Name :";
            // 
            // tbMusicUName
            // 
            this.tbMusicUName.ForeColor = System.Drawing.Color.Silver;
            this.tbMusicUName.Location = new System.Drawing.Point(958, 223);
            this.tbMusicUName.Name = "tbMusicUName";
            this.tbMusicUName.Size = new System.Drawing.Size(186, 27);
            this.tbMusicUName.TabIndex = 54;
            this.tbMusicUName.Text = "Unaccented Name";
            this.tbMusicUName.Enter += new System.EventHandler(this.tbMusicUName_Enter);
            this.tbMusicUName.Leave += new System.EventHandler(this.tbMusicUName_Leave);
            // 
            // tbMusicGenre
            // 
            this.tbMusicGenre.Location = new System.Drawing.Point(958, 268);
            this.tbMusicGenre.Name = "tbMusicGenre";
            this.tbMusicGenre.Size = new System.Drawing.Size(186, 27);
            this.tbMusicGenre.TabIndex = 53;
            // 
            // tbMusicLink
            // 
            this.tbMusicLink.Location = new System.Drawing.Point(901, 537);
            this.tbMusicLink.Name = "tbMusicLink";
            this.tbMusicLink.Size = new System.Drawing.Size(243, 27);
            this.tbMusicLink.TabIndex = 52;
            // 
            // tbMusicAbbreviation
            // 
            this.tbMusicAbbreviation.Location = new System.Drawing.Point(958, 491);
            this.tbMusicAbbreviation.Name = "tbMusicAbbreviation";
            this.tbMusicAbbreviation.Size = new System.Drawing.Size(186, 27);
            this.tbMusicAbbreviation.TabIndex = 51;
            // 
            // tbMusicSinger
            // 
            this.tbMusicSinger.Location = new System.Drawing.Point(958, 358);
            this.tbMusicSinger.Name = "tbMusicSinger";
            this.tbMusicSinger.Size = new System.Drawing.Size(186, 27);
            this.tbMusicSinger.TabIndex = 50;
            // 
            // tbMusicAName
            // 
            this.tbMusicAName.BackColor = System.Drawing.SystemColors.Window;
            this.tbMusicAName.ForeColor = System.Drawing.Color.Silver;
            this.tbMusicAName.Location = new System.Drawing.Point(958, 180);
            this.tbMusicAName.Name = "tbMusicAName";
            this.tbMusicAName.Size = new System.Drawing.Size(186, 27);
            this.tbMusicAName.TabIndex = 49;
            this.tbMusicAName.Text = "Accented Name";
            this.tbMusicAName.Enter += new System.EventHandler(this.tbMusicAName_Enter);
            this.tbMusicAName.Leave += new System.EventHandler(this.tbMusicAName_Leave);
            // 
            // tbMusicId
            // 
            this.tbMusicId.Location = new System.Drawing.Point(958, 138);
            this.tbMusicId.Name = "tbMusicId";
            this.tbMusicId.Size = new System.Drawing.Size(186, 27);
            this.tbMusicId.TabIndex = 48;
            // 
            // tbMusicComposer
            // 
            this.tbMusicComposer.Location = new System.Drawing.Point(958, 313);
            this.tbMusicComposer.Name = "tbMusicComposer";
            this.tbMusicComposer.Size = new System.Drawing.Size(186, 27);
            this.tbMusicComposer.TabIndex = 47;
            // 
            // rtbMusicLyric
            // 
            this.rtbMusicLyric.Location = new System.Drawing.Point(901, 403);
            this.rtbMusicLyric.Name = "rtbMusicLyric";
            this.rtbMusicLyric.Size = new System.Drawing.Size(243, 69);
            this.rtbMusicLyric.TabIndex = 46;
            this.rtbMusicLyric.Text = "";
            // 
            // lbMusicLink
            // 
            this.lbMusicLink.AutoSize = true;
            this.lbMusicLink.Location = new System.Drawing.Point(850, 540);
            this.lbMusicLink.Name = "lbMusicLink";
            this.lbMusicLink.Size = new System.Drawing.Size(42, 20);
            this.lbMusicLink.TabIndex = 45;
            this.lbMusicLink.Text = "Link :";
            // 
            // lbMusicAbbreviation
            // 
            this.lbMusicAbbreviation.AutoSize = true;
            this.lbMusicAbbreviation.Location = new System.Drawing.Point(850, 494);
            this.lbMusicAbbreviation.Name = "lbMusicAbbreviation";
            this.lbMusicAbbreviation.Size = new System.Drawing.Size(102, 20);
            this.lbMusicAbbreviation.TabIndex = 43;
            this.lbMusicAbbreviation.Text = "Abbreviation :";
            // 
            // lbMusicLyric
            // 
            this.lbMusicLyric.AutoSize = true;
            this.lbMusicLyric.Location = new System.Drawing.Point(850, 406);
            this.lbMusicLyric.Name = "lbMusicLyric";
            this.lbMusicLyric.Size = new System.Drawing.Size(45, 20);
            this.lbMusicLyric.TabIndex = 42;
            this.lbMusicLyric.Text = "Lyric :";
            // 
            // lbMusicSinger
            // 
            this.lbMusicSinger.AutoSize = true;
            this.lbMusicSinger.Location = new System.Drawing.Point(850, 361);
            this.lbMusicSinger.Name = "lbMusicSinger";
            this.lbMusicSinger.Size = new System.Drawing.Size(58, 20);
            this.lbMusicSinger.TabIndex = 41;
            this.lbMusicSinger.Text = "Singer :";
            // 
            // lbMusicComposer
            // 
            this.lbMusicComposer.AutoSize = true;
            this.lbMusicComposer.Location = new System.Drawing.Point(850, 316);
            this.lbMusicComposer.Name = "lbMusicComposer";
            this.lbMusicComposer.Size = new System.Drawing.Size(84, 20);
            this.lbMusicComposer.TabIndex = 39;
            this.lbMusicComposer.Text = "Composer :";
            // 
            // lbMusicGenre
            // 
            this.lbMusicGenre.AutoSize = true;
            this.lbMusicGenre.Location = new System.Drawing.Point(850, 271);
            this.lbMusicGenre.Name = "lbMusicGenre";
            this.lbMusicGenre.Size = new System.Drawing.Size(55, 20);
            this.lbMusicGenre.TabIndex = 38;
            this.lbMusicGenre.Text = "Genre :";
            // 
            // lbMusicAName
            // 
            this.lbMusicAName.AutoSize = true;
            this.lbMusicAName.Location = new System.Drawing.Point(850, 183);
            this.lbMusicAName.Name = "lbMusicAName";
            this.lbMusicAName.Size = new System.Drawing.Size(72, 20);
            this.lbMusicAName.TabIndex = 37;
            this.lbMusicAName.Text = "A_Name :";
            // 
            // lbMusicId
            // 
            this.lbMusicId.AutoSize = true;
            this.lbMusicId.Location = new System.Drawing.Point(850, 141);
            this.lbMusicId.Name = "lbMusicId";
            this.lbMusicId.Size = new System.Drawing.Size(73, 20);
            this.lbMusicId.TabIndex = 36;
            this.lbMusicId.Text = "Music ID :";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(927, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(150, 81);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 35;
            this.pictureBox4.TabStop = false;
            // 
            // btDeleteMusic
            // 
            this.btDeleteMusic.Location = new System.Drawing.Point(1022, 652);
            this.btDeleteMusic.Name = "btDeleteMusic";
            this.btDeleteMusic.Size = new System.Drawing.Size(94, 29);
            this.btDeleteMusic.TabIndex = 18;
            this.btDeleteMusic.Text = "Delete";
            this.btDeleteMusic.UseVisualStyleBackColor = true;
            this.btDeleteMusic.Click += new System.EventHandler(this.btDeleteMusic_Click);
            // 
            // btUpdateMusic
            // 
            this.btUpdateMusic.Location = new System.Drawing.Point(876, 652);
            this.btUpdateMusic.Name = "btUpdateMusic";
            this.btUpdateMusic.Size = new System.Drawing.Size(94, 29);
            this.btUpdateMusic.TabIndex = 17;
            this.btUpdateMusic.Text = "Update";
            this.btUpdateMusic.UseVisualStyleBackColor = true;
            this.btUpdateMusic.Click += new System.EventHandler(this.btUpdateMusic_Click);
            // 
            // btReadMusic
            // 
            this.btReadMusic.Location = new System.Drawing.Point(1022, 597);
            this.btReadMusic.Name = "btReadMusic";
            this.btReadMusic.Size = new System.Drawing.Size(94, 29);
            this.btReadMusic.TabIndex = 16;
            this.btReadMusic.Text = "Read";
            this.btReadMusic.UseVisualStyleBackColor = true;
            this.btReadMusic.Click += new System.EventHandler(this.btReadMusic_Click);
            // 
            // btCreateMusic
            // 
            this.btCreateMusic.Location = new System.Drawing.Point(876, 597);
            this.btCreateMusic.Name = "btCreateMusic";
            this.btCreateMusic.Size = new System.Drawing.Size(94, 29);
            this.btCreateMusic.TabIndex = 15;
            this.btCreateMusic.Text = "Create";
            this.btCreateMusic.UseVisualStyleBackColor = true;
            this.btCreateMusic.Click += new System.EventHandler(this.btCreateMusic_Click);
            // 
            // dgvMusic
            // 
            this.dgvMusic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusic.Location = new System.Drawing.Point(3, 3);
            this.dgvMusic.Name = "dgvMusic";
            this.dgvMusic.RowHeadersWidth = 51;
            this.dgvMusic.RowTemplate.Height = 29;
            this.dgvMusic.Size = new System.Drawing.Size(841, 690);
            this.dgvMusic.TabIndex = 2;
            this.dgvMusic.Click += new System.EventHandler(this.dgvMusic_Click);
            // 
            // tabRoomType
            // 
            this.tabRoomType.Controls.Add(this.nudRoomtypeId);
            this.tabRoomType.Controls.Add(this.tbRoomtypeName);
            this.tabRoomType.Controls.Add(this.lbRoomtypeName);
            this.tabRoomType.Controls.Add(this.lbRoomtypeId);
            this.tabRoomType.Controls.Add(this.pictureBox5);
            this.tabRoomType.Controls.Add(this.btDeleteRoomtype);
            this.tabRoomType.Controls.Add(this.btUpdateRoomtype);
            this.tabRoomType.Controls.Add(this.btReadRoomtype);
            this.tabRoomType.Controls.Add(this.btCreateRoomtype);
            this.tabRoomType.Controls.Add(this.dgvRoomType);
            this.tabRoomType.Location = new System.Drawing.Point(4, 29);
            this.tabRoomType.Name = "tabRoomType";
            this.tabRoomType.Size = new System.Drawing.Size(1150, 696);
            this.tabRoomType.TabIndex = 2;
            this.tabRoomType.Text = "Types of Room";
            this.tabRoomType.UseVisualStyleBackColor = true;
            // 
            // nudRoomtypeId
            // 
            this.nudRoomtypeId.Location = new System.Drawing.Point(947, 215);
            this.nudRoomtypeId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRoomtypeId.Name = "nudRoomtypeId";
            this.nudRoomtypeId.Size = new System.Drawing.Size(181, 27);
            this.nudRoomtypeId.TabIndex = 41;
            this.nudRoomtypeId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbRoomtypeName
            // 
            this.tbRoomtypeName.Location = new System.Drawing.Point(947, 314);
            this.tbRoomtypeName.Name = "tbRoomtypeName";
            this.tbRoomtypeName.Size = new System.Drawing.Size(181, 27);
            this.tbRoomtypeName.TabIndex = 40;
            // 
            // lbRoomtypeName
            // 
            this.lbRoomtypeName.AutoSize = true;
            this.lbRoomtypeName.Location = new System.Drawing.Point(850, 317);
            this.lbRoomtypeName.Name = "lbRoomtypeName";
            this.lbRoomtypeName.Size = new System.Drawing.Size(91, 20);
            this.lbRoomtypeName.TabIndex = 39;
            this.lbRoomtypeName.Text = "Type Name :";
            // 
            // lbRoomtypeId
            // 
            this.lbRoomtypeId.AutoSize = true;
            this.lbRoomtypeId.Location = new System.Drawing.Point(850, 217);
            this.lbRoomtypeId.Name = "lbRoomtypeId";
            this.lbRoomtypeId.Size = new System.Drawing.Size(66, 20);
            this.lbRoomtypeId.TabIndex = 38;
            this.lbRoomtypeId.Text = "Type ID :";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(927, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 81);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 36;
            this.pictureBox5.TabStop = false;
            // 
            // btDeleteRoomtype
            // 
            this.btDeleteRoomtype.Location = new System.Drawing.Point(1022, 541);
            this.btDeleteRoomtype.Name = "btDeleteRoomtype";
            this.btDeleteRoomtype.Size = new System.Drawing.Size(94, 29);
            this.btDeleteRoomtype.TabIndex = 18;
            this.btDeleteRoomtype.Text = "Delete";
            this.btDeleteRoomtype.UseVisualStyleBackColor = true;
            this.btDeleteRoomtype.Click += new System.EventHandler(this.btDeleteRoomtype_Click);
            // 
            // btUpdateRoomtype
            // 
            this.btUpdateRoomtype.Location = new System.Drawing.Point(876, 541);
            this.btUpdateRoomtype.Name = "btUpdateRoomtype";
            this.btUpdateRoomtype.Size = new System.Drawing.Size(94, 29);
            this.btUpdateRoomtype.TabIndex = 17;
            this.btUpdateRoomtype.Text = "Update";
            this.btUpdateRoomtype.UseVisualStyleBackColor = true;
            this.btUpdateRoomtype.Click += new System.EventHandler(this.btUpdateRoomtype_Click);
            // 
            // btReadRoomtype
            // 
            this.btReadRoomtype.Location = new System.Drawing.Point(1022, 486);
            this.btReadRoomtype.Name = "btReadRoomtype";
            this.btReadRoomtype.Size = new System.Drawing.Size(94, 29);
            this.btReadRoomtype.TabIndex = 16;
            this.btReadRoomtype.Text = "Read";
            this.btReadRoomtype.UseVisualStyleBackColor = true;
            this.btReadRoomtype.Click += new System.EventHandler(this.btReadRoomtype_Click);
            // 
            // btCreateRoomtype
            // 
            this.btCreateRoomtype.Location = new System.Drawing.Point(876, 486);
            this.btCreateRoomtype.Name = "btCreateRoomtype";
            this.btCreateRoomtype.Size = new System.Drawing.Size(94, 29);
            this.btCreateRoomtype.TabIndex = 15;
            this.btCreateRoomtype.Text = "Create";
            this.btCreateRoomtype.UseVisualStyleBackColor = true;
            this.btCreateRoomtype.Click += new System.EventHandler(this.btCreateRoomtype_Click);
            // 
            // dgvRoomType
            // 
            this.dgvRoomType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomType.Location = new System.Drawing.Point(3, 3);
            this.dgvRoomType.Name = "dgvRoomType";
            this.dgvRoomType.RowHeadersWidth = 51;
            this.dgvRoomType.RowTemplate.Height = 29;
            this.dgvRoomType.Size = new System.Drawing.Size(841, 690);
            this.dgvRoomType.TabIndex = 2;
            this.dgvRoomType.Click += new System.EventHandler(this.dgvRoomType_Click);
            // 
            // tabRoom
            // 
            this.tabRoom.Controls.Add(this.nudRoomNumber);
            this.tabRoom.Controls.Add(this.nudRoomFloor);
            this.tabRoom.Controls.Add(this.rbUsing);
            this.tabRoom.Controls.Add(this.rbIdle);
            this.tabRoom.Controls.Add(this.nudRoomPrice);
            this.tabRoom.Controls.Add(this.cbRoomType);
            this.tabRoom.Controls.Add(this.lbRoomStatus);
            this.tabRoom.Controls.Add(this.lbRoomPrice);
            this.tabRoom.Controls.Add(this.lbRoomType);
            this.tabRoom.Controls.Add(this.lbRoomNumber);
            this.tabRoom.Controls.Add(this.lbRoomFloor);
            this.tabRoom.Controls.Add(this.pictureBox6);
            this.tabRoom.Controls.Add(this.btDeleteRoom);
            this.tabRoom.Controls.Add(this.btUpdateRoom);
            this.tabRoom.Controls.Add(this.btReadRoom);
            this.tabRoom.Controls.Add(this.btCreateRoom);
            this.tabRoom.Controls.Add(this.dgvRoom);
            this.tabRoom.Location = new System.Drawing.Point(4, 29);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Size = new System.Drawing.Size(1150, 696);
            this.tabRoom.TabIndex = 4;
            this.tabRoom.Text = "Rooms";
            this.tabRoom.UseVisualStyleBackColor = true;
            // 
            // nudRoomNumber
            // 
            this.nudRoomNumber.Location = new System.Drawing.Point(970, 234);
            this.nudRoomNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRoomNumber.Name = "nudRoomNumber";
            this.nudRoomNumber.Size = new System.Drawing.Size(174, 27);
            this.nudRoomNumber.TabIndex = 67;
            this.nudRoomNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudRoomFloor
            // 
            this.nudRoomFloor.Location = new System.Drawing.Point(970, 157);
            this.nudRoomFloor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRoomFloor.Name = "nudRoomFloor";
            this.nudRoomFloor.Size = new System.Drawing.Size(174, 27);
            this.nudRoomFloor.TabIndex = 66;
            this.nudRoomFloor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbUsing
            // 
            this.rbUsing.AutoSize = true;
            this.rbUsing.Location = new System.Drawing.Point(970, 472);
            this.rbUsing.Name = "rbUsing";
            this.rbUsing.Size = new System.Drawing.Size(67, 24);
            this.rbUsing.TabIndex = 65;
            this.rbUsing.TabStop = true;
            this.rbUsing.Text = "Using";
            this.rbUsing.UseVisualStyleBackColor = true;
            // 
            // rbIdle
            // 
            this.rbIdle.AutoSize = true;
            this.rbIdle.Location = new System.Drawing.Point(1089, 472);
            this.rbIdle.Name = "rbIdle";
            this.rbIdle.Size = new System.Drawing.Size(55, 24);
            this.rbIdle.TabIndex = 64;
            this.rbIdle.TabStop = true;
            this.rbIdle.Text = "Idle";
            this.rbIdle.UseVisualStyleBackColor = true;
            // 
            // nudRoomPrice
            // 
            this.nudRoomPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRoomPrice.Location = new System.Drawing.Point(970, 393);
            this.nudRoomPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudRoomPrice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRoomPrice.Name = "nudRoomPrice";
            this.nudRoomPrice.Size = new System.Drawing.Size(174, 27);
            this.nudRoomPrice.TabIndex = 63;
            this.nudRoomPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cbRoomType
            // 
            this.cbRoomType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbRoomType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(970, 315);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(174, 28);
            this.cbRoomType.TabIndex = 62;
            // 
            // lbRoomStatus
            // 
            this.lbRoomStatus.AutoSize = true;
            this.lbRoomStatus.Location = new System.Drawing.Point(850, 474);
            this.lbRoomStatus.Name = "lbRoomStatus";
            this.lbRoomStatus.Size = new System.Drawing.Size(56, 20);
            this.lbRoomStatus.TabIndex = 58;
            this.lbRoomStatus.Text = "Status :";
            // 
            // lbRoomPrice
            // 
            this.lbRoomPrice.AutoSize = true;
            this.lbRoomPrice.Location = new System.Drawing.Point(850, 395);
            this.lbRoomPrice.Name = "lbRoomPrice";
            this.lbRoomPrice.Size = new System.Drawing.Size(84, 20);
            this.lbRoomPrice.TabIndex = 57;
            this.lbRoomPrice.Text = "Price (/1h) :";
            // 
            // lbRoomType
            // 
            this.lbRoomType.AutoSize = true;
            this.lbRoomType.Location = new System.Drawing.Point(850, 318);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(47, 20);
            this.lbRoomType.TabIndex = 56;
            this.lbRoomType.Text = "Type :";
            // 
            // lbRoomNumber
            // 
            this.lbRoomNumber.AutoSize = true;
            this.lbRoomNumber.Location = new System.Drawing.Point(850, 236);
            this.lbRoomNumber.Name = "lbRoomNumber";
            this.lbRoomNumber.Size = new System.Drawing.Size(114, 20);
            this.lbRoomNumber.TabIndex = 55;
            this.lbRoomNumber.Text = "Room Number :";
            // 
            // lbRoomFloor
            // 
            this.lbRoomFloor.AutoSize = true;
            this.lbRoomFloor.Location = new System.Drawing.Point(850, 159);
            this.lbRoomFloor.Name = "lbRoomFloor";
            this.lbRoomFloor.Size = new System.Drawing.Size(50, 20);
            this.lbRoomFloor.TabIndex = 54;
            this.lbRoomFloor.Text = "Floor :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(927, 19);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(150, 81);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            // 
            // btDeleteRoom
            // 
            this.btDeleteRoom.Location = new System.Drawing.Point(1024, 619);
            this.btDeleteRoom.Name = "btDeleteRoom";
            this.btDeleteRoom.Size = new System.Drawing.Size(94, 29);
            this.btDeleteRoom.TabIndex = 18;
            this.btDeleteRoom.Text = "Delete";
            this.btDeleteRoom.UseVisualStyleBackColor = true;
            this.btDeleteRoom.Click += new System.EventHandler(this.btDeleteRoom_Click);
            // 
            // btUpdateRoom
            // 
            this.btUpdateRoom.Location = new System.Drawing.Point(878, 619);
            this.btUpdateRoom.Name = "btUpdateRoom";
            this.btUpdateRoom.Size = new System.Drawing.Size(94, 29);
            this.btUpdateRoom.TabIndex = 17;
            this.btUpdateRoom.Text = "Update";
            this.btUpdateRoom.UseVisualStyleBackColor = true;
            this.btUpdateRoom.Click += new System.EventHandler(this.btUpdateRoom_Click);
            // 
            // btReadRoom
            // 
            this.btReadRoom.Location = new System.Drawing.Point(1024, 564);
            this.btReadRoom.Name = "btReadRoom";
            this.btReadRoom.Size = new System.Drawing.Size(94, 29);
            this.btReadRoom.TabIndex = 16;
            this.btReadRoom.Text = "Read";
            this.btReadRoom.UseVisualStyleBackColor = true;
            this.btReadRoom.Click += new System.EventHandler(this.btReadRoom_Click);
            // 
            // btCreateRoom
            // 
            this.btCreateRoom.Location = new System.Drawing.Point(878, 564);
            this.btCreateRoom.Name = "btCreateRoom";
            this.btCreateRoom.Size = new System.Drawing.Size(94, 29);
            this.btCreateRoom.TabIndex = 15;
            this.btCreateRoom.Text = "Create";
            this.btCreateRoom.UseVisualStyleBackColor = true;
            this.btCreateRoom.Click += new System.EventHandler(this.btCreateRoom_Click);
            // 
            // dgvRoom
            // 
            this.dgvRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceCol});
            this.dgvRoom.Location = new System.Drawing.Point(3, 3);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 29;
            this.dgvRoom.Size = new System.Drawing.Size(841, 690);
            this.dgvRoom.TabIndex = 2;
            this.dgvRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellClick);
            this.dgvRoom.Click += new System.EventHandler(this.dgvRoom_Click);
            // 
            // serviceCol
            // 
            this.serviceCol.HeaderText = "Services";
            this.serviceCol.MinimumWidth = 6;
            this.serviceCol.Name = "serviceCol";
            this.serviceCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.serviceCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.serviceCol.Text = "View Services";
            this.serviceCol.UseColumnTextForButtonValue = true;
            this.serviceCol.Width = 125;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.cbSerRoomtype);
            this.tabService.Controls.Add(this.nudSerQty);
            this.tabService.Controls.Add(this.nudSerPrice);
            this.tabService.Controls.Add(this.tbSerName);
            this.tabService.Controls.Add(this.tbSerId);
            this.tabService.Controls.Add(this.lbSerQty);
            this.tabService.Controls.Add(this.lbSerPrice);
            this.tabService.Controls.Add(this.lbSerName);
            this.tabService.Controls.Add(this.lbSerRoomtype);
            this.tabService.Controls.Add(this.lbSerId);
            this.tabService.Controls.Add(this.pictureBox7);
            this.tabService.Controls.Add(this.btDeleteService);
            this.tabService.Controls.Add(this.btUpdateService);
            this.tabService.Controls.Add(this.btReadService);
            this.tabService.Controls.Add(this.btCreateService);
            this.tabService.Controls.Add(this.dgvService);
            this.tabService.Location = new System.Drawing.Point(4, 29);
            this.tabService.Name = "tabService";
            this.tabService.Size = new System.Drawing.Size(1150, 696);
            this.tabService.TabIndex = 3;
            this.tabService.Text = "Services";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // cbSerRoomtype
            // 
            this.cbSerRoomtype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSerRoomtype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSerRoomtype.FormattingEnabled = true;
            this.cbSerRoomtype.Location = new System.Drawing.Point(947, 222);
            this.cbSerRoomtype.Name = "cbSerRoomtype";
            this.cbSerRoomtype.Size = new System.Drawing.Size(197, 28);
            this.cbSerRoomtype.TabIndex = 66;
            // 
            // nudSerQty
            // 
            this.nudSerQty.Location = new System.Drawing.Point(947, 454);
            this.nudSerQty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSerQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSerQty.Name = "nudSerQty";
            this.nudSerQty.Size = new System.Drawing.Size(200, 27);
            this.nudSerQty.TabIndex = 65;
            this.nudSerQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSerPrice
            // 
            this.nudSerPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSerPrice.Location = new System.Drawing.Point(947, 382);
            this.nudSerPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudSerPrice.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSerPrice.Name = "nudSerPrice";
            this.nudSerPrice.Size = new System.Drawing.Size(197, 27);
            this.nudSerPrice.TabIndex = 64;
            this.nudSerPrice.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // tbSerName
            // 
            this.tbSerName.Location = new System.Drawing.Point(947, 304);
            this.tbSerName.Name = "tbSerName";
            this.tbSerName.Size = new System.Drawing.Size(197, 27);
            this.tbSerName.TabIndex = 63;
            // 
            // tbSerId
            // 
            this.tbSerId.Location = new System.Drawing.Point(947, 154);
            this.tbSerId.Name = "tbSerId";
            this.tbSerId.Size = new System.Drawing.Size(197, 27);
            this.tbSerId.TabIndex = 60;
            // 
            // lbSerQty
            // 
            this.lbSerQty.AutoSize = true;
            this.lbSerQty.Location = new System.Drawing.Point(850, 461);
            this.lbSerQty.Name = "lbSerQty";
            this.lbSerQty.Size = new System.Drawing.Size(72, 20);
            this.lbSerQty.TabIndex = 58;
            this.lbSerQty.Text = "Quantity :";
            // 
            // lbSerPrice
            // 
            this.lbSerPrice.AutoSize = true;
            this.lbSerPrice.Location = new System.Drawing.Point(850, 384);
            this.lbSerPrice.Name = "lbSerPrice";
            this.lbSerPrice.Size = new System.Drawing.Size(48, 20);
            this.lbSerPrice.TabIndex = 57;
            this.lbSerPrice.Text = "Price :";
            // 
            // lbSerName
            // 
            this.lbSerName.AutoSize = true;
            this.lbSerName.Location = new System.Drawing.Point(850, 307);
            this.lbSerName.Name = "lbSerName";
            this.lbSerName.Size = new System.Drawing.Size(56, 20);
            this.lbSerName.TabIndex = 56;
            this.lbSerName.Text = "Name :";
            // 
            // lbSerRoomtype
            // 
            this.lbSerRoomtype.AutoSize = true;
            this.lbSerRoomtype.Location = new System.Drawing.Point(850, 230);
            this.lbSerRoomtype.Name = "lbSerRoomtype";
            this.lbSerRoomtype.Size = new System.Drawing.Size(91, 20);
            this.lbSerRoomtype.TabIndex = 55;
            this.lbSerRoomtype.Text = "Room Type :";
            // 
            // lbSerId
            // 
            this.lbSerId.AutoSize = true;
            this.lbSerId.Location = new System.Drawing.Point(850, 157);
            this.lbSerId.Name = "lbSerId";
            this.lbSerId.Size = new System.Drawing.Size(82, 20);
            this.lbSerId.TabIndex = 54;
            this.lbSerId.Text = "Service ID :";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(927, 19);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(150, 81);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 36;
            this.pictureBox7.TabStop = false;
            // 
            // btDeleteService
            // 
            this.btDeleteService.Location = new System.Drawing.Point(1027, 624);
            this.btDeleteService.Name = "btDeleteService";
            this.btDeleteService.Size = new System.Drawing.Size(94, 29);
            this.btDeleteService.TabIndex = 18;
            this.btDeleteService.Text = "Delete";
            this.btDeleteService.UseVisualStyleBackColor = true;
            this.btDeleteService.Click += new System.EventHandler(this.btDeleteService_Click);
            // 
            // btUpdateService
            // 
            this.btUpdateService.Location = new System.Drawing.Point(881, 624);
            this.btUpdateService.Name = "btUpdateService";
            this.btUpdateService.Size = new System.Drawing.Size(94, 29);
            this.btUpdateService.TabIndex = 17;
            this.btUpdateService.Text = "Update";
            this.btUpdateService.UseVisualStyleBackColor = true;
            this.btUpdateService.Click += new System.EventHandler(this.btUpdateService_Click);
            // 
            // btReadService
            // 
            this.btReadService.Location = new System.Drawing.Point(1027, 569);
            this.btReadService.Name = "btReadService";
            this.btReadService.Size = new System.Drawing.Size(94, 29);
            this.btReadService.TabIndex = 16;
            this.btReadService.Text = "Read";
            this.btReadService.UseVisualStyleBackColor = true;
            this.btReadService.Click += new System.EventHandler(this.btReadService_Click);
            // 
            // btCreateService
            // 
            this.btCreateService.Location = new System.Drawing.Point(881, 569);
            this.btCreateService.Name = "btCreateService";
            this.btCreateService.Size = new System.Drawing.Size(94, 29);
            this.btCreateService.TabIndex = 15;
            this.btCreateService.Text = "Create";
            this.btCreateService.UseVisualStyleBackColor = true;
            this.btCreateService.Click += new System.EventHandler(this.btCreateService_Click);
            // 
            // dgvService
            // 
            this.dgvService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(3, 3);
            this.dgvService.Name = "dgvService";
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.RowTemplate.Height = 29;
            this.dgvService.Size = new System.Drawing.Size(841, 690);
            this.dgvService.TabIndex = 2;
            this.dgvService.Click += new System.EventHandler(this.dgvService_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.tcManagement);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "frmAdmin";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tcManagement.ResumeLayout(false);
            this.tabAcc.ResumeLayout(false);
            this.tabAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.tabBill.ResumeLayout(false);
            this.tabBill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tabOrder.ResumeLayout(false);
            this.tabOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOrdQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tabMusic.ResumeLayout(false);
            this.tabMusic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).EndInit();
            this.tabRoomType.ResumeLayout(false);
            this.tabRoomType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomtypeId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).EndInit();
            this.tabRoom.ResumeLayout(false);
            this.tabRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRoomPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.tabService.ResumeLayout(false);
            this.tabService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSerPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManagement;
        private System.Windows.Forms.TabPage tabAcc;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.DataGridViewButtonColumn billCol;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.TabPage tabMusic;
        private System.Windows.Forms.DataGridView dgvMusic;
        private System.Windows.Forms.TabPage tabRoomType;
        private System.Windows.Forms.DataGridView dgvRoomType;
        private System.Windows.Forms.TabPage tabRoom;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.DataGridViewButtonColumn serviceCol;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewButtonColumn orderCol;
        private System.Windows.Forms.ComboBox cbAccPermission;
        private System.Windows.Forms.TextBox tbAccName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAccPassword;
        private System.Windows.Forms.Label lbAccUsername;
        private System.Windows.Forms.Label lbAccName;
        private System.Windows.Forms.TextBox tbAccPassword;
        private System.Windows.Forms.TextBox tbAccUsername;
        private System.Windows.Forms.Button btDeleteAcc;
        private System.Windows.Forms.Button btUpdateAcc;
        private System.Windows.Forms.Button btReadAcc;
        private System.Windows.Forms.Button btCreateAcc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btDeleteBill;
        private System.Windows.Forms.Button btUpdateBill;
        private System.Windows.Forms.Button btReadBill;
        private System.Windows.Forms.Button btCreateBill;
        private System.Windows.Forms.Button btDeleteOrd;
        private System.Windows.Forms.Button btUpdateOrd;
        private System.Windows.Forms.Button btReadOrd;
        private System.Windows.Forms.Button btCreateOrd;
        private System.Windows.Forms.Button btDeleteMusic;
        private System.Windows.Forms.Button btUpdateMusic;
        private System.Windows.Forms.Button btReadMusic;
        private System.Windows.Forms.Button btCreateMusic;
        private System.Windows.Forms.Button btDeleteRoomtype;
        private System.Windows.Forms.Button btUpdateRoomtype;
        private System.Windows.Forms.Button btReadRoomtype;
        private System.Windows.Forms.Button btCreateRoomtype;
        private System.Windows.Forms.Button btDeleteRoom;
        private System.Windows.Forms.Button btUpdateRoom;
        private System.Windows.Forms.Button btReadRoom;
        private System.Windows.Forms.Button btCreateRoom;
        private System.Windows.Forms.Button btDeleteService;
        private System.Windows.Forms.Button btUpdateService;
        private System.Windows.Forms.Button btReadService;
        private System.Windows.Forms.Button btCreateService;
        private System.Windows.Forms.Label lbBillStatus;
        private System.Windows.Forms.Label lbBillMethod;
        private System.Windows.Forms.Label lbBillDate;
        private System.Windows.Forms.Label lbBillUser;
        private System.Windows.Forms.Label lbBillId;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dtpBillDate;
        private System.Windows.Forms.RadioButton rbNotPaid;
        private System.Windows.Forms.RadioButton rbPaid;
        private System.Windows.Forms.TextBox tbBillUser;
        private System.Windows.Forms.TextBox tbBillId;
        private System.Windows.Forms.ComboBox cbBillMethod;
        private System.Windows.Forms.Label lbOrdStatus;
        private System.Windows.Forms.Label lbOrdQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOrdUser;
        private System.Windows.Forms.ComboBox cbOrdService;
        private System.Windows.Forms.NumericUpDown nudOrdQty;
        private System.Windows.Forms.RadioButton rbDoing;
        private System.Windows.Forms.RadioButton rbDone;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbMusicLink;
        private System.Windows.Forms.Label lbMusicAbbreviation;
        private System.Windows.Forms.Label lbMusicLyric;
        private System.Windows.Forms.Label lbMusicSinger;
        private System.Windows.Forms.Label lbMusicComposer;
        private System.Windows.Forms.Label lbMusicGenre;
        private System.Windows.Forms.Label lbMusicAName;
        private System.Windows.Forms.Label lbMusicId;
        private System.Windows.Forms.TextBox tbMusicGenre;
        private System.Windows.Forms.TextBox tbMusicLink;
        private System.Windows.Forms.TextBox tbMusicAbbreviation;
        private System.Windows.Forms.TextBox tbMusicSinger;
        private System.Windows.Forms.TextBox tbMusicAName;
        private System.Windows.Forms.TextBox tbMusicId;
        private System.Windows.Forms.TextBox tbMusicComposer;
        private System.Windows.Forms.RichTextBox rtbMusicLyric;
        private System.Windows.Forms.NumericUpDown nudRoomtypeId;
        private System.Windows.Forms.TextBox tbRoomtypeName;
        private System.Windows.Forms.Label lbRoomtypeName;
        private System.Windows.Forms.Label lbRoomtypeId;
        private System.Windows.Forms.RadioButton rbUsing;
        private System.Windows.Forms.RadioButton rbIdle;
        private System.Windows.Forms.NumericUpDown nudRoomPrice;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label lbRoomStatus;
        private System.Windows.Forms.Label lbRoomPrice;
        private System.Windows.Forms.Label lbRoomType;
        private System.Windows.Forms.Label lbRoomNumber;
        private System.Windows.Forms.Label lbRoomFloor;
        private System.Windows.Forms.ComboBox cbSerRoomtype;
        private System.Windows.Forms.NumericUpDown nudSerQty;
        private System.Windows.Forms.NumericUpDown nudSerPrice;
        private System.Windows.Forms.TextBox tbSerName;
        private System.Windows.Forms.TextBox tbSerId;
        private System.Windows.Forms.Label lbSerQty;
        private System.Windows.Forms.Label lbSerPrice;
        private System.Windows.Forms.Label lbSerName;
        private System.Windows.Forms.Label lbSerRoomtype;
        private System.Windows.Forms.Label lbSerId;
        private System.Windows.Forms.Label lbMusicUName;
        private System.Windows.Forms.TextBox tbMusicUName;
        private System.Windows.Forms.NumericUpDown nudRoomNumber;
        private System.Windows.Forms.NumericUpDown nudRoomFloor;
    }
}