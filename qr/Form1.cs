using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace qr
{
    public partial class QRGen : Form
    {
        public QRGen()
        {
            InitializeComponent();
        }

        private void TBscan_TextChanged(object sender, EventArgs e)
        {
            int NLcount = TBscan.Text.Split('\n').Length;

            string txt = TBscan.Text;
            
            string GetLine(string text, int lineNo)
            {
                string[] lines = text.Replace("\r", "").Split('\n');
                return lines.Length >= lineNo ? lines[lineNo - 1] : null;
            }
            fixedText.Text = GetLine(txt, 1);
            string str = fixedText.Text;
                int lotid = str.IndexOf("LGP-POL");
                fixedText.Text = lotid.ToString();
        }
    }
}
