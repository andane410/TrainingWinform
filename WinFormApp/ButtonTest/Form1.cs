using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonTest
{
    public partial class Form1 : Form
    {
        protected int a,b,c,d = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void btnFlat_Click(object sender, EventArgs e)
        {
            
            label1.Text = FlatStyle.Flat.ToString();
            if (a % 2 == 0)
            {
                btnFlat.Text = "바꿔엇당";
                a++;
            }
            else if (a % 2 == 1)
            {
                btnFlat.Text = "Flat";
                a++;
            }
        }

        private void btnPopup_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Popup.ToString();
            if (b % 2 == 0)
            {
                btnPopup.Text = "바꿔엇당";
                b++;
            }
            else if (b % 2 == 1)
            {
                btnPopup.Text = "Popup";
                b++;
            }
        }

        private void btnStandard_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.Standard.ToString();

            
            if (c % 2 == 0)
            {
                btnStandard.Text = "바꿔엇당";
                c++;
            }
            else if (c % 2 == 1)
            {
                btnStandard.Text = "Standard";
                c++;
            }
        }

        private void btnSystem_Click(object sender, EventArgs e)
        {
            label1.Text = FlatStyle.System.ToString();

            label1.Text = "System";
            if (d % 2 == 0)
            {
                btnSystem.Text = "바꿔엇당";
                d++;
            }
            else if(d%2==1)
            {
                btnSystem.Text = "System";
                d++;
            }
        }
    }
}
