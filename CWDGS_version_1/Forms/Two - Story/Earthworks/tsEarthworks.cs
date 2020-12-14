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
    public partial class tsEarthworks : Form
    {
        public tsEarthworks()
        {
            InitializeComponent();
        }
        private void ComputationOne()
        {

            try
            {
            decimal excavation = Convert.ToDecimal(txtExcavation.Text);
            decimal workers = Convert.ToDecimal(txtWorkers.Text);

            decimal cum = Convert.ToInt32(txtCum.Text);
            decimal days = Convert.ToDecimal(txtDays.Text);
            decimal a = (excavation / (workers * cum));

                days = (int)Math.Ceiling(a);
                txtDays.Text = days.ToString();
                CostOfLabor();
      
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }
        private void ComputationTwo()
        {
            decimal preffered = Convert.ToDecimal(txtPreffered.Text);
            decimal excavation = Convert.ToDecimal(txtExcavation.Text);
            decimal cum = Convert.ToDecimal(txtCum.Text);
            decimal workers = Convert.ToDecimal(txtWorkers.Text);

            try
            {
                decimal a = (excavation / (preffered * cum));
                workers = (int)Math.Ceiling(a);
                txtWorkers.Text = workers.ToString();
                txtLabor.Text = workers.ToString();
                ComputationOne();
                CostOfLabor();

                    
            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");
       
            }
        }
        private void CostOfLabor()
        {
      
            int costOfLabor = Convert.ToInt32(txtCostOfLabor.Text);
            int days = Convert.ToInt32(txtDays.Text);
            int labor = Convert.ToInt32(txtLabor.Text);

            try
            {
                int a = costOfLabor * labor * days;
                txtCost.Text = a.ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");
       
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    txtCum.Text = soft.Text;
                    ComputationOne();
                    ComputationTwo();

                }
                else
                {
                    txtCum.Text = hard.Text;
                    ComputationOne();
                    ComputationTwo();
                }
            }
            catch (Exception)
            {

               
            }
     
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            Close();

        }
        private void txtExcavation_TextChanged(object sender, EventArgs e)
        {

            if (txtWorkers.Text == "0")
            {

            }
            else if (txtExcavation.Text == "") {

            }
            else
            {
                ComputationOne();
            }
        }

        private void txtPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtPreffered.Text == "")
            {

            }
            else
            {
                ComputationTwo();
            }
          
        }

        private void frmEarthworks_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;

        }

        private void txtWorkers_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void txtLabor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtExcavation_Click(object sender, EventArgs e)
        {
            txtExcavation.SelectAll();
        }

        private void txtPreffered_Click(object sender, EventArgs e)
        {
            txtPreffered.SelectAll();
        }

        private void txtExcavation_Enter(object sender, EventArgs e)
        {
            TextBox lbox = sender as TextBox;
            lbox.SelectAll();
        }

        private void txtPreffered_Enter(object sender, EventArgs e)
        {
            TextBox lbox = sender as TextBox;
            lbox.SelectAll();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSoilType soilType = new frmSoilType();
            soilType.ShowDialog();
            soft.Text = soilType.textBox1.Text;
            hard.Text = soilType.textBox2.Text;
            txtCum.Text = "";


        }
    }
}
