using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using MaterialSkinExample;
using MySql.Data.MySqlClient;

namespace CWDGS_version_1.Forms.Bungalow.Earthworks
{
    public partial class frmEarthworks : Form
    {
        private string conn;
        private MySqlConnection connect;
        string mySoilType;
        int rate;

        public frmEarthworks()
        {
            InitializeComponent();
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

        //GET INFO
        private void getAllSoilType()
        {
            try
            {
                units_database();
                string query = "select soil_type from b_earthworks where project_id=" + MainForm.PassID;
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "b_earthworks");
                cbSoilType.DisplayMember = "soil_type";
                cbSoilType.ValueMember = "soil_type";
                cbSoilType.DataSource = ds.Tables["b_earthworks"];
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured!");
            }
        }
        private void getSoilType()
        {
            try
            {
                units_database();
                string query = "select * from b_earthworks where project_id='" +MainForm.PassID + "' order by (soil_type='" + mySoilType + "') desc";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "b_earthworks");
                cbSoilType.DisplayMember = "soil_type";
                cbSoilType.ValueMember = "soil_type";
                cbSoilType.DataSource = ds.Tables["b_earthworks"];
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured!");
            }
        }
        private void checkIfEmptyandGet()
        {
            db_connection();
            string queryID = "select soil_type from db_earthworks where project_id=" + MainForm.PassID;
            MySqlConnection connTwo = new MySqlConnection(conn);
            MySqlCommand commandTwo = new MySqlCommand(queryID, connTwo);
            connTwo.Open();
            MySqlDataReader reader = commandTwo.ExecuteReader();

            if (reader.Read())
            {
                if (reader.GetValue(0).ToString() == "")
                {
                   
                    getAllSoilType();
                    labelError.Visible = true;
                    cbSoilType.SelectedIndex = -1;
                   
                }
                else
                {
                    labelError.Visible = false;
                    mySoilType = reader.GetValue(0).ToString();
                    getSoilType();

                }
            }
            connTwo.Close();
        }
        private void getSoilTypeValue()
        {
            try
            {
                string SoilValue = this.cbSoilType.GetItemText(this.cbSoilType.SelectedItem);
                units_database();
                string queryID = "select cubic_meter_per_day from b_earthworks where soil_type='"+ SoilValue +"' ";
                MySqlConnection connTwo = new MySqlConnection(conn);
                MySqlCommand commandTwo = new MySqlCommand(queryID, connTwo);
                
                connTwo.Open();
                MySqlDataReader reader = commandTwo.ExecuteReader();
                if (reader.Read())
                {
                     txtCum.Text = reader.GetValue(0).ToString();
                }
                     connTwo.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void getRate()
        {
            db_connection();
            string queryID = "select rate from work_rate where workers = 'Laborer' and project_id=" + MainForm.PassID;
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

        //COMPUTATION
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
      

            int days = Convert.ToInt32(txtDays.Text);
            int labor = Convert.ToInt32(txtLabor.Text);

            try
            {
                int a = rate * labor * days;
                txtCost.Text = a.ToString();


            }
            catch (Exception)
            {
                MessageBox.Show("Note: Input value on the yellow cells");
       
            }
        }

        //SAVE & RETRIEVE DATA

        private void SaveData()
        {
            db_connection();
            string query = "update db_earthworks set soil_type= @type, " +
                "excavation=@x, " +
                "preffered_time=@y " +
                "where project_id=" + MainForm.PassID;
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {

                command.Parameters.AddWithValue("@type", cbSoilType.Text);
                command.Parameters.AddWithValue("@x", txtExcavation.Text);
                command.Parameters.AddWithValue("@y", txtPreffered.Text);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();

        }

        private void RetrieveData()
        {
            db_connection();
            string queryID = "select * from db_earthworks where project_id=" + MainForm.PassID;
            MySqlConnection connTwo = new MySqlConnection(conn);
            MySqlCommand commandTwo = new MySqlCommand(queryID, connTwo);
            connTwo.Open();
            MySqlDataReader reader = commandTwo.ExecuteReader();

            if (reader.Read())
            {
              
                txtExcavation.Text = reader.GetValue(3).ToString();
                txtPreffered.Text = reader.GetValue(4).ToString();

            }
            connTwo.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cbSoilType.Text))
                {
                    txtCum.Text = "";
                    txtExcavation.Enabled = false;
                    txtPreffered.Enabled = false;
                }
                else
                {
                    txtExcavation.Enabled = true;
                    txtPreffered.Enabled = true;
                    getSoilTypeValue();
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
            if (txtLabor.Text == "" || txtLabor.Text == "0")
            {
                MessageBox.Show("No Value");
            }
            else
            {
                MessageBox.Show("Data successfully updated", "Construction Worker Distribution Guide System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveData();
                this.Hide();
            }
        }
        private void txtExcavation_TextChanged(object sender, EventArgs e)
        {
            if (txtWorkers.Text == "0") {

            }
            else if (txtExcavation.Text == "") {

            }
            else{
                ComputationOne();
            }
        }
        private void txtPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtPreffered.Text == ""){

            }
            else{
                ComputationTwo();
            }
        }
        private void frmEarthworks_Load(object sender, EventArgs e)
        {
            getRate();
            checkIfEmptyandGet();
            if (string.IsNullOrEmpty(mySoilType))
            {

            }
            else
            {
                RetrieveData();
            }
           
        }
        private void txtExcavation_Click(object sender, EventArgs e)
        {
            txtExcavation.SelectAll();
        }
        private void txtPreffered_Click(object sender, EventArgs e)
        {
            txtPreffered.SelectAll();
        }
    }
}
