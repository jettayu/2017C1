﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplecaculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x=1;
            
            label1.Text=Caculator(x);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 2;

            label1.Text = Caculator(x);

        }

        private string Caculator(int i)
        {
            int num;
            switch (i)
            {
             case 1:
                    num = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                    return num.ToString();
             default:
                    num = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                    return num.ToString();
            }
        }
    }
}
