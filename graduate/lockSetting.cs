using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace graduate
{
    public partial class lockSetting : Form
    {
        public lockSetting()
        {
            InitializeComponent();
        }

        public string Password
        {
            get
            {
                return this.lockGetPassword.Text;
            }
        }
        public String getPassword()
        {
            return this.Password;
        }

        private void lockBtnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void btnLockClick(object sender, EventArgs e)
        {
            using (StreamWriter passwordWrite = new StreamWriter(@"..\..\lock.txt"))
            {
                // graduate 폴더에 비밀번호를 저장할 lock.txt 파일 생성
                passwordWrite.WriteLine('O' + this.Password);   // 잠금설정일 경우 lock.txt파일 맨 앞에 O, 아닐 경우 X
                MessageBox.Show("Cloud is Locked!\n");
            }

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

        private void btnUnlockClick(object sender, EventArgs e)
        {
            string[] lockPW = File.ReadAllLines(@"..\..\lock.txt");
            // 저장된 비밀번호와 입력된 비밀번호가 일치하고,
            // unlock버튼을 클릭하였을 때, 잠금이 해제된다.
            using (StreamWriter passwordWrite = new StreamWriter(@"..\..\lock.txt"))
            {
                passwordWrite.WriteLine("X");   // 잠금설정일 경우 lock.txt파일 맨 앞에 O, 아닐 경우 X
            }
            MessageBox.Show("Cloud is Unlocked!\n");
        }
    }
}
