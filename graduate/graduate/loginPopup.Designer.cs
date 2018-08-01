namespace graduate
{
    partial class loginPopup
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
            this.labelId = new System.Windows.Forms.Label();
            this.labelPw = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
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
            // labelId
            // 
            this.labelId.Font = new System.Drawing.Font("Consolas", 15F);
            this.labelId.Location = new System.Drawing.Point(12, 112);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(126, 35);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID :";
            this.labelId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPw
            // 
            this.labelPw.Font = new System.Drawing.Font("Consolas", 15F);
            this.labelPw.Location = new System.Drawing.Point(12, 171);
            this.labelPw.Name = "labelPw";
            this.labelPw.Size = new System.Drawing.Size(126, 35);
            this.labelPw.TabIndex = 2;
            this.labelPw.Text = "PW :";
            this.labelPw.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxId.Location = new System.Drawing.Point(156, 112);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(190, 36);
            this.textBoxId.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("굴림", 15F);
            this.textBoxPassword.Location = new System.Drawing.Point(156, 170);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(190, 36);
            this.textBoxPassword.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(26, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancelClick);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(284, 234);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOkClick);
            // 
            // btnJoin
            // 
            this.btnJoin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnJoin.Location = new System.Drawing.Point(156, 234);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 7;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoinClick);
            // 
            // loginPopup
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(389, 269);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelPw);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginPopup";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.loginPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelPw;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnJoin;
    }
}