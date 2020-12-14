using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CWDGS.Forms.Units
{
    public partial class b_steel : Form
    {

        private string conn;
        private MySqlConnection connect;

        string IDone;
        string IDtwo;
        string IDthree;
        string IDfour;
        string IDfive;
        string IDsix;
        string IDseven;

        public b_steel()
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
                string Query = "update b_steelrw " +
                        "set kilograms_per_day = case id " +
                        "when '" + IDone + "' then '" + txtFooting.Text + "' " +
                        "when '" + IDtwo + "' then '" + txtColumn.Text + "' " +
                        "when '" + IDthree + "' then '" + txtBeam.Text + "' " +
                        "when '" + IDfour + "' then '" + txtSlab.Text + "' " +
                        "when '" + IDfive + "' then '" + txtWalls.Text + "' " +
                        "when '" + IDsix + "' then '" + txtCHB.Text + "' " +
                        "when '" + IDseven + "' then '" + txtWood.Text + "' " +
                        "else kilograms_per_day " +
                        "end " +
                        "where id in ('" + IDone + "', '" + IDtwo + "', '" + IDthree + "', '" + IDfour + "', '" + IDfive + "', '" + IDsix + "', '" + IDseven + "')";
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
            string IDquery = "select id from b_steelrw";
            MySqlConnection IDconn = new MySqlConnection(conn);
            MySqlCommand IDcommand = new MySqlCommand(IDquery, IDconn);

            IDconn.Open();
            MySqlDataReader IDreader = IDcommand.ExecuteReader();

            IDreader.Read();
            IDone = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDtwo = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDthree = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDfour = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDfive = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDsix = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDseven = IDreader.GetValue(0).ToString();

            IDconn.Close();

            //VALUES
            string ValueQuery = "select kilograms_per_day from b_steelrw";
            MySqlConnection Valueconn = new MySqlConnection(conn);
            MySqlCommand Valuecommand = new MySqlCommand(ValueQuery, Valueconn);

            Valueconn.Open();
            MySqlDataReader IDvalue = Valuecommand.ExecuteReader();

            IDvalue.Read();
            txtFooting.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtColumn.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtBeam.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtSlab.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtWalls.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtCHB.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtWood.Text = IDvalue.GetValue(0).ToString();

            Valueconn.Close();
        }

        private void b_steel_Load(object sender, EventArgs e)
        {
            getInformation();

        }

        private void txtFooting_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCHB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFooting.Text == "" || txtColumn.Text == "" || txtBeam.Text == "" || txtSlab.Text == "" || txtWalls.Text == "" || txtCHB.Text == "" || txtWood.Text == "")
            {
                distribution_rate_error error = new distribution_rate_error();
                error.ShowDialog();
            }
            else
            {
                MessageBox.Show("Steel Reinforcement Work have been updated successfully.", "Construction Worker Distribution Guide System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                update();
                this.Hide();
            }
        }
    }
}
