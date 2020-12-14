using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Painting_Works
{
    public partial class frmPWs_Interior : Form
    {
        public frmPWs_Interior()
        {
            InitializeComponent();
        }

        private void frmPWs_Interior_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text1.Text == "" && text2.Text == "")
            {

            }
            else
            {
                Close();
            }
        }
    }
}
