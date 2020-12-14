using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CWDGS_version_1.Forms.New
{
    public partial class frmNew : Form
    {
        private string conn;
        private MySqlConnection connect;

        public frmNew()
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
        private void AddProject()
        {
            db_connection();
            string query = "INSERT INTO projects (name) VALUES (@name)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@name", txtProjectName.Text);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtProjectName.Text == "")
            {
                error.Visible = true;
                txtProjectName.Focus();
            }
            else
            {
                AddProject();
                MessageBox.Show("New Project Added : " + txtProjectName.Text, "Construction Worker Distribution Guide System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtProjectName.Text == "")
                error.Visible = true;
                else
                error.Visible = false;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProjectName.Clear();
            txtProjectName.Focus();
        }
    }
}
