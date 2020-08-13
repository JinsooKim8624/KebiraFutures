using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KebiraFutures
{
    /// <summary>
    /// 선물/옵션차트(일주월)
    /// </summary>
    class t8416 : Query
    {
       public t8416()
            : base()
        {
            myXAQueryClass.ResFileName = @"Res\t8416.res";
            GetInBlockName();
        }

        /// <param name="InputDataTable">입력사항 없슴</param>
        public t8416(Dictionary<string, string> InputDataTable)
            : base()
        {
            this.InputDataTable = InputDataTable;
            myXAQueryClass.ResFileName = @"Res\t8416.res";
            GetInBlockName();
        }

        /// <param name="InputDataTable">입력사항 없슴</param>
        public override void QueryExcute(Dictionary<string, string> InputDataTable)
        {
            base.QueryExcute(InputDataTable);
        }

        protected override void myXAQueryClass_ReceiveData(string szTrCode)
        {
            int cntOutBlock = myXAQueryClass.GetBlockCount("t8416OutBlock");
            
            for (int i = 0; i < cntOutBlock; i++)
            {
                string shcode = myXAQueryClass.GetFieldData("t8416OutBlock", "shcode", i);
                myXAQueryClass.GetFieldData("t8416OutBlock", "jisiga", i);
                
                MainForm.prevDayGoga = Convert.ToDouble(myXAQueryClass.GetFieldData("t8416OutBlock", "jihigh", i));
                Util.SetTextBoxWithText("textBoxPrevDayGoga", MainForm.prevDayGoga.ToString());
                
                MainForm.prevDayJeoga = Convert.ToDouble(myXAQueryClass.GetFieldData("t8416OutBlock", "jilow", i));
                Util.SetTextBoxWithText("textBoxPrevDayJeoga", MainForm.prevDayJeoga.ToString());

                MainForm.prevDayJongga = Convert.ToDouble(myXAQueryClass.GetFieldData("t8416OutBlock", "jiclose", i));
                Util.SetTextBoxWithText("textBoxPrevDayJongga", MainForm.prevDayJongga.ToString());
                
                myXAQueryClass.GetFieldData("t8416OutBlock", "jivolume", i);
                myXAQueryClass.GetFieldData("t8416OutBlock", "disiga", i);
                myXAQueryClass.GetFieldData("t8416OutBlock", "dihigh", i);
                myXAQueryClass.GetFieldData("t8416OutBlock", "dilow", i);
                myXAQueryClass.GetFieldData("t8416OutBlock", "diclose", i);
                myXAQueryClass.GetFieldData("t8416OutBlock", "highend", i);
                myXAQueryClass.GetFieldData("t8416OutBlock", "cts_date", i);
                myXAQueryClass.GetFieldData("t8416OutBlock", "s_time", i);
                myXAQueryClass.GetFieldData("t8416OutBlock", "e_time", i);
                myXAQueryClass.GetFieldData("t8416OutBlock", "dshmin", i);
                myXAQueryClass.GetFieldData("t8416OutBlock", "recount", i);
            }


            int cntOutBlock2 = myXAQueryClass.GetBlockCount("t8416OutBlock1");
            for (int i = 0; i < cntOutBlock2; i++)
            {
                //myXAQueryClass.GetFieldData("t8416OutBlock", "shcode", i);
                //myXAQueryClass.GetFieldData("t8416OutBlock", "jisiga", i);
                //MainForm.prevDayGoga = Convert.ToDouble(myXAQueryClass.GetFieldData("t8416OutBlock", "jihigh", i));
                //MainForm.prevDayJeoga = Convert.ToDouble(myXAQueryClass.GetFieldData("t8416OutBlock", "jilow", i));
                //MainForm.prevDayJongga = Convert.ToDouble(myXAQueryClass.GetFieldData("t8416OutBlock", "jiclose", i));
                //myXAQueryClass.GetFieldData("t8416OutBlock", "jivolume", i);
                //myXAQueryClass.GetFieldData("t8416OutBlock", "disiga", i);
                //myXAQueryClass.GetFieldData("t8416OutBlock", "dihigh", i);
                //myXAQueryClass.GetFieldData("t8416OutBlock", "dilow", i);
                //myXAQueryClass.GetFieldData("t8416OutBlock", "diclose", i);
                //myXAQueryClass.GetFieldData("t8416OutBlock", "highend", i);
                //myXAQueryClass.GetFieldData("t8416OutBlock", "cts_date", i);
                //myXAQueryClass.GetFieldData("t8416OutBlock", "s_time", i);
                //myXAQueryClass.GetFieldData("t8416OutBlock", "e_time", i);
                //myXAQueryClass.GetFieldData("t8416OutBlock", "dshmin", i);
                //myXAQueryClass.GetFieldData("t8416OutBlock", "recount", i);
            }

        }
    }
}
