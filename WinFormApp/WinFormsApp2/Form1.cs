﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            label1.Text = now.ToString("HH:mm:ss");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("폼 로드 시 발생");
        }
       
        

        private void MainForm_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("폼 활성화 시 발생");
        }
    }
}
