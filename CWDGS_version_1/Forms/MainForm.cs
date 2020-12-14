using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using CWDGS_version_1.Forms.Bungalow;
using CWDGS.Forms;
using CWDGS_version_1.Forms.Bungalow.Units;
using CWDGS.Forms.Units;

namespace MaterialSkinExample
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private string conn;
        private MySqlConnection connect;
        public static string PassID;

        public static string projectName;
        public static string projectStyle;
        public MainForm()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
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
            db_connection();

            string sql = "Select * from projects";
            MySqlCommand cmd = new MySqlCommand(sql, connect);
            MySqlDataReader Reader = cmd.ExecuteReader();

            materialListView1.Items.Clear();

            while (Reader.Read())
            {
                ListViewItem lv = new ListViewItem(Reader.GetInt32(0).ToString());
                lv.SubItems.Add(Reader.GetString(1));
                materialListView1.Items.Add(lv);

            }
            Reader.Close();
            cmd.Dispose();
            connect.Close();
        }

        private void RefreshData()
        {
            if (System.Windows.Forms.Application.OpenForms["MainForm"] != null)
            {
                (System.Windows.Forms.Application.OpenForms["MainForm"] as MainForm).DisplayData();
            }

        }

 
        private void materialButton1_Click(object sender, EventArgs e)
        {
            materialSkinManager.Theme = materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? MaterialSkinManager.Themes.LIGHT : MaterialSkinManager.Themes.DARK;
            updateColor();
        }

        private int colorSchemeIndex;

        private void MaterialButton1_Click(object sender, EventArgs e)
        {
            colorSchemeIndex++;
            if (colorSchemeIndex > 2)
                colorSchemeIndex = 0;
            updateColor();
        }

        private void updateColor()
        {
            //These are just example color schemes
            switch (colorSchemeIndex)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal500 : Primary.Indigo500,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal700 : Primary.Indigo700,
                        materialSkinManager.Theme == MaterialSkinManager.Themes.DARK ? Primary.Teal200 : Primary.Indigo100,
                        Accent.Pink200,
                        TextShade.WHITE);
                    break;

                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.Green600,
                        Primary.Green700,
                        Primary.Green200,
                        Accent.Red100,
                        TextShade.WHITE);
                    break;

                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(
                        Primary.BlueGrey800,
                        Primary.BlueGrey900,
                        Primary.BlueGrey500,
                        Accent.LightBlue200,
                        TextShade.WHITE);
                    break;
            }
            Invalidate();
        }
        private void MaterialButton3_Click(object sender, EventArgs e)
        {
            var builder = new StringBuilder("Batch operation report:\n\n");
            var random = new Random();
            var result = 0;

            for (int i = 0; i < 200; i++)
            {
                result = random.Next(1000);

                if (result < 950)
                {
                    builder.AppendFormat(" - Task {0}: Operation completed sucessfully.\n", i);
                }
                else
                {
                    builder.AppendFormat(" - Task {0}: Operation failed! A very very very very very very very very very very very very serious error has occured during this sub-operation. The errorcode is: {1}).\n", i, result);
                }
            }
            var batchOperationResults = builder.ToString();
            var mresult = MaterialMessageBox.Show(batchOperationResults, "Batch Operation");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
   
            try
            {
                DisplayData();
   
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialListView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = materialListView1.SelectedItems[0];
            id.Text = item.SubItems[0].Text;

        }

        private void materialButton9_Click(object sender, EventArgs e)
        {
       
            if (String.IsNullOrEmpty(materialTextBox6.Text))
            {
              materialLabel3.Visible = true;
             
            }
           else if (!bungalowRadio.Checked && !twostoryRadio.Checked)
            {
                styleError.Visible = true;
  
            }
            else
            {
                materialLabel3.Visible = false;
                styleError.Visible = false;
                projectName = materialTextBox6.Text;

                if (bungalowRadio.Checked == true)
                {
                    projectStyle = bungalowRadio.Text;
                }
                else if (twostoryRadio.Checked == true)
                {
                    projectStyle = twostoryRadio.Text;
                }

                distribution_rate disAndrate = new distribution_rate();
                disAndrate.ShowDialog();
                materialTextBox6.Clear();
                materialLabel3.Visible = false;
                styleError.Visible = false;

                bungalowRadio.Checked = false;
                twostoryRadio.Checked = false;
            }
           



        }
  
        private void bungalowRadio_CheckedChanged(object sender, EventArgs e)
        {
            styleError.Visible = false;
        }

        private void twostoryRadio_CheckedChanged(object sender, EventArgs e)
        {
            styleError.Visible = false;
        }

        private void materialButton10_Click(object sender, EventArgs e)
        {
            if (id.Text == "0")
            {
                materialLabel1.Visible = true;
            }
            else
            {
                try
                {
                PassID = id.Text;
                Bungalow bungalowForm = new Bungalow();
                bungalowForm.ShowDialog();
                materialLabel1.Visible = false;
                id.Text = "0";
                materialListView1.SelectedItems.Clear();

                }
                catch (Exception)
                {
                }
            }
        }
        private void btnCeiling_Click(object sender, EventArgs e)
        {
            frmUnits ceilingForm = new frmUnits();
            ceilingForm.ShowDialog();
        }

        private void btnDoors_Click(object sender, EventArgs e)
        {
            b_doors doorsForm = new b_doors();
            doorsForm.ShowDialog();
        }

        private void btnEarth_Click(object sender, EventArgs e)
        {
            b_earthworks earthWorksForm = new b_earthworks();
            earthWorksForm.ShowDialog();

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            frmTwoStory second = new frmTwoStory();
            second.ShowDialog();
        }

        private void btnFloor_Click(object sender, EventArgs e)
        {
            b_flooring flooringForm = new b_flooring();
            flooringForm.ShowDialog();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            b_formworks formworksForm = new b_formworks();
            formworksForm.ShowDialog();

        }

        private void btnMansory_Click(object sender, EventArgs e)
        {
            b_mansory mansoryForm = new b_mansory();
            mansoryForm.ShowDialog();
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            b_painting paintingForm = new b_painting();
            paintingForm.ShowDialog();
        }

        private void btnPlastering_Click(object sender, EventArgs e)
        {
            b_plastering plasteringWorks = new b_plastering();
            plasteringWorks.ShowDialog();
        }

        private void btnReinforce_Click(object sender, EventArgs e)
        {
            b_reinforced reinforcedForm = new b_reinforced();
            reinforcedForm.ShowDialog();
        }

        private void btnSteel_Click(object sender, EventArgs e)
        {
            b_steel steelForm = new b_steel();
            steelForm.ShowDialog();
        }
    }
}