namespace graduate
{
    partial class fileSearch
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
            this.textKey = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFileContentSearch = new System.Windows.Forms.Button();
            this.btnFileNameSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F);
            this.label1.Location = new System.Drawing.Point(34, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Keyword";
            // 
            // textKey
            // 
            this.textKey.Font = new System.Drawing.Font("Consolas", 12F);
            this.textKey.Location = new System.Drawing.Point(127, 14);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(192, 31);
            this.textKey.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 79);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(443, 356);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "검색결과";
            // 
            // btnFileContentSearch
            // 
            this.btnFileContentSearch.Location = new System.Drawing.Point(386, 12);
            this.btnFileContentSearch.Name = "btnFileContentSearch";
            this.btnFileContentSearch.Size = new System.Drawing.Size(55, 60);
            this.btnFileContentSearch.TabIndex = 5;
            this.btnFileContentSearch.Text = "파일내용검색";
            this.btnFileContentSearch.UseVisualStyleBackColor = true;
            this.btnFileContentSearch.Click += new System.EventHandler(this.btnFileContentSearchClick);
            // 
            // btnFileNameSearch
            // 
            this.btnFileNameSearch.Location = new System.Drawing.Point(325, 12);
            this.btnFileNameSearch.Name = "btnFileNameSearch";
            this.btnFileNameSearch.Size = new System.Drawing.Size(55, 60);
            this.btnFileNameSearch.TabIndex = 4;
            this.btnFileNameSearch.Text = "파일이름검색";
            this.btnFileNameSearch.UseVisualStyleBackColor = true;
            this.btnFileNameSearch.Click += new System.EventHandler(this.btnFileNameSearchClick);
            // 
            // fileSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 447);
            this.Controls.Add(this.btnFileContentSearch);
            this.Controls.Add(this.btnFileNameSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.label1);
            this.Name = "fileSearch";
            this.Text = "fileSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFileNameSearch;
        private System.Windows.Forms.Button btnFileContentSearch;
    }
}