using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CWDGS_version_1.Forms.Projects
{
    public partial class frmProjects : Form
    {
        private string conn;
        private MySqlConnection connect;

        public frmProjects()
        {
            InitializeComponent();
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
        public void DisplayData()
        {
            try
            {
                db_connection();
                string Query = "select id, name as 'Project Name' from projects";
                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand myCommand = new MySqlCommand(Query, myConn);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = myCommand;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgv.DataSource = dTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void frmProjects_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayData();
                dgv.Rows[0].Selected = false;
                dgv.Columns[0].Visible = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    id.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
