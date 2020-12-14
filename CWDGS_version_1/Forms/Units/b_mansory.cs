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
    public partial class b_mansory : Form
    {
        private string conn;
        private MySqlConnection connect;
        string IDone;
        string IDtwo;
        string IDthree;
        string IDfour;
        string IDfive;

        public b_mansory()
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
                string Query = "update b_mansorywalls " +
                        "set square_meter_per_day = case id " +
                        "when '" + IDone + "' then '" + txt8.Text + "' " +
                        "when '" + IDtwo + "' then '" + txt6.Text + "' " +
                        "when '" + IDthree + "' then '" + txtDwall.Text + "' " +
                        "when '" + IDfour + "' then '" + txt6_2.Text + "' " +
                        "when '" + IDfive + "' then '" + txt8_2.Text + "' " +
                        "else square_meter_per_day " +
                        "end " +
                        "where id in ('" + IDone + "', '" + IDtwo + "', '" + IDthree + "', '" + IDfour + "', '" + IDfive + "')";
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
            string IDquery = "select id from b_mansorywalls";
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

            IDconn.Close();

            //VALUES
            string ValueQuery = "select square_meter_per_day from b_mansorywalls";
            MySqlConnection Valueconn = new MySqlConnection(conn);
            MySqlCommand Valuecommand = new MySqlCommand(ValueQuery, Valueconn);

            Valueconn.Open();
            MySqlDataReader IDvalue = Valuecommand.ExecuteReader();

            IDvalue.Read();
            txt8.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txt6.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txtDwall.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txt6_2.Text = IDvalue.GetValue(0).ToString();

            IDvalue.Read();
            txt8_2.Text = IDvalue.GetValue(0).ToString();


            Valueconn.Close();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt6.Text == "" || txt8.Text == "" || txtDwall.Text == "" || txt6_2.Text == "" || txt8_2.Text == "" )
            {
                distribution_rate_error error = new distribution_rate_error();
                error.ShowDialog();
            }
            else
            {
                MessageBox.Show("Mansory Walls have been updated successfully.", "Construction Worker Distribution Guide System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                update();
                this.Hide();
            }
        }

        private void b_mansory_Load(object sender, EventArgs e)
        {
            getInformation();
        }

        private void txt8_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDwall_KeyPress(object sender, KeyPressEventArgs e)
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
