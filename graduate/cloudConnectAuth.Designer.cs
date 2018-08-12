namespace graduate.Resources
{
    partial class cloudConnectAuth
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
            this.label3 = new System.Windows.Forms.Label();
            this.textAuthCode = new System.Windows.Forms.TextBox();
            this.btnAuthCancel = new System.Windows.Forms.Button();
            this.btnAuthOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.Location = new System.Drawing.Point(3, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "인증 코드";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textAuthCode
            // 
            this.textAuthCode.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textAuthCode.Location = new System.Drawing.Point(118, 20);
            this.textAuthCode.Name = "textAuthCode";
            this.textAuthCode.Size = new System.Drawing.Size(304, 25);
            this.textAuthCode.TabIndex = 5;
            // 
            // btnAuthCancel
            // 
            this.btnAuthCancel.Location = new System.Drawing.Point(12, 69);
            this.btnAuthCancel.Name = "btnAuthCancel";
            this.btnAuthCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAuthCancel.TabIndex = 7;
            this.btnAuthCancel.Text = "Cancel";
            this.btnAuthCancel.UseVisualStyleBackColor = true;
            this.btnAuthCancel.Click += new System.EventHandler(this.btnAuthCancel_Click);
            // 
            // btnAuthOk
            // 
            this.btnAuthOk.Location = new System.Drawing.Point(345, 69);
            this.btnAuthOk.Name = "btnAuthOk";
            this.btnAuthOk.Size = new System.Drawing.Size(86, 23);
            this.btnAuthOk.TabIndex = 8;
            this.btnAuthOk.Text = "인증 확인";
            this.btnAuthOk.UseVisualStyleBackColor = true;
            this.btnAuthOk.Click += new System.EventHandler(this.btnAuthOk_Click);
            // 
            // cloudConnectAuth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 111);
            this.Controls.Add(this.btnAuthOk);
            this.Controls.Add(this.btnAuthCancel);
            this.Controls.Add(this.textAuthCode);
            this.Controls.Add(this.label3);
            this.Name = "cloudConnectAuth";
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAuthCode;
        private System.Windows.Forms.Button btnAuthCancel;
        private System.Windows.Forms.Button btnAuthOk;
    }
}