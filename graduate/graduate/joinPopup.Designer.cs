namespace graduate
{
    partial class joinPopup
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
            this.joinId = new System.Windows.Forms.Label();
            this.joinPassword = new System.Windows.Forms.Label();
            this.joinName = new System.Windows.Forms.Label();
            this.joinInputId = new System.Windows.Forms.TextBox();
            this.joinInputPassword = new System.Windows.Forms.TextBox();
            this.joinInputName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.joinBtnCheckId = new System.Windows.Forms.Button();
            this.joinBtnCheckName = new System.Windows.Forms.Button();
            this.joinPasswordCheck = new System.Windows.Forms.Label();
            this.joinInputPasswordCheck = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // joinId
            // 
            this.joinId.Font = new System.Drawing.Font("Consolas", 15F);
            this.joinId.Location = new System.Drawing.Point(12, 29);
            this.joinId.Name = "joinId";
            this.joinId.Size = new System.Drawing.Size(100, 33);
            this.joinId.TabIndex = 0;
            this.joinId.Text = "ID :";
            this.joinId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // joinPassword
            // 
            this.joinPassword.Font = new System.Drawing.Font("Consolas", 15F);
            this.joinPassword.Location = new System.Drawing.Point(12, 80);
            this.joinPassword.Name = "joinPassword";
            this.joinPassword.Size = new System.Drawing.Size(100, 33);
            this.joinPassword.TabIndex = 1;
            this.joinPassword.Text = "PW :";
            this.joinPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // joinName
            // 
            this.joinName.Font = new System.Drawing.Font("Consolas", 15F);
            this.joinName.Location = new System.Drawing.Point(12, 215);
            this.joinName.Name = "joinName";
            this.joinName.Size = new System.Drawing.Size(100, 33);
            this.joinName.TabIndex = 2;
            this.joinName.Text = "Name :";
            this.joinName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // joinInputId
            // 
            this.joinInputId.Font = new System.Drawing.Font("Consolas", 15F);
            this.joinInputId.Location = new System.Drawing.Point(129, 28);
            this.joinInputId.Name = "joinInputId";
            this.joinInputId.Size = new System.Drawing.Size(163, 37);
            this.joinInputId.TabIndex = 3;
            // 
            // joinInputPassword
            // 
            this.joinInputPassword.Font = new System.Drawing.Font("Consolas", 15F);
            this.joinInputPassword.Location = new System.Drawing.Point(129, 79);
            this.joinInputPassword.Name = "joinInputPassword";
            this.joinInputPassword.Size = new System.Drawing.Size(163, 37);
            this.joinInputPassword.TabIndex = 4;
            // 
            // joinInputName
            // 
            this.joinInputName.Font = new System.Drawing.Font("Consolas", 15F);
            this.joinInputName.Location = new System.Drawing.Point(129, 214);
            this.joinInputName.Name = "joinInputName";
            this.joinInputName.Size = new System.Drawing.Size(163, 37);
            this.joinInputName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F);
            this.label1.Location = new System.Drawing.Point(129, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "영문, 숫자 조합 8~12자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F);
            this.label2.Location = new System.Drawing.Point(129, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "한글 2~8자";
            // 
            // joinBtnCheckId
            // 
            this.joinBtnCheckId.Font = new System.Drawing.Font("Consolas", 10F);
            this.joinBtnCheckId.Location = new System.Drawing.Point(312, 32);
            this.joinBtnCheckId.Name = "joinBtnCheckId";
            this.joinBtnCheckId.Size = new System.Drawing.Size(51, 33);
            this.joinBtnCheckId.TabIndex = 8;
            this.joinBtnCheckId.Text = "중복";
            this.joinBtnCheckId.UseVisualStyleBackColor = true;
            // 
            // joinBtnCheckName
            // 
            this.joinBtnCheckName.Font = new System.Drawing.Font("Consolas", 10F);
            this.joinBtnCheckName.Location = new System.Drawing.Point(312, 218);
            this.joinBtnCheckName.Name = "joinBtnCheckName";
            this.joinBtnCheckName.Size = new System.Drawing.Size(51, 33);
            this.joinBtnCheckName.TabIndex = 9;
            this.joinBtnCheckName.Text = "중복";
            this.joinBtnCheckName.UseVisualStyleBackColor = true;
            // 
            // joinPasswordCheck
            // 
            this.joinPasswordCheck.Font = new System.Drawing.Font("Consolas", 15F);
            this.joinPasswordCheck.Location = new System.Drawing.Point(12, 151);
            this.joinPasswordCheck.Name = "joinPasswordCheck";
            this.joinPasswordCheck.Size = new System.Drawing.Size(100, 33);
            this.joinPasswordCheck.TabIndex = 10;
            this.joinPasswordCheck.Text = "RePW :";
            this.joinPasswordCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // joinInputPasswordCheck
            // 
            this.joinInputPasswordCheck.Font = new System.Drawing.Font("Consolas", 15F);
            this.joinInputPasswordCheck.Location = new System.Drawing.Point(129, 150);
            this.joinInputPasswordCheck.Name = "joinInputPasswordCheck";
            this.joinInputPasswordCheck.Size = new System.Drawing.Size(163, 37);
            this.joinInputPasswordCheck.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(17, 370);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.joinBtnCancelClick);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnOk.Location = new System.Drawing.Point(288, 370);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.joinBtnOkClick);
            // 
            // joinPopup
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(375, 423);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.joinInputPasswordCheck);
            this.Controls.Add(this.joinPasswordCheck);
            this.Controls.Add(this.joinBtnCheckName);
            this.Controls.Add(this.joinBtnCheckId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.joinInputName);
            this.Controls.Add(this.joinInputPassword);
            this.Controls.Add(this.joinInputId);
            this.Controls.Add(this.joinName);
            this.Controls.Add(this.joinPassword);
            this.Controls.Add(this.joinId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Join";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.joinPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label joinId;
        private System.Windows.Forms.Label joinPassword;
        private System.Windows.Forms.Label joinName;
        private System.Windows.Forms.TextBox joinInputId;
        private System.Windows.Forms.TextBox joinInputPassword;
        private System.Windows.Forms.TextBox joinInputName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button joinBtnCheckId;
        private System.Windows.Forms.Button joinBtnCheckName;
        private System.Windows.Forms.Label joinPasswordCheck;
        private System.Windows.Forms.TextBox joinInputPasswordCheck;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
    }
}