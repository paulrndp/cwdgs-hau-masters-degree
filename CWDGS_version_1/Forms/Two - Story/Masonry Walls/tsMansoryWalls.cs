using CWDGS_version_1.Forms.Two___Story.Masonry_Walls;
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
    public partial class tsMansoryWalls : Form
    {
        public tsMansoryWalls()
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

                }

                decimal c = mason + laborer;
                workers = (int)Math.Ceiling(c);
                txtWorkers.Text = workers.ToString();

                decimal d = (surfacearea / (workers * walls));
                days = (int)Math.Ceiling(d);
                txtDays.Text = days.ToString();
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




                }
                decimal c = inmason + inlaborer;
                inworkers = (int)Math.Ceiling(c);
                txtinWorkers.Text = inworkers.ToString();

                decimal d = (insurfacearea / (inworkers * inwalls));
                indays = (int)Math.Ceiling(d);
                txtinDays.Text = indays.ToString();
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

        private void exteriorGF()
        {

            try
            {
                decimal EXTsurfacearea = Convert.ToDecimal(txtEXTArea.Text);
                decimal EXTpreffered = Convert.ToDecimal(txtEXTPreffered.Text);
                decimal EXTwalls = Convert.ToDecimal(txtEXTCHBWALLS.Text);

                decimal EXTdays = Convert.ToDecimal(txtEXTDays.Text);
                decimal EXTworkers = Convert.ToDecimal(txtEXTWorkers.Text);

                decimal EXTmason = Convert.ToDecimal(txtEXTMason.Text);
                decimal EXTlaborer = Convert.ToDecimal(txtEXTLaborer.Text);

                decimal a = (EXTsurfacearea / (EXTpreffered * EXTwalls));

                EXTmason = (int)Math.Ceiling(a);
                txtEXTMason.Text = EXTmason.ToString();

                if (EXTmason - 2 <= 0)
                {
                    txtEXTLaborer.Text = "1";
                }
                else
                {
                    decimal b = (EXTmason / 2);
                    EXTlaborer = (int)Math.Ceiling(b);
                    txtEXTLaborer.Text = EXTlaborer.ToString();




                }

                decimal c = EXTmason + EXTlaborer;
                EXTworkers = (int)Math.Ceiling(c);
                txtEXTWorkers.Text = EXTworkers.ToString();

                decimal d = (EXTsurfacearea / (EXTworkers * EXTwalls));
                EXTdays = (int)Math.Ceiling(d);
                txtEXTDays.Text = EXTdays.ToString();

                exteriorGFCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }
        private void exteriorGFCostOfLabor()
        {
            try
            {

                int EXTlaborer = Convert.ToInt32(txtEXTLaborer.Text);
                int EXTdays = Convert.ToInt32(txtEXTDays.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int EXTmason = Convert.ToInt32(txtEXTMason.Text);
                int masonValue = Convert.ToInt32(txtMasonValue.Text);

                int a = (EXTlaborer * EXTdays * laborerValue) + (EXTmason * EXTdays * masonValue);
                txtEXTCostOfLabor.Text = a.ToString();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }

        private void interiorGF()
        {

            try
            {
                decimal INTsurfacearea = Convert.ToDecimal(txtINTArea.Text);
                decimal INTpreffered = Convert.ToDecimal(txtINTPreffered.Text);
                decimal INTwalls = Convert.ToDecimal(txtINTCHBWalls.Text);

                decimal INTdays = Convert.ToDecimal(txtINTDays.Text);
                decimal INTworkers = Convert.ToDecimal(txtINTWorkers.Text);

                decimal INTmason = Convert.ToDecimal(txtINTMason.Text);
                decimal INTlaborer = Convert.ToDecimal(txtINTLabor.Text);

                decimal a = (INTsurfacearea / (INTpreffered * INTwalls));

                INTmason = (int)Math.Ceiling(a);
                txtINTMason.Text = INTmason.ToString();

                if (INTmason - 2 <= 0)
                {
                    txtINTLabor.Text = "1";
                }
                else
                {
                    decimal b = (INTmason / 2);
                    INTlaborer = (int)Math.Ceiling(b);
                    txtINTLabor.Text = INTlaborer.ToString();




                }

                decimal c = INTmason + INTlaborer;
                INTworkers = (int)Math.Ceiling(c);
                txtINTWorkers.Text = INTworkers.ToString();

                decimal d = (INTsurfacearea / (INTworkers * INTwalls));
                INTdays = (int)Math.Ceiling(d);
                txtINTDays.Text = INTdays.ToString();
                interiorGFCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }
        private void interiorGFCostOfLabor()
        {
            try
            {

                int INTlaborer = Convert.ToInt32(txtINTLabor.Text);
                int INTdays = Convert.ToInt32(txtINTDays.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int INTmason = Convert.ToInt32(txtINTMason.Text);
                int masonValue = Convert.ToInt32(txtMasonValue.Text);

                int a = (INTlaborer * INTdays * laborerValue) + (INTmason * INTdays * masonValue);
                txtINTCostOfLabor.Text = a.ToString();

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

        private void tsMansoryWalls_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;



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

        private void txtEXTArea_TextChanged(object sender, EventArgs e)
        {
            if (txtEXTArea.Text == "" || txtEXTArea.Text == "0")
            {

            }
            else if (txtEXTPreffered.Text == "" || txtEXTPreffered.Text == "0")
            {

            }
            else
            {
                exteriorGF();
            }
        }

        private void txtEXTPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtEXTArea.Text == "" || txtEXTArea.Text == "0")
            {

            }
            else if (txtEXTPreffered.Text == "" || txtEXTPreffered.Text == "0")
            {

            }
            else
            {
                exteriorGF();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (comboBox3.SelectedIndex == 0)
                {
                    txtEXTCHBWALLS.Text = valueEXTone.Text;
                    exteriorGF();

                }
                else
                {
                    txtEXTCHBWALLS.Text = valueEXTtwo.Text;
                    exteriorGF();
                }
            }
            catch (Exception)
            {


            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox4.SelectedIndex == 0)
                {
                    txtINTCHBWalls.Text = valueINTone.Text;
                    interiorGF();

                }
                else if (comboBox4.SelectedIndex == 1)
                {
                    txtINTCHBWalls.Text = txtINTtwo.Text;
                    interiorGF();
                }
                else if (comboBox4.SelectedIndex == 2)
                {
                    txtINTCHBWalls.Text = txtINTthree.Text;
                    interiorGF();
                }
            }
            catch (Exception)
            {


            }
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

        private void txtINTArea_TextChanged(object sender, EventArgs e)
        {
            if (txtINTArea.Text == "" || txtINTArea.Text == "0")
            {

            }
            else if (txtINTPreffered.Text == "" || txtINTPreffered.Text == "0")
            {

            }
            else
            {
                interiorGF();
            }
        }

        private void txtINTPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtINTArea.Text == "" || txtINTArea.Text == "0")
            {

            }
            else if (txtINTPreffered.Text == "" || txtINTPreffered.Text == "0")
            {

            }
            else
            {
                interiorGF();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            txExteriorGF EGF = new txExteriorGF();
            EGF.ShowDialog();
            valueEXTone.Text = EGF.textbox1.Text;
            valueEXTtwo.Text = EGF.textBox2.Text;
            txtEXTCHBWALLS.Text = "";


        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tsInteriorGF IGF = new tsInteriorGF();
            IGF.ShowDialog();
            valueINTone.Text = IGF.textbox1.Text;
            txtINTtwo.Text = IGF.textBox2.Text;
            txtINTthree.Text = IGF.textBox3.Text;
            txtINTCHBWalls.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
