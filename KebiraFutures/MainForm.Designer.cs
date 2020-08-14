namespace KebiraFutures
{
    partial class MainForm
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.서버선택ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서버선택ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.모의투자서버ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실계좌서버ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.로그인ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계좌ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.계좌리스트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.거래내역조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.잔고조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.증거금조회ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.주문ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_매도주문 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_매수주문 = new System.Windows.Forms.ToolStripMenuItem();
            this.mun_정정주문 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_취소주문 = new System.Windows.Forms.ToolStripMenuItem();
            this.시세ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.현재가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.옵션전광판ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBeginTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEndTime = new System.Windows.Forms.TextBox();
            this.textBoxLongEstimateConclusionRangeEnd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLongEstimateConclusionRangeBegin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxShortEstimateConclusionRangeEnd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxShortEstimateConclusionRangeBegin = new System.Windows.Forms.TextBox();
            this.textBoxShortQtySumDiffEnd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxShortQtySumDiffBegin = new System.Windows.Forms.TextBox();
            this.textBoxLongQtySumDiffEnd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLongQtySumDiffBegin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxShortTickRangeEnd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxShortTickRangeBegin = new System.Windows.Forms.TextBox();
            this.textBoxLongTickRangeEnd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxLongTickRangeBegin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.listBoxSysMsg = new System.Windows.Forms.ListBox();
            this.gridSetup = new System.Windows.Forms.DataGridView();
            this.시초가시작 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.시초가끝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전일고가시작 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전일고가끝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전일저가시작 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전일저가끝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전일종가시작 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.전일종가끝 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSetup)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 564);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(562, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.서버선택ToolStripMenuItem,
            this.계좌ToolStripMenuItem,
            this.주문ToolStripMenuItem,
            this.시세ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 서버선택ToolStripMenuItem
            // 
            this.서버선택ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.서버선택ToolStripMenuItem1,
            this.로그인ToolStripMenuItem,
            this.종료ToolStripMenuItem});
            this.서버선택ToolStripMenuItem.Name = "서버선택ToolStripMenuItem";
            this.서버선택ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.서버선택ToolStripMenuItem.Text = "로그인";
            // 
            // 서버선택ToolStripMenuItem1
            // 
            this.서버선택ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.모의투자서버ToolStripMenuItem,
            this.실계좌서버ToolStripMenuItem});
            this.서버선택ToolStripMenuItem1.Name = "서버선택ToolStripMenuItem1";
            this.서버선택ToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.서버선택ToolStripMenuItem1.Text = "서버선택";
            // 
            // 모의투자서버ToolStripMenuItem
            // 
            this.모의투자서버ToolStripMenuItem.Name = "모의투자서버ToolStripMenuItem";
            this.모의투자서버ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.모의투자서버ToolStripMenuItem.Text = "모의투자서버";
            this.모의투자서버ToolStripMenuItem.Click += new System.EventHandler(this.모의투자서버ToolStripMenuItem_Click);
            // 
            // 실계좌서버ToolStripMenuItem
            // 
            this.실계좌서버ToolStripMenuItem.Name = "실계좌서버ToolStripMenuItem";
            this.실계좌서버ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.실계좌서버ToolStripMenuItem.Text = "실계좌서버";
            this.실계좌서버ToolStripMenuItem.Click += new System.EventHandler(this.실계좌서버ToolStripMenuItem_Click);
            // 
            // 로그인ToolStripMenuItem
            // 
            this.로그인ToolStripMenuItem.Enabled = false;
            this.로그인ToolStripMenuItem.Name = "로그인ToolStripMenuItem";
            this.로그인ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.로그인ToolStripMenuItem.Text = "로그인";
            this.로그인ToolStripMenuItem.Click += new System.EventHandler(this.로그인ToolStripMenuItem_Click);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // 계좌ToolStripMenuItem
            // 
            this.계좌ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.계좌리스트ToolStripMenuItem,
            this.거래내역조회ToolStripMenuItem,
            this.잔고조회ToolStripMenuItem,
            this.증거금조회ToolStripMenuItem});
            this.계좌ToolStripMenuItem.Name = "계좌ToolStripMenuItem";
            this.계좌ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.계좌ToolStripMenuItem.Text = "계좌";
            // 
            // 계좌리스트ToolStripMenuItem
            // 
            this.계좌리스트ToolStripMenuItem.Enabled = false;
            this.계좌리스트ToolStripMenuItem.Name = "계좌리스트ToolStripMenuItem";
            this.계좌리스트ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.계좌리스트ToolStripMenuItem.Text = "계좌리스트";
            this.계좌리스트ToolStripMenuItem.Click += new System.EventHandler(this.계좌리스트ToolStripMenuItem_Click);
            // 
            // 거래내역조회ToolStripMenuItem
            // 
            this.거래내역조회ToolStripMenuItem.Enabled = false;
            this.거래내역조회ToolStripMenuItem.Name = "거래내역조회ToolStripMenuItem";
            this.거래내역조회ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.거래내역조회ToolStripMenuItem.Text = "거래내역조회";
            this.거래내역조회ToolStripMenuItem.Click += new System.EventHandler(this.거래내역조회ToolStripMenuItem_Click);
            // 
            // 잔고조회ToolStripMenuItem
            // 
            this.잔고조회ToolStripMenuItem.Enabled = false;
            this.잔고조회ToolStripMenuItem.Name = "잔고조회ToolStripMenuItem";
            this.잔고조회ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.잔고조회ToolStripMenuItem.Text = "잔고조회";
            this.잔고조회ToolStripMenuItem.Click += new System.EventHandler(this.잔고조회ToolStripMenuItem_Click);
            // 
            // 증거금조회ToolStripMenuItem
            // 
            this.증거금조회ToolStripMenuItem.Enabled = false;
            this.증거금조회ToolStripMenuItem.Name = "증거금조회ToolStripMenuItem";
            this.증거금조회ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.증거금조회ToolStripMenuItem.Text = "증거금조회";
            this.증거금조회ToolStripMenuItem.Click += new System.EventHandler(this.증거금조회ToolStripMenuItem_Click);
            // 
            // 주문ToolStripMenuItem
            // 
            this.주문ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_매도주문,
            this.mnu_매수주문,
            this.mun_정정주문,
            this.mnu_취소주문});
            this.주문ToolStripMenuItem.Enabled = false;
            this.주문ToolStripMenuItem.Name = "주문ToolStripMenuItem";
            this.주문ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.주문ToolStripMenuItem.Text = "주문";
            // 
            // mnu_매도주문
            // 
            this.mnu_매도주문.Name = "mnu_매도주문";
            this.mnu_매도주문.Size = new System.Drawing.Size(122, 22);
            this.mnu_매도주문.Text = "매도주문";
            this.mnu_매도주문.Click += new System.EventHandler(this.mnu_매도주문_Click);
            // 
            // mnu_매수주문
            // 
            this.mnu_매수주문.Name = "mnu_매수주문";
            this.mnu_매수주문.Size = new System.Drawing.Size(122, 22);
            this.mnu_매수주문.Text = "매수주문";
            this.mnu_매수주문.Click += new System.EventHandler(this.mnu_매도주문_Click);
            // 
            // mun_정정주문
            // 
            this.mun_정정주문.Name = "mun_정정주문";
            this.mun_정정주문.Size = new System.Drawing.Size(122, 22);
            this.mun_정정주문.Text = "정정주문";
            this.mun_정정주문.Click += new System.EventHandler(this.mnu_매도주문_Click);
            // 
            // mnu_취소주문
            // 
            this.mnu_취소주문.Name = "mnu_취소주문";
            this.mnu_취소주문.Size = new System.Drawing.Size(122, 22);
            this.mnu_취소주문.Text = "취소주문";
            this.mnu_취소주문.Click += new System.EventHandler(this.mnu_매도주문_Click);
            // 
            // 시세ToolStripMenuItem
            // 
            this.시세ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.현재가ToolStripMenuItem,
            this.옵션전광판ToolStripMenuItem});
            this.시세ToolStripMenuItem.Enabled = false;
            this.시세ToolStripMenuItem.Name = "시세ToolStripMenuItem";
            this.시세ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.시세ToolStripMenuItem.Text = "시세";
            // 
            // 현재가ToolStripMenuItem
            // 
            this.현재가ToolStripMenuItem.Name = "현재가ToolStripMenuItem";
            this.현재가ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.현재가ToolStripMenuItem.Text = "현재가";
            this.현재가ToolStripMenuItem.Click += new System.EventHandler(this.현재가ToolStripMenuItem_Click);
            // 
            // 옵션전광판ToolStripMenuItem
            // 
            this.옵션전광판ToolStripMenuItem.Name = "옵션전광판ToolStripMenuItem";
            this.옵션전광판ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.옵션전광판ToolStripMenuItem.Text = "옵션전광판";
            this.옵션전광판ToolStripMenuItem.Click += new System.EventHandler(this.옵션전광판ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "시간설정";
            // 
            // textBoxBeginTime
            // 
            this.textBoxBeginTime.Location = new System.Drawing.Point(216, 39);
            this.textBoxBeginTime.Name = "textBoxBeginTime";
            this.textBoxBeginTime.Size = new System.Drawing.Size(55, 21);
            this.textBoxBeginTime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "~";
            // 
            // textBoxEndTime
            // 
            this.textBoxEndTime.Location = new System.Drawing.Point(307, 39);
            this.textBoxEndTime.Name = "textBoxEndTime";
            this.textBoxEndTime.Size = new System.Drawing.Size(57, 21);
            this.textBoxEndTime.TabIndex = 5;
            // 
            // textBoxLongEstimateConclusionRangeEnd
            // 
            this.textBoxLongEstimateConclusionRangeEnd.Location = new System.Drawing.Point(490, 453);
            this.textBoxLongEstimateConclusionRangeEnd.Name = "textBoxLongEstimateConclusionRangeEnd";
            this.textBoxLongEstimateConclusionRangeEnd.Size = new System.Drawing.Size(57, 21);
            this.textBoxLongEstimateConclusionRangeEnd.TabIndex = 9;
            this.textBoxLongEstimateConclusionRangeEnd.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(460, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "~";
            this.label3.Visible = false;
            // 
            // textBoxLongEstimateConclusionRangeBegin
            // 
            this.textBoxLongEstimateConclusionRangeBegin.Location = new System.Drawing.Point(399, 453);
            this.textBoxLongEstimateConclusionRangeBegin.Name = "textBoxLongEstimateConclusionRangeBegin";
            this.textBoxLongEstimateConclusionRangeBegin.Size = new System.Drawing.Size(55, 21);
            this.textBoxLongEstimateConclusionRangeBegin.TabIndex = 7;
            this.textBoxLongEstimateConclusionRangeBegin.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "예상체결점위";
            this.label4.Visible = false;
            // 
            // textBoxShortEstimateConclusionRangeEnd
            // 
            this.textBoxShortEstimateConclusionRangeEnd.Location = new System.Drawing.Point(490, 480);
            this.textBoxShortEstimateConclusionRangeEnd.Name = "textBoxShortEstimateConclusionRangeEnd";
            this.textBoxShortEstimateConclusionRangeEnd.Size = new System.Drawing.Size(57, 21);
            this.textBoxShortEstimateConclusionRangeEnd.TabIndex = 12;
            this.textBoxShortEstimateConclusionRangeEnd.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 483);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "~";
            this.label5.Visible = false;
            // 
            // textBoxShortEstimateConclusionRangeBegin
            // 
            this.textBoxShortEstimateConclusionRangeBegin.Location = new System.Drawing.Point(399, 480);
            this.textBoxShortEstimateConclusionRangeBegin.Name = "textBoxShortEstimateConclusionRangeBegin";
            this.textBoxShortEstimateConclusionRangeBegin.Size = new System.Drawing.Size(55, 21);
            this.textBoxShortEstimateConclusionRangeBegin.TabIndex = 10;
            this.textBoxShortEstimateConclusionRangeBegin.Visible = false;
            // 
            // textBoxShortQtySumDiffEnd
            // 
            this.textBoxShortQtySumDiffEnd.Location = new System.Drawing.Point(288, 353);
            this.textBoxShortQtySumDiffEnd.Name = "textBoxShortQtySumDiffEnd";
            this.textBoxShortQtySumDiffEnd.Size = new System.Drawing.Size(57, 21);
            this.textBoxShortQtySumDiffEnd.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "~";
            // 
            // textBoxShortQtySumDiffBegin
            // 
            this.textBoxShortQtySumDiffBegin.Location = new System.Drawing.Point(197, 353);
            this.textBoxShortQtySumDiffBegin.Name = "textBoxShortQtySumDiffBegin";
            this.textBoxShortQtySumDiffBegin.Size = new System.Drawing.Size(55, 21);
            this.textBoxShortQtySumDiffBegin.TabIndex = 17;
            // 
            // textBoxLongQtySumDiffEnd
            // 
            this.textBoxLongQtySumDiffEnd.Location = new System.Drawing.Point(288, 326);
            this.textBoxLongQtySumDiffEnd.Name = "textBoxLongQtySumDiffEnd";
            this.textBoxLongQtySumDiffEnd.Size = new System.Drawing.Size(57, 21);
            this.textBoxLongQtySumDiffEnd.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "~";
            // 
            // textBoxLongQtySumDiffBegin
            // 
            this.textBoxLongQtySumDiffBegin.Location = new System.Drawing.Point(197, 326);
            this.textBoxLongQtySumDiffBegin.Name = "textBoxLongQtySumDiffBegin";
            this.textBoxLongQtySumDiffBegin.Size = new System.Drawing.Size(55, 21);
            this.textBoxLongQtySumDiffBegin.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "선물총잔량설정범위";
            // 
            // textBoxShortTickRangeEnd
            // 
            this.textBoxShortTickRangeEnd.Location = new System.Drawing.Point(288, 421);
            this.textBoxShortTickRangeEnd.Name = "textBoxShortTickRangeEnd";
            this.textBoxShortTickRangeEnd.Size = new System.Drawing.Size(57, 21);
            this.textBoxShortTickRangeEnd.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(258, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 12);
            this.label9.TabIndex = 25;
            this.label9.Text = "~";
            // 
            // textBoxShortTickRangeBegin
            // 
            this.textBoxShortTickRangeBegin.Location = new System.Drawing.Point(197, 421);
            this.textBoxShortTickRangeBegin.Name = "textBoxShortTickRangeBegin";
            this.textBoxShortTickRangeBegin.Size = new System.Drawing.Size(55, 21);
            this.textBoxShortTickRangeBegin.TabIndex = 24;
            // 
            // textBoxLongTickRangeEnd
            // 
            this.textBoxLongTickRangeEnd.Location = new System.Drawing.Point(288, 394);
            this.textBoxLongTickRangeEnd.Name = "textBoxLongTickRangeEnd";
            this.textBoxLongTickRangeEnd.Size = new System.Drawing.Size(57, 21);
            this.textBoxLongTickRangeEnd.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(258, 397);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 12);
            this.label10.TabIndex = 22;
            this.label10.Text = "~";
            // 
            // textBoxLongTickRangeBegin
            // 
            this.textBoxLongTickRangeBegin.Location = new System.Drawing.Point(197, 394);
            this.textBoxLongTickRangeBegin.Name = "textBoxLongTickRangeBegin";
            this.textBoxLongTickRangeBegin.Size = new System.Drawing.Size(55, 21);
            this.textBoxLongTickRangeBegin.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "진입틱수설정범위";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(364, 459);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 37;
            this.label16.Text = "매수";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(364, 483);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 38;
            this.label17.Text = "매도";
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(162, 329);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 39;
            this.label18.Text = "매수";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(162, 356);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 12);
            this.label19.TabIndex = 40;
            this.label19.Text = "매도";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(162, 427);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 42;
            this.label20.Text = "매도";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(162, 400);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 41;
            this.label21.Text = "매수";
            // 
            // listBoxSysMsg
            // 
            this.listBoxSysMsg.FormattingEnabled = true;
            this.listBoxSysMsg.ItemHeight = 12;
            this.listBoxSysMsg.Location = new System.Drawing.Point(0, 509);
            this.listBoxSysMsg.Name = "listBoxSysMsg";
            this.listBoxSysMsg.Size = new System.Drawing.Size(562, 52);
            this.listBoxSysMsg.TabIndex = 79;
            // 
            // gridSetup
            // 
            this.gridSetup.AllowUserToAddRows = false;
            this.gridSetup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSetup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.시초가시작,
            this.시초가끝,
            this.전일고가시작,
            this.전일고가끝,
            this.전일저가시작,
            this.전일저가끝,
            this.전일종가시작,
            this.전일종가끝});
            this.gridSetup.Location = new System.Drawing.Point(0, 104);
            this.gridSetup.Name = "gridSetup";
            this.gridSetup.RowTemplate.Height = 23;
            this.gridSetup.Size = new System.Drawing.Size(562, 194);
            this.gridSetup.TabIndex = 80;
            // 
            // 시초가시작
            // 
            this.시초가시작.HeaderText = "시초가시작";
            this.시초가시작.Name = "시초가시작";
            this.시초가시작.Width = 50;
            // 
            // 시초가끝
            // 
            this.시초가끝.HeaderText = "시초가끝";
            this.시초가끝.Name = "시초가끝";
            this.시초가끝.Width = 50;
            // 
            // 전일고가시작
            // 
            this.전일고가시작.HeaderText = "전일고가시작";
            this.전일고가시작.Name = "전일고가시작";
            this.전일고가시작.Width = 50;
            // 
            // 전일고가끝
            // 
            this.전일고가끝.HeaderText = "전일고가끝";
            this.전일고가끝.Name = "전일고가끝";
            this.전일고가끝.Width = 50;
            // 
            // 전일저가시작
            // 
            this.전일저가시작.HeaderText = "전일저가시작";
            this.전일저가시작.Name = "전일저가시작";
            this.전일저가시작.Width = 50;
            // 
            // 전일저가끝
            // 
            this.전일저가끝.HeaderText = "전일저가끝";
            this.전일저가끝.Name = "전일저가끝";
            this.전일저가끝.Width = 50;
            // 
            // 전일종가시작
            // 
            this.전일종가시작.HeaderText = "전일종가시작";
            this.전일종가시작.Name = "전일종가시작";
            this.전일종가시작.Width = 50;
            // 
            // 전일종가끝
            // 
            this.전일종가끝.HeaderText = "전일종가끝";
            this.전일종가끝.Name = "전일종가끝";
            this.전일종가끝.Width = 50;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(490, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(57, 21);
            this.textBox1.TabIndex = 83;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(460, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 12);
            this.label12.TabIndex = 82;
            this.label12.Text = "~";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(399, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 21);
            this.textBox2.TabIndex = 81;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(286, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 12);
            this.label13.TabIndex = 84;
            this.label13.Text = "시초가 시간설정";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(562, 586);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.gridSetup);
            this.Controls.Add(this.listBoxSysMsg);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.textBoxShortTickRangeEnd);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxShortTickRangeBegin);
            this.Controls.Add(this.textBoxLongTickRangeEnd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBoxLongTickRangeBegin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxShortQtySumDiffEnd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxShortQtySumDiffBegin);
            this.Controls.Add(this.textBoxLongQtySumDiffEnd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxLongQtySumDiffBegin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxShortEstimateConclusionRangeEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxShortEstimateConclusionRangeBegin);
            this.Controls.Add(this.textBoxLongEstimateConclusionRangeEnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLongEstimateConclusionRangeBegin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxEndTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBeginTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "케비라 선물";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSetup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 서버선택ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서버선택ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 모의투자서버ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실계좌서버ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그인ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 계좌ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 계좌리스트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 거래내역조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잔고조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 증거금조회ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 주문ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_매도주문;
        private System.Windows.Forms.ToolStripMenuItem mnu_매수주문;
        private System.Windows.Forms.ToolStripMenuItem mun_정정주문;
        private System.Windows.Forms.ToolStripMenuItem mnu_취소주문;
        private System.Windows.Forms.ToolStripMenuItem 시세ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 현재가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 옵션전광판ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBeginTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEndTime;
        private System.Windows.Forms.TextBox textBoxLongEstimateConclusionRangeEnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLongEstimateConclusionRangeBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxShortEstimateConclusionRangeEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxShortEstimateConclusionRangeBegin;
        private System.Windows.Forms.TextBox textBoxShortQtySumDiffEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxShortQtySumDiffBegin;
        private System.Windows.Forms.TextBox textBoxLongQtySumDiffEnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxLongQtySumDiffBegin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxShortTickRangeEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxShortTickRangeBegin;
        private System.Windows.Forms.TextBox textBoxLongTickRangeEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxLongTickRangeBegin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ListBox listBoxSysMsg;
        private System.Windows.Forms.DataGridView gridSetup;
        private System.Windows.Forms.DataGridViewTextBoxColumn 시초가시작;
        private System.Windows.Forms.DataGridViewTextBoxColumn 시초가끝;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전일고가시작;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전일고가끝;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전일저가시작;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전일저가끝;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전일종가시작;
        private System.Windows.Forms.DataGridViewTextBoxColumn 전일종가끝;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
    }
}

