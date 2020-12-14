using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Reinforced_Cement_Concrete
{
    public partial class frmRCC : Form
    {
        public frmRCC()
        {
            InitializeComponent();
        }

        private void footingsOne()
        {

            try
            {

                decimal volumn = Convert.ToDecimal(txtVolumn.Text);
                decimal workers = Convert.ToDecimal(txtWorkers.Text);
                decimal footings = Convert.ToDecimal(txtFooting.Text);

                decimal days = Convert.ToDecimal(txtDays.Text);

                decimal a = (volumn / (workers * footings));
                days = (int)Math.Ceiling(a);
                txtDays.Text = days.ToString();
                footingCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void footingsTwo()
        {

            try
            {

                decimal volumn = Convert.ToDecimal(txtVolumn.Text);
                decimal preffered = Convert.ToDecimal(txtPreffered.Text);
                decimal footings = Convert.ToDecimal(txtFooting.Text);

                decimal workers = Convert.ToDecimal(txtWorkers.Text);

                decimal a = (volumn * 2 / (preffered * footings));
                workers = (int)Math.Ceiling(a);
                txtWorkers.Text = workers.ToString();
                footingsOne();

                if (workers - 2 <= 0 )
                {
                    txtLaborer.Text = "1";
                }
                else
                {
                    decimal b = workers - 2;
                    txtLaborer.Text = b.ToString();

                }

                if (workers <= 1)
                {
                    txtMason.Text = "0";
                }
                else
                {

                    decimal laborer = Convert.ToDecimal(txtLaborer.Text);
                    decimal c = workers - laborer;
                    txtMason.Text = c.ToString();
                }
                footingCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void footingCostOfLabor()
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

        private void columnOne()
        {

            try
            {

                decimal cvolumn = Convert.ToDecimal(txtCVolumn.Text);
                decimal cworkers = Convert.ToDecimal(txtCWorkers.Text);
                decimal column = Convert.ToDecimal(txtColumn.Text);

                decimal cdays = Convert.ToDecimal(txtDays.Text);

                decimal a = (cvolumn / (cworkers * column));
                cdays = (int)Math.Ceiling(a);
                txtCDays.Text = cdays.ToString();
                columnCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void columnTwo()
        {

            try
            {

                decimal cvolumn = Convert.ToDecimal(txtCVolumn.Text);
                decimal cpreffered = Convert.ToDecimal(txtCPreffered.Text);
                decimal column = Convert.ToDecimal(txtColumn.Text);

                decimal cworkers = Convert.ToDecimal(txtCWorkers.Text);

                decimal a = (cvolumn * 2 / (cpreffered * column));
                cworkers = (int)Math.Ceiling(a);
                txtCWorkers.Text = cworkers.ToString();
                columnOne();

                if (cworkers - 2 <= 0)
                {
                    txtCLaborer.Text = "1";
                }
                else
                {
                    decimal b = cworkers - 2;
                    txtCLaborer.Text = b.ToString();

                }

                if (cworkers <= 1)
                {
                    txtCMason.Text = "0";
                }
                else
                {

                    decimal claborer = Convert.ToDecimal(txtCLaborer.Text);
                    decimal c = cworkers - claborer;
                    txtCMason.Text = c.ToString();
                }

                columnCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void columnCostOfLabor()
        {
            try
            {


                int claborer = Convert.ToInt32(txtCLaborer.Text);
                int cdays = Convert.ToInt32(txtCDays.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int cmason = Convert.ToInt32(txtCMason.Text);
                int masonValue = Convert.ToInt32(txtMasonValue.Text);



                int a = (claborer * cdays * laborerValue) + (cmason * cdays * masonValue);
                txtCCostOfLabor.Text = a.ToString();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }

        private void beamOne()
        {

            try
            {

                decimal bvolumn = Convert.ToDecimal(txtBVolumn.Text);
                decimal bworkers = Convert.ToDecimal(txtBWorkers.Text);
                decimal beam = Convert.ToDecimal(txtBeam.Text);

                decimal bdays = Convert.ToDecimal(txtBDays.Text);

                decimal a = (bvolumn / (bworkers * beam));
                bdays = (int)Math.Ceiling(a);
                txtBDays.Text = bdays.ToString();
                beamCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void beamTwo()
        {

            try
            {

                decimal bvolumn = Convert.ToDecimal(txtBVolumn.Text);
                decimal bpreffered = Convert.ToDecimal(txtBPreffered.Text);
                decimal beam = Convert.ToDecimal(txtBeam.Text);

                decimal bworkers = Convert.ToDecimal(txtBWorkers.Text);

                decimal a = (bvolumn * 2 / (bpreffered * beam));
                bworkers = (int)Math.Ceiling(a);
                txtBWorkers.Text = bworkers.ToString();
                beamOne();

                if (bworkers - 2 <= 0)
                {
                    txtBLaborer.Text = "1";
                }
                else
                {
                    decimal b = bworkers - 2;
                    txtBLaborer.Text = b.ToString();

                }

                if (bworkers <= 1)
                {
                    txtBMason.Text = "0";
                }
                else
                {

                    decimal blaborer = Convert.ToDecimal(txtBLaborer.Text);
                    decimal c = bworkers - blaborer;
                    txtBMason.Text = c.ToString();
                }

                beamCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void beamCostOfLabor()
        {
            try
            {


                int blaborer = Convert.ToInt32(txtBLaborer.Text);
                int bdays = Convert.ToInt32(txtBDays.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int bmason = Convert.ToInt32(txtBMason.Text);
                int masonValue = Convert.ToInt32(txtMasonValue.Text);



                int a = (blaborer * bdays * laborerValue) + (bmason * bdays * masonValue);
                txtBCostOfLabor.Text = a.ToString();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }

        private void slabOne()
        {

            try
            {

                decimal svolumn = Convert.ToDecimal(txtSVolumn.Text);
                decimal sworkers = Convert.ToDecimal(txtSWorkers.Text);
                decimal slab = Convert.ToDecimal(txtSlab.Text);

                decimal sdays = Convert.ToDecimal(txtSDays.Text);

                decimal a = (svolumn / (sworkers * slab));
                sdays = (int)Math.Ceiling(a);
                txtSDays.Text = sdays.ToString();
                slabCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void slabTwo()
        {

            try
            {

                decimal svolumn = Convert.ToDecimal(txtSVolumn.Text);
                decimal spreffered = Convert.ToDecimal(txtSPreffered.Text);
                decimal slab = Convert.ToDecimal(txtSlab.Text);

                decimal sworkers = Convert.ToDecimal(txtSWorkers.Text);

                decimal a = (svolumn * 2 / (spreffered * slab));
                sworkers = (int)Math.Ceiling(a);
                txtSWorkers.Text = sworkers.ToString();
                slabOne();

                if (sworkers - 2 <= 0)
                {
                    txtSLaborer.Text = "1";
                }
                else
                {
                    decimal b = sworkers - 2;
                    txtSLaborer.Text = b.ToString();

                }

                if (sworkers <= 1)
                {
                    txtSMason.Text = "0";
                }
                else
                {

                    decimal slaborer = Convert.ToDecimal(txtSLaborer.Text);
                    decimal c = sworkers - slaborer;
                    txtSMason.Text = c.ToString();
                }

                slabCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void slabCostOfLabor()
        {
            try
            {


                int slaborer = Convert.ToInt32(txtSLaborer.Text);
                int sdays = Convert.ToInt32(txtSDays.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int smason = Convert.ToInt32(txtSMason.Text);
                int masonValue = Convert.ToInt32(txtMasonValue.Text);



                int a = (slaborer * sdays * laborerValue) + (smason * sdays * masonValue);
                txtSCostOfLabor.Text = a.ToString();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRR_footings footings = new frmRR_footings();
            footings.ShowDialog();
            txtFooting.Text = footings.textbox1.Text;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRR_clumn column = new frmRR_clumn();
            column.ShowDialog();
            txtColumn.Text = column.textbox1.Text;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRR_beam beam = new frmRR_beam();
            beam.ShowDialog();
            txtBeam.Text = beam.textbox1.Text;

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRR_slab slab = new frmRR_slab();
            slab.ShowDialog();
            txtSlab.Text = slab.textbox1.Text;

        }

        private void txtSVolumn_TextChanged(object sender, EventArgs e)
        {
            if (txtSVolumn.Text == "" || txtSVolumn.Text == "0")
            {

            }
            else if (txtSlab.Text == "")
            {

            }
            else if (txtSWorkers.Text == "0" || txtSWorkers.Text == "")
            {

            }
            else
            {
                slabOne();
                //footingsTwo();
            }
        }

        private void txtVolumn_TextChanged(object sender, EventArgs e)
        {
            if (txtVolumn.Text == "" || txtVolumn.Text == "0")
            {

            }
            else if (txtFooting.Text == "")
            {

            }
            else if (txtWorkers.Text == "0" || txtWorkers.Text == "")
            {

            }
            else
            {
                footingsOne();
                //footingsTwo();
            }
        }

        private void txtPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else if (txtVolumn.Text == "" || txtVolumn.Text == "0")
            {

            }
            else
            {
                footingsTwo();
            }
        }

        private void txtCVolumn_TextChanged(object sender, EventArgs e)
        {
            if (txtCVolumn.Text == "" || txtCVolumn.Text == "0")
            {

            }
            else if (txtColumn.Text == "")
            {

            }
            else if (txtCWorkers.Text == "0" || txtCWorkers.Text == "")
            {

            }
            else
            {
                columnOne();
                //footingsTwo();
            }
        }

        private void txtCPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtCPreffered.Text == "" || txtCPreffered.Text == "0")
            {

            }
            else if (txtCVolumn.Text == "" || txtCVolumn.Text == "0")
            {

            }
            else
            {
                columnTwo();
            }
        }

        private void txtBVolumn_TextChanged(object sender, EventArgs e)
        {
            if (txtBVolumn.Text == "" || txtBVolumn.Text == "0")
            {

            }
            else if (txtBeam.Text == "")
            {

            }
            else if (txtBWorkers.Text == "0" || txtBWorkers.Text == "")
            {

            }
            else
            {
                beamOne();
                //footingsTwo();
            }
        }

        private void txtBPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtBPreffered.Text == "" || txtBPreffered.Text == "0")
            {

            }
            else if (txtBeam.Text == "" || txtBeam.Text == "0")
            {

            }
            else
            {
                beamTwo();
            }
        }

        private void txtSPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtSPreffered.Text == "" || txtSPreffered.Text == "0")
            {

            }
            else if (txtSlab.Text == "" || txtSlab.Text == "0")
            {

            }
            else
            {
                slabTwo();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
