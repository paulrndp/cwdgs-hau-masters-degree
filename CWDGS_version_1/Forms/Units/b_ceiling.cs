﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CWDGS.Forms;
using MySql.Data.MySqlClient;



namespace CWDGS_version_1.Forms.Bungalow.Units
{
    public partial class frmUnits : Form
    {
        private string conn;
        private MySqlConnection connect;
        string IDone;
        string IDtwo;
        public frmUnits()
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
        private void update()
        {
            try
            {
                units_database();
                string Query = "update b_ceiling " +
                        "set square_meter_per_day = case id " +
                        "when '" + IDone + "' then '" + txtSteel.Text + "' " +
                        "when '" + IDtwo + "' then '" + txtPlywood.Text + "' " +
                        "else square_meter_per_day " +
                        "end " +
                        "where id in ('" + IDone + "', '" + IDtwo + "')";
                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand myCommand = new MySqlCommand(Query, myConn);
                MySqlDataReader reader;
                myConn.Open();
                reader = myCommand.ExecuteReader();
                if (reader.Read())
                {
                }
                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void getInformation()
        {
            units_database();
            //ID
            string IDquery = "select id from b_ceiling";
            MySqlConnection IDconn = new MySqlConnection(conn);
            MySqlCommand IDcommand = new MySqlCommand(IDquery, IDconn);

            IDconn.Open();
            MySqlDataReader IDreader = IDcommand.ExecuteReader();

            IDreader.Read();
            IDone = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDtwo = IDreader.GetValue(0).ToString();

            IDconn.Close();

            //VALUES
            string ValueQuery = "select square_meter_per_day from b_ceiling";
            MySqlConnection Valueconn = new MySqlConnection(conn);
            MySqlCommand Valuecommand = new MySqlCommand(ValueQuery, Valueconn);

            Valueconn.Open();
            MySqlDataReader IDvalue = Valuecommand.ExecuteReader();

            IDvalue.Read();
            txtSteel.Text = IDvalue.GetValue(0).ToString();
            
            IDvalue.Read();
            txtPlywood.Text = IDvalue.GetValue(0).ToString();

            Valueconn.Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSteel.Text == "" || txtPlywood.Text == "")
            {
                distribution_rate_error error = new distribution_rate_error();
                error.ShowDialog();
            }
            else
            {
                MessageBox.Show("Ceiling have been updated successfully.", "Construction Worker Distribution Guide System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                update();
                this.Hide();
            }
        }
        private void frmUnits_Load(object sender, EventArgs e)
        {
            getInformation();
        }
        private void txtSteel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtPlywood_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
