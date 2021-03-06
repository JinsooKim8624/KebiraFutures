﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XA_SESSIONLib;
using System.Threading;
using System.Configuration;

namespace KebiraFutures
{
    public partial class MainForm : Form
    {
        XASessionClass myXASessionClass;

        //static 변수 : AccList, 종목마스터
        public static Dictionary<string, List<string>> AccList;//<계좌번호, <비밀번호, 계좌명, 상품구분>>
        public static SortedDictionary<string, List<string>> 종목마스터 = new SortedDictionary<string, List<string>>(); //<확장코드, <단축코드, 종목명, 만기년월, 상한가, 하한가>>
        public static List<Form> LoadedForm = new List<Form>();//로그인시 열린폼을 닫기위함

        public static string futureCode;

        bool 실계좌여부 = false; //모의투자/실계좌 처리방법의 구분을 위함
        
        public MainForm()
        {
            InitializeComponent();

            myXASessionClass = new XASessionClass();
            myXASessionClass._IXASessionEvents_Event_Login += new XA_SESSIONLib._IXASessionEvents_LoginEventHandler(myXASessionClass__IXASessionEvents_Event_Login);
            myXASessionClass.Disconnect += new XA_SESSIONLib._IXASessionEvents_DisconnectEventHandler(myXASessionClass_Disconnect);

            Util.listBoxSysMsg = listBoxSysMsg;
            Util.form = this;

            gridSetup.Rows.Add(4);
            gridSetup.RowHeadersWidth = 150;
            gridSetup.Rows[0].HeaderCell.Value = "선물잔량 : 매수";
            gridSetup.Rows[1].HeaderCell.Value = "선물잔량 : 매도";
            gridSetup.Rows[2].HeaderCell.Value = "진입틱수 : 매수";
            gridSetup.Rows[3].HeaderCell.Value = "진입틱수 : 매도";

        }

        void myXASessionClass_Disconnect()
        {
            toolStripStatusLabel1.Text = "myXASessionClass_Disconnect";
            MessageBox.Show("myXASessionClass_Disconnect");
        }

        void myXASessionClass__IXASessionEvents_Event_Login(string szCode, string szMsg)
        {
            toolStripStatusLabel1.Text +=";\t"+ szMsg;

            if (szCode == "0000")//로그인이 성공적으로 수행 되면..
            {
                계좌리스트ToolStripMenuItem.Enabled = true;
                계좌리스트ToolStripMenuItem_Click(null, null);//사용할(선물옵션계좌)의 비밀번호를 등록하고 AccList에 등록

                if (AccList.Count > 0)
                {
                    toolStripStatusLabel1.Text = AccList.Count + "개의 계좌가 등록 되었습니다.";
                }
                else
                {
                    toolStripStatusLabel1.Text = "등록된 계좌가 없습니다.";
                }

                //종목마스터로 부터 선물 옵션 전종목을 저장
                t9943 myt9943 = new t9943();
                myt9943.QueryExcute(new Dictionary<string,string>());

                t9944 myt9944 = new t9944();
                myt9944.QueryExcute(new Dictionary<string, string>());


                //메뉴항목 활성화
                거래내역조회ToolStripMenuItem.Enabled = true;
                증거금조회ToolStripMenuItem.Enabled = true;
                잔고조회ToolStripMenuItem.Enabled = true;
                주문ToolStripMenuItem.Enabled = true;
                시세ToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("LogIn 실패");
            }
        }        

        private void 모의투자서버ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myXASessionClass.ConnectServer("demo.etrade.co.kr", 20001))//모의투자 서버 주소 및 포트
            {
                toolStripStatusLabel1.Text = "ConnectServer 성공(모의투자)";
                로그인ToolStripMenuItem.Enabled = true;
                실계좌여부 = false;
                로그인ToolStripMenuItem_Click(null, null);
            }
            else
            {
                toolStripStatusLabel1.Text = myXASessionClass.GetErrorMessage(myXASessionClass.GetLastError());
                로그인ToolStripMenuItem.Enabled = false;
            }
        }

        private void 실계좌서버ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (myXASessionClass.ConnectServer("hts.etrade.co.kr", 20001))//실계좌 서버 주소 및 포트
            {
                toolStripStatusLabel1.Text = "ConnectServer 성공(실계좌)";
                로그인ToolStripMenuItem.Enabled = true;
                실계좌여부 = true;
                로그인ToolStripMenuItem_Click(null, null);
            }
            else
            {
                toolStripStatusLabel1.Text = myXASessionClass.GetErrorMessage(myXASessionClass.GetLastError());
                로그인ToolStripMenuItem.Enabled = false;
            }
        }

        private void 로그인ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Login myLogin = new Login(실계좌여부);
            DialogResult result = myLogin.ShowDialog();
            if (result == DialogResult.OK)
            {
                for (int i = LoadedForm.Count - 1; i >= 0; i--)
                {
                    LoadedForm[i].Close();
                }
                //메뉴항목 비활성화
                계좌리스트ToolStripMenuItem.Enabled = false;
                거래내역조회ToolStripMenuItem.Enabled = false;
                증거금조회ToolStripMenuItem.Enabled = false;
                잔고조회ToolStripMenuItem.Enabled = false;
                주문ToolStripMenuItem.Enabled = false;
                시세ToolStripMenuItem.Enabled = false;

                if (myXASessionClass.Login(myLogin.txt_고객ID.Text.Trim(), myLogin.txt_비밀번호.Text.Trim(), myLogin.txt_공인인증.Text.Trim(), 0, false))
                {
                    toolStripStatusLabel1.Text = "Login 전송 성공.";
                }
                else
                {
                    toolStripStatusLabel1.Text = "Login 전송 실패.";
                }
            }


        }

        private void 계좌리스트ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccList = new Dictionary<string, List<string>>();
            AccountList myAccountList = new AccountList(실계좌여부);

            //로그인 ID의 모든계좌를 불러옴
            for (int i = 0; i < myXASessionClass.GetAccountListCount(); i++)
            {
                myAccountList.dataGridView1.Rows.Add(myXASessionClass.GetAccountList(i),"","","","");
            }
            DialogResult result = myAccountList.ShowDialog();
            if (result == DialogResult.OK)
            {
                //모의투자의 경우 두개의 계좌중 첫번째계좌가 선물옵션 계좌임
                if (!실계좌여부)
                {
                    AccList.Add(myAccountList.dataGridView1.Rows[0].Cells["AccNum"].Value.ToString(), new List<string>());
                    AccList[myAccountList.dataGridView1.Rows[0].Cells["AccNum"].Value.ToString()].Add("0000");
                    AccList[myAccountList.dataGridView1.Rows[0].Cells["AccNum"].Value.ToString()].Add("모의투자");
                    AccList[myAccountList.dataGridView1.Rows[0].Cells["AccNum"].Value.ToString()].Add("선물옵션");
                }
                else
                {
                    foreach (DataGridViewRow row in myAccountList.dataGridView1.Rows)
                    {
                        if (row.Cells["Item"].Value.ToString().Contains("선물옵션"))//선물옵션 계좌만 목록에 등록
                        {
                            AccList.Add(row.Cells["AccNum"].Value.ToString(), new List<string>());
                            AccList[row.Cells["AccNum"].Value.ToString()].Add(row.Cells["Pass"].Value.ToString().Trim());
                            AccList[row.Cells["AccNum"].Value.ToString()].Add(row.Cells["AccName"].Value.ToString().Trim());
                            AccList[row.Cells["AccNum"].Value.ToString()].Add(row.Cells["Item"].Value.ToString().Trim());
                        }
                    }
                }

                잔고조회ToolStripMenuItem_Click(null, null);

                현재가ToolStripMenuItem_Click(null, null);

            }
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //종료 확인
            DialogResult result = MessageBox.Show("정말로 종료하시겠습니까..?", "종료", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                e.Cancel = true;
        }


        //각 메뉴항목에 해당하는 Form을 띄움.
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }        

        private void 거래내역조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TradeHistory myTradeHistory = new TradeHistory();
        }

        private void 잔고조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrPosition myCurrPosition = new CurrPosition();
        }

        private void 증거금조회ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrMargin myCurrMargin = new CurrMargin();
        }

        private void mnu_매도주문_Click(object sender, EventArgs e)
        {
            FormOrder myOrder = new FormOrder(((ToolStripMenuItem)sender).Text.Replace("mnu_", ""));
        }

        private void 현재가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrPrice myCurrPrice = new CurrPrice();
        }

        private void 옵션전광판ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionBoard myOptionBoard = new OptionBoard();
        }



        public static string beginTime;
        public static string endTime;

        public static double longEstimatedFr;
        public static double longEstimatedTo;
        public static double shortEstimatedFr;
        public static double shortEstimatedTo;

        public static int longQtySumDiffFr;
        public static int longQtySumDiffTo;
        public static int shortQtySumDiffFr;
        public static int shortQtySumDiffTo;

        public static int longEnterTickFr;
        public static int longEnterTickTo;
        public static int shortEnterTickFr;
        public static int shortEnterTickTo;







        public static double prevDayGoga;
        public static double prevDayJeoga;
        public static double prevDayJongga;



        private void MainForm_Load(object sender, EventArgs e)
        {

            //시간 설정
            textBoxBeginTime.Text =  ConfigurationManager.AppSettings["BeginTime"];
            textBoxEndTime.Text = ConfigurationManager.AppSettings["EndTime"];

            //선물총잔량설정범위
            textBoxLongQtySumDiffBegin.Text = ConfigurationManager.AppSettings["LongQtySumDiffBegin"];
            textBoxLongQtySumDiffEnd.Text = ConfigurationManager.AppSettings["LongQtySumDiffEnd"];

            textBoxShortQtySumDiffBegin.Text = ConfigurationManager.AppSettings["ShortQtySumDiffBegin"];
            textBoxShortQtySumDiffEnd.Text = ConfigurationManager.AppSettings["ShortQtySumDiffEnd"];



            //예상체결범위
            textBoxLongEstimateConclusionRangeBegin.Text = ConfigurationManager.AppSettings["LongEstimatedBegin"];
            textBoxLongEstimateConclusionRangeEnd.Text = ConfigurationManager.AppSettings["LongEstimatedEnd"];

            textBoxShortEstimateConclusionRangeBegin.Text = ConfigurationManager.AppSettings["ShortEstimatedBegin"];
            textBoxShortEstimateConclusionRangeEnd.Text = ConfigurationManager.AppSettings["ShortEstimatedEnd"];





            //진입틱수설정범위
            textBoxLongTickRangeBegin.Text = ConfigurationManager.AppSettings["LongEnterTickBegin"];
            textBoxLongTickRangeEnd.Text = ConfigurationManager.AppSettings["LongEnterTickEnd"];

            textBoxShortTickRangeBegin.Text = ConfigurationManager.AppSettings["ShortEnterTickBegin"];
            textBoxShortTickRangeEnd.Text = ConfigurationManager.AppSettings["ShortEnterTickEnd"];


            //손절라인



            longEstimatedFr  = Convert.ToSingle(textBoxLongEstimateConclusionRangeBegin.Text);
            longEstimatedTo = Convert.ToSingle(textBoxLongEstimateConclusionRangeEnd.Text); 
            shortEstimatedFr = Convert.ToSingle(textBoxShortEstimateConclusionRangeBegin.Text); 
            shortEstimatedTo = Convert.ToSingle(textBoxShortEstimateConclusionRangeEnd.Text); 

            longQtySumDiffFr = Convert.ToInt32(textBoxLongQtySumDiffBegin.Text);
            longQtySumDiffTo = Convert.ToInt32(textBoxLongQtySumDiffEnd.Text);
            shortQtySumDiffFr = Convert.ToInt32(textBoxShortQtySumDiffBegin.Text);
            shortQtySumDiffTo = Convert.ToInt32(textBoxShortQtySumDiffEnd.Text);

            longEnterTickFr = Convert.ToInt32(textBoxLongTickRangeBegin.Text);
            longEnterTickTo = Convert.ToInt32(textBoxLongTickRangeEnd.Text);
            shortEnterTickFr = Convert.ToInt32(textBoxShortTickRangeBegin.Text);
            shortEnterTickTo = Convert.ToInt32(textBoxShortTickRangeEnd.Text);




            //t8432 jisuFutures = new t8432();
            //Dictionary<string, string> InputDataTable = new Dictionary<string, string>();
            //InputDataTable.Add("RecCnt", "1");
            //InputDataTable.Add("AcntNo", dataGridView1.Rows[e.RowIndex].Cells["AccNUm"].Value.ToString());
            //InputDataTable.Add("InptPwd", dataGridView1.Rows[e.RowIndex].Cells["Pass"].Value.ToString());
            //jisuFutures.QueryExcute(InputDataTable);

            //textBoxPrevDayGoga.Text = "326.25";
            //textBoxPrevDayJeoga.Text = "319.26";
            //textBoxPrevDayJongga.Text = "323.10";

            //prevDayGoga = Convert.ToSingle(textBoxPrevDayGoga.Text);
            //prevDayJeoga = Convert.ToSingle(textBoxPrevDayJeoga.Text);
            //prevDayJongga = Convert.ToSingle(textBoxPrevDayJongga.Text);


        }




        public void SetTextBoxWithText(string textBoxName, string text)
        {
         }




    }
}
