namespace PharmacyManagement
{
    partial class ChangePasswordInterface
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
            this.userNameLbl = new System.Windows.Forms.Label();
            this.currentPasswordLbl = new System.Windows.Forms.Label();
            this.newPasswordLbl = new System.Windows.Forms.Label();
            this.confirmNewPasswordLbl = new System.Windows.Forms.Label();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.currentPasswordTxt = new System.Windows.Forms.TextBox();
            this.newPasswordTxt = new System.Windows.Forms.TextBox();
            this.confirmNewPasswordTxt = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passNotMatchErLbl = new System.Windows.Forms.Label();
            this.questionCheckBox = new System.Windows.Forms.CheckBox();
            this.questionLbl = new System.Windows.Forms.Label();
            this.answerLbl = new System.Windows.Forms.Label();
            this.questionTxt = new System.Windows.Forms.TextBox();
            this.anserTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.Location = new System.Drawing.Point(23, 66);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userNameLbl.Size = new System.Drawing.Size(67, 15);
            this.userNameLbl.TabIndex = 0;
            this.userNameLbl.Text = "User Name";
            this.userNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentPasswordLbl
            // 
            this.currentPasswordLbl.AutoSize = true;
            this.currentPasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.currentPasswordLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordLbl.Location = new System.Drawing.Point(23, 110);
            this.currentPasswordLbl.Name = "currentPasswordLbl";
            this.currentPasswordLbl.Size = new System.Drawing.Size(105, 15);
            this.currentPasswordLbl.TabIndex = 1;
            this.currentPasswordLbl.Text = "Current Password";
            this.currentPasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // newPasswordLbl
            // 
            this.newPasswordLbl.AutoSize = true;
            this.newPasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.newPasswordLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLbl.Location = new System.Drawing.Point(23, 149);
            this.newPasswordLbl.Name = "newPasswordLbl";
            this.newPasswordLbl.Size = new System.Drawing.Size(89, 15);
            this.newPasswordLbl.TabIndex = 2;
            this.newPasswordLbl.Text = "New Password";
            this.newPasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // confirmNewPasswordLbl
            // 
            this.confirmNewPasswordLbl.AutoSize = true;
            this.confirmNewPasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmNewPasswordLbl.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPasswordLbl.Location = new System.Drawing.Point(23, 188);
            this.confirmNewPasswordLbl.Name = "confirmNewPasswordLbl";
            this.confirmNewPasswordLbl.Size = new System.Drawing.Size(137, 15);
            this.confirmNewPasswordLbl.TabIndex = 3;
            this.confirmNewPasswordLbl.Text = "Confirm New Password";
            this.confirmNewPasswordLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.Location = new System.Drawing.Point(173, 66);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(261, 22);
            this.userNameTxt.TabIndex = 0;
            this.userNameTxt.TabStop = false;
            // 
            // currentPasswordTxt
            // 
            this.currentPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordTxt.Location = new System.Drawing.Point(173, 106);
            this.currentPasswordTxt.Name = "currentPasswordTxt";
            this.currentPasswordTxt.Size = new System.Drawing.Size(261, 22);
            this.currentPasswordTxt.TabIndex = 1;
            this.currentPasswordTxt.UseSystemPasswordChar = true;
            this.currentPasswordTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.currentPasswordTxt_KeyDown);
            // 
            // newPasswordTxt
            // 
            this.newPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTxt.Location = new System.Drawing.Point(173, 145);
            this.newPasswordTxt.Name = "newPasswordTxt";
            this.newPasswordTxt.Size = new System.Drawing.Size(261, 22);
            this.newPasswordTxt.TabIndex = 2;
            this.newPasswordTxt.UseSystemPasswordChar = true;
            this.newPasswordTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.newPasswordTxt_KeyDown);
            // 
            // confirmNewPasswordTxt
            // 
            this.confirmNewPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmNewPasswordTxt.Location = new System.Drawing.Point(173, 184);
            this.confirmNewPasswordTxt.Name = "confirmNewPasswordTxt";
            this.confirmNewPasswordTxt.Size = new System.Drawing.Size(261, 22);
            this.confirmNewPasswordTxt.TabIndex = 3;
            this.confirmNewPasswordTxt.UseSystemPasswordChar = true;
            this.confirmNewPasswordTxt.TextChanged += new System.EventHandler(this.confirmNewPasswordTxt_TextChanged);
            this.confirmNewPasswordTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.confirmNewPasswordTxt_KeyDown);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Image = global::PharmacyManagement.Properties.Resources.ic_save_black_24dp_1x;
            this.saveBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveBtn.Location = new System.Drawing.Point(258, 317);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(86, 32);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "    Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Image = global::PharmacyManagement.Properties.Resources.ic_cancel_black_24dp_1x;
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(348, 317);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(86, 32);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "    Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Change Password";
            // 
            // passNotMatchErLbl
            // 
            this.passNotMatchErLbl.AutoSize = true;
            this.passNotMatchErLbl.BackColor = System.Drawing.Color.Transparent;
            this.passNotMatchErLbl.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passNotMatchErLbl.ForeColor = System.Drawing.Color.Red;
            this.passNotMatchErLbl.Location = new System.Drawing.Point(176, 210);
            this.passNotMatchErLbl.Name = "passNotMatchErLbl";
            this.passNotMatchErLbl.Size = new System.Drawing.Size(276, 12);
            this.passNotMatchErLbl.TabIndex = 11;
            this.passNotMatchErLbl.Text = "*Confirmed password does not match with new password";
            this.passNotMatchErLbl.Visible = false;
            // 
            // questionCheckBox
            // 
            this.questionCheckBox.AutoSize = true;
            this.questionCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.questionCheckBox.Location = new System.Drawing.Point(26, 235);
            this.questionCheckBox.Name = "questionCheckBox";
            this.questionCheckBox.Size = new System.Drawing.Size(147, 17);
            this.questionCheckBox.TabIndex = 12;
            this.questionCheckBox.Text = "Answer Security Question";
            this.questionCheckBox.UseVisualStyleBackColor = false;
            this.questionCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Location = new System.Drawing.Point(23, 263);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(49, 13);
            this.questionLbl.TabIndex = 13;
            this.questionLbl.Text = "Question";
            this.questionLbl.Visible = false;
            // 
            // answerLbl
            // 
            this.answerLbl.AutoSize = true;
            this.answerLbl.Location = new System.Drawing.Point(23, 293);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(42, 13);
            this.answerLbl.TabIndex = 14;
            this.answerLbl.Text = "Answer";
            this.answerLbl.Visible = false;
            // 
            // questionTxt
            // 
            this.questionTxt.Location = new System.Drawing.Point(115, 260);
            this.questionTxt.MaxLength = 70;
            this.questionTxt.Name = "questionTxt";
            this.questionTxt.Size = new System.Drawing.Size(242, 20);
            this.questionTxt.TabIndex = 15;
            this.questionTxt.Visible = false;
            // 
            // anserTxt
            // 
            this.anserTxt.Location = new System.Drawing.Point(115, 290);
            this.anserTxt.MaxLength = 20;
            this.anserTxt.Name = "anserTxt";
            this.anserTxt.Size = new System.Drawing.Size(242, 20);
            this.anserTxt.TabIndex = 16;
            this.anserTxt.Visible = false;
            // 
            // ChangePasswordInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PharmacyManagement.Properties.Resources.contactformbgnd;
            this.ClientSize = new System.Drawing.Size(466, 377);
            this.Controls.Add(this.anserTxt);
            this.Controls.Add(this.questionTxt);
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.questionCheckBox);
            this.Controls.Add(this.passNotMatchErLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.confirmNewPasswordTxt);
            this.Controls.Add(this.newPasswordTxt);
            this.Controls.Add(this.currentPasswordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.confirmNewPasswordLbl);
            this.Controls.Add(this.newPasswordLbl);
            this.Controls.Add(this.currentPasswordLbl);
            this.Controls.Add(this.userNameLbl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordInterface";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Randima Pharmacy | Wadduwa";
            this.Load += new System.EventHandler(this.ChangePasswordInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label currentPasswordLbl;
        private System.Windows.Forms.Label newPasswordLbl;
        private System.Windows.Forms.Label confirmNewPasswordLbl;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox currentPasswordTxt;
        private System.Windows.Forms.TextBox newPasswordTxt;
        private System.Windows.Forms.TextBox confirmNewPasswordTxt;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label passNotMatchErLbl;
        private System.Windows.Forms.CheckBox questionCheckBox;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.Label answerLbl;
        private System.Windows.Forms.TextBox questionTxt;
        private System.Windows.Forms.TextBox anserTxt;
    }
}