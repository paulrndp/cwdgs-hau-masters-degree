using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkinExample;
using MySql.Data.MySqlClient;

namespace CWDGS_version_1.Forms.Bungalow.Formworks
{
    public partial class frmFormworks : Form
    {
        private string conn;
        private MySqlConnection connect;
        decimal unitFootings;
        decimal unitColumn;
        decimal unitBeam;
        decimal unitSlab;
        int carpenterRate;
        int laborerRate;


        private void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=construction_db;Uid=root;Pwd=;CharSet=utf8;default command timeout=3600;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException)
            {
                throw;
            }

        }
        private void units_database()
        {
            try
            {
                conn = "Server=localhost;Database=construction_units;Uid=root;Pwd=;CharSet=utf8;default command timeout=3600;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException)
            {
                throw;
            }
        }

        public frmFormworks()
        {
            InitializeComponent();
        }

        //GETINFO
        private void getUnitValue()
        {
            try
            {
                units_database();

                string query = "select square_meter_per_day from b_formworks where project_id=" + MainForm.PassID;

                //LABOR
                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, con);

                con.Open();
                MySqlDataReader dr = command.ExecuteReader();

                dr.Read();
                unitFootings = Convert.ToDecimal(dr.GetValue(0));
                dr.Read();
                unitColumn = Convert.ToDecimal(dr.GetValue(0));
                dr.Read();
                unitBeam = Convert.ToDecimal(dr.GetValue(0));
                dr.Read();
                unitSlab = Convert.ToDecimal(dr.GetValue(0));
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void getRate()
        {
            db_connection();
            string queryID = "select rate from work_rate where project_id'"+ MainForm.PassID +"' and id between 1 and 2";
            MySqlConnection connTwo = new MySqlConnection(conn);
            MySqlCommand commandTwo = new MySqlCommand(queryID, connTwo);
            connTwo.Open();
            MySqlDataReader reader = commandTwo.ExecuteReader();

            if (reader.Read())
            {
                rate = Convert.ToInt32(reader.GetValue(0).ToString());
            }
            connTwo.Close();

        }
        //FOOTING
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

        //COLUMN
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

        //BEAM
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

        //SLAB
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Close();
           
        }
    }
}
