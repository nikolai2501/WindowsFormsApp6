﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Button_Yes_Click(object sender, EventArgs e)
        {
            Hide();
            GAMELOSE g = new GAMELOSE ();
            g.Show();
        }

        private void Button_No_Click(object sender, EventArgs e)
        {
            Hide();
            GAMEPROFRESS1 g = new GAMEPROFRESS1();
            g.Show();
        }
    }
}