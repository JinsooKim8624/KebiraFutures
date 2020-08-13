using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using XA_DATASETLib;


namespace KebiraFutures
{
    public class Order
    {

        public void ShortOrder(string acntNo, string pwd, string paramCode, decimal price, decimal qty)
        {
            CFOAT00100 myCFOAT00100 = new CFOAT00100();
            myCFOAT00100.CallBackMethod += ReceveData;
            myCFOAT00100.CallBackMsg += ReceveMsg;
            Dictionary<string, string> InputDataTable = new Dictionary<string, string>();
            InputDataTable.Add("AcntNo", acntNo);
            InputDataTable.Add("Pwd", pwd);

            foreach (KeyValuePair<string, List<string>> code in MainForm.종목마스터)
            {
                if (code.Value[0] == paramCode)
                {
                    InputDataTable.Add("FnoIsuNo", code.Key);
                }
            }

            InputDataTable.Add("BnsTpCode", "1");
            InputDataTable.Add("FnoOrdprcPtnCode", "00");
            InputDataTable.Add("OrdPrc", price.ToString());
            InputDataTable.Add("OrdQty", qty.ToString());

            myCFOAT00100.QueryExcute(InputDataTable);


        }



        public void LongOrder(string acntNo, string pwd, string paramCode, decimal price, decimal qty)
        {

            CFOAT00100 myCFOAT00100 = new CFOAT00100();
            myCFOAT00100.CallBackMethod += ReceveData;
            myCFOAT00100.CallBackMsg += ReceveMsg;
            Dictionary<string, string> InputDataTable = new Dictionary<string, string>();
            InputDataTable.Add("AcntNo", acntNo);
            InputDataTable.Add("Pwd", pwd);
            foreach (KeyValuePair<string, List<string>> code in MainForm.종목마스터)
            {
                if (code.Value[0] == paramCode)
                {
                    InputDataTable.Add("FnoIsuNo", code.Key);
                }
            }

            InputDataTable.Add("BnsTpCode", "2");
            InputDataTable.Add("FnoOrdprcPtnCode", "00");
            InputDataTable.Add("OrdPrc", price.ToString());
            InputDataTable.Add("OrdQty", qty.ToString());

            myCFOAT00100.QueryExcute(InputDataTable);


        }




        public void ModifyOrder(string acntNo, string pwd, string paramCode, string modiOrderNo, decimal price, decimal qty)
        {
            CFOAT00200 myCFOAT00200 = new CFOAT00200();
            myCFOAT00200.CallBackMethod += ReceveData;
            myCFOAT00200.CallBackMsg += ReceveMsg;
            Dictionary<string, string> InputDataTable = new Dictionary<string, string>();
            InputDataTable.Add("AcntNo", acntNo);
            InputDataTable.Add("Pwd",pwd);
            foreach (KeyValuePair<string, List<string>> code in MainForm.종목마스터)
            {
                if (code.Value[0] == paramCode)
                {
                    InputDataTable.Add("FnoIsuNo", code.Key);
                }
            }

            InputDataTable.Add("OrgOrdNo", modiOrderNo);
            InputDataTable.Add("FnoOrdprcPtnCode", "00");
            InputDataTable.Add("OrdPrc", price.ToString());
            InputDataTable.Add("MdfyQty", qty.ToString());

            myCFOAT00200.QueryExcute(InputDataTable);



        }


        public void CancelOrder(string acntNo, string pwd, string paramCode, string cancelOrderNo, decimal qty)
        {
            CFOAT00300 myCFOAT00300 = new CFOAT00300();
            myCFOAT00300.CallBackMethod += ReceveData;
            myCFOAT00300.CallBackMsg += ReceveMsg;
            Dictionary<string, string> InputDataTable = new Dictionary<string, string>();
            InputDataTable.Add("AcntNo", acntNo);
            InputDataTable.Add("Pwd", pwd);
            foreach (KeyValuePair<string, List<string>> code in MainForm.종목마스터)
            {
                if (code.Value[0] == paramCode)
                {
                    InputDataTable.Add("FnoIsuNo", code.Key);
                }
            }

            InputDataTable.Add("OrgOrdNo", cancelOrderNo);
            InputDataTable.Add("CancQty", qty.ToString());

            myCFOAT00300.QueryExcute(InputDataTable);



        }




        private void ReceveData(XAQueryClass myXAQueryClass)
        {

        }

        private void ReceveMsg(bool bIsSystemError, string Msg)
        {
            if (bIsSystemError)
            {
                MessageBox.Show(Msg);
            }
            else
            {
                //toolStripStatusLabel1.Text = Msg;
            }
        }

    }
}
