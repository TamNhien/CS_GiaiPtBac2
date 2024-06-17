using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_GiaiPtBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txta.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtb.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            txtc.Text = trackBar3.Value.ToString();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            double a, b, c, delta, x1, x2;
            a = Convert.ToDouble(txta.Text);
            b = Convert.ToDouble(txtb.Text);
            c = Convert.ToDouble(txtc.Text);

            if (a == 0)
                if (b == 0)
                    if (c != 0)
                        lblKQ.Text = "Phương trình vô số nghiệm";
                    else
                        lblKQ.Text = "Phương trình vô nghiệm";
                else
                    lblKQ.Text = "Phương trình có nghiệm x1 = x2: " + ((-c) / b).ToString();
            else
            {
                delta = b * b - 4 * a * c;

                if (delta < 0)
                    lblKQ.Text = "Phương trình vô nghiệm";
                else
                {
                    if (delta == 0)
                        lblKQ.Text = "Phương trình có nghiệm" + ((-b) / (2 * a)).ToString();
                    else
                    {
                        x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        lblKQ.Text = "Phương trình có nghiệm"+ "\nx1 = " + x1 + "\nx2 = " + x2;
                    }
                }
            }
        }
    }
}
