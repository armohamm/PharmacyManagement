namespace PharmacyManagement
{
    partial class CashierInterface
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
            this.changePasswordBtn = new System.Windows.Forms.Button();
            this.makeASaleBtn = new System.Windows.Forms.Button();
            this.searchItemBtn = new System.Windows.Forms.Button();
            this.returnItemBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.changePasswordBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordBtn.Image = global::PharmacyManagement.Properties.Resources.ic_lock_open_black_24dp_2x1;
            this.changePasswordBtn.Location = new System.Drawing.Point(12, 274);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(291, 113);
            this.changePasswordBtn.TabIndex = 3;
            this.changePasswordBtn.Text = "Change Password";
            this.changePasswordBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.changePasswordBtn.UseVisualStyleBackColor = false;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // makeASaleBtn
            // 
            this.makeASaleBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.makeASaleBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeASaleBtn.Image = global::PharmacyManagement.Properties.Resources.ic_local_grocery_store_black_24dp_2x;
            this.makeASaleBtn.Location = new System.Drawing.Point(12, 36);
            this.makeASaleBtn.Name = "makeASaleBtn";
            this.makeASaleBtn.Size = new System.Drawing.Size(318, 113);
            this.makeASaleBtn.TabIndex = 1;
            this.makeASaleBtn.Text = "Make a Sale";
            this.makeASaleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.makeASaleBtn.UseVisualStyleBackColor = false;
            this.makeASaleBtn.Click += new System.EventHandler(this.makeASaleBtn_Click);
            // 
            // searchItemBtn
            // 
            this.searchItemBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.searchItemBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchItemBtn.Image = global::PharmacyManagement.Properties.Resources.ic_search_black_24dp_2x;
            this.searchItemBtn.Location = new System.Drawing.Point(12, 155);
            this.searchItemBtn.Name = "searchItemBtn";
            this.searchItemBtn.Size = new System.Drawing.Size(569, 113);
            this.searchItemBtn.TabIndex = 0;
            this.searchItemBtn.Text = "Search product";
            this.searchItemBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchItemBtn.UseVisualStyleBackColor = false;
            this.searchItemBtn.Click += new System.EventHandler(this.searchItemBtn_Click);
            // 
            // returnItemBtn
            // 
            this.returnItemBtn.BackColor = System.Drawing.Color.AliceBlue;
            this.returnItemBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnItemBtn.Image = global::PharmacyManagement.Properties.Resources.ic_backspace_black_24dp_2x;
            this.returnItemBtn.Location = new System.Drawing.Point(336, 36);
            this.returnItemBtn.Name = "returnItemBtn";
            this.returnItemBtn.Size = new System.Drawing.Size(245, 113);
            this.returnItemBtn.TabIndex = 2;
            this.returnItemBtn.Text = "Return Item";
            this.returnItemBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.returnItemBtn.UseVisualStyleBackColor = false;
            this.returnItemBtn.Click += new System.EventHandler(this.returnItemBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PharmacyManagement.Properties.Resources.ic_swap_horiz_black_24dp_2x1;
            this.button1.Location = new System.Drawing.Point(309, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 113);
            this.button1.TabIndex = 4;
            this.button1.Text = "Logout";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(417, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Logged in as :";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 6;
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
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.viewHelpToolStripMenuItem.Text = "View help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // CashierInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmacyManagement.Properties.Resources.contactformbgnd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.returnItemBtn);
            this.Controls.Add(this.searchItemBtn);
            this.Controls.Add(this.makeASaleBtn);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CashierInterface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randima Pharmacy | Wadduwa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CashierInterface_FormClosing);
            this.Load += new System.EventHandler(this.CashierInterface_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button changePasswordBtn;
        private System.Windows.Forms.Button makeASaleBtn;
        private System.Windows.Forms.Button searchItemBtn;
        private System.Windows.Forms.Button returnItemBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
    }
}