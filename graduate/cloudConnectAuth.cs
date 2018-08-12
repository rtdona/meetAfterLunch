using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using graduate.AppClient;
using graduate.AppClient.GoogleDrive;
using graduate.AppClient.Dropbox;
using graduate.AppClient.MicroSoft;
using System.Diagnostics;

namespace graduate.Resources
{
    public partial class cloudConnectAuth : Form
    {
        private IAppClient client;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        public cloudConnectAuth(string cloud)
        {
            InitializeComponent();

            switch (cloud)
            {
                case "GoogleDrive":
                    client = GoogleServiceClient.Instance;
                    break;
                case "Dropbox":
                    client = DropboxAppClient.Instance;
                    break;
                case "OneDrive":
                    client = MicrosoftGraphClient.Instance;
                    break;
                default:
                    break;

            }
            var process = client.StartAuthCodeUri();
            process.WaitForInputIdle();
            SetForegroundWindow(this.Handle);
        }

        private void btnAuthCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAuthOk_Click(object sender, EventArgs e)
        {
            await this.CodeConnect();
        }

        private async Task CodeConnect()
        {
            try {
                var code = textAuthCode.Text;

                if (String.IsNullOrEmpty(code)) throw new ArgumentException("코드를 입력하세요");

                code.Replace(" ", String.Empty);
                await client.CodeFlowGetAccessTokenAsync(code);
                await client.ConnectAsync();

                // TODO: 성공적인 연결인 경우 연결상태의 변화를 표시해 줘야 합니다.

                this.Close();
            }
            catch (Exception exception) {
                // 예외를 제대로 처리하려면 각 클라우드의 Exception을 mapping시켜야합니다.
                // 일단은 입력코드가 들렸다고 가정하고 처리합니다.
                PresentException(exception);
            }
        }

        private static void PresentException(Exception exception)
        {
            var message = exception.Message;
            MessageBox.Show(string.Format("reported the following error: {0}", message));
        }
    }
}
