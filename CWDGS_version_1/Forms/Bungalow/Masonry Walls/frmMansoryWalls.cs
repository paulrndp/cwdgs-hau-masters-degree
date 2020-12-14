using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Masonry_Walls
{
    public partial class frmMansoryWalls : Form
    {
        public frmMansoryWalls()
        {
            InitializeComponent();
        }

        private void exteriorTwo()
        {

            try
            {
                decimal surfacearea = Convert.ToDecimal(txtSurfaceArea.Text);
                decimal preffered = Convert.ToDecimal(txtPreffered.Text);
                decimal walls = Convert.ToDecimal(txtCHBWalls.Text);

                decimal days = Convert.ToDecimal(txtDays.Text);
                decimal workers = Convert.ToDecimal(txtWorkers.Text);

                decimal mason = Convert.ToDecimal(txtMason.Text);
                decimal laborer = Convert.ToDecimal(txtLaborer.Text);
    
                decimal a = (surfacearea / (preffered * walls));

                mason = (int)Math.Ceiling(a);
                txtMason.Text = mason.ToString();

                if (mason -2 <= 0)
                {
                    txtLaborer.Text = "1";     
                }
                else
                {
                    decimal b = (mason / 2);
                    laborer = (int)Math.Ceiling(b);
                    txtLaborer.Text = laborer.ToString();

                    decimal c = mason + laborer;
                    workers = (int)Math.Ceiling(c);
                    txtWorkers.Text = workers.ToString();

                    decimal d = (surfacearea / (workers * walls));
                    days = (int)Math.Ceiling(d);
                    txtDays.Text = days.ToString();


                }
                exteriorCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

       private void exteriorCostOfLabor()
        {
            try
            {

                int laborer = Convert.ToInt32(txtLaborer.Text);
                int days = Convert.ToInt32(txtDays.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int mason = Convert.ToInt32(txtMason.Text);
                int masonValue = Convert.ToInt32(txtMasonValue.Text);

                int a = (laborer * days * laborerValue) + (mason * days * masonValue);
                txtCostOfLabor.Text = a.ToString();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }

        private void interior()
        {

            try
            {
                decimal insurfacearea = Convert.ToDecimal(txtinSurfaceArea.Text);
                decimal inpreffered = Convert.ToDecimal(txtinPreffered.Text);
                decimal inwalls = Convert.ToDecimal(txtinCHBWalls.Text);

                decimal indays = Convert.ToDecimal(txtinDays.Text);
                decimal inworkers = Convert.ToDecimal(txtinWorkers.Text);

                decimal inmason = Convert.ToDecimal(txtinMason.Text);
                decimal inlaborer = Convert.ToDecimal(txtinLaborer.Text);

                decimal a = (insurfacearea / (inpreffered * inwalls));

                inmason = (int)Math.Ceiling(a);
                txtinMason.Text = inmason.ToString();

                if (inmason - 2 <= 0)
                {
                    txtinLaborer.Text = "1";
                }
                else
                {
                    decimal b = (inmason / 2);
                    inlaborer = (int)Math.Ceiling(b);
                    txtinLaborer.Text = inlaborer.ToString();

                    decimal c = inmason + inlaborer;
                    inworkers = (int)Math.Ceiling(c);
                    txtinWorkers.Text = inworkers.ToString();

                    decimal d = (insurfacearea / (inworkers * inwalls));
                    indays = (int)Math.Ceiling(d);
                    txtinDays.Text = indays.ToString();


                }
                interiorCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void interiorCostOfLabor()
        {
            try
            {

                int inlaborer = Convert.ToInt32(txtinLaborer.Text);
                int indays = Convert.ToInt32(txtinDays.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int inmason = Convert.ToInt32(txtinMason.Text);
                int masonValue = Convert.ToInt32(txtMasonValue.Text);

                int a = (inlaborer * indays * laborerValue) + (inmason * indays * masonValue);
                txtinCostOfLabor.Text = a.ToString();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                   txtCHBWalls.Text = valueOne.Text;
                    exteriorTwo();

                }
                else
                {
                    txtCHBWalls.Text = valueTwo.Text;
                    exteriorTwo();
                }
            }
            catch (Exception)
            {


            }
        }

        private void frmMansoryWalls_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void txtSurfaceArea_TextChanged(object sender, EventArgs e)
        {
            if (txtSurfaceArea.Text == "" || txtSurfaceArea.Text == "0")
            {

            }
            else if (txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else
            {
                exteriorTwo();
            }
       
                    
        }

        private void txtPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtSurfaceArea.Text == "" || txtSurfaceArea.Text == "0")
            {

            }
            else if (txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else
            {
                exteriorTwo();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmExterior exterior = new frmExterior();
            exterior.ShowDialog();
            valueOne.Text = exterior.textbox1.Text;
            valueTwo.Text = exterior.textBox2.Text;
            txtCHBWalls.Text = "";

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    txtinCHBWalls.Text = txtDWall.Text;
                    interior();
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    txtinCHBWalls.Text = txtSix.Text;
                    interior();
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    txtinCHBWalls.Text = txtEight.Text;
                    interior();
                }

            }
            catch (Exception)
            {


            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmInterior interior = new frmInterior();
            interior.ShowDialog();
            txtDWall.Text = interior.textbox1.Text;
            txtSix.Text = interior.textBox2.Text;
            txtEight.Text = interior.textBox3.Text;
            txtinCHBWalls.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtinSurfaceArea_TextChanged(object sender, EventArgs e)
        {
            if (txtinSurfaceArea.Text == "" || txtinSurfaceArea.Text == "0")
            {

            }
            else if (txtinPreffered.Text == "" || txtinPreffered.Text == "0")
            {

            }
            else
            {
                interior();
            }
        }

        private void txtinPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtinSurfaceArea.Text == "" || txtinSurfaceArea.Text == "0")
            {

            }
            else if (txtinPreffered.Text == "" || txtinPreffered.Text == "0")
            {

            }
            else
            {
                interior();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
