using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Two___Story.Steel_Reinforcement_Work
{
    public partial class tsStairCase : Form
    {
        public tsStairCase()
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
