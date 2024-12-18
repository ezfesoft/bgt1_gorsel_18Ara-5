using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bgt1_gorsel_18Ara_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int satir= Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= satir; i++)
            {
                string yildiz = "";
                string bosluk = "";
                for (int a = 0; a < satir-i; a++)
                {
                    bosluk += " ";
                }
                for (int j=1;j<=i;j++)
                {
                    yildiz += "* ";
                }
                listBox1.Items.Add(bosluk+yildiz);

                /*
                
                |    *
                |   * *
                |  * * *
                | * * * * 

                */
            }
        }
    }
}
