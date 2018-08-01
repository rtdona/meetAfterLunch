namespace graduate
{
    partial class unlockPopup
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPw = new System.Windows.Forms.Label();
            this.unlockGetPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelLogin.Font = new System.Drawing.Font("Consolas", 40F);
            this.labelLogin.Location = new System.Drawing.Point(12, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(365, 64);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Cloud";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPw
            // 
            this.labelPw.Font = new System.Drawing.Font("Consolas", 15F);
            this.labelPw.Location = new System.Drawing.Point(12, 111);
            this.labelPw.Name = "labelPw";
            this.labelPw.Size = new System.Drawing.Size(126, 35);
            this.labelPw.TabIndex = 2;
            this.labelPw.Text = "PW :";
            this.labelPw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // unlockGetPassword
            // 
            this.unlockGetPassword.Font = new System.Drawing.Font("굴림", 15F);
            this.unlockGetPassword.Location = new System.Drawing.Point(156, 113);
            this.unlockGetPassword.Name = "unlockGetPassword";
            this.unlockGetPassword.Size = new System.Drawing.Size(190, 36);
            this.unlockGetPassword.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(26, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(285, 182);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOkClick);
            // 
            // unlockPopup
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(389, 215);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.unlockGetPassword);
            this.Controls.Add(this.labelPw);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "unlockPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.loginPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPw;
        private System.Windows.Forms.TextBox unlockGetPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}