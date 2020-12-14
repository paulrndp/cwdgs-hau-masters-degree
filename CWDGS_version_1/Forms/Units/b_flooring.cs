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
    public partial class b_flooring : Form
    {
        private string conn;
        private MySqlConnection connect;
        string IDone;
        string IDtwo;
        string IDthree;
        string IDfour;
        string IDfive;
        string IDsix;

        string IDoneTB;
        string IDtwoTB;
        string IDthreeTB;
        string IDfourTB;
        string IDfiveTB;
        string IDsixTB;

        public b_flooring()
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
                string Query = "update b_flooring " +
                        "set square_meter_per_day = case id " +
                        "when '" + IDone + "' then '" + txtMosaic.Text + "' " +
                        "when '" + IDtwo + "' then '" + txtCeramic.Text + "' " +
                        "when '" + IDthree + "' then '" + txtVitrified.Text + "' " +
                        "when '" + IDfour + "' then '" + txtGranite.Text + "' " +
                        "when '" + IDfive + "' then '" + txtMarble.Text + "' " +
                        "when '" + IDsix + "' then '" + txtGlazed.Text + "' " +
                        "when '" + IDoneTB + "' then '" + txtMosaic_2.Text + "' " +
                        "when '" + IDtwoTB + "' then '" + txtCeramic_2.Text + "' " +
                        "when '" + IDthreeTB + "' then '" + txtVitrified_2.Text + "' " +
                        "when '" + IDfourTB + "' then '" + txtGranite_2.Text + "' " +
                        "when '" + IDfiveTB + "' then '" + txtMarble_2.Text + "' " +
                        "when '" + IDsixTB + "' then '" + txtGlazed_2.Text + "' " +
                        "else square_meter_per_day " +
                        "end " +
                        "where id in ('" + IDone + "', '" + IDtwo + "', '" + IDthree + "', '" + IDfour + "', '" + IDfive + "', '" + IDsix + "', '" + IDoneTB + "', '" + IDtwoTB + "', '" + IDthreeTB + "', '" + IDfourTB + "', '" + IDfiveTB + "', '" + IDsixTB + "')";
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


        private void getInformationEXC()
        {
            units_database();
            //ID
            string IDquery = "select id from b_flooring where part='EXC T&B'";
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

            IDconn.Close();

            //VALUES
            string ValueQuery = "select square_meter_per_day from b_flooring where part='EXC T&B'";
            MySqlConnection Valueconn = new MySqlConnection(conn);
            MySqlCommand Valuecommand = new MySqlCommand(ValueQuery, Valueconn);

            Valueconn.Open();
            MySqlDataReader IDvalue = Valuecommand.ExecuteReader();

            IDvalue.Read();
            txtMosaic.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtCeramic.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtVitrified.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtGranite.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtMarble.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtGlazed.Text = IDvalue.GetValue(0).ToString();

            Valueconn.Close();


        }
        private void getInformationTB()
        {
            units_database();
            //ID
            string IDquery = "select id from b_flooring where part='T&B'";
            MySqlConnection IDconn = new MySqlConnection(conn);
            MySqlCommand IDcommand = new MySqlCommand(IDquery, IDconn);

            IDconn.Open();
            MySqlDataReader IDreader = IDcommand.ExecuteReader();

            IDreader.Read();
            IDoneTB = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDtwoTB = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDthreeTB = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDfourTB = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDfiveTB = IDreader.GetValue(0).ToString();

            IDreader.Read();
            IDsixTB = IDreader.GetValue(0).ToString();

            IDconn.Close();

            //VALUES
            string ValueQuery = "select square_meter_per_day from b_flooring where part='T&B'";
            MySqlConnection Valueconn = new MySqlConnection(conn);
            MySqlCommand Valuecommand = new MySqlCommand(ValueQuery, Valueconn);

            Valueconn.Open();
            MySqlDataReader IDvalue = Valuecommand.ExecuteReader();

            IDvalue.Read();
            txtMosaic_2.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtCeramic_2.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtVitrified_2.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtGranite_2.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtMarble_2.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtGlazed_2.Text = IDvalue.GetValue(0).ToString();

            Valueconn.Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMosaic.Text == "" || txtCeramic.Text == "" || txtVitrified.Text == "" || txtGranite.Text == "" || txtMarble.Text == "" || txtGlazed.Text == "" || txtMosaic_2.Text == "" || txtCeramic_2.Text == "" || txtVitrified_2.Text == "" || txtGranite_2.Text == "" || txtMarble_2.Text == "" || txtGlazed_2.Text == "")
            {
                distribution_rate_error error = new distribution_rate_error();
                error.ShowDialog();
            }
            else
            {
                MessageBox.Show("Flooring have been updated successfully.", "Construction Worker Distribution Guide System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                update();
                this.Hide();
            }
        }

        private void b_flooring_Load(object sender, EventArgs e)
        {
            getInformationEXC();
            getInformationTB();
        }

        private void txtMosaic_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCeramic_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVitrified_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGranite_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMarble_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGlazed_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMosaic_2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCeramic_2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtVitrified_2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGranite_2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMarble_2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGlazed_2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
