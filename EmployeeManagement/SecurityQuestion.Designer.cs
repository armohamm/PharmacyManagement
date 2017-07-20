namespace PharmacyManagement.EmployeeManagement
{
    partial class SecurityQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecurityQuestion));
            this.questionLbl = new System.Windows.Forms.Label();
            this.answerLbl = new System.Windows.Forms.Label();
            this.questionTxt = new System.Windows.Forms.TextBox();
            this.answertxt = new System.Windows.Forms.TextBox();
            this.okBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.BackColor = System.Drawing.Color.Transparent;
            this.questionLbl.Location = new System.Drawing.Point(28, 33);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(60, 15);
            this.questionLbl.TabIndex = 0;
            this.questionLbl.Text = "Question:";
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.BackColor = System.Drawing.Color.Transparent;
            this.answerLbl.Location = new System.Drawing.Point(28, 73);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(52, 15);
            this.answerLbl.TabIndex = 1;
            this.answerLbl.Text = "Answer:";
            // 
            // questionTxt
            // 
            this.questionTxt.Location = new System.Drawing.Point(108, 29);
            this.questionTxt.Name = "questionTxt";
            this.questionTxt.ReadOnly = true;
            this.questionTxt.Size = new System.Drawing.Size(429, 23);
            this.questionTxt.TabIndex = 2;
            // 
            // answertxt
            // 
            this.answertxt.Location = new System.Drawing.Point(108, 70);
            this.answertxt.Name = "answertxt";
            this.answertxt.Size = new System.Drawing.Size(429, 23);
            this.answertxt.TabIndex = 3;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(342, 122);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(90, 33);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(447, 122);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(90, 33);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // SecurityQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmacyManagement.Properties.Resources.contactformbgnd;
            this.ClientSize = new System.Drawing.Size(566, 178);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.answertxt);
            this.Controls.Add(this.questionTxt);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.questionLbl);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecurityQuestion";
            this.Text = "Security Question";
            this.Load += new System.EventHandler(this.SecurityQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.TextBox questionTxt;
        private System.Windows.Forms.TextBox answertxt;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}