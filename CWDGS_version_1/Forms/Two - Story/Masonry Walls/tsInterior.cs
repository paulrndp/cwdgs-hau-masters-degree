﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Masonry_Walls
{
    public partial class tsInterior : Form
    {
        public tsInterior()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {

            }
            else
            {
                Close();
            }
        }
    }
}
