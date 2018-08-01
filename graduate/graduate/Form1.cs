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
            loginPopup login = new loginPopup();
            DialogResult DialogResult = login.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                USER user = new USER(login.ID, login.Password);
                userName.Text = user.getId();
                userInfo.Text = "10 Gb / 100 Gb"; // Cloud 가용 용량 표시
                MessageBox.Show("ID = " + login.ID + "\n" + "PW = " + login.Password);
            }
            else
            {
                this.Close(); // 생성자에서 이 메소드를 호출하면 Exception 발생
            }

            // fileArray에 fileAdd() 테스트 >> 성공
            USER user1 = new USER("SDH","1234","donghwa");
            userFile file1 = new userFile("testName", "mp3", "googleDrive", "indexA");
            user1.fileAdd(file1);   
            MessageBox.Show(user1.fileList[0].getFileName() + "\n" + user1.fileList[0].getFileType());
            
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

        }

        /*--------------------스트립 메뉴 : 파일--------------------*/
        /*--------------------------------------------------------*/

        private void logoutBtnClick(object sender, EventArgs e) // 로그아웃 버튼 클릭
        {

        }
        private void viewSwitchBtnClick(object sender, EventArgs e) // 뷰전환 버튼 클릭 시, 뷰 전환 (detail <->LargeIcon)
        {
            if(this.listView1.View == View.Details)
                this.listView1.View = View.LargeIcon;
            else
                this.listView1.View = View.Details;
        }

        private void cloudConnectBtnClick(object sender, EventArgs e) // 클라우드 연동 버튼 클릭
        {

        }

        private void cloudSyncBtnClick(object sender, EventArgs e) // 클라우드 동기화 버튼 클릭
        {

        }

        /*--------------------단축 버튼 메뉴--------------------*/
        /*------------------------------------------------------*/

        /*------------------------------------------------------*/
        /*--------------------스트립 메뉴 : 유저--------------------*/

        private void 회원가입ToolStripMenuItem_Click(object sender, EventArgs e) // 스트립메뉴 회원가입
        {
            joinPopup join = new joinPopup();
            join.ShowDialog();  // 회원가입 팝업
        }

        private void 회원정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 로그아웃ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 회원탈퇴ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginPopup login = new loginPopup();
            DialogResult DialogResult = login.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                USER user = new USER(login.ID, login.Password);
                userName.Text = user.getId();
                userInfo.Text = "10 Gb / 100 Gb"; // Cloud 가용 용량 표시 예시
                MessageBox.Show("ID = " + login.ID + "\n" + "PW = " + login.Password);
            }
            else
            {
                this.Close(); // 생성자에서 이 메소드를 호출하면 Exception 발생
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        /*--------------------스트립 메뉴 : 유저--------------------*/
        /*------------------------------------------------------*/

        /*----------------------------------------*/
        /*----------------파일탐색기---------------*/
        // 지금은 window 파일 탐색기로 코드짜여 있는데,
        // 파일탐색기 코드를, USER.FILE의 구조에 따라서 나타내도록 바꿔야해요
           
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(@"../../");
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

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void treeAfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 2;
            e.Node.SelectedImageIndex = 2;
        }

        /*---------------파일탐색기---------------*/
        /*---------------------------------------*/


    }
    
}
 