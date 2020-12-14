using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Two___Story.Formworks
{
    public partial class tsF_Column_SF : Form
    {
        public tsF_Column_SF()
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
