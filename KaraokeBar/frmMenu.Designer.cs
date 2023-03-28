namespace KaraokeBar
{
    partial class frmMenu
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
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.serviceidCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tcService = new System.Windows.Forms.TabControl();
            this.tabService = new System.Windows.Forms.TabPage();
            this.btConfirm = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.gbOrder = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.serName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeCol = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.tabBill = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.tcService.SuspendLayout();
            this.tabService.SuspendLayout();
            this.gbOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvService
            // 
            this.dgvService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceidCol,
            this.nameCol,
            this.priceCol,
            this.quantityCol,
            this.orderCol});
            this.dgvService.Location = new System.Drawing.Point(6, 26);
            this.dgvService.Name = "dgvService";
            this.dgvService.RowHeadersWidth = 51;
            this.dgvService.RowTemplate.Height = 29;
            this.dgvService.Size = new System.Drawing.Size(672, 502);
            this.dgvService.TabIndex = 0;
            this.dgvService.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvService_CellClick);
            // 
            // serviceidCol
            // 
            this.serviceidCol.HeaderText = "Service ID";
            this.serviceidCol.MinimumWidth = 6;
            this.serviceidCol.Name = "serviceidCol";
            this.serviceidCol.Visible = false;
            this.serviceidCol.Width = 125;
            // 
            // nameCol
            // 
            this.nameCol.HeaderText = "Service Name";
            this.nameCol.MinimumWidth = 6;
            this.nameCol.Name = "nameCol";
            this.nameCol.Width = 180;
            // 
            // priceCol
            // 
            this.priceCol.HeaderText = "Price";
            this.priceCol.MinimumWidth = 6;
            this.priceCol.Name = "priceCol";
            this.priceCol.Width = 125;
            // 
            // quantityCol
            // 
            this.quantityCol.HeaderText = "Remaining Quantity";
            this.quantityCol.MinimumWidth = 6;
            this.quantityCol.Name = "quantityCol";
            this.quantityCol.Width = 170;
            // 
            // orderCol
            // 
            this.orderCol.HeaderText = "Order";
            this.orderCol.MinimumWidth = 6;
            this.orderCol.Name = "orderCol";
            this.orderCol.Text = "Add";
            this.orderCol.UseColumnTextForButtonValue = true;
            this.orderCol.Width = 125;
            // 
            // tcService
            // 
            this.tcService.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcService.Controls.Add(this.tabService);
            this.tcService.Controls.Add(this.tabBill);
            this.tcService.Location = new System.Drawing.Point(12, 12);
            this.tcService.Name = "tcService";
            this.tcService.SelectedIndex = 0;
            this.tcService.Size = new System.Drawing.Size(1264, 579);
            this.tcService.TabIndex = 0;
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.btConfirm);
            this.tabService.Controls.Add(this.tbTotal);
            this.tabService.Controls.Add(this.lbTotal);
            this.tabService.Controls.Add(this.gbOrder);
            this.tabService.Controls.Add(this.gbMenu);
            this.tabService.Location = new System.Drawing.Point(4, 29);
            this.tabService.Name = "tabService";
            this.tabService.Padding = new System.Windows.Forms.Padding(3);
            this.tabService.Size = new System.Drawing.Size(1256, 546);
            this.tabService.TabIndex = 0;
            this.tabService.Text = "Service";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // btConfirm
            // 
            this.btConfirm.Location = new System.Drawing.Point(1041, 427);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(94, 84);
            this.btConfirm.TabIndex = 4;
            this.btConfirm.Text = "Confirm";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(810, 484);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(125, 27);
            this.tbTotal.TabIndex = 3;
            // 
            // lbTotal
            // 
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTotal.Location = new System.Drawing.Point(810, 427);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(125, 54);
            this.lbTotal.TabIndex = 2;
            this.lbTotal.Text = "Total Payment";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbOrder
            // 
            this.gbOrder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbOrder.Controls.Add(this.dgvOrder);
            this.gbOrder.Location = new System.Drawing.Point(694, 6);
            this.gbOrder.Name = "gbOrder";
            this.gbOrder.Size = new System.Drawing.Size(556, 391);
            this.gbOrder.TabIndex = 1;
            this.gbOrder.TabStop = false;
            this.gbOrder.Text = "Order List";
            // 
            // dgvOrder
            // 
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serName,
            this.serQty,
            this.total,
            this.removeCol});
            this.dgvOrder.Location = new System.Drawing.Point(6, 26);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 29;
            this.dgvOrder.Size = new System.Drawing.Size(544, 359);
            this.dgvOrder.TabIndex = 0;
            this.dgvOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrder_CellClick);
            // 
            // serName
            // 
            this.serName.HeaderText = "Name";
            this.serName.MinimumWidth = 6;
            this.serName.Name = "serName";
            this.serName.Width = 125;
            // 
            // serQty
            // 
            this.serQty.HeaderText = "Quantity";
            this.serQty.MinimumWidth = 6;
            this.serQty.Name = "serQty";
            this.serQty.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // removeCol
            // 
            this.removeCol.HeaderText = "Remove Order";
            this.removeCol.MinimumWidth = 6;
            this.removeCol.Name = "removeCol";
            this.removeCol.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.removeCol.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.removeCol.Text = "Remove";
            this.removeCol.UseColumnTextForButtonValue = true;
            this.removeCol.Width = 125;
            // 
            // gbMenu
            // 
            this.gbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMenu.Controls.Add(this.dgvService);
            this.gbMenu.Location = new System.Drawing.Point(6, 6);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(684, 534);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "Menu";
            // 
            // tabBill
            // 
            this.tabBill.Location = new System.Drawing.Point(4, 29);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(3);
            this.tabBill.Size = new System.Drawing.Size(1269, 546);
            this.tabBill.TabIndex = 1;
            this.tabBill.Text = "Bill";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 603);
            this.Controls.Add(this.tcService);
            this.MinimumSize = new System.Drawing.Size(1250, 600);
            this.Name = "frmMenu";
            this.Text = "Wishing you a delicious!";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
            this.tcService.ResumeLayout(false);
            this.tabService.ResumeLayout(false);
            this.tabService.PerformLayout();
            this.gbOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.gbMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.GroupBox gbOrder;
        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceidCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityCol;
        private System.Windows.Forms.DataGridViewButtonColumn orderCol;
        public System.Windows.Forms.TabControl tcService;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn serName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn removeCol;
    }
}