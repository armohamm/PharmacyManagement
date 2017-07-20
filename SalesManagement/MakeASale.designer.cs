namespace PharmacyManagement
{
    partial class MakeASale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Endtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addbttn = new System.Windows.Forms.Button();
            this.MASBttn = new System.Windows.Forms.Button();
            this.Totaltxt = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.dscnttxt = new System.Windows.Forms.TextBox();
            this.RMVALLBttn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pnametxt = new System.Windows.Forms.TextBox();
            this.pcodetxt = new System.Windows.Forms.TextBox();
            this.Exitbttn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.logtxt = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Remove,
            this.pcode,
            this.product,
            this.quantity,
            this.price,
            this.Endtotal});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(31, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(740, 140);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // pcode
            // 
            this.pcode.HeaderText = "prodcut_code";
            this.pcode.Name = "pcode";
            this.pcode.ReadOnly = true;
            // 
            // product
            // 
            this.product.HeaderText = "Product";
            this.product.Name = "product";
            this.product.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Endtotal
            // 
            this.Endtotal.HeaderText = "Total";
            this.Endtotal.Name = "Endtotal";
            this.Endtotal.ReadOnly = true;
            // 
            // Addbttn
            // 
            this.Addbttn.BackColor = System.Drawing.SystemColors.Control;
            this.Addbttn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbttn.Image = global::PharmacyManagement.Properties.Resources.ic_add_box_black_24dp_1x;
            this.Addbttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Addbttn.Location = new System.Drawing.Point(31, 238);
            this.Addbttn.Name = "Addbttn";
            this.Addbttn.Size = new System.Drawing.Size(99, 32);
            this.Addbttn.TabIndex = 6;
            this.Addbttn.Text = "     ADD";
            this.Addbttn.UseVisualStyleBackColor = true;
            this.Addbttn.Click += new System.EventHandler(this.Addbttn_Click);
            // 
            // MASBttn
            // 
            this.MASBttn.BackColor = System.Drawing.SystemColors.Control;
            this.MASBttn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MASBttn.Image = global::PharmacyManagement.Properties.Resources.ic_assignment_turned_in_black_24dp_1x;
            this.MASBttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MASBttn.Location = new System.Drawing.Point(31, 450);
            this.MASBttn.Name = "MASBttn";
            this.MASBttn.Size = new System.Drawing.Size(99, 31);
            this.MASBttn.TabIndex = 8;
            this.MASBttn.Text = "     FINISH";
            this.MASBttn.UseVisualStyleBackColor = true;
            this.MASBttn.Click += new System.EventHandler(this.MASBttn_Click);
            // 
            // Totaltxt
            // 
            this.Totaltxt.Location = new System.Drawing.Point(242, 456);
            this.Totaltxt.Name = "Totaltxt";
            this.Totaltxt.ReadOnly = true;
            this.Totaltxt.Size = new System.Drawing.Size(110, 20);
            this.Totaltxt.TabIndex = 40;
            this.Totaltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Totaltxt.TextChanged += new System.EventHandler(this.Totaltxt_TextChanged);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.Transparent;
            this.Total.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(177, 459);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(58, 15);
            this.Total.TabIndex = 8;
            this.Total.Text = "Total Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(544, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantity";
            // 
            // quantitytxt
            // 
            this.quantitytxt.Location = new System.Drawing.Point(599, 206);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.Size = new System.Drawing.Size(100, 20);
            this.quantitytxt.TabIndex = 4;
            this.quantitytxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantitytxt.TextChanged += new System.EventHandler(this.quantitytxt_TextChanged);
            this.quantitytxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantitytxt_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Product code";
            // 
            // Discount
            // 
            this.Discount.AutoSize = true;
            this.Discount.BackColor = System.Drawing.Color.Transparent;
            this.Discount.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discount.Location = new System.Drawing.Point(702, 208);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(57, 15);
            this.Discount.TabIndex = 14;
            this.Discount.Text = "Discount";
            // 
            // dscnttxt
            // 
            this.dscnttxt.Location = new System.Drawing.Point(761, 206);
            this.dscnttxt.Name = "dscnttxt";
            this.dscnttxt.Size = new System.Drawing.Size(94, 20);
            this.dscnttxt.TabIndex = 5;
            this.dscnttxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dscnttxt.TextChanged += new System.EventHandler(this.dscnttxt_TextChanged);
            this.dscnttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dscnttxt_KeyPress);
            // 
            // RMVALLBttn
            // 
            this.RMVALLBttn.BackColor = System.Drawing.SystemColors.Control;
            this.RMVALLBttn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMVALLBttn.Image = global::PharmacyManagement.Properties.Resources.ic_clear_all_black_24dp_1x;
            this.RMVALLBttn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RMVALLBttn.Location = new System.Drawing.Point(787, 287);
            this.RMVALLBttn.Name = "RMVALLBttn";
            this.RMVALLBttn.Size = new System.Drawing.Size(68, 62);
            this.RMVALLBttn.TabIndex = 7;
            this.RMVALLBttn.Text = "REMOVE ALL";
            this.RMVALLBttn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RMVALLBttn.UseVisualStyleBackColor = true;
            this.RMVALLBttn.Click += new System.EventHandler(this.RMVALLBttn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.Location = new System.Drawing.Point(31, 50);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(824, 149);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // pnametxt
            // 
            this.pnametxt.Location = new System.Drawing.Point(114, 206);
            this.pnametxt.Name = "pnametxt";
            this.pnametxt.Size = new System.Drawing.Size(100, 20);
            this.pnametxt.TabIndex = 1;
            this.pnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pnametxt.TextChanged += new System.EventHandler(this.pnametxt_TextChanged);
            // 
            // pcodetxt
            // 
            this.pcodetxt.Location = new System.Drawing.Point(294, 206);
            this.pcodetxt.Name = "pcodetxt";
            this.pcodetxt.Size = new System.Drawing.Size(104, 20);
            this.pcodetxt.TabIndex = 2;
            this.pcodetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pcodetxt.TextChanged += new System.EventHandler(this.pcodetxt_TextChanged);
            this.pcodetxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pcodetxt_KeyPress);
            // 
            // Exitbttn
            // 
            this.Exitbttn.BackColor = System.Drawing.SystemColors.Control;
            this.Exitbttn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbttn.Image = global::PharmacyManagement.Properties.Resources.ic_cancel_black_24dp_1x;
            this.Exitbttn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exitbttn.Location = new System.Drawing.Point(774, 450);
            this.Exitbttn.Name = "Exitbttn";
            this.Exitbttn.Size = new System.Drawing.Size(81, 31);
            this.Exitbttn.TabIndex = 9;
            this.Exitbttn.Text = "    Exit";
            this.Exitbttn.UseVisualStyleBackColor = true;
            this.Exitbttn.Click += new System.EventHandler(this.Exitbttn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Price";
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(436, 206);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(105, 20);
            this.pricetxt.TabIndex = 3;
            this.pricetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.pricetxt.TextChanged += new System.EventHandler(this.pricetxt_TextChanged);
            // 
            // logtxt
            // 
            this.logtxt.AutoSize = true;
            this.logtxt.BackColor = System.Drawing.Color.Transparent;
            this.logtxt.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logtxt.Location = new System.Drawing.Point(688, 18);
            this.logtxt.Name = "logtxt";
            this.logtxt.Size = new System.Drawing.Size(83, 15);
            this.logtxt.TabIndex = 41;
            this.logtxt.Text = "Logged In As :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(879, 24);
            this.menuStrip1.TabIndex = 42;
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
            // MakeASale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmacyManagement.Properties.Resources.contactformbgnd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(879, 503);
            this.Controls.Add(this.logtxt);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Exitbttn);
            this.Controls.Add(this.pcodetxt);
            this.Controls.Add(this.pnametxt);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.RMVALLBttn);
            this.Controls.Add(this.dscnttxt);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantitytxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Totaltxt);
            this.Controls.Add(this.MASBttn);
            this.Controls.Add(this.Addbttn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MakeASale";
            this.Text = "Make A Sale";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Addbttn;
        private System.Windows.Forms.Button MASBttn;
        private System.Windows.Forms.TextBox Totaltxt;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.TextBox dscnttxt;
        private System.Windows.Forms.Button RMVALLBttn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox pnametxt;
        private System.Windows.Forms.TextBox pcodetxt;
        private System.Windows.Forms.Button Exitbttn;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.DataGridViewTextBoxColumn pcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn product;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Endtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.Label logtxt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
    }
}

