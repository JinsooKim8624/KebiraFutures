using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KebiraFutures
{
    /// <summary>
    /// KOSPI200선물호가
    /// </summary>
    class FH0 : Real
    {
        public FH0()
            : base()
        {
            myXARealClass.ResFileName = @"Res\FH0.res";
        }

        /// <param name="InputDataTable">futcode(단축코드)</param>
        public override void AdviseExcute(Dictionary<string, string> InputDataTable)
        {
            base.AdviseExcute(InputDataTable);
        }

        protected override void myXARealClass_ReceiveRealData(string szTrCode)
        {
            base.myXARealClass_ReceiveRealData(szTrCode);
        }
    }
}
