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
    public partial class loginPopup : Form
    {
        public loginPopup()
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
                return this.textBoxId.Text;
            }
        }

        public string Password
        {
            get
            {
                return this.textBoxPassword.Text;
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

        private void btnJoinClick(object sender, EventArgs e)   // 로그인팝업창 회원가입 클릭
        {
            joinPopup join = new joinPopup();
            DialogResult DialogResult = join.ShowDialog();
            this.Hide();
            if (DialogResult == DialogResult.OK)
            {
                USER user = new USER(join.ID, join.Password, join.Name);
                MessageBox.Show("ID = " + join.ID + "\n" + "PW = " + join.Password + "\n" + "Name = " + join.Name);
                this.Show();
            }
            else
            {
                this.Close(); // 생성자에서 이 메소드를 호출하면 Exception 발생
            }
        }
    }
}
