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
    public partial class unlockPopup : Form
    {
        public unlockPopup()
        {
            InitializeComponent();
        }

        private void loginPopup_Load(object sender, EventArgs e)
        {

        }

        public string ID
        {
            get
            {
                return this.unlockGetPassword.Text;
            }
        }

        public string Password
        {
            get
            {
                return this.unlockGetPassword.Text;
            }
        }
        private void btnOkClick(object sender, EventArgs e)
        {
            try
            {
                // DialogResult에 OK 값을 넣는다.(알아서 Form은 종료된다.)
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "[ERROR]", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
            }
        }

        private void btnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    
        
    }
}
