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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.authID = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCallKey = new System.Windows.Forms.Button();
            this.btnAuthCancel = new System.Windows.Forms.Button();
            this.btnAuthOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 12F);
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // authID
            // 
            this.authID.Font = new System.Drawing.Font("굴림", 15F);
            this.authID.Location = new System.Drawing.Point(146, 23);
            this.authID.Name = "authID";
            this.authID.Size = new System.Drawing.Size(152, 36);
            this.authID.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox1.Location = new System.Drawing.Point(146, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 36);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Consolas", 12F);
            this.label3.Location = new System.Drawing.Point(23, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "인증 Key : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("굴림", 15F);
            this.textBox2.Location = new System.Drawing.Point(146, 168);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 36);
            this.textBox2.TabIndex = 5;
            // 
            // btnCallKey
            // 
            this.btnCallKey.Font = new System.Drawing.Font("굴림", 7F);
            this.btnCallKey.Location = new System.Drawing.Point(243, 112);
            this.btnCallKey.Name = "btnCallKey";
            this.btnCallKey.Size = new System.Drawing.Size(55, 40);
            this.btnCallKey.TabIndex = 6;
            this.btnCallKey.Text = "인증 키 요청";
            this.btnCallKey.UseVisualStyleBackColor = true;
            // 
            // btnAuthCancel
            // 
            this.btnAuthCancel.Location = new System.Drawing.Point(16, 245);
            this.btnAuthCancel.Name = "btnAuthCancel";
            this.btnAuthCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAuthCancel.TabIndex = 7;
            this.btnAuthCancel.Text = "Cancel";
            this.btnAuthCancel.UseVisualStyleBackColor = true;
            this.btnAuthCancel.Click += new System.EventHandler(this.btnAuthCancel_Click);
            // 
            // btnAuthOk
            // 
            this.btnAuthOk.Location = new System.Drawing.Point(229, 245);
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
            this.ClientSize = new System.Drawing.Size(327, 280);
            this.Controls.Add(this.btnAuthOk);
            this.Controls.Add(this.btnAuthCancel);
            this.Controls.Add(this.btnCallKey);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.authID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cloudConnectAuth";
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox authID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCallKey;
        private System.Windows.Forms.Button btnAuthCancel;
        private System.Windows.Forms.Button btnAuthOk;
    }
}