using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Two___Story.Masonry_Walls
{
    public partial class tsInteriorGF : Form
    {
        public tsInteriorGF()
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
