using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Steel_Reinforcement_Work
{
    public partial class frmSRW : Form
    {
        public frmSRW()
        {
            InitializeComponent();
        }
        private void FootingsOne()
        {

            try
            {

                decimal fworkers = Convert.ToDecimal(txtFWorkers.Text);
                decimal fweight = Convert.ToDecimal(txtFWeight.Text);
                decimal footings = Convert.ToDecimal(txtFootings.Text);

                decimal fdays = Convert.ToDecimal(txtFDays.Text);

                decimal a = (fweight / (fworkers  * footings));
                fdays = (int)Math.Ceiling(a);
                txtFDays.Text = fdays.ToString();

                FCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }
        private void FootingsTwo()
        {
          
            decimal fweight = Convert.ToDecimal(txtFWeight.Text);
            decimal fpreffered = Convert.ToDecimal(txtFPreffered.Text);
            decimal footings = Convert.ToDecimal(txtFootings.Text);

            decimal fworkers = Convert.ToDecimal(txtFWorkers.Text);
            try
            {
                decimal a = (fweight / (fpreffered * footings));
                fworkers = (int)Math.Ceiling(a);
                txtFWorkers.Text = fworkers.ToString();
                txtFSteelMan.Text = fworkers.ToString();
                FootingsOne();
                FCostOfLabor();


            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");

            }
        }
        private void FCostOfLabor()
        {

            int costOfLabor = Convert.ToInt32(txtSteelManValue.Text);
            int fdays = Convert.ToInt32(txtFDays.Text);
            int fsteelman = Convert.ToInt32(txtFSteelMan.Text);

            try
            {
                int a = costOfLabor * fdays * fsteelman;
                txtFCostofLabor.Text = a.ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");

            }
        }

        private void ColumnOne()
        {

            try
            {

                decimal cworkers = Convert.ToDecimal(txtCWorkers.Text);
                decimal cweight = Convert.ToDecimal(txtCWeight.Text);
                decimal column = Convert.ToDecimal(txtColumn.Text);

                decimal cdays = Convert.ToDecimal(txtCDays.Text);

                decimal a = (cweight / (cworkers * column));
                cdays = (int)Math.Ceiling(a);
                txtCDays.Text = cdays.ToString();
                CCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }
        private void ColumnTwo()
        {

            decimal cweight = Convert.ToDecimal(txtCWeight.Text);
            decimal cpreffered = Convert.ToDecimal(txtCPreffered.Text);
            decimal column = Convert.ToDecimal(txtColumn.Text);

            decimal cworkers = Convert.ToDecimal(txtCWorkers.Text);
            try
            {
                decimal a = (cweight / (cpreffered * column));
                cworkers = (int)Math.Ceiling(a);
                txtCWorkers.Text = cworkers.ToString();
                txtCSteelMan.Text = cworkers.ToString();

                ColumnOne();
                CCostOfLabor();


            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");

            }
        }

        private void CCostOfLabor()
        {

            int costOfLabor = Convert.ToInt32(txtSteelManValue.Text);
            int cdays = Convert.ToInt32(txtCDays.Text);
            int csteelman = Convert.ToInt32(txtCSteelMan.Text);

            try
            {
                int a = costOfLabor * cdays * csteelman;
                txtCCostOfLabor.Text = a.ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");

            }
        }

        private void BeamOne()
        {

            try
            {

                decimal bworkers = Convert.ToDecimal(txtBWorkers.Text);
                decimal bweight = Convert.ToDecimal(txtBWeight.Text);
                decimal beam = Convert.ToDecimal(txtBeam.Text);

                decimal bdays = Convert.ToDecimal(txtBDays.Text);

                decimal a = (bweight / (bworkers * beam));
                bdays = (int)Math.Ceiling(a);
                txtBDays.Text = bdays.ToString();
                BCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void BeamTwo()
        {

            decimal bweight = Convert.ToDecimal(txtBWeight.Text);
            decimal bpreffered = Convert.ToDecimal(txtBPreffered.Text);
            decimal beam = Convert.ToDecimal(txtBeam.Text);

            decimal bworkers = Convert.ToDecimal(txtBWorkers.Text);
            try
            {
                decimal a = (bweight / (bpreffered * beam));
                bworkers = (int)Math.Ceiling(a);
                txtBWorkers.Text = bworkers.ToString();
                txtBSteelMan.Text = bworkers.ToString();

                BeamOne();
                BCostOfLabor();


            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");

            }
        }

        private void BCostOfLabor()
        {

            int costOfLabor = Convert.ToInt32(txtSteelManValue.Text);
            int bdays = Convert.ToInt32(txtBDays.Text);
            int bsteelman = Convert.ToInt32(txtBSteelMan.Text);

            try
            {
                int a = costOfLabor * bdays * bsteelman;
                txtBCostOfLabor.Text = a.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");

            }
        }

        private void SlabOne()
        {

            try
            {

                decimal sworkers = Convert.ToDecimal(txtSWorkers.Text);
                decimal sweight = Convert.ToDecimal(txtSWeight.Text);
                decimal slab = Convert.ToDecimal(txtSlab.Text);

                decimal sdays = Convert.ToDecimal(txtSDays.Text);

                decimal a = (sweight / (sworkers * slab));
                sdays = (int)Math.Ceiling(a);
                txtSDays.Text = sdays.ToString();
                SCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void SlabTwo()
        {

            decimal sweight = Convert.ToDecimal(txtSWeight.Text);
            decimal spreffered = Convert.ToDecimal(txtSPreffered.Text);
            decimal slab = Convert.ToDecimal(txtSlab.Text);

            decimal sworkers = Convert.ToDecimal(txtSWorkers.Text);
            try
            {
                decimal a = (sweight / (spreffered * slab));
                sworkers = (int)Math.Ceiling(a);
                txtSWorkers.Text = sworkers.ToString();
                txtSSteelMan.Text = sworkers.ToString();

                SlabOne();
                SCostOfLabor();


            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");

            }
        }

        private void SCostOfLabor()
        {

            int costOfLabor = Convert.ToInt32(txtSteelManValue.Text);
            int sdays = Convert.ToInt32(txtSDays.Text);
            int ssteelman = Convert.ToInt32(txtSSteelMan.Text);

            try
            {
                int a = costOfLabor * sdays * ssteelman;
                txtSCostOfLabor.Text = a.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");

            }
        }

        private void WallsOne()
        {

            try
            {

                decimal wworkers = Convert.ToDecimal(txtWWorkers.Text);
                decimal wweight = Convert.ToDecimal(txtWWeight.Text);
                decimal walls = Convert.ToDecimal(txtWalls.Text);

                decimal wdays = Convert.ToDecimal(txtWDays.Text);

                decimal a = (wweight / (wworkers * walls));
                wdays = (int)Math.Ceiling(a);
                txtWDays.Text = wdays.ToString();
                WCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void WallsTwo()
        {

            decimal wweight = Convert.ToDecimal(txtWWeight.Text);
            decimal wpreffered = Convert.ToDecimal(txtWPreffered.Text);
            decimal walls = Convert.ToDecimal(txtWalls.Text);

            decimal wworkers = Convert.ToDecimal(txtWWorkers.Text);
            try
            {
                decimal a = (wweight / (wpreffered * walls));
                wworkers = (int)Math.Ceiling(a);
                txtWWorkers.Text = wworkers.ToString();
                txtWSteelMan.Text = wworkers.ToString();

                WallsOne();
                WCostOfLabor();


            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");

            }
        }

        private void WCostOfLabor()
        {

            int costOfLabor = Convert.ToInt32(txtSteelManValue.Text);
            int wdays = Convert.ToInt32(txtWDays.Text);
            int wsteelman = Convert.ToInt32(txtWSteelMan.Text);

            try
            {
                int a = costOfLabor * wdays * wsteelman;
                txtWCostOfLabor.Text = a.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");

            }
        }

        private void WallsTypeOne()
        {

            try
            {

                decimal wtworkers = Convert.ToDecimal(txtWTWorkers.Text);
                decimal wtweight = Convert.ToDecimal(txtWTWeight.Text);
                decimal wallsType = Convert.ToInt32(txtWallType.Text);

                decimal wtdays = Convert.ToDecimal(txtWTDays.Text);

                decimal a = (wtweight / (wtworkers * wallsType));
                wtdays = (int)Math.Ceiling(a);
                txtWTDays.Text = wtdays.ToString();
                //WTCostOfLabor();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void WallsTypeTwo()
        {

            decimal wtweight = Convert.ToDecimal(txtWTWeight.Text);
            decimal wtpreffered = Convert.ToDecimal(txtWTPreffered.Text);
            decimal wallsType = Convert.ToInt32(txtWallType.Text);

            decimal wtworkers = Convert.ToDecimal(txtWTWorkers.Text);
            try
            {
                decimal a = (wtweight / (wtpreffered * wallsType));
                wtworkers = (int)Math.Ceiling(a);
                txtWTWorkers.Text = wtworkers.ToString();
                txtWTSteelMan.Text = wtworkers.ToString();

                WallsTypeOne();
                WTCostOfLabor();


            }
            catch (Exception e)
            {

                MessageBox.Show("message" + e);
            }
        }

        private void WTCostOfLabor()
        {

            int costOfLabor = Convert.ToInt32(txtSteelManValue.Text);
            int wtdays = Convert.ToInt32(txtWTDays.Text);
            int wtsteelman = Convert.ToInt32(txtWTSteelMan.Text);

            try
            {
                int a = costOfLabor * wtdays * wtsteelman;
                txtWTCostOfLabor.Text = a.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");

            }
        }

        private void txtFWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtFootings.Text == "")
            {

            }
            else if (txtFWeight.Text == "")
            {

            }
            else if (txtFWorkers.Text == "0")
            {

            }
            else
            {
                FootingsOne();
        
            }
        }

        private void txtFPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtFWeight.Text == "")
            {

            }
            else if (txtFPreffered.Text == "")
            {

            }
            else
            {
                FootingsTwo();
            }
        }

        private void txtFWeight_Enter(object sender, EventArgs e)
        {
            TextBox lbox = sender as TextBox;
            lbox.SelectAll();
        }

        private void txtFPreffered_Enter(object sender, EventArgs e)
        {
            TextBox lbox = sender as TextBox;
            lbox.SelectAll();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmFootings footings = new frmFootings();
            footings.ShowDialog();
            txtFootings.Text = footings.textbox1.Text; 
        }

        private void txtFootings_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtColumn.Text == "")
            {

            }
            else if (txtCWeight.Text == "")
            {

            }
            else if (txtCWorkers.Text == "0")
            {

            }
            else
            {
                ColumnOne();

            }
        }

        private void txtCPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtCWeight.Text == "")
            {

            }
            else if (txtCPreffered.Text == "")
            {

            }
            else
            {
                ColumnTwo();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            frmColumn column = new frmColumn();
            column.ShowDialog();
            txtColumn.Text = column.textbox1.Text;

        }

        private void txtCWeight_Enter(object sender, EventArgs e)
        {
            TextBox lbox = sender as TextBox;
            lbox.SelectAll();
        }

        private void txtCPreffered_Enter(object sender, EventArgs e)
        {
            TextBox lbox = sender as TextBox;
            lbox.SelectAll();
        }

        private void txtBWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtBeam.Text == "")
            {

            }
            else if (txtBWeight.Text == "")
            {

            }
            else if (txtBWorkers.Text == "0")
            {

            }
            else
            {
                BeamOne();

            }
        }

        private void txtBPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtBWeight.Text == "")
            {

            }
            else if (txtBPreffered.Text == "")
            {

            }
            else
            {
                BeamTwo();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBeam beam = new frmBeam();
            beam.ShowDialog();
            txtBeam.Text = beam.textbox1.Text;


        }

        private void txtSWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtSlab.Text == "")
            {

            }
            else if (txtSWeight.Text == "")
            {

            }
            else if (txtSWorkers.Text == "0")
            {

            }
            else
            {
                SlabOne();

            }
        }

        private void txtSPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtSWeight.Text == "")
            {

            }
            else if (txtSPreffered.Text == "")
            {

            }
            else
            {
                SlabTwo();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSlab slab = new frmSlab();
            slab.ShowDialog();
            txtSlab.Text = slab.textbox1.Text;


        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmWalls walls = new frmWalls();
            walls.ShowDialog();
            txtWalls.Text = walls.textbox1.Text;

        }

        private void txtWWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtWalls.Text == "")
            {

            }
            else if (txtWWeight.Text == "")
            {

            }
            else if (txtWWorkers.Text == "0")
            {

            }
            else
            {
                WallsOne();

            }
        }

        private void txtWPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtWWeight.Text == "")
            {

            }
            else if (txtWPreffered.Text == "")
            {

            }
            else
            {
                WallsTwo();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    txtWallType.Text = txtCHB.Text;
                    linkLabel6.Text = "kgs/day";
                    WallsTypeOne();
                    WallsTypeTwo();

                }
                else
                {
                    txtWallType.Text = txtWood.Text;
                    linkLabel6.Text = "sqm./day";
                    WallsTypeOne();
                    WallsTypeTwo();
                }
            }
            catch (Exception)
            {
            }
        }

        private void txtWTWeight_TextChanged(object sender, EventArgs e)
        {
            if (txtWTWorkers.Text == "0")
            {

            }
            else if (txtWTWeight.Text == "")
            {

            }
            else
            {
                WallsTypeOne();
            }
        }

        private void txtWTPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtWTPreffered.Text == "")
            {

            }
            else
            {
                WallsTypeTwo();
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmWallsType wallType = new frmWallsType();
            wallType.ShowDialog();
            txtCHB.Text = wallType.textBox1.Text;
            txtWood.Text = wallType.textBox2.Text;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
