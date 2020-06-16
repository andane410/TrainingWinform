using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        string teststring1,teststring2;

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "아이디 : " + textBox1.Text + "\n비밀번호 :" + textBox2.Text;
        }
    }
}
