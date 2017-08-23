using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackerWatchServer
{
    class Helper
    {
        public static string encodeRTF(string RTF)
        {
            return RTF.Replace(@"\", "§").Replace(@"'", "£");
        }

        public static string decodeRTF(string RTF)
        {
            return RTF.Replace("§", "\\").Replace("£", @"'");
        }

        public static string getTextFromRTF(String rtfString)
        {
            using (RichTextBox textBox = new RichTextBox())
            {
                string returningString = "";

                try
                {
                    textBox.Rtf = decodeRTF(rtfString);
                    returningString = textBox.Text;
                }
                catch
                {
                    returningString = rtfString;
                }

                return returningString;
            }
        }
    }
}
