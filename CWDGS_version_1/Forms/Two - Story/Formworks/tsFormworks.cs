using CWDGS_version_1.Forms.Two___Story.Formworks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Formworks
{
    public partial class tsFormworks : Form
    {
        public tsFormworks()
        {
            InitializeComponent();
        }
        private void footingsOne()
        {

            try
            {

                decimal area = Convert.ToDecimal(txtArea.Text);
                decimal carpenter = Convert.ToDecimal(txtCarpenter.Text);
                decimal footings = Convert.ToDecimal(txtFooting.Text);

                decimal days = Convert.ToDecimal(txtDays.Text);

                decimal a = (area / (carpenter * footings));
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

        private void footingCarpenter()
        {
            try
            {

                decimal area = Convert.ToDecimal(txtArea.Text);
                decimal preffered = Convert.ToDecimal(txtPreffered.Text);
                decimal footings = Convert.ToDecimal(txtFooting.Text);

                decimal laborer = Convert.ToDecimal(txtLaborer.Text);

                decimal carpenter = Convert.ToDecimal(txtCarpenter.Text);

                decimal workers = Convert.ToDecimal(txtWorkers.Text);


                decimal a = (area / (preffered * footings));
                carpenter = (int)Math.Ceiling(a);
                txtCarpenter.Text = carpenter.ToString();
                footingsOne();

                if (carpenter <= 0)
                {

                    txtLaborer.Text = "1";
                }
                else
                {

                    decimal b = carpenter / 2;
                    laborer = (int)Math.Ceiling(b);
                    txtLaborer.Text = laborer.ToString();

                    decimal c = carpenter + laborer;
                    workers = (int)Math.Ceiling(c);
                    txtWorkers.Text = workers.ToString();

                    footingCostOfLabor();

                }


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



                int days = Convert.ToInt32(txtDays.Text);
                int carpenter = Convert.ToInt32(txtCarpenter.Text);
                int laborer = Convert.ToInt32(txtLaborer.Text);

                int carpenterValue = Convert.ToInt32(txtCarpenterValue.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int a = (laborer * days * laborerValue) + (carpenter * days * carpenterValue);
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

                decimal carea = Convert.ToDecimal(txtCArea.Text);
                decimal ccarpenter = Convert.ToDecimal(txtCCarpenter.Text);
                decimal column = Convert.ToDecimal(txtColumn.Text);

                decimal cdays = Convert.ToDecimal(txtCDays.Text);

                decimal a = (carea / (ccarpenter * column));
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

        private void columnCarpenter()
        {
            try
            {

                decimal carea = Convert.ToDecimal(txtCArea.Text);
                decimal cpreffered = Convert.ToDecimal(txtCPreffered.Text);
                decimal column = Convert.ToDecimal(txtColumn.Text);

                decimal claborer = Convert.ToDecimal(txtCLaborer.Text);

                decimal ccarpenter = Convert.ToDecimal(txtCCarpenter.Text);

                decimal cworkers = Convert.ToDecimal(txtCWorkers.Text);


                decimal a = (carea / (cpreffered * column));
                ccarpenter = (int)Math.Ceiling(a);
                txtCCarpenter.Text = ccarpenter.ToString();
                columnOne();

                if (ccarpenter <= 0)
                {

                    txtCLaborer.Text = "1";
                }
                else
                {

                    decimal b = ccarpenter / 2;
                    claborer = (int)Math.Ceiling(b);
                    txtCLaborer.Text = claborer.ToString();

                    decimal c = ccarpenter + claborer;
                    cworkers = (int)Math.Ceiling(c);
                    txtCWorkers.Text = cworkers.ToString();

                    columnCostOfLabor();

                }


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



                int cdays = Convert.ToInt32(txtCDays.Text);
                int ccarpenter = Convert.ToInt32(txtCCarpenter.Text);
                int claborer = Convert.ToInt32(txtCLaborer.Text);

                int carpenterValue = Convert.ToInt32(txtCarpenterValue.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int a = (claborer * cdays * laborerValue) + (ccarpenter * cdays * carpenterValue);
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

                decimal barea = Convert.ToDecimal(txtBArea.Text);
                decimal bcarpenter = Convert.ToDecimal(txtBCarpenter.Text);
                decimal beam = Convert.ToDecimal(txtBeam.Text);

                decimal bdays = Convert.ToDecimal(txtBDays.Text);

                decimal a = (barea / (bcarpenter * beam));
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

        private void beamCarpenter()
        {
            try
            {

                decimal barea = Convert.ToDecimal(txtBArea.Text);
                decimal bpreffered = Convert.ToDecimal(txtBPreffered.Text);
                decimal beam = Convert.ToDecimal(txtBeam.Text);

                decimal blaborer = Convert.ToDecimal(txtBLaborer.Text);

                decimal bcarpenter = Convert.ToDecimal(txtBCarpenter.Text);

                decimal bworkers = Convert.ToDecimal(txtBWorkers.Text);


                decimal a = (barea / (bpreffered * beam));
                bcarpenter = (int)Math.Ceiling(a);
                txtBCarpenter.Text = bcarpenter.ToString();
                beamOne();

                if (bcarpenter <= 0)
                {

                    txtBLaborer.Text = "1";
                }
                else
                {

                    decimal b = bcarpenter / 2;
                    blaborer = (int)Math.Ceiling(b);
                    txtBLaborer.Text = blaborer.ToString();

                    decimal c = bcarpenter + blaborer;
                    bworkers = (int)Math.Ceiling(c);
                    txtBWorkers.Text = bworkers.ToString();

                    beamCostOfLabor();

                }


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



                int bdays = Convert.ToInt32(txtBDays.Text);
                int bcarpenter = Convert.ToInt32(txtBCarpenter.Text);
                int blaborer = Convert.ToInt32(txtBLaborer.Text);

                int carpenterValue = Convert.ToInt32(txtCarpenterValue.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int a = (blaborer * bdays * laborerValue) + (bcarpenter * bdays * carpenterValue);
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

                decimal sarea = Convert.ToDecimal(txtSArea.Text);
                decimal scarpenter = Convert.ToDecimal(txtSCarpenter.Text);
                decimal slab = Convert.ToDecimal(txtSlab.Text);

                decimal sdays = Convert.ToDecimal(txtSDays.Text);

                decimal a = (sarea / (scarpenter * slab));
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

        private void slabCarpenter()
        {
            try
            {

                decimal sarea = Convert.ToDecimal(txtSArea.Text);
                decimal spreffered = Convert.ToDecimal(txtSPreffered.Text);
                decimal slab = Convert.ToDecimal(txtSlab.Text);

                decimal slaborer = Convert.ToDecimal(txtSLaborer.Text);

                decimal scarpenter = Convert.ToDecimal(txtSCarpenter.Text);

                decimal sworkers = Convert.ToDecimal(txtSWorkers.Text);


                decimal a = (sarea / (spreffered * slab));
                scarpenter = (int)Math.Ceiling(a);
                txtSCarpenter.Text = scarpenter.ToString();
                slabOne();

                if (scarpenter <= 0)
                {

                    txtSLaborer.Text = "1";
                }
                else
                {

                    decimal b = scarpenter / 2;
                    slaborer = (int)Math.Ceiling(b);
                    txtSLaborer.Text = slaborer.ToString();

                    decimal c = scarpenter + slaborer;
                    sworkers = (int)Math.Ceiling(c);
                    txtSWorkers.Text = sworkers.ToString();

                    slabCostOfLabor();

                }


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



                int sdays = Convert.ToInt32(txtSDays.Text);
                int scarpenter = Convert.ToInt32(txtSCarpenter.Text);
                int slaborer = Convert.ToInt32(txtSLaborer.Text);

                int carpenterValue = Convert.ToInt32(txtCarpenterValue.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int a = (slaborer * sdays * laborerValue) + (scarpenter * sdays * carpenterValue);
                txtSCostOfLabor.Text = a.ToString();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }

        private void columnSFCarpenter()
        {
            try
            {

                decimal SFarea = Convert.ToDecimal(txtSFArea.Text);
                decimal SFpreffered = Convert.ToDecimal(txtSFPreffered.Text);
                decimal columnSF = Convert.ToDecimal(txtSFColumn.Text);

                decimal SFlaborer = Convert.ToDecimal(txtSFLaborer.Text);

                decimal SFcarpenter = Convert.ToDecimal(txtSFCarpenter.Text);

                decimal SFworkers = Convert.ToDecimal(txtSFWorkers.Text);
                decimal SFdays = Convert.ToDecimal(txtSFDays.Text);


                decimal a = (SFarea / (SFpreffered * columnSF));
                SFcarpenter = (int)Math.Ceiling(a);
                txtSFCarpenter.Text = SFcarpenter.ToString();
       

                if (SFcarpenter -2  <= 0)
                {

                    txtSFLaborer.Text = "1";
                }
                else
                {

                    decimal b = SFcarpenter / 2;
                    SFlaborer = (int)Math.Ceiling(b);
                    txtSFLaborer.Text = SFlaborer.ToString();

                }

                    decimal c = SFcarpenter + SFlaborer;
                    SFworkers = (int)Math.Ceiling(c);
                    txtSFWorkers.Text = SFworkers.ToString();

                    int newCarpenter = Convert.ToInt32(txtSFCarpenter.Text);
                    int newLaborer = Convert.ToInt32(txtSFLaborer.Text);

                    int d = newCarpenter + newLaborer;

                    txtSFWorkers.Text = d.ToString();

                    decimal e = (SFarea / (SFcarpenter * columnSF));
                    SFdays = (int)Math.Ceiling(e);
                    txtSFDays.Text = SFdays.ToString();


                    int carpenterValue = Convert.ToInt32(txtCarpenterValue.Text);
                    int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                    int myLabor = Convert.ToInt32(txtSFLaborer.Text);
                    int myDays = Convert.ToInt32(txtSFDays.Text);
                    int myCarpenter = Convert.ToInt32(txtSFCarpenter.Text);


                    int f = (myLabor * myDays * laborerValue) + (myCarpenter * myDays * carpenterValue);
                    txtSFCostOfLabor.Text = f.ToString();


            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }


        private void beamRBCarpenter()
        {
            try
            {

                decimal RbWeight = Convert.ToDecimal(txtRBArea.Text);
                decimal Rbpreffered = Convert.ToDecimal(txtRBPreffered.Text);
                decimal Rbeam = Convert.ToDecimal(txtRBBeam.Text);

                decimal Rblaborer = Convert.ToDecimal(txtRBLabor.Text);

                decimal Rbcarpenter = Convert.ToDecimal(txtRBCarpenter.Text);

                decimal Rbworkers = Convert.ToDecimal(txtRBWorkers.Text);
                decimal RbDays = Convert.ToDecimal(txtRBDays.Text);


                decimal a = (RbWeight / (Rbpreffered * Rbeam));
                Rbcarpenter = (int)Math.Ceiling(a);
                txtRBCarpenter.Text = Rbcarpenter.ToString();
     

                if (Rbcarpenter - 2 <= 0)
                {

                    txtRBLabor.Text = "1";
                }
                else
                {

                    decimal b = Rbcarpenter / 2;
                    Rblaborer = (int)Math.Ceiling(b);
                    txtRBLabor.Text = Rblaborer.ToString();

                }


                int newCarpenter = Convert.ToInt32(txtRBCarpenter.Text);
                int newLaborer = Convert.ToInt32(txtRBLabor.Text);

                int c = newCarpenter + newLaborer;
                txtRBWorkers.Text = c.ToString();

                decimal d = (RbWeight / (Rbcarpenter * Rbeam));
                RbDays = (int)Math.Ceiling(d);
                txtRBDays.Text = RbDays.ToString();


                int carpenterValue = Convert.ToInt32(txtCarpenterValue.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int myLabor = Convert.ToInt32(txtRBLabor.Text );
                int myDays = Convert.ToInt32(txtRBDays.Text );
                int myCarpenter = Convert.ToInt32(txtRBCarpenter.Text ); 

                
                int e = (myLabor * myDays * laborerValue) + (myCarpenter * myDays * carpenterValue);
                txtRBCostOfLabor.Text = e.ToString();


            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }


        private void SCCarpenter()
        {
            try
            {

                decimal SCWeight = Convert.ToDecimal(txtSCArea.Text);
                decimal SCpreffered = Convert.ToDecimal(txtSCPreffered.Text);
                decimal SC = Convert.ToDecimal(txtStairCase.Text);

                decimal SClaborer = Convert.ToDecimal(txtSCLaborer.Text);

                decimal SCcarpenter = Convert.ToDecimal(txtSCCarpenter.Text);

                decimal SCworkers = Convert.ToDecimal(txtSCWorkers.Text);
                decimal SCDays = Convert.ToDecimal(txtSCDays.Text);

           
                decimal a = (SCWeight * 2 / (SCpreffered * SC));
                SCworkers = (int)Math.Ceiling(a);
                txtSCWorkers.Text = SCworkers.ToString();

                decimal x = (SCWeight / (SCworkers * SC));
                SCDays = (int)Math.Ceiling(x);
                txtSCDays.Text = SCDays.ToString();


                if (SCworkers - 2 <= 0)
                {
                    txtSCLaborer.Text = "1";
                }
                else
                {

                    int thisWorkers = Convert.ToInt32(txtSCWorkers.Text);
                    int b = thisWorkers - 2;
                    txtSCLaborer.Text = b.ToString();

                }

                if (SCworkers <= 1)
                {
                    txtSCCarpenter.Text = "0";
                }
                else
                {
                    int thisLabor = Convert.ToInt32(txtSCLaborer.Text);
                    int thisWorkers = Convert.ToInt32(txtSCWorkers.Text);
                    int c = thisWorkers - thisLabor;
                    txtSCCarpenter.Text = c.ToString();
                }


                int myDay = Convert.ToInt32(txtSCDays.Text);
                int myCarpenter = Convert.ToInt32(txtSCCarpenter.Text);
                int myLabor = Convert.ToInt32(txtSCLaborer.Text);

                int carpenterValue = Convert.ToInt32(txtCarpenterValue.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int d = (myLabor * myDay * laborerValue) + (myCarpenter * myDay * carpenterValue);
                txtSCCostOfLabor.Text = d.ToString();



            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }
        }

     
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmF_footings footings = new frmF_footings();
            footings.ShowDialog();
            txtFooting.Text = footings.textbox1.Text;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmF_Column column = new frmF_Column();
            column.ShowDialog();
            txtColumn.Text = column.textbox1.Text;

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmF_Beam beam = new frmF_Beam();
            beam.ShowDialog();
            txtBeam.Text = beam.textbox1.Text;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmF_Slab slab = new frmF_Slab();
            slab.ShowDialog();
            txtSlab.Text = slab.textbox1.Text;
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            if (txtArea.Text == "")
            {

            }
            else if (txtPreffered.Text == "")
            {

            }
            else if (txtCarpenter.Text == "0")
            {
              
            }
            else
            { footingsOne(); }
        }

        private void txtPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else if (txtArea.Text == "")
            {

            }
            else
            {
                footingCarpenter();
            }
        }

        private void txtCarpenter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCArea_TextChanged(object sender, EventArgs e)
        {
            if (txtCArea.Text == "")
            {

            }
            else if (txtCPreffered.Text == "")
            {

            }
            else if (txtCCarpenter.Text == "0")
            {

            }
            else
            { columnOne(); }
        }

        private void txtCPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtCPreffered.Text == "" || txtCPreffered.Text == "0")
            {

            }
            else if (txtCArea.Text == "")
            {

            }
            else
            {
                columnCarpenter();
            }
        }

        private void txtBArea_TextChanged(object sender, EventArgs e)
        {
            if (txtBArea.Text == "")
            {

            }
            else if (txtBPreffered.Text == "")
            {

            }
            else if (txtBCarpenter.Text == "0")
            {

            }
            else
            { beamOne(); }
        }

        private void txtBPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtBPreffered.Text == "" || txtBPreffered.Text == "0")
            {

            }
            else if (txtBArea.Text == "")
            {

            }
            else
            {
                beamCarpenter();
            }
        }

        private void txtSArea_TextChanged(object sender, EventArgs e)
        {
            if (txtSArea.Text == "")
            {

            }
            else if (txtSPreffered.Text == "")
            {

            }
            else if (txtSCarpenter.Text == "0")
            {

            }
            else
            { slabOne(); }
        }

        private void txtSPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtSPreffered.Text == "" || txtSPreffered.Text == "0")
            {

            }
            else if (txtSArea.Text == "")
            {

            }
            else
            {
                slabCarpenter();
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (txtSCArea.Text == "" || txtSCArea.Text == "0" || txtSCPreffered.Text == "" || txtSCPreffered.Text == "0")
            {

            }
            else
            {
                SCCarpenter();
            }
        }

        private void txtSFArea_TextChanged(object sender, EventArgs e)
        {
            if (txtSFArea.Text == "" || txtSFArea.Text == "0" || txtSFPreffered.Text == "" || txtSFPreffered.Text == "0")
            {

            }
            else
            {
                columnSFCarpenter();
            }
        }

        private void txtSFPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtSFArea.Text == "" || txtSFArea.Text == "0" || txtSFPreffered.Text == "" || txtSFPreffered.Text == "0")
            {

            }
            else
            {
                columnSFCarpenter();
            }
        }

        private void txtRBArea_TextChanged(object sender, EventArgs e)
        {
            if (txtRBArea.Text == "" || txtRBArea.Text == "0" || txtRBPreffered.Text == "" || txtRBPreffered.Text == "0")
            {

            }
            else {
                beamCarpenter();
            }
        }

        private void txtRBPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtRBArea.Text == "" || txtRBArea.Text == "0" || txtRBPreffered.Text == "" || txtRBPreffered.Text == "0")
            {

            }
            else { beamRBCarpenter(); }
        }

        private void txtSCArea_TextChanged(object sender, EventArgs e)
        {
            if (txtSCArea.Text == "" || txtSCArea.Text == "0" || txtSCPreffered.Text == "" || txtSCPreffered.Text == "0")
            {

            }
            else
            {
                SCCarpenter();
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tsF_Column_SF colSF = new tsF_Column_SF();
            colSF.ShowDialog();
            txtSFColumn.Text = colSF.textbox1.Text;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tsF_Beam_RB rb = new tsF_Beam_RB();
            rb.ShowDialog();
            txtRBBeam.Text = rb.textbox1.Text;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ts_Staircase staircase = new ts_Staircase();
            staircase.ShowDialog();
            txtStairCase.Text = staircase.textbox1.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
