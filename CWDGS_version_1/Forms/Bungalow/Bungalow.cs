using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Collections.Generic;
using CWDGS;
using SeriesCollection = LiveCharts.SeriesCollection;
using System.Linq;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using CWDGS.Forms;
using CWDGS_version_1.Forms.Bungalow.Units;
using CWDGS_version_1.Forms.Bungalow.Earthworks;
using CWDGS_version_1.Forms.Bungalow.Formworks;

namespace MaterialSkinExample
{
    public partial class Bungalow : MaterialForm
    {
        private string conn;
        private MySqlConnection connect;
        private readonly MaterialSkinManager materialSkinManager;
        bool getError = true;


        public Bungalow()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);

            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Bottom;
            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[]
             {
                    "Earth Works",
                    "Steel Works",
                    "Form Works",
                    "Concreting",
                    "Masonry"
                },
                Separator = new Separator
                {
                    Step = 1.0,
                    IsEnabled = true

                },
            });
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisY.Add(
            new Axis
            {
                MinValue = 0
            });

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
        public void GetInfo()
        {
            db_connection();
            string queryID = "select * from projects where id=" + MainForm.PassID;
            MySqlConnection connTwo = new MySqlConnection(conn);
            MySqlCommand commandTwo = new MySqlCommand(queryID, connTwo);
            connTwo.Open();
            MySqlDataReader reader = commandTwo.ExecuteReader();

            if (reader.Read())
            {
                this.Text = reader.GetValue(1).ToString();
                labelName.Text = reader.GetString(1).ToString().ToUpper();
                labelStyle.Text = reader.GetString(2).ToString().ToUpper();
            }
            connTwo.Close();
        }
        public void getDistributionMain()
        {
            try
            {
                db_connection();
                string Query = "select part as 'WORKS'," +
                    " labor as 'LABOR'," +
                    " mason as 'MASON'," +
                    " steelman as 'STEELMAN' " +
                    "from work_distribution";

                MySqlConnection MyConn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);


                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgv.DataSource = dTable;

                cartesianChart1.Series = new SeriesCollection
            {

                new LineSeries
                {
                    Title = "Labor",
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,(int)dgv[1, 0].Value),
                        new ObservablePoint(1,(int)dgv[1, 1].Value),
                        new ObservablePoint(2,(int)dgv[1, 2].Value),
                        new ObservablePoint(3,(int)dgv[1, 3].Value),
                        new ObservablePoint(4,(int)dgv[1, 4].Value)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Title = "Mason",
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,(int)dgv[2, 0].Value),
                        new ObservablePoint(1,(int)dgv[2, 1].Value),
                        new ObservablePoint(2,(int)dgv[2, 2].Value),
                        new ObservablePoint(3,(int)dgv[2, 3].Value),
                        new ObservablePoint(4,(int)dgv[2, 4].Value)
                    },
                    PointGeometrySize = 15
                },
                new LineSeries
                {
                    Title = "Steel Man",
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(0,(int)dgv[3, 0].Value),
                        new ObservablePoint(1,(int)dgv[3, 1].Value),
                        new ObservablePoint(2,(int)dgv[3, 2].Value),
                        new ObservablePoint(3,(int)dgv[3, 3].Value),
                        new ObservablePoint(4,(int)dgv[3, 4].Value)
                    },
                    PointGeometrySize = 15
                }

            };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connect.Close();
        }

        //MAN POWER DISTRIBUTION
        public void getDistributionID()
        {

            try
            {

                db_connection();

                string query = "select id from work_distribution where project_id=" + MainForm.PassID;
                MySqlConnection IDconn = new MySqlConnection(conn);
                MySqlCommand IDcommand = new MySqlCommand(query, IDconn);


                IDconn.Open();
                MySqlDataReader dr_ID = IDcommand.ExecuteReader();

                dr_ID.Read();
                id_one.Text = dr_ID.GetValue(0).ToString();

                dr_ID.Read();
                id_two.Text = dr_ID.GetValue(0).ToString();

                dr_ID.Read();
                id_three.Text = dr_ID.GetValue(0).ToString();

                dr_ID.Read();
                id_four.Text = dr_ID.GetValue(0).ToString();

                dr_ID.Read();
                id_five.Text = dr_ID.GetValue(0).ToString();

                IDconn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getDistribution()
        {
            try
            {
                db_connection();
                string sql = "select part, labor, mason, steelman from work_distribution where project_id=" + MainForm.PassID;
                MySqlCommand commands = new MySqlCommand(sql, connect);
                MySqlDataReader read = commands.ExecuteReader();

           

                while (read.Read())
                {
                    ListViewItem distri_lv = new ListViewItem(read.GetString(0));
                    distri_lv.SubItems.Add(read.GetString(1));
                    distri_lv.SubItems.Add(read.GetString(2));
                    distri_lv.SubItems.Add(read.GetString(3));
                    distribution_listview.Items.Add(distri_lv);

                }
                read.Close();
                commands.Dispose();
                connect.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void getDistrbution_value()
        {
            try
            {

                db_connection();

                string labor_query = "select labor from work_distribution where project_id=" + MainForm.PassID;
                string mason_query = "select mason from work_distribution where project_id=" + MainForm.PassID;
                string steel_query = "select steelman from work_distribution where project_id=" + MainForm.PassID;

                //LABOR
                MySqlConnection labor_conn = new MySqlConnection(conn);
                MySqlCommand labor_command = new MySqlCommand(labor_query, labor_conn);

                //MASON
                MySqlConnection mason_conn = new MySqlConnection(conn);
                MySqlCommand mason_command = new MySqlCommand(mason_query, mason_conn);

                //STEELMAN
                MySqlConnection steel_conn = new MySqlConnection(conn);
                MySqlCommand steel_command = new MySqlCommand(steel_query, steel_conn);



                labor_conn.Open();
                MySqlDataReader dr_labor = labor_command.ExecuteReader();
                dr_labor.Read();
                labor_1.Text = dr_labor.GetValue(0).ToString();
                dr_labor.Read();
                labor_2.Text = dr_labor.GetValue(0).ToString();
                dr_labor.Read();
                labor_3.Text = dr_labor.GetValue(0).ToString();
                dr_labor.Read();
                labor_4.Text = dr_labor.GetValue(0).ToString();
                dr_labor.Read();
                labor_5.Text = dr_labor.GetValue(0).ToString();
                labor_conn.Close();


                mason_conn.Open();
                MySqlDataReader dr_mason = mason_command.ExecuteReader();
                dr_mason.Read();
                mason_1.Text = dr_mason.GetValue(0).ToString();
                dr_mason.Read();
                mason_2.Text = dr_mason.GetValue(0).ToString();
                dr_mason.Read();
                mason_3.Text = dr_mason.GetValue(0).ToString();
                dr_mason.Read();
                mason_4.Text = dr_mason.GetValue(0).ToString();
                dr_mason.Read();
                mason_5.Text = dr_mason.GetValue(0).ToString();
                mason_conn.Close();

                steel_conn.Open();
                MySqlDataReader dr_steel = steel_command.ExecuteReader();
                dr_steel.Read();
                steel_1.Text = dr_steel.GetValue(0).ToString();
                dr_steel.Read();
                steel_2.Text = dr_steel.GetValue(0).ToString();
                dr_steel.Read();
                steel_3.Text = dr_steel.GetValue(0).ToString();
                dr_steel.Read();
                steel_4.Text = dr_steel.GetValue(0).ToString();
                dr_steel.Read();
                steel_5.Text = dr_steel.GetValue(0).ToString();
                steel_conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void update_Distribution()
        {
            try
            {
            db_connection();
            string Query ="update work_distribution " +
                    "set labor = case id " +
                    "when '"+ id_one.Text +"' then '"+ labor_1.Text +"' " +
                    "when '"+ id_two.Text +"' then '"+ labor_2.Text +"' " +
                    "when '"+ id_three.Text +"' then '"+ labor_3.Text +"' " +
                    "when '"+ id_four.Text +"' then '"+ labor_4.Text +"' " +
                    "when '"+ id_five.Text +"' then '"+labor_5.Text +"' " +
                    "else labor " +
                    "end, " +
                    "mason = case id " +
                    "when '" + id_one.Text + "' then '" + mason_1.Text + "' " +
                    "when '" + id_two.Text + "' then '" + mason_2.Text + "' " +
                    "when '" + id_three.Text + "' then '" + mason_3.Text + "' " +
                    "when '" + id_four.Text + "' then '" + mason_4.Text + "' " +
                    "when '" + id_five.Text + "' then '" + mason_5.Text + "' " +
                    "else mason " +
                    "end, " +
                    "steelman = case id " +
                    "when '" + id_one.Text + "' then '" + steel_1.Text + "' " +
                    "when '" + id_two.Text + "' then '" + steel_2.Text + "' " +
                    "when '" + id_three.Text + "' then '" + steel_3.Text + "' " +
                    "when '" + id_four.Text + "' then '" + steel_4.Text + "' " +
                    "when '" + id_five.Text + "' then '" + steel_5.Text + "' " +
                    "else steelman " +
                    "end " +
                    "where id in ('" + id_one.Text + "', '" + id_two.Text + "','" + id_three.Text + "','" + id_four.Text + "','" + id_five.Text + "')";
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
        private void refreshDistribution()
        {
            if (System.Windows.Forms.Application.OpenForms["Bungalow"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Bungalow"] as Bungalow).getDistrbution_value();
            }

            if (System.Windows.Forms.Application.OpenForms["Bungalow"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Bungalow"] as Bungalow).getDistribution();
            }

        }

        // RATE OF WORKERS
        public void getRateID()
        {

            try
            {

                db_connection();

                string query = "select id from work_rate where project_id=" + MainForm.PassID;
                MySqlConnection IDconn = new MySqlConnection(conn);
                MySqlCommand IDcommand = new MySqlCommand(query, IDconn);


                IDconn.Open();
                MySqlDataReader dr_ID = IDcommand.ExecuteReader();

                dr_ID.Read();
                rate_one.Text = dr_ID.GetValue(0).ToString();

                dr_ID.Read();
                rate_two.Text = dr_ID.GetValue(0).ToString();

                dr_ID.Read();
                rate_three.Text = dr_ID.GetValue(0).ToString();

                dr_ID.Read();
                rate_four.Text = dr_ID.GetValue(0).ToString();

                dr_ID.Read();
                rate_five.Text = dr_ID.GetValue(0).ToString();

                dr_ID.Read();
                rate_six.Text = dr_ID.GetValue(0).ToString();

                dr_ID.Read();
                rate_seven.Text = dr_ID.GetValue(0).ToString();

                IDconn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void getRate()
        {
            DataTable tbl = new DataTable();

            try
            {
                db_connection();
                string sql = "select workers, rate from work_rate where project_id=" + MainForm.PassID;
                MySqlCommand cmd = new MySqlCommand(sql, connect);
                MySqlDataReader Reader = cmd.ExecuteReader();

              

                while (Reader.Read())
                {
                    ListViewItem lv = new ListViewItem(Reader.GetString(0));
                    lv.SubItems.Add(Reader.GetString(1));
                    rate_list.Items.Add(lv);
                }
                Reader.Close();
                cmd.Dispose();
                connect.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        public void GetWorkersRateMain()
        {
            try
            {
                db_connection();
                string Query = "select workers as 'WORKERS', rate as 'RATE' from work_rate where project_id=" + MainForm.PassID;

                MySqlConnection MyConn2 = new MySqlConnection(conn);
                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dgv2.DataSource = dTable;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            connect.Close();
        }
        private void getRate_value()
        {
            try
            {

                db_connection();

                string labor_query = "select rate from work_rate where project_id=" + MainForm.PassID;

                //LABOR
                MySqlConnection con = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(labor_query, con);
                
                con.Open();
                MySqlDataReader dr = command.ExecuteReader();
                dr.Read();
                txtCarpenter.Text = dr.GetValue(0).ToString();
                dr.Read();
                txtLabor.Text = dr.GetValue(0).ToString();
                dr.Read();
                txtMason.Text = dr.GetValue(0).ToString();
                dr.Read();
                txtSteel.Text = dr.GetValue(0).ToString();
                dr.Read();
                txtPainter.Text = dr.GetValue(0).ToString();
                dr.Read();
                txtTile.Text = dr.GetValue(0).ToString();
                dr.Read();
                txtDoor.Text = dr.GetValue(0).ToString();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateRate()
        {
            try
            {
                db_connection();
                string Query = "update work_rate " +
                        "set rate = case id " +
                        "when '" + rate_one.Text + "' then '" + txtCarpenter.Text + "' " +
                        "when '" + rate_two.Text + "' then '" + txtLabor.Text + "' " +
                        "when '" + rate_three.Text + "' then '" + txtMason.Text + "' " +
                        "when '" + rate_four.Text + "' then '" + txtSteel.Text + "' " +
                        "when '" + rate_five.Text + "' then '" + txtPainter.Text + "' " +
                        "when '" + rate_six.Text + "' then '" + txtTile.Text + "' " +
                        "when '" + rate_seven.Text + "' then '" + txtDoor.Text + "' " +
                        "else rate " +
                        "end " +
                        "where id in ('" + rate_one.Text + "', '" + rate_two.Text + "','" + rate_three.Text + "','" + rate_four.Text + "','" + rate_five.Text + "','" + rate_six.Text + "','" + rate_seven.Text + "')";
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
        private void refreshRate()
        {
            if (System.Windows.Forms.Application.OpenForms["Bungalow"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Bungalow"] as Bungalow).getDistrbution_value();
            }

            if (System.Windows.Forms.Application.OpenForms["Bungalow"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["Bungalow"] as Bungalow).getDistribution();
            }

        }

        //ERRORS
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
            else if (txtCarpenter.Text == "" || txtLabor.Text == "" || txtMason.Text == "" || txtSteel.Text == "" || txtPainter.Text == "" || txtTile.Text == "" || txtDoor.Text == "")
            {
                getError = true;
            }
            else
            {
                getError = false;
            }
        }
     
        private void Bungalow_Load(object sender, EventArgs e)
        {
             GetInfo();

            //DISTRIBUTION
           getDistribution();
            getDistributionMain();
            getDistributionID();
            getDistrbution_value();

            //RATE
            GetWorkersRateMain();
            getRate();
            getRateID();
            getRate_value();
           

            dgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv.Columns["LABOR"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv.Columns["MASON"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgv.Columns["STEELMAN"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            this.dgv2.Columns["RATE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

           dgv2.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            CheckError();
            distribution_rate_error errorMsg = new distribution_rate_error();
            if (getError == true)
            {
                errorMsg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Man power distribution have been updated successfully.", "Construction Worker Distribution Guide System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                update_Distribution();
                refreshDistribution();
            }
        }
        private void materialButton3_Click(object sender, EventArgs e)
        {
            CheckError();
            distribution_rate_error errorMsg = new distribution_rate_error();
            if (getError == true)
            {
                errorMsg.ShowDialog();
            }
            else
            {
                MessageBox.Show("Man power distribution have been updated successfully.", "Construction Worker Distribution Guide System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                updateRate();
            }
        }
        private void btnCeiling_Click(object sender, EventArgs e)
        {
            frmUnits ceilingForm = new frmUnits();
            ceilingForm.ShowDialog();
        }

        private void btnEarthworks_Click(object sender, EventArgs e)
        {
            frmEarthworks earthworksForm = new frmEarthworks();
            earthworksForm.ShowDialog();

        }

        private void btnFormworks_Click(object sender, EventArgs e)
        {
            frmFormworks formworksForm = new frmFormworks();
            formworksForm.ShowDialog();

        }
    }
}