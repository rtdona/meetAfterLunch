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
    public partial class joinPopup : Form
    {
        public joinPopup()
        {
            InitializeComponent();
        }

        public string ID
        {
            get
            {
                return this.joinInputId.Text;
            }
        }

        public string Password
        {
            get
            {
                return this.joinInputPassword.Text;
            }
        }

        public string Name
        {
            get
            {
                return this.joinInputName.Text;
            }
        }

        private void joinPopup_Load(object sender, EventArgs e)
        {

        }

        private void joinBtnOkClick(object sender, EventArgs e) // 작동 실패 ㅠ, joinPopup Close()하면 loginPopup까지 닫혀버립니다
        {
            /*
            회원가입한 정보를 DB에 전달 할 코드를 넣어야.
            */
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
        private void joinBtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
