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
    public partial class txExteriorGF : Form
    {
        public txExteriorGF()
        {
            InitializeComponent();
        }

        private void txExteriorGF_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbox1.Text == "" && textBox2.Text == "")
            {

            }
            else
            {
                Close();
            }
        }
    }
}
