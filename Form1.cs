﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Hi {0}", txtName.Text.Trim()));
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Bye {0}", txtName.Text.Trim()));

        }

    }
}
