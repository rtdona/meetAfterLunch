using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graduate.Resources
{
    public partial class cloudConnectAuth : Form
    {
        public cloudConnectAuth()
        {
            InitializeComponent();
        }

        private void btnAuthCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAuthOk_Click(object sender, EventArgs e)
        {
            // 인증확인 화면
        }
    }
}
