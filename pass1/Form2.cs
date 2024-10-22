using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pass1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            string listHash = "";
            for (int i = 0; i < 24; i++)
            {
                string atom = "";
                for (int j = 1; j < (i % 4) + 4; j++)
                {
                    int symbol = (int)password[((i + 3) * j) % password.Length];
                    symbol = 33 + (symbol * (i + 1)) % 92;
                    atom += ((char)symbol).ToString();
                }
                listHash += atom;
            }
            char[] listChar = listHash.ToCharArray();
            for (int j = 0; j < listChar.Length; j++)
            {
                char atom = listChar[j];
                int symbol = (listChar.Length - j + (((int)atom) * j)) % listHash.Length;
                (listChar[j], listChar[symbol]) = (listChar[symbol], listChar[j]);
            }
            listHash = new string(listChar);
            if(listHash == """1YGek"Oi-ma!A%o/5cf=e5yfa8A4#8QI2UrGy0IcQ)%iEQ5S'Y-19$Oa)aGXaAS4qq]e;[Eayqa)=2ie]m9OU)C%h'N]KMa`1su%!II5M8)u""")
                label1.Text = "correct";
            else
                label1.Text = "try again";
        }
    }
}
