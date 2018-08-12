using graduate.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graduate
{
    public partial class cloudConnect : Form
    {
        public cloudConnect()
        {
            InitializeComponent();
        }

        private void btnConnectCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cloudConnectAuth auth = new cloudConnectAuth("GoogleDrive");
            auth.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cloudConnectAuth auth = new cloudConnectAuth("Dropbox");
            auth.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cloudConnectAuth auth = new cloudConnectAuth("OneDrive");
            auth.ShowDialog();
        }

        private void setGoogleDriveOn(object sender, EventArgs e)
        {
            this.googledriveStatus.Text = "연동 중..";
        }
        private void setGoogleDriveOff(object sender, EventArgs e)
        {
            this.googledriveStatus.Text = "연동 안됨";
        }

        private void setDropBoxOn(object sender, EventArgs e)
        {
            this.dropboxStatus.Text = "연동 중..";
        }
        private void setDropBoxOff(object sender, EventArgs e)
        {
            this.dropboxStatus.Text = "연동 안됨";
        }

        private void setOnedriveOn(object sender, EventArgs e)
        {
            this.onedriveStatus.Text = "연동 중..";
        }
        private void setOnedriveOff(object sender, EventArgs e)
        {
            this.onedriveStatus.Text = "연동 안됨";
        }

        // 연동 되었을 때, 용량 표시
        //
        //
        //
    }
}
