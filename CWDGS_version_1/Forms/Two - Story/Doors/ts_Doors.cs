using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Plastering_Works
{
    public partial class ts_Doors : Form
    {
        public ts_Doors()
        {
            InitializeComponent();
        }

        private void doorLockSets()
        {

            try
            {
                decimal sets = Convert.ToDecimal(txtSets.Text);
                decimal preffered = Convert.ToDecimal(txtPreffered.Text);
                decimal doorlocksets = Convert.ToDecimal(txtDoorLockSet.Text);

                decimal workers = Convert.ToDecimal(txtWorkers.Text);
                decimal a = (sets / (preffered * doorlocksets));
                workers = (int)Math.Ceiling(a);
                txtWorkers.Text = workers.ToString();
                txtDoorInstaller.Text = workers.ToString();

                decimal days = Convert.ToDecimal(txtDays.Text);
                decimal b = (sets / (workers * doorlocksets));
                days = (int)Math.Ceiling(b);
                txtDays.Text = days.ToString();

                decimal doorInstaller = Convert.ToDecimal(txtDoorInstaller.Text);
                decimal doorValue = Convert.ToDecimal(txtDoorInstallerValue.Text);
      

                decimal c = (doorInstaller * days * doorValue);

                txtCostOfLabor.Text = c.ToString();


            }

            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }
        private void door()
        {

            try
            {
                decimal Dsets = Convert.ToDecimal(txtDSets.Text);
                decimal Dpreffered = Convert.ToDecimal(txtDPreffered.Text);
                decimal Door = Convert.ToDecimal(txtDoor.Text);

                decimal Dworkers = Convert.ToDecimal(txtDWorkers.Text);
                decimal a = (Dsets / (Dpreffered * Door));
                Dworkers = (int)Math.Ceiling(a);
                txtDWorkers.Text = Dworkers.ToString();
                txtDDoorInstaller.Text = Dworkers.ToString();

                decimal Ddays = Convert.ToDecimal(txtDDays.Text);
                decimal b = (Dsets / (Dworkers * Door));
                Ddays = (int)Math.Ceiling(b);
                txtDDays.Text = Ddays.ToString();

                decimal DdoorInstaller = Convert.ToDecimal(txtDDoorInstaller.Text);
                decimal doorValue = Convert.ToDecimal(txtDoorInstallerValue.Text);


                decimal c = (DdoorInstaller * Ddays * doorValue);

                txtDCostOfLabor.Text = c.ToString();


            }

            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }
        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            if (txtSets.Text == "" || txtSets.Text == "0" || txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else
            {
                doorLockSets();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_DoorLockSet doorlockset = new frm_DoorLockSet();
            doorlockset.ShowDialog();
            txtDoorLockSet.Text = doorlockset.textbox1.Text;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Door door = new frm_Door();
            door.ShowDialog();
            txtDoor.Text = door.textbox1.Text;

        }

        private void txtPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtSets.Text == "" || txtSets.Text == "0" || txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else
            {
                doorLockSets();
            }
        }

        private void txtDSets_TextChanged(object sender, EventArgs e)
        {
            if (txtDSets.Text == "" || txtDSets.Text == "0" || txtDPreffered.Text == "" || txtDPreffered.Text == "0")
            {

            }
            else
            {
                door();
            }
        }

        private void txtDPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtDSets.Text == "" || txtDSets.Text == "0" || txtDPreffered.Text == "" || txtDPreffered.Text == "0")
            {

            }
            else
            {
                door();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
