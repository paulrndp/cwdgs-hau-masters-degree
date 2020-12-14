using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkinExample;
using MySql.Data.MySqlClient;

namespace CWDGS.Forms
{
    public partial class distribution_rate : Form
    {
        private string conn;
        private MySqlConnection connect;
        bool getError = true;
        public distribution_rate()
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
        private void GetNextID()
        {
            db_connection();
            string queryID = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = 'construction_db' AND TABLE_NAME = 'projects';";
            MySqlConnection connTwo = new MySqlConnection(conn);
            MySqlCommand commandTwo = new MySqlCommand(queryID, connTwo);
            connTwo.Open();
            MySqlDataReader reader = commandTwo.ExecuteReader();

            if (reader.Read())
            {
                nextID.Text = reader.GetValue(0).ToString();
            }

            connTwo.Close();
        }
        private void CheckError()
        {
            if (labor_1.Text == "" || labor_2.Text == "" || labor_3.Text == "" || labor_4.Text == "" || labor_5.Text == "")
            {
                getError = true;
       

            }
            else if (mason_1.Text == "" || mason_2.Text == "" || mason_3.Text == "" || mason_4.Text == "" || mason_5.Text == "")
            {
                getError = true;
    
            }
            else if (steel_1.Text == "" || steel_2.Text == "" || steel_3.Text == "" || steel_4.Text == "" || steel_5.Text == "")
            {
                getError = true;
            }
            else if (rateCarpenter.Text == "" || txtLaborer.Text == "" || txtMason.Text == "" || txtSteel.Text == "" || txtPainter.Text == "" || txtTile.Text == "" || txtDoor.Text == "")
            {
                getError = true;
            }
            else
            {
                getError = false;
            }

        }
        private void addProject()
        {
            db_connection();
            string query = "INSERT INTO projects (name,style) VALUES (Upper(@name), (@style))";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
            command.Parameters.AddWithValue("@name", MainForm.projectName);
            command.Parameters.AddWithValue("@style", MainForm.projectStyle);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void addRate()
        {
            db_connection();
            string query = "INSERT INTO work_rate (project_id, workers, rate) VALUES " +
                "(@project_id, @carpenter, @rate_carpenter)," +
                "(@project_id, @laborer, @rate_laborer)," +
                "(@project_id, @mason, @rate_mason)," +
                "(@project_id, @steel, @rate_steel)," +
                "(@project_id, @painter, @rate_painter)," +
                "(@project_id, @tile, @rate_tile)," +
                "(@project_id, @door, @rate_door)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
            command.Parameters.AddWithValue("@project_id", nextID.Text);

            command.Parameters.AddWithValue("@carpenter", "Carpenter");
            command.Parameters.AddWithValue("@rate_carpenter", rateCarpenter.Text);

            command.Parameters.AddWithValue("@laborer", "Laborer");
            command.Parameters.AddWithValue("@rate_laborer", txtLaborer.Text);

            command.Parameters.AddWithValue("@mason", "Mason");
            command.Parameters.AddWithValue("@rate_mason", txtMason.Text);

            command.Parameters.AddWithValue("@steel", "Steel Man");
            command.Parameters.AddWithValue("@rate_steel", txtSteel.Text);
                
            command.Parameters.AddWithValue("@painter", "Painter");
            command.Parameters.AddWithValue("@rate_painter", txtPainter.Text);

            command.Parameters.AddWithValue("@tile", "Tile Man");
            command.Parameters.AddWithValue("@rate_tile", txtTile.Text);

            command.Parameters.AddWithValue("@door", "Door Installer");
            command.Parameters.AddWithValue("@rate_door", txtDoor.Text);


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void addDistribution()
        {
            db_connection();
            string query = "INSERT INTO work_distribution (project_id, part, labor, mason, steelman) VALUES " +
                "(@project_id, @earth, @labor_1, @mason_1, @steel_1)," +
                "(@project_id, @steel, @labor_2, @mason_2, @steel_2)," +
                "(@project_id, @form,  @labor_3, @mason_3, @steel_3)," +
                "(@project_id, @con,   @labor_4, @mason_4, @steel_4)," +
                "(@project_id, @mansory, @labor_5, @mason_5, @steel_5)";

            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@project_id", nextID.Text);

 
                command.Parameters.AddWithValue("@earth", "Earth Works");
                command.Parameters.AddWithValue("@labor_1", labor_1.Text);
                command.Parameters.AddWithValue("@mason_1", mason_1.Text);
                command.Parameters.AddWithValue("@steel_1", steel_1.Text);


                command.Parameters.AddWithValue("@steel", "Steel Works");
                command.Parameters.AddWithValue("@labor_2", labor_2.Text);
                command.Parameters.AddWithValue("@mason_2", mason_2.Text);
                command.Parameters.AddWithValue("@steel_2", steel_2.Text);

                command.Parameters.AddWithValue("@form", "Form Works");
                command.Parameters.AddWithValue("@labor_3", labor_3.Text);
                command.Parameters.AddWithValue("@mason_3", mason_3.Text);
                command.Parameters.AddWithValue("@steel_3", steel_3.Text);

                command.Parameters.AddWithValue("@con", "Concreting");
                command.Parameters.AddWithValue("@labor_4", labor_4.Text);
                command.Parameters.AddWithValue("@mason_4", mason_4.Text);
                command.Parameters.AddWithValue("@steel_4", steel_4.Text);

                command.Parameters.AddWithValue("@mansory", "Mansory");
                command.Parameters.AddWithValue("@labor_5", labor_5.Text);
                command.Parameters.AddWithValue("@mason_5", mason_5.Text);
                command.Parameters.AddWithValue("@steel_5", steel_5.Text);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void RefreshData()
        {
            if (System.Windows.Forms.Application.OpenForms["MainForm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).DisplayData();
            }

        }

        private void Earthworks()
        {
            db_connection();
            string query = "INSERT INTO db_earthworks (project_id) VALUES (@project_id)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@project_id", nextID.Text);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void Formworks()
        {
            db_connection();
            string query = "INSERT INTO db_formworks (project_id, part) VALUES" +
                "(@projectID, @footing)," +
                "(@projectID, @column)," +
                "(@projectID, @beam)," +
                "(@projectID, @slab)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@projectID", nextID.Text);
                command.Parameters.AddWithValue("@footing", "Footing");
                command.Parameters.AddWithValue("@column", "Column");
                command.Parameters.AddWithValue("@beam", "Beam");
                command.Parameters.AddWithValue("@slab", "Slab");
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void ManosoryWalls()
        {
            db_connection();
            string query = "INSERT INTO db_mansorywalls (project_id,part) VALUES " +
                "(@projectID, @ext)," +
                "(@projectID, @int)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@projectID", nextID.Text);
                command.Parameters.AddWithValue("@ext", "Exterior");
                command.Parameters.AddWithValue("@int", "Interior");
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void Reinforced()
        {
            db_connection();
            string query = "INSERT INTO db_reinforcedcc (project_id, part) VALUES " +
                "(@projectID, @footing)," +
                "(@projectID, @column)," +
                "(@projectID, @beam)," +
                "(@projectID, @slab)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@projectID", nextID.Text);
                command.Parameters.AddWithValue("@footing", "Footing");
                command.Parameters.AddWithValue("@column", "Column");
                command.Parameters.AddWithValue("@beam", "Beam");
                command.Parameters.AddWithValue("@slab", "Slab");
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void Steel()
        {
            db_connection();
            string query = "INSERT INTO db_steelrw (project_id, part) VALUES " +
                "(@projectID, @footing)," +
                "(@projectID, @column)," +
                "(@projectID, @beam)," +
                "(@projectID, @slab)," +
                "(@projectID, @walls)," +
                "(@projectID, @walltype)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@projectID", nextID.Text);
                command.Parameters.AddWithValue("@footing", "Footing");
                command.Parameters.AddWithValue("@column", "Column");
                command.Parameters.AddWithValue("@beam", "Beam");
                command.Parameters.AddWithValue("@slab", "Slab");
                command.Parameters.AddWithValue("@walls", "Walls");
                command.Parameters.AddWithValue("@walltype", "CHB");
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void Flooring()
        {
            db_connection();
            string query = "INSERT INTO db_flooring (project_id, part) VALUES " +
                "(@projectID, @exc)," +
                "(@projectID, @tb)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@projectID", nextID.Text);
                command.Parameters.AddWithValue("@exc", "EXC T&B");
                command.Parameters.AddWithValue("@tb", "T&B");
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void Plastering()
        {
            db_connection();
            string query = "INSERT INTO db_plasteringw (project_id, part) VALUES " +
                "(@projectID, @int)," +
                "(@projectID, @ext)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@projectID", nextID.Text);
                command.Parameters.AddWithValue("@int", "Interior");
                command.Parameters.AddWithValue("@ext", "Exterior");
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void Painting()
        {
            db_connection();
            string query = "INSERT INTO db_paintingw (project_id, part) VALUES " +
                "(@projectID, @INSkim)," +
                "(@projectID, @EXSkim)," +
                "(@projectID, @int)," +
                "(@projectID, @ext)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@projectID", nextID.Text);
                command.Parameters.AddWithValue("@INSkim", "Internal Skim Coat");
                command.Parameters.AddWithValue("@EXSkim", "External Skim Coat");
                command.Parameters.AddWithValue("@int", "Interior");
                command.Parameters.AddWithValue("@ext", "Exterior");
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void Doors()
        {
            db_connection();
            string query = "INSERT INTO db_doors (project_id, part) VALUES " +
                "(@projectID, @door1)," +
                "(@projectID, @door2)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@projectID", nextID.Text);
                command.Parameters.AddWithValue("@door1", "Door Lockset");
                command.Parameters.AddWithValue("@door2", "Door");

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }
        private void Ceiling()
        {
            db_connection();
            string query = "INSERT INTO db_ceiling (project_id, part) VALUES " +
                "(@projectID, @value1)," +
                "(@projectID, @value2)";
            MySqlCommand command = new MySqlCommand(query, connect);
            try
            {
                command.Parameters.AddWithValue("@projectID", nextID.Text);
                command.Parameters.AddWithValue("@value1", "Steel Frame");
                command.Parameters.AddWithValue("@value2", "Plywood");

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connect.Close();
        }

        public void ClearTextBoxes(Control.ControlCollection ctrlCollection)
        {
            foreach (Control ctrl in ctrlCollection)
            {
                if (ctrl is TextBoxBase)
                {
                    ctrl.Text = String.Empty;
                }
                else
                {
                    ClearTextBoxes(ctrl.Controls);
                }
            }
        }
        private void distribution_rate_Load(object sender, EventArgs e)
        {
            GetNextID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
   
          
            CheckError();

            distribution_rate_error errorMsg = new distribution_rate_error();
            if (getError == true)
            {
                errorMsg.ShowDialog();
            }
            else
            {
                MessageBox.Show("New Project Added : " + MainForm.projectName, "Construction Worker Distribution Guide System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addProject();
                addRate();
                addDistribution();
                Earthworks();
                Formworks();
                ManosoryWalls();
                Reinforced();
                Steel();
                Flooring();
                Plastering();
                Painting();
                Doors();
                Ceiling();
                RefreshData();
                this.Hide();
            }
        }
        private void materialButton24_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);

        }

        private void materialButton24_Click_1(object sender, EventArgs e)
        {

        }
    }
}
