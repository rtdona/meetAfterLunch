namespace graduate
{
    partial class cloudConnect
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cloudConnect));
            this.label1 = new System.Windows.Forms.Label();
            this.imageListCloud = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConnectCancel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "연동할 클라우드 선택";
            // 
            // imageListCloud
            // 
            this.imageListCloud.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListCloud.ImageStream")));
            this.imageListCloud.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListCloud.Images.SetKeyName(0, "drive.png");
            this.imageListCloud.Images.SetKeyName(1, "dropbox.png");
            this.imageListCloud.Images.SetKeyName(2, "one-drive.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "GoogleDrive";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "DropBox";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "OneDrive";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnectCancel
            // 
            this.btnConnectCancel.Location = new System.Drawing.Point(290, 194);
            this.btnConnectCancel.Name = "btnConnectCancel";
            this.btnConnectCancel.Size = new System.Drawing.Size(75, 23);
            this.btnConnectCancel.TabIndex = 6;
            this.btnConnectCancel.Text = "Cancel";
            this.btnConnectCancel.UseVisualStyleBackColor = true;
            this.btnConnectCancel.Click += new System.EventHandler(this.btnConnectCancel_Click);
            // 
            // button1
            // 
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageListCloud;
            this.button1.Location = new System.Drawing.Point(16, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 98);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageIndex = 1;
            this.button2.ImageList = this.imageListCloud;
            this.button2.Location = new System.Drawing.Point(134, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 98);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ImageIndex = 2;
            this.button3.ImageList = this.imageListCloud;
            this.button3.Location = new System.Drawing.Point(255, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 98);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cloudConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 229);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConnectCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cloudConnect";
            this.Text = "클라우드 연결하기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageListCloud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConnectCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}