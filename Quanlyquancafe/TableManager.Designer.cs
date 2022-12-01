namespace Quanlyquancafe
{
    partial class TableManager
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listViewBill = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBoxSwichTable = new System.Windows.Forms.ComboBox();
            this.buttonSwichTable = new System.Windows.Forms.Button();
            this.numericUpDownDisCount = new System.Windows.Forms.NumericUpDown();
            this.buttonDisCount = new System.Windows.Forms.Button();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.numericUpDownCount = new System.Windows.Forms.NumericUpDown();
            this.buttonAddFood = new System.Windows.Forms.Button();
            this.comboBoxFood = new System.Windows.Forms.ComboBox();
            this.comboBoxCaterory = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanelTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisCount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1344, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listViewBill);
            this.panel2.Location = new System.Drawing.Point(757, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 363);
            this.panel2.TabIndex = 2;
            // 
            // listViewBill
            // 
            this.listViewBill.Location = new System.Drawing.Point(7, 3);
            this.listViewBill.Name = "listViewBill";
            this.listViewBill.Size = new System.Drawing.Size(566, 342);
            this.listViewBill.TabIndex = 0;
            this.listViewBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBoxSwichTable);
            this.panel3.Controls.Add(this.buttonSwichTable);
            this.panel3.Controls.Add(this.numericUpDownDisCount);
            this.panel3.Controls.Add(this.buttonDisCount);
            this.panel3.Controls.Add(this.buttonCheckOut);
            this.panel3.Location = new System.Drawing.Point(757, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 70);
            this.panel3.TabIndex = 3;
            // 
            // comboBoxSwichTable
            // 
            this.comboBoxSwichTable.FormattingEnabled = true;
            this.comboBoxSwichTable.Location = new System.Drawing.Point(7, 39);
            this.comboBoxSwichTable.Name = "comboBoxSwichTable";
            this.comboBoxSwichTable.Size = new System.Drawing.Size(138, 28);
            this.comboBoxSwichTable.TabIndex = 7;
            // 
            // buttonSwichTable
            // 
            this.buttonSwichTable.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSwichTable.Location = new System.Drawing.Point(7, 3);
            this.buttonSwichTable.Name = "buttonSwichTable";
            this.buttonSwichTable.Size = new System.Drawing.Size(138, 29);
            this.buttonSwichTable.TabIndex = 6;
            this.buttonSwichTable.Text = "Chuyển bàn";
            this.buttonSwichTable.UseVisualStyleBackColor = true;
            // 
            // numericUpDownDisCount
            // 
            this.numericUpDownDisCount.Location = new System.Drawing.Point(289, 40);
            this.numericUpDownDisCount.Name = "numericUpDownDisCount";
            this.numericUpDownDisCount.Size = new System.Drawing.Size(118, 27);
            this.numericUpDownDisCount.TabIndex = 5;
            this.numericUpDownDisCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDisCount
            // 
            this.buttonDisCount.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDisCount.Location = new System.Drawing.Point(289, 12);
            this.buttonDisCount.Name = "buttonDisCount";
            this.buttonDisCount.Size = new System.Drawing.Size(118, 29);
            this.buttonDisCount.TabIndex = 4;
            this.buttonDisCount.Text = "Thanh toán";
            this.buttonDisCount.UseVisualStyleBackColor = true;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonCheckOut.Location = new System.Drawing.Point(428, 12);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(118, 55);
            this.buttonCheckOut.TabIndex = 3;
            this.buttonCheckOut.Text = "Thanh toán";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.numericUpDownCount);
            this.panel4.Controls.Add(this.buttonAddFood);
            this.panel4.Controls.Add(this.comboBoxFood);
            this.panel4.Controls.Add(this.comboBoxCaterory);
            this.panel4.Location = new System.Drawing.Point(756, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(576, 73);
            this.panel4.TabIndex = 4;
            // 
            // numericUpDownCount
            // 
            this.numericUpDownCount.Location = new System.Drawing.Point(462, 27);
            this.numericUpDownCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownCount.Name = "numericUpDownCount";
            this.numericUpDownCount.Size = new System.Drawing.Size(85, 27);
            this.numericUpDownCount.TabIndex = 3;
            this.numericUpDownCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAddFood
            // 
            this.buttonAddFood.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddFood.Location = new System.Drawing.Point(338, 17);
            this.buttonAddFood.Name = "buttonAddFood";
            this.buttonAddFood.Size = new System.Drawing.Size(118, 43);
            this.buttonAddFood.TabIndex = 2;
            this.buttonAddFood.Text = "Thêm";
            this.buttonAddFood.UseVisualStyleBackColor = true;
            // 
            // comboBoxFood
            // 
            this.comboBoxFood.FormattingEnabled = true;
            this.comboBoxFood.Location = new System.Drawing.Point(8, 45);
            this.comboBoxFood.Name = "comboBoxFood";
            this.comboBoxFood.Size = new System.Drawing.Size(283, 28);
            this.comboBoxFood.TabIndex = 1;
            // 
            // comboBoxCaterory
            // 
            this.comboBoxCaterory.FormattingEnabled = true;
            this.comboBoxCaterory.Location = new System.Drawing.Point(8, 7);
            this.comboBoxCaterory.Name = "comboBoxCaterory";
            this.comboBoxCaterory.Size = new System.Drawing.Size(283, 28);
            this.comboBoxCaterory.TabIndex = 0;
            // 
            // flowLayoutPanelTable
            // 
            this.flowLayoutPanelTable.Location = new System.Drawing.Point(12, 31);
            this.flowLayoutPanelTable.Name = "flowLayoutPanelTable";
            this.flowLayoutPanelTable.Size = new System.Drawing.Size(738, 523);
            this.flowLayoutPanelTable.TabIndex = 5;
            // 
            // TableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 578);
            this.Controls.Add(this.flowLayoutPanelTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán cafe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisCount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private Panel panel2;
        private ListView listViewBill;
        private Panel panel3;
        private Panel panel4;
        private NumericUpDown numericUpDownCount;
        private Button buttonAddFood;
        private ComboBox comboBoxFood;
        private ComboBox comboBoxCaterory;
        private Button buttonCheckOut;
        private FlowLayoutPanel flowLayoutPanelTable;
        private NumericUpDown numericUpDownDisCount;
        private Button buttonDisCount;
        private ComboBox comboBoxSwichTable;
        private Button buttonSwichTable;
    }
}