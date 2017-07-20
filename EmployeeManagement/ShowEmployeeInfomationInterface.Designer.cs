namespace PharmacyManagement
{
    partial class ShowEmployeeInfomationInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.layoutNameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.statusLbl = new System.Windows.Forms.Label();
            this.statusCbx = new System.Windows.Forms.ComboBox();
            this.EMPIDLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.addressTxt = new System.Windows.Forms.TextBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.typeCBox = new System.Windows.Forms.ComboBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.shopCBox = new System.Windows.Forms.ComboBox();
            this.shopLbl = new System.Windows.Forms.Label();
            this.contactNoTxt = new System.Windows.Forms.TextBox();
            this.contactNoLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchGBox = new System.Windows.Forms.GroupBox();
            this.employeeIdLbl = new System.Windows.Forms.Label();
            this.nicLbl = new System.Windows.Forms.Label();
            this.employeeIdTxt = new System.Windows.Forms.TextBox();
            this.nicTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.searchGBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::PharmacyManagement.Properties.Resources.contactformbgnd;
            this.panel1.Controls.Add(this.layoutNameLbl);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.searchGBox);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 511);
            this.panel1.TabIndex = 0;
            // 
            // layoutNameLbl
            // 
            this.layoutNameLbl.AutoSize = true;
            this.layoutNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.layoutNameLbl.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layoutNameLbl.Location = new System.Drawing.Point(306, 9);
            this.layoutNameLbl.Name = "layoutNameLbl";
            this.layoutNameLbl.Size = new System.Drawing.Size(247, 22);
            this.layoutNameLbl.TabIndex = 15;
            this.layoutNameLbl.Text = "Show Employee Infomation";
            this.layoutNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.statusLbl);
            this.groupBox1.Controls.Add(this.statusCbx);
            this.groupBox1.Controls.Add(this.EMPIDLbl);
            this.groupBox1.Controls.Add(this.saveBtn);
            this.groupBox1.Controls.Add(this.addressTxt);
            this.groupBox1.Controls.Add(this.typeLbl);
            this.groupBox1.Controls.Add(this.typeCBox);
            this.groupBox1.Controls.Add(this.addressLbl);
            this.groupBox1.Controls.Add(this.shopCBox);
            this.groupBox1.Controls.Add(this.shopLbl);
            this.groupBox1.Controls.Add(this.contactNoTxt);
            this.groupBox1.Controls.Add(this.contactNoLbl);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 340);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 156);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update Info";
            this.groupBox1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(514, 45);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 19);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Owner Change";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // statusLbl
            // 
            this.statusLbl.AutoSize = true;
            this.statusLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLbl.Location = new System.Drawing.Point(301, 83);
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(40, 15);
            this.statusLbl.TabIndex = 17;
            this.statusLbl.Text = "Status";
            // 
            // statusCbx
            // 
            this.statusCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusCbx.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusCbx.FormattingEnabled = true;
            this.statusCbx.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.statusCbx.Location = new System.Drawing.Point(363, 80);
            this.statusCbx.Name = "statusCbx";
            this.statusCbx.Size = new System.Drawing.Size(145, 23);
            this.statusCbx.TabIndex = 7;
            this.statusCbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.statusCbx_KeyDown);
            // 
            // EMPIDLbl
            // 
            this.EMPIDLbl.AutoSize = true;
            this.EMPIDLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMPIDLbl.Location = new System.Drawing.Point(171, 12);
            this.EMPIDLbl.Name = "EMPIDLbl";
            this.EMPIDLbl.Size = new System.Drawing.Size(94, 15);
            this.EMPIDLbl.TabIndex = 15;
            this.EMPIDLbl.Text = "Employee ID : ";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Image = global::PharmacyManagement.Properties.Resources.ic_save_black_24dp_1x;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(527, 105);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(84, 37);
            this.saveBtn.TabIndex = 9;
            this.saveBtn.Text = "    Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(97, 43);
            this.addressTxt.Multiline = true;
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(171, 57);
            this.addressTxt.TabIndex = 4;
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            this.addressTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressTxt_KeyDown);
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLbl.Location = new System.Drawing.Point(306, 46);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(35, 15);
            this.typeLbl.TabIndex = 10;
            this.typeLbl.Text = "Type";
            // 
            // typeCBox
            // 
            this.typeCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCBox.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCBox.FormattingEnabled = true;
            this.typeCBox.Items.AddRange(new object[] {
            "Owner",
            "Cashier",
            "Supervisor"});
            this.typeCBox.Location = new System.Drawing.Point(363, 43);
            this.typeCBox.Name = "typeCBox";
            this.typeCBox.Size = new System.Drawing.Size(145, 23);
            this.typeCBox.TabIndex = 6;
            this.typeCBox.SelectedIndexChanged += new System.EventHandler(this.typeCBox_SelectedIndexChanged);
            this.typeCBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.typeCBox_KeyDown);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(17, 46);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(52, 15);
            this.addressLbl.TabIndex = 7;
            this.addressLbl.Text = "Address";
            // 
            // shopCBox
            // 
            this.shopCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shopCBox.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopCBox.FormattingEnabled = true;
            this.shopCBox.Items.AddRange(new object[] {
            "Shop",
            "Shop1",
            "Shop2"});
            this.shopCBox.Location = new System.Drawing.Point(363, 116);
            this.shopCBox.Name = "shopCBox";
            this.shopCBox.Size = new System.Drawing.Size(145, 23);
            this.shopCBox.TabIndex = 8;
            this.shopCBox.SelectedIndexChanged += new System.EventHandler(this.shopCBox_SelectedIndexChanged);
            this.shopCBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shopCBox_KeyDown);
            // 
            // shopLbl
            // 
            this.shopLbl.AutoSize = true;
            this.shopLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopLbl.Location = new System.Drawing.Point(307, 119);
            this.shopLbl.Name = "shopLbl";
            this.shopLbl.Size = new System.Drawing.Size(34, 15);
            this.shopLbl.TabIndex = 9;
            this.shopLbl.Text = "Shop";
            // 
            // contactNoTxt
            // 
            this.contactNoTxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNoTxt.Location = new System.Drawing.Point(96, 116);
            this.contactNoTxt.Name = "contactNoTxt";
            this.contactNoTxt.Size = new System.Drawing.Size(171, 23);
            this.contactNoTxt.TabIndex = 5;
            this.contactNoTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.contactNoTxt_KeyDown);
            this.contactNoTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contactNoTxt_KeyPress);
            // 
            // contactNoLbl
            // 
            this.contactNoLbl.AutoSize = true;
            this.contactNoLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactNoLbl.Location = new System.Drawing.Point(17, 119);
            this.contactNoLbl.Name = "contactNoLbl";
            this.contactNoLbl.Size = new System.Drawing.Size(64, 15);
            this.contactNoLbl.TabIndex = 8;
            this.contactNoLbl.Text = "ContactNo";
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Image = global::PharmacyManagement.Properties.Resources.ic_cancel_black_24dp_1x;
            this.closeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.closeBtn.Location = new System.Drawing.Point(719, 456);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(101, 37);
            this.closeBtn.TabIndex = 10;
            this.closeBtn.Text = "    Clo&se";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.Image = global::PharmacyManagement.Properties.Resources.ic_update_black_24dp_1x;
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(719, 410);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(101, 37);
            this.updateBtn.TabIndex = 4;
            this.updateBtn.Text = "    Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(23, 141);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 181);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.RowHeaderCellChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowHeaderCellChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // searchGBox
            // 
            this.searchGBox.BackColor = System.Drawing.Color.Transparent;
            this.searchGBox.Controls.Add(this.employeeIdLbl);
            this.searchGBox.Controls.Add(this.nicLbl);
            this.searchGBox.Controls.Add(this.employeeIdTxt);
            this.searchGBox.Controls.Add(this.nicTxt);
            this.searchGBox.Controls.Add(this.nameTxt);
            this.searchGBox.Controls.Add(this.nameLbl);
            this.searchGBox.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchGBox.Location = new System.Drawing.Point(23, 52);
            this.searchGBox.Name = "searchGBox";
            this.searchGBox.Size = new System.Drawing.Size(797, 74);
            this.searchGBox.TabIndex = 1;
            this.searchGBox.TabStop = false;
            this.searchGBox.Text = "Search by";
            // 
            // employeeIdLbl
            // 
            this.employeeIdLbl.AutoSize = true;
            this.employeeIdLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdLbl.Location = new System.Drawing.Point(22, 32);
            this.employeeIdLbl.Name = "employeeIdLbl";
            this.employeeIdLbl.Size = new System.Drawing.Size(78, 15);
            this.employeeIdLbl.TabIndex = 5;
            this.employeeIdLbl.Text = "Employee ID";
            // 
            // nicLbl
            // 
            this.nicLbl.AutoSize = true;
            this.nicLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicLbl.Location = new System.Drawing.Point(328, 32);
            this.nicLbl.Name = "nicLbl";
            this.nicLbl.Size = new System.Drawing.Size(27, 15);
            this.nicLbl.TabIndex = 4;
            this.nicLbl.Text = "NIC";
            // 
            // employeeIdTxt
            // 
            this.employeeIdTxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdTxt.Location = new System.Drawing.Point(127, 28);
            this.employeeIdTxt.Name = "employeeIdTxt";
            this.employeeIdTxt.Size = new System.Drawing.Size(144, 23);
            this.employeeIdTxt.TabIndex = 0;
            this.employeeIdTxt.TextChanged += new System.EventHandler(this.employeeIdTxt_TextChanged);
            this.employeeIdTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.employeeIdTxt_KeyDown);
            // 
            // nicTxt
            // 
            this.nicTxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicTxt.Location = new System.Drawing.Point(377, 28);
            this.nicTxt.Name = "nicTxt";
            this.nicTxt.Size = new System.Drawing.Size(144, 23);
            this.nicTxt.TabIndex = 1;
            this.nicTxt.TextChanged += new System.EventHandler(this.nicTxt_TextChanged);
            this.nicTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nicTxt_KeyDown);
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(633, 28);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(144, 23);
            this.nameTxt.TabIndex = 2;
            this.nameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.nameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nameTxt_KeyDown);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(572, 29);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(39, 15);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.viewHelpToolStripMenuItem.Text = "View help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // ShowEmployeeInfomationInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 510);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowEmployeeInfomationInterface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randima Pharmacy | Wadduwa";
            this.Load += new System.EventHandler(this.ShowEmployeeInfomation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.searchGBox.ResumeLayout(false);
            this.searchGBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.GroupBox searchGBox;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Label employeeIdLbl;
        private System.Windows.Forms.Label nicLbl;
        private System.Windows.Forms.TextBox employeeIdTxt;
        private System.Windows.Forms.TextBox nicTxt;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Label shopLbl;
        private System.Windows.Forms.Label contactNoLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox contactNoTxt;
        private System.Windows.Forms.TextBox addressTxt;
        private System.Windows.Forms.ComboBox typeCBox;
        private System.Windows.Forms.ComboBox shopCBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label layoutNameLbl;
        private System.Windows.Forms.Label EMPIDLbl;
        private System.Windows.Forms.Label statusLbl;
        private System.Windows.Forms.ComboBox statusCbx;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
    }
}