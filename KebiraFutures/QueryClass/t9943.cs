using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KebiraFutures
{
    /// <summary>
    /// 지수선물마스터조회API용
    /// </summary>
    class t9943 : Query
    {
        public t9943()
            : base()
        {
            myXAQueryClass.ResFileName = @"Res\t9943.res";
            GetInBlockName();
        }

        /// <param name="InputDataTable">입력사항 없슴</param>
        public t9943(Dictionary<string, string> InputDataTable)
            : base()
        {
            this.InputDataTable = InputDataTable;
            myXAQueryClass.ResFileName = @"Res\t9943.res";
            GetInBlockName();
        }

        /// <param name="InputDataTable">입력사항 없슴</param>
        public override void QueryExcute(Dictionary<string, string> InputDataTable)
        {
            base.QueryExcute(InputDataTable);
        }

        protected override void myXAQueryClass_ReceiveData(string szTrCode)
        {
            int cnt_t9943OutBlock = myXAQueryClass.GetBlockCount("t9943OutBlock");
            for (int i = 0; i < cnt_t9943OutBlock; i++)
            {
                List<string> list = new List<string>();
                string shcode = myXAQueryClass.GetFieldData("t9943OutBlock", "shcode", i);
                string yy = "20";
                string hname = myXAQueryClass.GetFieldData("t9943OutBlock", "hname", i);
                list.Add(shcode);
                list.Add(hname);
                list.Add(yy+hname.Split(new string[]{" "},StringSplitOptions.RemoveEmptyEntries)[1].Replace("월",""));
                if(!MainForm.종목마스터.ContainsKey(myXAQueryClass.GetFieldData("t9943OutBlock", "expcode", i)))
                    MainForm.종목마스터.Add(myXAQueryClass.GetFieldData("t9943OutBlock", "expcode", i), list);
                
                if (i.Equals(0))
                {
                    MainForm.futureCode = shcode;
                }
            }


            t8416 futureDayCandle = new t8416();
            Dictionary<string, string> InputDataTable = new Dictionary<string, string>();
            InputDataTable.Add("shcode", MainForm.futureCode);
            InputDataTable.Add("gubun", "2");
            InputDataTable.Add("qrycnt", "5");
            InputDataTable.Add("sdate", System.DateTime.Now.ToString("yyyyMMdd"));
            InputDataTable.Add("edate", System.DateTime.Now.AddDays(-10).ToString("yyyyMMdd"));
            InputDataTable.Add("cts_date", System.DateTime.Now.AddDays(-10).ToString("yyyyMMdd"));
            InputDataTable.Add("comp_yn", "Y");

            futureDayCandle.QueryExcute(InputDataTable);


        }
    }
}
