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
            cloudConnectAuth auth = new cloudConnectAuth();
            auth.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cloudConnectAuth auth = new cloudConnectAuth();
            auth.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cloudConnectAuth auth = new cloudConnectAuth();
            auth.ShowDialog();
        }
    }
}
