﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Steel_Reinforcement_Work
{
    public partial class tsSlab : Form
    {
        public tsSlab()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "")
            {

            }
            else
            {
                Close();
            }
        }
    }
}
