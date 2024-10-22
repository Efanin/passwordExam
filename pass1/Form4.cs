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
    public partial class Form4 : Form
    {
        public Form4()
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
            if (listHash == """1.)a9AQr<H0iUaAUaA=LqiUogYYYYYiIEiA-N-:eGqemIuqXQ1a]-)n9-]+ICyu,F5EEEEEE^vy{9SA=`]=`yYM5)m0&z+mu+!f!8!-9E%A1""")
                label1.Text = "correct";
            else
                label1.Text = "try again";
        }
    }
}
