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
            this.tcManagement = new System.Windows.Forms.TabControl();
            this.tabAcc = new System.Windows.Forms.TabPage();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.billCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.orderCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.tabMusic = new System.Windows.Forms.TabPage();
            this.dgvMusic = new System.Windows.Forms.DataGridView();
            this.tabRoomType = new System.Windows.Forms.TabPage();
            this.dgvRoomType = new System.Windows.Forms.DataGridView();
            this.tabRoom = new System.Windows.Forms.TabPage();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.serviceCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabService = new System.Windows.Forms.TabPage();
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.tcManagement.SuspendLayout();
            this.tabAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.tabMusic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).BeginInit();
            this.tabRoomType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).BeginInit();
            this.tabRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.tabService.SuspendLayout();
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
            this.tabAcc.Controls.Add(this.dgvAccount);
            this.tabAcc.Location = new System.Drawing.Point(4, 29);
            this.tabAcc.Name = "tabAcc";
            this.tabAcc.Padding = new System.Windows.Forms.Padding(3);
            this.tabAcc.Size = new System.Drawing.Size(1150, 696);
            this.tabAcc.TabIndex = 0;
            this.tabAcc.Text = "Accounts";
            this.tabAcc.UseVisualStyleBackColor = true;
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
            this.tabBill.Controls.Add(this.dgvBill);
            this.tabBill.Location = new System.Drawing.Point(4, 29);
            this.tabBill.Name = "tabBill";
            this.tabBill.Size = new System.Drawing.Size(1150, 696);
            this.tabBill.TabIndex = 5;
            this.tabBill.Text = "Bills";
            this.tabBill.UseVisualStyleBackColor = true;
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
            this.tabOrder.Controls.Add(this.dgvOrder);
            this.tabOrder.Location = new System.Drawing.Point(4, 29);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Size = new System.Drawing.Size(1150, 696);
            this.tabOrder.TabIndex = 6;
            this.tabOrder.Text = "Orders";
            this.tabOrder.UseVisualStyleBackColor = true;
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
            // 
            // tabMusic
            // 
            this.tabMusic.Controls.Add(this.dgvMusic);
            this.tabMusic.Location = new System.Drawing.Point(4, 29);
            this.tabMusic.Name = "tabMusic";
            this.tabMusic.Padding = new System.Windows.Forms.Padding(3);
            this.tabMusic.Size = new System.Drawing.Size(1150, 696);
            this.tabMusic.TabIndex = 1;
            this.tabMusic.Text = "Musics";
            this.tabMusic.UseVisualStyleBackColor = true;
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
            // 
            // tabRoomType
            // 
            this.tabRoomType.Controls.Add(this.dgvRoomType);
            this.tabRoomType.Location = new System.Drawing.Point(4, 29);
            this.tabRoomType.Name = "tabRoomType";
            this.tabRoomType.Size = new System.Drawing.Size(1150, 696);
            this.tabRoomType.TabIndex = 2;
            this.tabRoomType.Text = "Types of Room";
            this.tabRoomType.UseVisualStyleBackColor = true;
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
            // 
            // tabRoom
            // 
            this.tabRoom.Controls.Add(this.dgvRoom);
            this.tabRoom.Location = new System.Drawing.Point(4, 29);
            this.tabRoom.Name = "tabRoom";
            this.tabRoom.Size = new System.Drawing.Size(1150, 696);
            this.tabRoom.TabIndex = 4;
            this.tabRoom.Text = "Rooms";
            this.tabRoom.UseVisualStyleBackColor = true;
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
            this.tabService.Controls.Add(this.dgvService);
            this.tabService.Location = new System.Drawing.Point(4, 29);
            this.tabService.Name = "tabService";
            this.tabService.Size = new System.Drawing.Size(1150, 696);
            this.tabService.TabIndex = 3;
            this.tabService.Text = "Services";
            this.tabService.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.tabBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tabOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.tabMusic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusic)).EndInit();
            this.tabRoomType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomType)).EndInit();
            this.tabRoom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.tabService.ResumeLayout(false);
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
    }
}