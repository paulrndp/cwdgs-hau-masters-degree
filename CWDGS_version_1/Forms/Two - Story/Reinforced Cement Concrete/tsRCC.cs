using CWDGS_version_1.Forms.Two___Story.Reinforced_Cement_Concrete;
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
    public partial class tsRCC : Form
    {
        public tsRCC()
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

        private void columnOneSF()
        {

            try
            {

                decimal SFvolumn = Convert.ToDecimal(txtSFVolumn.Text);
                decimal SFworkers = Convert.ToDecimal(txtSFWorkers.Text);
                decimal SFcolumn = Convert.ToDecimal(txtSFColumn.Text);

                decimal SFdays = Convert.ToDecimal(txtSFDays.Text);

                decimal a = (SFvolumn / (SFworkers * SFcolumn));
                SFdays = (int)Math.Ceiling(a);
                txtSFDays.Text = SFdays.ToString();
                columnSFCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void columnTwoSF()
        {

            try
            {

                decimal SFvolumn = Convert.ToDecimal(txtSFVolumn.Text);
                decimal SFpreffered = Convert.ToDecimal(txtSFPreffered.Text);
                decimal SFcolumn = Convert.ToDecimal(txtSFColumn.Text);

                decimal SFworkers = Convert.ToDecimal(txtSFWorkers.Text);

                decimal a = (SFvolumn * 2 / (SFpreffered * SFcolumn));
                SFworkers = (int)Math.Ceiling(a);
                txtSFWorkers.Text = SFworkers.ToString();
                columnOneSF();

                if (SFworkers - 2 <= 0)
                {
                    txtSFLaborer.Text = "1";
                }
                else
                {
                    decimal b = SFworkers - 2;
                    txtSFLaborer.Text = b.ToString();

                }

                if (SFworkers <= 1)
                {
                    txtSFMason.Text = "0";
                }
                else
                {

                    decimal SFlaborer = Convert.ToDecimal(txtSFLaborer.Text);
                    decimal c = SFworkers - SFlaborer;
                    txtSFMason.Text = c.ToString();
                }

                columnSFCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void columnSFCostOfLabor()
        {
            try
            {


                int SFlaborer = Convert.ToInt32(txtSFLaborer.Text);
                int SFdays = Convert.ToInt32(txtSFDays.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int SFmason = Convert.ToInt32(txtSFMason.Text);
                int masonValue = Convert.ToInt32(txtMasonValue.Text);



                int a = (SFlaborer * SFdays * laborerValue) + (SFmason * SFdays * masonValue);
                txtSFCostOfLabor.Text = a.ToString();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }

        private void beamOneRB()
        {

            try
            {

                decimal RBvolumn = Convert.ToDecimal(txtRBVolumn.Text);
                decimal Rbworkers = Convert.ToDecimal(txtRBWorkers.Text);
                decimal Rbeam = Convert.ToDecimal(txtRBBeam.Text);

                decimal Rbdays = Convert.ToDecimal(txtRBDays.Text);

                decimal a = (RBvolumn / (Rbworkers * Rbeam));
                Rbdays = (int)Math.Ceiling(a);
                txtRBDays.Text = Rbdays.ToString();
                beamRBCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void beamTwoRB()
        {

            try
            {

                decimal Rbvolumn = Convert.ToDecimal(txtRBVolumn.Text);
                decimal Rbpreffered = Convert.ToDecimal(txtRBPreffered.Text);
                decimal Rbeam = Convert.ToDecimal(txtRBBeam.Text);

                decimal Rbworkers = Convert.ToDecimal(txtRBWorkers.Text);

                decimal a = (Rbvolumn * 2 / (Rbpreffered * Rbeam));
                Rbworkers = (int)Math.Ceiling(a);
                txtRBWorkers.Text = Rbworkers.ToString();
                beamOneRB();

                if (Rbworkers - 2 <= 0)
                {
                    txtRBLabor.Text = "1";
                }
                else
                {
                    decimal b = Rbworkers - 2;
                    txtRBLabor.Text = b.ToString();

                }

                if (Rbworkers <= 1)
                {
                    txtRBMason.Text = "0";
                }
                else
                {

                    decimal Rblaborer = Convert.ToDecimal(txtRBLabor.Text);
                    decimal c = Rbworkers - Rblaborer;
                    txtRBMason.Text = c.ToString();
                }

                beamRBCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void beamRBCostOfLabor()
        {
            try
            {


                int Rblaborer = Convert.ToInt32(txtRBLabor.Text);
                int Rbdays = Convert.ToInt32(txtRBDays.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int Rbmason = Convert.ToInt32(txtRBMason.Text);
                int masonValue = Convert.ToInt32(txtMasonValue.Text);



                int a = (Rblaborer * Rbdays * laborerValue) + (Rbmason * Rbdays * masonValue);
                txtRBCostOfLabor.Text = a.ToString();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }

        private void slabOneSF()
        {

            try
            {

                decimal SFSvolumn = Convert.ToDecimal(txtSFSVolume.Text);
                decimal SFSworkers = Convert.ToDecimal(txtSFSWorkers.Text);
                decimal SFSslab = Convert.ToDecimal(txtSFSlab.Text);

                decimal SFSdays = Convert.ToDecimal(txtSFSDays.Text);

                decimal a = (SFSvolumn / (SFSworkers * SFSslab));
                SFSdays = (int)Math.Ceiling(a);
                txtSFSDays.Text = SFSdays.ToString();
                slabSFSCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void slabTwoSF()
        {

            try
            {

                decimal SFSvolumn = Convert.ToDecimal(txtSFSVolume.Text);
                decimal SFSpreffered = Convert.ToDecimal(txtSFSPreffered.Text);
                decimal SFSslab = Convert.ToDecimal(txtSFSlab.Text);

                decimal SFSworkers = Convert.ToDecimal(txtSFSWorkers.Text);

                decimal a = (SFSvolumn * 2 / (SFSpreffered * SFSslab));
                SFSworkers = (int)Math.Ceiling(a);
                txtSFSWorkers.Text = SFSworkers.ToString();
                slabOneSF();

                if (SFSworkers - 2 <= 0)
                {
                    txtSFSLabor.Text = "1";
                }
                else
                {
                    decimal b = SFSworkers - 2;
                    txtSFSLabor.Text = b.ToString();

                }

                if (SFSworkers <= 1)
                {
                    txtSFSMason.Text = "0";
                }
                else
                {

                    decimal SFSlaborer = Convert.ToDecimal(txtSFSLabor.Text);
                    decimal c = SFSworkers - SFSlaborer;
                    txtSFSMason.Text = c.ToString();
                }

                slabSFSCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void slabSFSCostOfLabor()
        {
            try
            {


                int SFSlaborer = Convert.ToInt32(txtSFSLabor.Text);
                int SFSdays = Convert.ToInt32(txtSFSDays.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int SFSmason = Convert.ToInt32(txtSFSMason.Text);
                int masonValue = Convert.ToInt32(txtMasonValue.Text);


                int a = (SFSlaborer * SFSdays * laborerValue) + (SFSmason * SFSdays * masonValue);
                txtSFSCostOfLabor.Text = a.ToString();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }

        private void SCOne()
        {

            try
            {

                decimal SCvolumn = Convert.ToDecimal(txtSCVolumn.Text);
                decimal SCworkers = Convert.ToDecimal(txtSCWorkers.Text);
                decimal SC = Convert.ToDecimal(txtStairCase.Text);

                decimal SCdays = Convert.ToDecimal(txtSCDays.Text);

                decimal a = (SCvolumn / (SCworkers * SC));
                SCdays = (int)Math.Ceiling(a);
                txtSCDays.Text = SCdays.ToString();
                SCCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void SCTwo()
        {

            try
            {

                decimal SCvolumn = Convert.ToDecimal(txtSCVolumn.Text);
                decimal SCpreffered = Convert.ToDecimal(txtSCPreffered.Text);
                decimal SC = Convert.ToDecimal(txtStairCase.Text);

                decimal SCworkers = Convert.ToDecimal(txtSCWorkers.Text);

                decimal a = (SCvolumn * 2 / (SCpreffered * SC));
                SCworkers = (int)Math.Ceiling(a);
                txtSCWorkers.Text = SCworkers.ToString();
                SCOne();

                if (SCworkers - 2 <= 0)
                {
                    txtSCLaborer.Text = "1";
                }
                else
                {
                    decimal b = SCworkers - 2;
                    txtSCLaborer.Text = b.ToString();

                }

                if (SCworkers <= 1)
                {
                    txtSCMason.Text = "0";
                }
                else
                {

                    decimal SClaborer = Convert.ToDecimal(txtSCLaborer.Text);
                    decimal c = SCworkers - SClaborer;
                    txtSCMason.Text = c.ToString();
                }
                SCCostOfLabor();
            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void SCCostOfLabor()
        {
            try
            {


                int SClaborer = Convert.ToInt32(txtSCLaborer.Text);
                int SCdays = Convert.ToInt32(txtSCDays.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int SCmason = Convert.ToInt32(txtSCMason.Text);
                int masonValue = Convert.ToInt32(txtMasonValue.Text);



                int a = (SClaborer * SCdays * laborerValue) + (SCmason * SCdays * masonValue);
                txtSCCostOfLabor.Text = a.ToString();

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

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void txtRBPreffered_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRBArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSFVolumn_TextChanged(object sender, EventArgs e)
        {
            if (txtSFVolumn.Text == "" || txtSFVolumn.Text == "0" || txtSFPreffered.Text == "" || txtSFPreffered.Text == "0")
            {

            }
            else
            {
                columnOneSF();
            }    
        }

        private void txtSFPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtSFVolumn.Text == "" || txtSFVolumn.Text == "0" || txtSFPreffered.Text == "" || txtSFPreffered.Text == "0")
            {

            }
            else
            {
                columnTwoSF();
            }
        }

        private void txtRBVolumn_TextChanged(object sender, EventArgs e)
        {
            if (txtRBVolumn.Text == "" || txtRBVolumn.Text == "0" || txtRBPreffered.Text == "" || txtRBPreffered.Text == "0")
            {

            }
            else
            {
                beamOneRB();
            }
        }

        private void txtRBPreffered_TextChanged_1(object sender, EventArgs e)
        {
            if (txtRBVolumn.Text == "" || txtRBVolumn.Text == "0" || txtRBPreffered.Text == "" || txtRBPreffered.Text == "0")
            {

            }
            else
            {
                beamTwoRB();
            }
        }

        private void txtSFSVolume_TextChanged(object sender, EventArgs e)
        {
            if (txtSFSVolume.Text == "" || txtSFSVolume.Text == "0" || txtSFSPreffered.Text == "" || txtSFSPreffered.Text == "0")
            {

            }
            else
            {
                slabOneSF();
            }
        }

        private void txtSFSPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtSFSVolume.Text == "" || txtSFSVolume.Text == "0" || txtSFSPreffered.Text == "" || txtSFSPreffered.Text == "0")
            {

            }
            else
            {
                slabTwoSF();
            }
        }

        private void txtSCVolumn_TextChanged(object sender, EventArgs e)
        {
            if (txtSCVolumn.Text == "" || txtSCVolumn.Text == "0" || txtSCPreffered.Text == "" || txtSCPreffered.Text == "0")
            {

            }
            else
            {
                SCOne();
            }
        }

        private void txtSCPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtSCVolumn.Text == "" || txtSCVolumn.Text == "0" || txtSCPreffered.Text == "" || txtSCPreffered.Text == "0")
            {

            }
            else
            {
                SCTwo();
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ts_column_sf columnsf = new ts_column_sf();
            columnsf.ShowDialog();
            txtSFColumn.Text = columnsf.textbox1.Text;
       
        }

        private void linkLabel6_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ts_beam_rb beamrb = new ts_beam_rb();
            beamrb.ShowDialog();
            txtRBBeam.Text = beamrb.textbox1.Text;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ts_slab_sf slabsf = new ts_slab_sf();
            slabsf.ShowDialog();
            txtSFSlab.Text = slabsf.textbox1.Text;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ts_staircase sc = new ts_staircase();
            sc.ShowDialog();
            txtStairCase.Text = sc.textbox1.Text;
        }

        private void tsRCC_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
