namespace graduate
{
    partial class lockSetting
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
            this.lockPassword = new System.Windows.Forms.Label();
            this.lockGetPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lockPassword
            // 
            this.lockPassword.Font = new System.Drawing.Font("Consolas", 15F);
            this.lockPassword.Location = new System.Drawing.Point(1, 19);
            this.lockPassword.Name = "lockPassword";
            this.lockPassword.Size = new System.Drawing.Size(156, 33);
            this.lockPassword.TabIndex = 1;
            this.lockPassword.Text = "Lock PW :";
            this.lockPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lockPassword.UseCompatibleTextRendering = true;
            // 
            // lockGetPassword
            // 
            this.lockGetPassword.Font = new System.Drawing.Font("Consolas", 15F);
            this.lockGetPassword.Location = new System.Drawing.Point(192, 19);
            this.lockGetPassword.Name = "lockGetPassword";
            this.lockGetPassword.Size = new System.Drawing.Size(163, 37);
            this.lockGetPassword.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F);
            this.label1.Location = new System.Drawing.Point(189, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "영문, 숫자 조합 8~12자";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(30, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.lockBtnCancelClick);
            // 
            // btnLock
            // 
            this.btnLock.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLock.Location = new System.Drawing.Point(280, 89);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(75, 23);
            this.btnLock.TabIndex = 13;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLockClick);
            // 
            // btnUnlock
            // 
            this.btnUnlock.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUnlock.Location = new System.Drawing.Point(156, 89);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(75, 23);
            this.btnUnlock.TabIndex = 14;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlockClick);
            // 
            // lockSetting
            // 
            this.AcceptButton = this.btnLock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(375, 124);
            this.Controls.Add(this.btnUnlock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lockGetPassword);
            this.Controls.Add(this.lockPassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lockSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LockSetting";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lockPassword;
        private System.Windows.Forms.TextBox lockGetPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnUnlock;
    }
}