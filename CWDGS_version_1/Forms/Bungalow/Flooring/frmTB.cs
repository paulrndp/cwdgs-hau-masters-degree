using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Flooring
{
    public partial class frmTB : Form
    {
        public frmTB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMosaicTB.Text == "" || txtCeramicTB.Text == "" || txtVitrifiedTB.Text == "" || txtGraniteTB.Text == "" || txtMarbleTB.Text == "" || txtGlazedTB.Text == "")
            {

            }
            else
            {
                Close();
            }
        }
    }
}
