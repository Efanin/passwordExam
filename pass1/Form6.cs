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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            string listHash = "";
            for (int i = 0; i < 24; i++)
            {
                int symbol = (int)password[(i + 3) % password.Length];
                symbol = 33 + (symbol * (i + 1)) % 92;
                listHash += ((char)symbol).ToString();
            }
            if (listHash == """1G%1$I5a1{u)`qF='-]Y&m!y""")
                label1.Text = "correct";
            else
                label1.Text = "try again";
        }
    }
}
