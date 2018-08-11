using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using graduate.Resources;

namespace graduate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateTreeView();
        }

        private void Form1_Load(object sender, EventArgs e) // 메인폼을 로드할 때, 로그인팝업을 먼저 띄움
        {
            string[] lockPW = File.ReadAllLines(@"..\..\lock.txt");
            // 잠금설정 O 이면, unlockPopup출력
            // 잠금설정 X 이면, unlockPopup출력하지 않음
            if (lockPW[0].Substring(0, 1) == "O")
            {
                string unlock_key;
                while (true)
                {
                    unlockPopup unlock = new unlockPopup();
                    DialogResult DialogResult = unlock.ShowDialog();
                    unlock_key = lockPW[0].Substring(1); // unlock_key는 저장된 비밀번호

                    if (DialogResult == DialogResult.OK)
                    {
                        if (unlock.Password == unlock_key) // 입력된 비밀번호와 저장된 비밀번호가 일치
                        {
                            MessageBox.Show("Password Correct! \n CLOUD is Unlocked! \n");
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Password Uncorrect! \n Please re-enter your password. \n");
                        }
                    }
                    else
                    {
                        this.Close(); // 생성자에서 이 메소드를 호출하면 Exception 발생
                    }
                }
            }
            // fileArray에 fileAdd() 테스트 >> 성공
            USER user1 = new USER("SDH","1234","donghwa");
            userFile file1 = new userFile("testName", "mp3", "googleDrive", "indexA");
            user1.fileAdd(file1);   
           // MessageBox.Show(user1.fileList[0].getFileName() + "\n" + user1.fileList[0].getFileType());
            
        }
   
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 환경설정팝업으로ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        /*--------------------------------------------------------*/
        /*--------------------스트립 메뉴 : 파일--------------------*/

        private void fileUploadBtnClick(object sender, EventArgs e) // 파일업로드  버튼 클릭
        {

        }

        private void fileDownloadBtnClick(object sender, EventArgs e) // 파일다운로드 버튼 클릭
        {

        }

        private void fileSearchBtnClick(object sender, EventArgs e) // 파일검색 버튼 클릭
        {
            fileSearch searching = new fileSearch();
            searching.ShowDialog();
        }

        /*--------------------스트립 메뉴 : 파일--------------------*/
        /*--------------------------------------------------------*/


        /*------------------------------------------------------*/
        /*--------------------단축 버튼 메뉴--------------------*/
        private void viewSwitchBtnClick(object sender, EventArgs e) // 뷰전환 버튼 클릭 시, 뷰 전환 (detail <->LargeIcon)
        {
            if(this.listView1.View == View.Details)
                this.listView1.View = View.LargeIcon;
            else
                this.listView1.View = View.Details;

            if (this.btnViewSwitch.ImageIndex == 4)
                this.btnViewSwitch.ImageIndex = 5;
            else
                this.btnViewSwitch.ImageIndex = 4;
        }

        private void cloudConnectBtnClick(object sender, EventArgs e) // 클라우드 연동 버튼 클릭
        {
            cloudConnect cloud = new cloudConnect();
            cloud.ShowDialog();
        }

        private void cloudSyncBtnClick(object sender, EventArgs e) // 클라우드 동기화 버튼 클릭
        {

        }

        private void btnClassificationClick(object sender, EventArgs e) // 파일분류하기 버튼 클릭
        {

        }

        /*--------------------단축 버튼 메뉴--------------------*/
        /*------------------------------------------------------*/


        /*------------------------------------------------------*/
        /*--------------------스트립 메뉴 : 유저--------------------*/

        private void lockSettingClick(object sender, EventArgs e)
        {
            lockSetting lockSet = new lockSetting();
            lockSet.ShowDialog();  // 비밀번호 세팅 팝업
        }
        

        /*--------------------스트립 메뉴 : 유저--------------------*/
        /*------------------------------------------------------*/


        /*----------------------------------------*/
        /*----------------파일탐색기---------------*/
        // 지금은 window 파일 탐색기로 코드짜여 있는데,
        // 파일탐색기 코드를, USER.FILE의 구조에 따라서 나타내도록 바꿔야해요
           
        private void PopulateTreeView()
        {
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(@"../../root");
            // 현재 코드는 프로젝트 graduate 디렉토리 리스트를 보여줌

            // graduate의 하위폴더인 file_address로 탐색
            // > DirectoryInfo info = new DirectoryInfo(@"../../file_address");

            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 1, 1);
                aNode.Tag = subDir;
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            listView1.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                          {new ListViewItem.ListViewSubItem(item, "Directory"),
                   new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                          { new ListViewItem.ListViewSubItem(item, "File"),
                   new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                listView1.Items.Add(item);
            }

            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }


        private void treeAfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 2;
            e.Node.SelectedImageIndex = 2;
        }

        private void 버전정보ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }


        /*-------------------------------*/
        /*-----------------툴팁-----------*/
        private void btnCloudConnectMouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.btnCloudConnect, "클라우드 연동하기");
        }

        private void btnCloudSyncMouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.btnCloudSync, "클라우드 동기화");
        }

        private void btnFileUploadMouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.btnFileUpload, "파일 업로드");
        }

        private void btnFileDownloadMouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.btnFileDownload, "파일 다운로드");
        }

        private void btnFileSearchMouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.btnFileSearch, "파일 검색");
        }

        private void btnViewSwitchMouseHover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.btnViewSwitch, "뷰 전환");
        }

        private void btnClassificationMousehover(object sender, EventArgs e)
        {
            this.toolTip1.IsBalloon = false;
            this.toolTip1.SetToolTip(this.btnClassification, "전체 파일 분류하기");
        }


        /*-------------------------------------------*/
        /*-------------리스트뷰 우클릭메뉴-------------*/
        private void 파일분류하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 파일다운로드ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 파일이름변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 파일복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 파일삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listViewMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode tn = treeView1.GetNodeAt(e.Location);
                treeView1.SelectedNode = tn;

                this.listViewMenuStrip.Show(new Point(e.X, e.Y));
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*-------------리스트뷰 우클릭메뉴-------------*/
        /*-------------------------------------------*/




        /*---------------툴팁--------------------*/
        /*---------------------------------------*/



    }

}
 