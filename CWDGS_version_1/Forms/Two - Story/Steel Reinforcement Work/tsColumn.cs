using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Steel_Reinforcement_Work
{
    public partial class tsColumn : Form
    {
        public tsColumn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "")
            {
                MessageBox.Show("Empty Input");
            }
            else
                Close();
        }
    }
}
