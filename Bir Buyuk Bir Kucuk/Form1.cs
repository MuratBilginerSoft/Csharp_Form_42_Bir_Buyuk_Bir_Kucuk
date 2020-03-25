using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bir_Buyuk_Bir_Kucuk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string kelime = textBox1.Text;

            int a = 0;

            string sonhali = "";

            string harf2;

            foreach (char harf in kelime)
            {
                if (a % 2 == 0)
                {
                    harf2 = harf.ToString().ToUpper();

                    sonhali += harf2;

                    a++;
                }

                else
                {
                    harf2 = harf.ToString().ToLower();

                    sonhali += harf2;

                    a++;


                }
            }


            textBox2.Text = sonhali;
        }
    }
}
