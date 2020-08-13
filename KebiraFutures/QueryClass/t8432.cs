using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KebiraFutures
{
    /// <summary>
    /// 지수선물마스터조회API
    /// </summary>
    class t8432 : Query
    {      
        public t8432()
            : base()
        {
            myXAQueryClass.ResFileName = @"Res\t8432.res";
            GetInBlockName();
        }

        /// <param name="InputDataTable">입력사항 없슴</param>
        public t8432(Dictionary<string, string> InputDataTable)
            : base()
        {
            this.InputDataTable = InputDataTable;
            myXAQueryClass.ResFileName = @"Res\t8432.res";
            GetInBlockName();
        }

        /// <param name="InputDataTable">입력사항 없슴</param>
        public override void QueryExcute(Dictionary<string, string> InputDataTable)
        {
            base.QueryExcute(InputDataTable);
        }

        protected override void myXAQueryClass_ReceiveData(string szTrCode)
        {
            int cntOutBlock = myXAQueryClass.GetBlockCount("t8432OutBlock");
            for (int i = 0; i < cntOutBlock; i++)
            {
                 List<string> list = new List<string>();
            }
        }
    }
}
