using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Earthworks
{
    public partial class frmSoilType : Form
    {


        public frmSoilType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" && textBox2.Text != "")
            {
               Close();
            }
            else
            {

   
            }


                



         

           // this.Hide();
            

        }

        private void frmSoilType_Load(object sender, EventArgs e)
        {

        }
    }
}
