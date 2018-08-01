using System.Windows.Forms;

namespace graduate
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "test",
            "test"}, 1);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewSwitch = new System.Windows.Forms.Button();
            this.btnCloudSync = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnFileSearch = new System.Windows.Forms.Button();
            this.btnFileDownload = new System.Windows.Forms.Button();
            this.btnFileUpload = new System.Windows.Forms.Button();
            this.btnCloudConnect = new System.Windows.Forms.Button();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일업로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일다운로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일명검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일내용검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.환경설정팝업으로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.클라우드연동ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.클라우드동기화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.클라우드우선순위설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.클아우드용도설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.트리뷰ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.리스트뷰파일탐색기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.버전정보ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.개발자정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.버전정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.제작자ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.유저ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원가입ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원탈퇴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.userName = new System.Windows.Forms.Label();
            this.userInfo = new System.Windows.Forms.Label();
            this.userPhoto = new System.Windows.Forms.PictureBox();
            this.유저ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.테스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 576);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1104, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(84, 20);
            this.toolStripStatusLabel1.Text = "상태표시줄";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnViewSwitch);
            this.panel1.Controls.Add(this.btnCloudSync);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnFileSearch);
            this.panel1.Controls.Add(this.btnFileDownload);
            this.panel1.Controls.Add(this.btnFileUpload);
            this.panel1.Controls.Add(this.btnCloudConnect);
            this.panel1.Location = new System.Drawing.Point(210, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 73);
            this.panel1.TabIndex = 2;
            // 
            // btnViewSwitch
            // 
            this.btnViewSwitch.Location = new System.Drawing.Point(354, 3);
            this.btnViewSwitch.Name = "btnViewSwitch";
            this.btnViewSwitch.Size = new System.Drawing.Size(64, 66);
            this.btnViewSwitch.TabIndex = 6;
            this.btnViewSwitch.Text = "뷰전환";
            this.btnViewSwitch.UseVisualStyleBackColor = true;
            this.btnViewSwitch.Click += new System.EventHandler(this.viewSwitchBtnClick);
            // 
            // btnCloudSync
            // 
            this.btnCloudSync.Location = new System.Drawing.Point(74, 4);
            this.btnCloudSync.Name = "btnCloudSync";
            this.btnCloudSync.Size = new System.Drawing.Size(64, 66);
            this.btnCloudSync.TabIndex = 5;
            this.btnCloudSync.Text = "클라우드 동기화";
            this.btnCloudSync.UseVisualStyleBackColor = true;
            this.btnCloudSync.Click += new System.EventHandler(this.cloudSyncBtnClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(482, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(64, 66);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "로그 아웃";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.logoutBtnClick);
            // 
            // btnFileSearch
            // 
            this.btnFileSearch.Location = new System.Drawing.Point(284, 3);
            this.btnFileSearch.Name = "btnFileSearch";
            this.btnFileSearch.Size = new System.Drawing.Size(64, 66);
            this.btnFileSearch.TabIndex = 3;
            this.btnFileSearch.Text = "파일 검색";
            this.btnFileSearch.UseVisualStyleBackColor = true;
            this.btnFileSearch.Click += new System.EventHandler(this.fileSearchBtnClick);
            // 
            // btnFileDownload
            // 
            this.btnFileDownload.Location = new System.Drawing.Point(214, 3);
            this.btnFileDownload.Name = "btnFileDownload";
            this.btnFileDownload.Size = new System.Drawing.Size(64, 66);
            this.btnFileDownload.TabIndex = 2;
            this.btnFileDownload.Text = "파일 다운로드";
            this.btnFileDownload.UseVisualStyleBackColor = true;
            this.btnFileDownload.Click += new System.EventHandler(this.fileDownloadBtnClick);
            // 
            // btnFileUpload
            // 
            this.btnFileUpload.Location = new System.Drawing.Point(144, 4);
            this.btnFileUpload.Name = "btnFileUpload";
            this.btnFileUpload.Size = new System.Drawing.Size(64, 66);
            this.btnFileUpload.TabIndex = 1;
            this.btnFileUpload.Text = "파일 업로드";
            this.btnFileUpload.UseVisualStyleBackColor = true;
            this.btnFileUpload.Click += new System.EventHandler(this.fileUploadBtnClick);
            // 
            // btnCloudConnect
            // 
            this.btnCloudConnect.Location = new System.Drawing.Point(4, 4);
            this.btnCloudConnect.Name = "btnCloudConnect";
            this.btnCloudConnect.Size = new System.Drawing.Size(64, 66);
            this.btnCloudConnect.TabIndex = 0;
            this.btnCloudConnect.Text = "클라우드연동";
            this.btnCloudConnect.UseVisualStyleBackColor = true;
            this.btnCloudConnect.Click += new System.EventHandler(this.cloudConnectBtnClick);
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일업로드ToolStripMenuItem,
            this.파일다운로ToolStripMenuItem,
            this.파일열기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 파일업로드ToolStripMenuItem
            // 
            this.파일업로드ToolStripMenuItem.Name = "파일업로드ToolStripMenuItem";
            this.파일업로드ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.파일업로드ToolStripMenuItem.Text = "파일 업로드";
            // 
            // 파일다운로ToolStripMenuItem
            // 
            this.파일다운로ToolStripMenuItem.Name = "파일다운로ToolStripMenuItem";
            this.파일다운로ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.파일다운로ToolStripMenuItem.Text = "파일 다운로드";
            // 
            // 파일열기ToolStripMenuItem
            // 
            this.파일열기ToolStripMenuItem.Name = "파일열기ToolStripMenuItem";
            this.파일열기ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.파일열기ToolStripMenuItem.Text = "파일 열기";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일명검색ToolStripMenuItem,
            this.파일내용검색ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 파일명검색ToolStripMenuItem
            // 
            this.파일명검색ToolStripMenuItem.Name = "파일명검색ToolStripMenuItem";
            this.파일명검색ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.파일명검색ToolStripMenuItem.Text = "파일명 검색";
            // 
            // 파일내용검색ToolStripMenuItem
            // 
            this.파일내용검색ToolStripMenuItem.Name = "파일내용검색ToolStripMenuItem";
            this.파일내용검색ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.파일내용검색ToolStripMenuItem.Text = "파일내용 검색";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.환경설정팝업으로ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 환경설정팝업으로ToolStripMenuItem
            // 
            this.환경설정팝업으로ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.클라우드연동ToolStripMenuItem,
            this.클라우드동기화ToolStripMenuItem,
            this.클라우드우선순위설정ToolStripMenuItem,
            this.클아우드용도설정ToolStripMenuItem});
            this.환경설정팝업으로ToolStripMenuItem.Name = "환경설정팝업으로ToolStripMenuItem";
            this.환경설정팝업으로ToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.환경설정팝업으로ToolStripMenuItem.Text = "환경 설정(팝업으로)";
            // 
            // 클라우드연동ToolStripMenuItem
            // 
            this.클라우드연동ToolStripMenuItem.Name = "클라우드연동ToolStripMenuItem";
            this.클라우드연동ToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.클라우드연동ToolStripMenuItem.Text = "클라우드 연동";
            // 
            // 클라우드동기화ToolStripMenuItem
            // 
            this.클라우드동기화ToolStripMenuItem.Name = "클라우드동기화ToolStripMenuItem";
            this.클라우드동기화ToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.클라우드동기화ToolStripMenuItem.Text = "클라우드 동기화";
            // 
            // 클라우드우선순위설정ToolStripMenuItem
            // 
            this.클라우드우선순위설정ToolStripMenuItem.Name = "클라우드우선순위설정ToolStripMenuItem";
            this.클라우드우선순위설정ToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.클라우드우선순위설정ToolStripMenuItem.Text = "클라우드 우선순위 설정";
            // 
            // 클아우드용도설정ToolStripMenuItem
            // 
            this.클아우드용도설정ToolStripMenuItem.Name = "클아우드용도설정ToolStripMenuItem";
            this.클아우드용도설정ToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.클아우드용도설정ToolStripMenuItem.Text = "클아우드 용도 설정";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 트리뷰ToolStripMenuItem
            // 
            this.트리뷰ToolStripMenuItem.Name = "트리뷰ToolStripMenuItem";
            this.트리뷰ToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.트리뷰ToolStripMenuItem.Text = "트리 뷰";
            // 
            // 리스트뷰파일탐색기ToolStripMenuItem
            // 
            this.리스트뷰파일탐색기ToolStripMenuItem.Name = "리스트뷰파일탐색기ToolStripMenuItem";
            this.리스트뷰파일탐색기ToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.리스트뷰파일탐색기ToolStripMenuItem.Text = "리스트 뷰(파일탐색기)";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.버전정보ToolStripMenuItem1,
            this.개발자정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // 버전정보ToolStripMenuItem1
            // 
            this.버전정보ToolStripMenuItem1.Name = "버전정보ToolStripMenuItem1";
            this.버전정보ToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.버전정보ToolStripMenuItem1.Text = "버전 정보";
            // 
            // 개발자정보ToolStripMenuItem
            // 
            this.개발자정보ToolStripMenuItem.Name = "개발자정보ToolStripMenuItem";
            this.개발자정보ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.개발자정보ToolStripMenuItem.Text = "개발자 정보";
            // 
            // 버전정보ToolStripMenuItem
            // 
            this.버전정보ToolStripMenuItem.Name = "버전정보ToolStripMenuItem";
            this.버전정보ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.버전정보ToolStripMenuItem.Text = "버전 정보";
            // 
            // 제작자ToolStripMenuItem
            // 
            this.제작자ToolStripMenuItem.Name = "제작자ToolStripMenuItem";
            this.제작자ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.제작자ToolStripMenuItem.Text = "제작자";
            // 
            // 유저ToolStripMenuItem
            // 
            this.유저ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그인ToolStripMenuItem,
            this.로그아웃ToolStripMenuItem,
            this.회원가입ToolStripMenuItem,
            this.회원정보ToolStripMenuItem,
            this.회원탈퇴ToolStripMenuItem});
            this.유저ToolStripMenuItem.Name = "유저ToolStripMenuItem";
            this.유저ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.유저ToolStripMenuItem.Text = "유저";
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.로그인ToolStripMenuItem.Text = "로그인";
            this.로그인ToolStripMenuItem.Click += new System.EventHandler(this.로그인ToolStripMenuItem_Click);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            this.로그아웃ToolStripMenuItem.Click += new System.EventHandler(this.로그아웃ToolStripMenuItem_Click);
            // 
            // 회원가입ToolStripMenuItem
            // 
            this.회원가입ToolStripMenuItem.Name = "회원가입ToolStripMenuItem";
            this.회원가입ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.회원가입ToolStripMenuItem.Text = "회원가입";
            this.회원가입ToolStripMenuItem.Click += new System.EventHandler(this.회원가입ToolStripMenuItem_Click);
            // 
            // 회원정보ToolStripMenuItem
            // 
            this.회원정보ToolStripMenuItem.Name = "회원정보ToolStripMenuItem";
            this.회원정보ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.회원정보ToolStripMenuItem.Text = "회원정보";
            this.회원정보ToolStripMenuItem.Click += new System.EventHandler(this.회원정보ToolStripMenuItem_Click);
            // 
            // 회원탈퇴ToolStripMenuItem
            // 
            this.회원탈퇴ToolStripMenuItem.Name = "회원탈퇴ToolStripMenuItem";
            this.회원탈퇴ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.회원탈퇴ToolStripMenuItem.Text = "회원탈퇴";
            this.회원탈퇴ToolStripMenuItem.Click += new System.EventHandler(this.회원탈퇴ToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(4, 108);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(1100, 462);
            this.splitContainer1.SplitterDistance = 366;
            this.splitContainer1.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView1.ImageIndex = 1;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 36);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 2;
            this.treeView1.Size = new System.Drawing.Size(366, 426);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.treeAfterExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cloud.png");
            this.imageList1.Images.SetKeyName(1, "folder.png");
            this.imageList1.Images.SetKeyName(2, "folderOpened.png");
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Enabled = false;
            listViewItem1.Tag = "dir";
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.LargeImageList = this.imageList2;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(730, 462);
            this.listView1.SmallImageList = this.imageList1;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 134;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 53;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Modified";
            this.columnHeader3.Width = 118;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "cloud.png");
            this.imageList2.Images.SetKeyName(1, "folder.png");
            this.imageList2.Images.SetKeyName(2, "folderOpened.png");
            // 
            // userName
            // 
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userName.Location = new System.Drawing.Point(85, 33);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(119, 32);
            this.userName.TabIndex = 5;
            this.userName.Text = "userName";
            this.userName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userInfo
            // 
            this.userInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userInfo.Location = new System.Drawing.Point(85, 66);
            this.userInfo.Name = "userInfo";
            this.userInfo.Size = new System.Drawing.Size(119, 36);
            this.userInfo.TabIndex = 6;
            this.userInfo.Text = "userInfo";
            this.userInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPhoto
            // 
            this.userPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPhoto.Location = new System.Drawing.Point(4, 32);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.Size = new System.Drawing.Size(77, 69);
            this.userPhoto.TabIndex = 4;
            this.userPhoto.TabStop = false;
            // 
            // 유저ToolStripMenuItem1
            // 
            this.유저ToolStripMenuItem1.Name = "유저ToolStripMenuItem1";
            this.유저ToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.유저ToolStripMenuItem,
            this.파일ToolStripMenuItem,
            this.설정ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // 테스트ToolStripMenuItem
            // 
            this.테스트ToolStripMenuItem.Name = "테스트ToolStripMenuItem";
            this.테스트ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 598);
            this.Controls.Add(this.userInfo);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.userPhoto);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CLOUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCloudConnect;
        private System.Windows.Forms.Button btnFileSearch;
        private System.Windows.Forms.Button btnFileDownload;
        private System.Windows.Forms.Button btnFileUpload;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일업로드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일다운로ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일명검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 파일내용검색ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 환경설정팝업으로ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 클라우드연동ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 클라우드동기화ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 클라우드우선순위설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 클아우드용도설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 트리뷰ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 리스트뷰파일탐색기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 버전정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 제작자ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 유저ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원가입ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원탈퇴ToolStripMenuItem;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnCloudSync;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private PictureBox userPhoto;
        private Label userName;
        private Label userInfo;
        private ToolStripMenuItem 유저ToolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 테스트ToolStripMenuItem;
        private Button btnViewSwitch;
        private ImageList imageList2;
        private ToolStripMenuItem 버전정보ToolStripMenuItem1;
        private ToolStripMenuItem 개발자정보ToolStripMenuItem;

        public object ToolStripMenuItem { get; private set; }
    }
}

