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
    public partial class tsEXC : Form
    {
        public tsEXC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMosaic.Text == "" || txtCeramic.Text == "" || txtVitrified.Text == "" || txtGranite.Text == "" || txtMarble.Text == "" || txtGlazed.Text == "" )
            {

            }
            else
            {
                Close();
            }
        }
    }
}
