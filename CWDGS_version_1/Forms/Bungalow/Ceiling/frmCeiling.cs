using CWDGS_version_1.Forms.Bungalow.Plastering_Works;
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
    public partial class frmCeiling : Form
    {
        public frmCeiling()
        {
            InitializeComponent();
        }
        private void steelFrame()
        {

            try
            {

                decimal area = Convert.ToDecimal(txtArea.Text);
                decimal preffered = Convert.ToDecimal(txtPreffered.Text);
                decimal steelframe = Convert.ToDecimal(txtSteelFrame.Text);

                decimal carpenter = Convert.ToDecimal(txtCarpenter.Text);
                decimal laborer = Convert.ToDecimal(txtLaborer.Text);

                decimal a = (area / (preffered * steelframe));
                carpenter = (int)Math.Ceiling(a);
                txtCarpenter.Text = carpenter.ToString();

                decimal b = carpenter / 2;
                laborer = (int)Math.Ceiling(b);

                if (carpenter - 2 <= 0 )
                {
                    txtLaborer.Text = "1";

                }
                else
                {
                    txtLaborer.Text = laborer.ToString();

                }

                decimal c = carpenter + laborer;
                txtWorkers.Text = c.ToString();

             
                decimal workers = Convert.ToDecimal(txtWorkers.Text);
                decimal days = Convert.ToDecimal(txtDays.Text);
                decimal d = (area / (workers * steelframe));
                days = (int)Math.Ceiling(d);
                txtDays.Text = days.ToString();

                decimal laborerValue = Convert.ToDecimal(txtLaborerValue.Text);
                decimal carpenterValue = Convert.ToDecimal(txtCarpenterValue.Text);

                decimal e = (laborer + days + laborerValue) + (carpenter + days + carpenterValue);
                txtCostOfLabor.Text = e.ToString();


            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void plywood()
        {

            try
            {

                decimal Parea = Convert.ToDecimal(txtPArea.Text);
                decimal Ppreffered = Convert.ToDecimal(txtPPreffered.Text);
                decimal plywood = Convert.ToDecimal(txtPlywood.Text);

                decimal Pcarpenter = Convert.ToDecimal(txtPCarpenter.Text);
                decimal Plaborer = Convert.ToDecimal(txtPLaborer.Text);

                decimal a = (Parea / (Ppreffered * plywood));
                Pcarpenter = (int)Math.Ceiling(a);
                txtPCarpenter.Text = Pcarpenter.ToString();

                decimal b = Pcarpenter / 2;
                Plaborer = (int)Math.Ceiling(b);

                if (Pcarpenter - 2 <= 0)
                {
                    txtPLaborer.Text = "1";

                }
                else
                {
                    txtPLaborer.Text = Plaborer.ToString();

                }

                decimal c = Pcarpenter + Plaborer;
                txtPWorkers.Text = c.ToString();


                decimal Pworkers = Convert.ToDecimal(txtPWorkers.Text);
                decimal Pdays = Convert.ToDecimal(txtPDays.Text);
                decimal d = (Parea / (Pworkers * plywood));
                Pdays = (int)Math.Ceiling(d);
                txtPDays.Text = Pdays.ToString();

                decimal laborerValue = Convert.ToDecimal(txtLaborerValue.Text);
                decimal carpenterValue = Convert.ToDecimal(txtCarpenterValue.Text);

                decimal e = (Plaborer + Pdays + laborerValue) + (Pcarpenter + Pdays + carpenterValue);
                txtPCostOfLabor.Text = e.ToString();


            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmSteelFrame mySteelFrame = new frmSteelFrame();
            mySteelFrame.ShowDialog();
            txtSteelFrame.Text = mySteelFrame.textbox1.Text;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frm_Door mydoor = new frm_Door();
            mydoor.ShowDialog();
            txtPlywood.Text = mydoor.textbox1.Text;


        }


        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            if (txtArea.Text == "" || txtArea.Text == "0" || txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else
            {
                steelFrame();
            }
        }

        private void txtPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtArea.Text == "" || txtArea.Text == "0" || txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else
            {
                steelFrame();
            }
        }

        private void txtCarpenter_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCArea_TextChanged(object sender, EventArgs e)
        {
            if (txtPArea.Text == "" || txtPArea.Text == "0" || txtPPreffered.Text == "" || txtPPreffered.Text == "0")
            {

            }
            else
            {
                plywood();
            }
        }

        private void txtCPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtPArea.Text == "" || txtPArea.Text == "0" || txtPPreffered.Text == "" || txtPPreffered.Text == "0")
            {

            }
            else
            {
                plywood();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
