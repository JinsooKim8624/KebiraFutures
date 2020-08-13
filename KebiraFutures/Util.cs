using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KebiraFutures
{
    class Util
    {
        public static ListBox listBoxSysMsg;



        public static void WriteSysMsg(string msg)
        {
            if (listBoxSysMsg.Items.Count >= 50000)
            {
                listBoxSysMsg.Items.RemoveAt(50000);

            }
            else
            {
                string msg2 = String.Format($"{System.DateTime.Now} {msg}");
                listBoxSysMsg.Items.Insert(0, msg2);

            }

        }


        public static Form form;

        public static void SetTextBoxWithText(string textBoxName, string text)
        {
            foreach (Control ctrl in form.Controls)
            {
                if (ctrl is TextBox && ((TextBox)ctrl).Name == textBoxName)
                {
                    ((TextBox)ctrl).Text = text;
                }
            }

        }


    }
}
