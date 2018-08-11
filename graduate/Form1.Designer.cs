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
            this.btnClassification = new System.Windows.Forms.Button();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.btnViewSwitch = new System.Windows.Forms.Button();
            this.btnCloudSync = new System.Windows.Forms.Button();
            this.btnFileSearch = new System.Windows.Forms.Button();
            this.btnFileDownload = new System.Windows.Forms.Button();
            this.btnFileUpload = new System.Windows.Forms.Button();
            this.btnCloudConnect = new System.Windows.Forms.Button();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일업로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일다운로ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일검색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.잠금비밀번호설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.파일다운로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일분ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일자동분류ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일수동분류ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일이름변경ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.파일삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.유저ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.테스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfo = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.Label();
            this.userPhoto = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.listViewMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
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
            this.panel1.Controls.Add(this.btnClassification);
            this.panel1.Controls.Add(this.btnViewSwitch);
            this.panel1.Controls.Add(this.btnCloudSync);
            this.panel1.Controls.Add(this.btnFileSearch);
            this.panel1.Controls.Add(this.btnFileDownload);
            this.panel1.Controls.Add(this.btnFileUpload);
            this.panel1.Controls.Add(this.btnCloudConnect);
            this.panel1.Location = new System.Drawing.Point(210, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 73);
            this.panel1.TabIndex = 2;
            // 
            // btnClassification
            // 
            this.btnClassification.BackColor = System.Drawing.SystemColors.Control;
            this.btnClassification.ImageIndex = 8;
            this.btnClassification.ImageList = this.imageList3;
            this.btnClassification.Location = new System.Drawing.Point(424, 3);
            this.btnClassification.Name = "btnClassification";
            this.btnClassification.Size = new System.Drawing.Size(64, 66);
            this.btnClassification.TabIndex = 7;
            this.btnClassification.UseVisualStyleBackColor = false;
            this.btnClassification.Click += new System.EventHandler(this.btnClassificationClick);
            this.btnClassification.MouseHover += new System.EventHandler(this.btnClassificationMousehover);
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "cloud_connect.png");
            this.imageList3.Images.SetKeyName(1, "cloud-sync.png");
            this.imageList3.Images.SetKeyName(2, "cloud-upload.png");
            this.imageList3.Images.SetKeyName(3, "download-from-cloud.png");
            this.imageList3.Images.SetKeyName(4, "folder.png");
            this.imageList3.Images.SetKeyName(5, "list.png");
            this.imageList3.Images.SetKeyName(6, "root-directory.png");
            this.imageList3.Images.SetKeyName(7, "search.png");
            this.imageList3.Images.SetKeyName(8, "classification.png");
            // 
            // btnViewSwitch
            // 
            this.btnViewSwitch.ImageIndex = 5;
            this.btnViewSwitch.ImageList = this.imageList3;
            this.btnViewSwitch.Location = new System.Drawing.Point(354, 3);
            this.btnViewSwitch.Name = "btnViewSwitch";
            this.btnViewSwitch.Size = new System.Drawing.Size(64, 66);
            this.btnViewSwitch.TabIndex = 6;
            this.btnViewSwitch.UseVisualStyleBackColor = true;
            this.btnViewSwitch.Click += new System.EventHandler(this.viewSwitchBtnClick);
            this.btnViewSwitch.MouseHover += new System.EventHandler(this.btnViewSwitchMouseHover);
            // 
            // btnCloudSync
            // 
            this.btnCloudSync.ImageKey = "cloud-sync.png";
            this.btnCloudSync.ImageList = this.imageList3;
            this.btnCloudSync.Location = new System.Drawing.Point(74, 4);
            this.btnCloudSync.Name = "btnCloudSync";
            this.btnCloudSync.Size = new System.Drawing.Size(64, 66);
            this.btnCloudSync.TabIndex = 5;
            this.btnCloudSync.UseVisualStyleBackColor = true;
            this.btnCloudSync.Click += new System.EventHandler(this.cloudSyncBtnClick);
            this.btnCloudSync.MouseHover += new System.EventHandler(this.btnCloudSyncMouseHover);
            // 
            // btnFileSearch
            // 
            this.btnFileSearch.ImageKey = "search.png";
            this.btnFileSearch.ImageList = this.imageList3;
            this.btnFileSearch.Location = new System.Drawing.Point(284, 3);
            this.btnFileSearch.Name = "btnFileSearch";
            this.btnFileSearch.Size = new System.Drawing.Size(64, 66);
            this.btnFileSearch.TabIndex = 3;
            this.btnFileSearch.UseVisualStyleBackColor = true;
            this.btnFileSearch.Click += new System.EventHandler(this.fileSearchBtnClick);
            this.btnFileSearch.MouseHover += new System.EventHandler(this.btnFileSearchMouseHover);
            // 
            // btnFileDownload
            // 
            this.btnFileDownload.ImageKey = "download-from-cloud.png";
            this.btnFileDownload.ImageList = this.imageList3;
            this.btnFileDownload.Location = new System.Drawing.Point(214, 3);
            this.btnFileDownload.Name = "btnFileDownload";
            this.btnFileDownload.Size = new System.Drawing.Size(64, 66);
            this.btnFileDownload.TabIndex = 2;
            this.btnFileDownload.UseVisualStyleBackColor = true;
            this.btnFileDownload.Click += new System.EventHandler(this.fileDownloadBtnClick);
            this.btnFileDownload.MouseHover += new System.EventHandler(this.btnFileDownloadMouseHover);
            // 
            // btnFileUpload
            // 
            this.btnFileUpload.ImageKey = "cloud-upload.png";
            this.btnFileUpload.ImageList = this.imageList3;
            this.btnFileUpload.Location = new System.Drawing.Point(144, 4);
            this.btnFileUpload.Name = "btnFileUpload";
            this.btnFileUpload.Size = new System.Drawing.Size(64, 66);
            this.btnFileUpload.TabIndex = 1;
            this.btnFileUpload.UseVisualStyleBackColor = true;
            this.btnFileUpload.Click += new System.EventHandler(this.fileUploadBtnClick);
            this.btnFileUpload.MouseHover += new System.EventHandler(this.btnFileUploadMouseHover);
            // 
            // btnCloudConnect
            // 
            this.btnCloudConnect.ImageKey = "cloud_connect.png";
            this.btnCloudConnect.ImageList = this.imageList3;
            this.btnCloudConnect.Location = new System.Drawing.Point(4, 4);
            this.btnCloudConnect.Name = "btnCloudConnect";
            this.btnCloudConnect.Size = new System.Drawing.Size(64, 66);
            this.btnCloudConnect.TabIndex = 0;
            this.btnCloudConnect.UseVisualStyleBackColor = true;
            this.btnCloudConnect.Click += new System.EventHandler(this.cloudConnectBtnClick);
            this.btnCloudConnect.MouseHover += new System.EventHandler(this.btnCloudConnectMouseHover);
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
            this.파일업로드ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.파일업로드ToolStripMenuItem.Text = "파일 업로드";
            // 
            // 파일다운로ToolStripMenuItem
            // 
            this.파일다운로ToolStripMenuItem.Name = "파일다운로ToolStripMenuItem";
            this.파일다운로ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.파일다운로ToolStripMenuItem.Text = "파일 다운로드";
            // 
            // 파일열기ToolStripMenuItem
            // 
            this.파일열기ToolStripMenuItem.Name = "파일열기ToolStripMenuItem";
            this.파일열기ToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.파일열기ToolStripMenuItem.Text = "파일 열기";
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일검색ToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.편집ToolStripMenuItem.Text = "편집";
            // 
            // 파일검색ToolStripMenuItem
            // 
            this.파일검색ToolStripMenuItem.Name = "파일검색ToolStripMenuItem";
            this.파일검색ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.파일검색ToolStripMenuItem.Text = "파일검색";
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
            this.버전정보ToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.버전정보ToolStripMenuItem1.Text = "버전 정보";
            this.버전정보ToolStripMenuItem1.Click += new System.EventHandler(this.버전정보ToolStripMenuItem1_Click);
            // 
            // 개발자정보ToolStripMenuItem
            // 
            this.개발자정보ToolStripMenuItem.Name = "개발자정보ToolStripMenuItem";
            this.개발자정보ToolStripMenuItem.Size = new System.Drawing.Size(164, 26);
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
            this.잠금비밀번호설정ToolStripMenuItem});
            this.유저ToolStripMenuItem.Name = "유저ToolStripMenuItem";
            this.유저ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.유저ToolStripMenuItem.Text = "유저";
            // 
            // 잠금비밀번호설정ToolStripMenuItem
            // 
            this.잠금비밀번호설정ToolStripMenuItem.Name = "잠금비밀번호설정ToolStripMenuItem";
            this.잠금비밀번호설정ToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.잠금비밀번호설정ToolStripMenuItem.Text = "잠금 설정/해제";
            this.잠금비밀번호설정ToolStripMenuItem.Click += new System.EventHandler(this.lockSettingClick);
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
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.listViewMenuStrip;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Enabled = false;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            listViewItem1.StateImageIndex = 0;
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
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewMouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 163;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Modified";
            this.columnHeader3.Width = 118;
            // 
            // listViewMenuStrip
            // 
            this.listViewMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.listViewMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일다운로드ToolStripMenuItem,
            this.파일분ToolStripMenuItem,
            this.파일이름변경ToolStripMenuItem,
            this.파일복사ToolStripMenuItem,
            this.파일삭제ToolStripMenuItem});
            this.listViewMenuStrip.Name = "listViewMenuStrip";
            this.listViewMenuStrip.Size = new System.Drawing.Size(179, 124);
            // 
            // 파일다운로드ToolStripMenuItem
            // 
            this.파일다운로드ToolStripMenuItem.Name = "파일다운로드ToolStripMenuItem";
            this.파일다운로드ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.파일다운로드ToolStripMenuItem.Text = "파일 다운로드";
            this.파일다운로드ToolStripMenuItem.Click += new System.EventHandler(this.파일다운로드ToolStripMenuItem_Click);
            // 
            // 파일분ToolStripMenuItem
            // 
            this.파일분ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일자동분류ToolStripMenuItem,
            this.파일수동분류ToolStripMenuItem});
            this.파일분ToolStripMenuItem.Name = "파일분ToolStripMenuItem";
            this.파일분ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.파일분ToolStripMenuItem.Text = "파일 분류";
            this.파일분ToolStripMenuItem.Click += new System.EventHandler(this.파일분류하기ToolStripMenuItem_Click);
            // 
            // 파일자동분류ToolStripMenuItem
            // 
            this.파일자동분류ToolStripMenuItem.Name = "파일자동분류ToolStripMenuItem";
            this.파일자동분류ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.파일자동분류ToolStripMenuItem.Text = "파일 자동 분류";
            // 
            // 파일수동분류ToolStripMenuItem
            // 
            this.파일수동분류ToolStripMenuItem.Name = "파일수동분류ToolStripMenuItem";
            this.파일수동분류ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.파일수동분류ToolStripMenuItem.Text = "파일 수동 분류";
            // 
            // 파일이름변경ToolStripMenuItem
            // 
            this.파일이름변경ToolStripMenuItem.Name = "파일이름변경ToolStripMenuItem";
            this.파일이름변경ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.파일이름변경ToolStripMenuItem.Text = "파일 이름 변경";
            this.파일이름변경ToolStripMenuItem.Click += new System.EventHandler(this.파일이름변경ToolStripMenuItem_Click);
            // 
            // 파일복사ToolStripMenuItem
            // 
            this.파일복사ToolStripMenuItem.Name = "파일복사ToolStripMenuItem";
            this.파일복사ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.파일복사ToolStripMenuItem.Text = "파일 복사";
            this.파일복사ToolStripMenuItem.Click += new System.EventHandler(this.파일복사ToolStripMenuItem_Click);
            // 
            // 파일삭제ToolStripMenuItem
            // 
            this.파일삭제ToolStripMenuItem.Name = "파일삭제ToolStripMenuItem";
            this.파일삭제ToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.파일삭제ToolStripMenuItem.Text = "파일 삭제";
            this.파일삭제ToolStripMenuItem.Click += new System.EventHandler(this.파일삭제ToolStripMenuItem_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "cloud.png");
            this.imageList2.Images.SetKeyName(1, "folder.png");
            this.imageList2.Images.SetKeyName(2, "folderOpened.png");
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
            // 
            // 테스트ToolStripMenuItem
            // 
            this.테스트ToolStripMenuItem.Name = "테스트ToolStripMenuItem";
            this.테스트ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
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
            // userPhoto
            // 
            this.userPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPhoto.Location = new System.Drawing.Point(4, 32);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.Size = new System.Drawing.Size(77, 69);
            this.userPhoto.TabIndex = 4;
            this.userPhoto.TabStop = false;
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
            this.listViewMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem 파일검색ToolStripMenuItem;
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
        private ToolStripMenuItem 유저ToolStripMenuItem1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 테스트ToolStripMenuItem;
        private Button btnViewSwitch;
        private ImageList imageList2;
        private ToolStripMenuItem 버전정보ToolStripMenuItem1;
        private ToolStripMenuItem 개발자정보ToolStripMenuItem;
        private ToolStripMenuItem 잠금비밀번호설정ToolStripMenuItem;
        private Label userInfo;
        private Label userName;
        private ImageList imageList3;
        private ToolTip toolTip1;
        private Button btnClassification;
        private ContextMenuStrip listViewMenuStrip;
        private ToolStripMenuItem 파일다운로드ToolStripMenuItem;
        private ToolStripMenuItem 파일분ToolStripMenuItem;
        private ToolStripMenuItem 파일자동분류ToolStripMenuItem;
        private ToolStripMenuItem 파일수동분류ToolStripMenuItem;
        private ToolStripMenuItem 파일이름변경ToolStripMenuItem;
        private ToolStripMenuItem 파일복사ToolStripMenuItem;
        private ToolStripMenuItem 파일삭제ToolStripMenuItem;

        public object ToolStripMenuItem { get; private set; }
    }
}

