
using CWDGS_version_1.Forms.Bungalow.Earthworks;
using CWDGS_version_1.Forms.Bungalow.Flooring;
using CWDGS_version_1.Forms.Bungalow.Formworks;
using CWDGS_version_1.Forms.Bungalow.Masonry_Walls;
using CWDGS_version_1.Forms.Bungalow.Painting_Works;
using CWDGS_version_1.Forms.Bungalow.Plastering_Works;
using CWDGS_version_1.Forms.Bungalow.Reinforced_Cement_Concrete;
using CWDGS_version_1.Forms.Bungalow.Steel_Reinforcement_Work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow
{
    public partial class frmTwoStory : Form
    {


        public frmTwoStory()
        {
            InitializeComponent();
        }

        private void frmTwoStory_Load(object sender, EventArgs e)
        {
            dgv.Columns["col2"].DefaultCellStyle.BackColor = Color.Yellow;

            dgv.Rows.Add();
            dgv.Rows[0].Cells["col1"].Value = "Carpenter";
            dgv.Rows[0].Cells["col2"].Value = "600";

            dgv.Rows.Add();
            dgv.Rows[1].Cells["col1"].Value = "Laborer";
            dgv.Rows[1].Cells["col2"].Value = "400";

            dgv.Rows.Add();
            dgv.Rows[2].Cells["col1"].Value = "Mason";
            dgv.Rows[2].Cells["col2"].Value = "550";

            dgv.Rows.Add();
            dgv.Rows[3].Cells["col1"].Value = "Steel Man";
            dgv.Rows[3].Cells["col2"].Value = "550";

            dgv.Rows.Add();
            dgv.Rows[4].Cells["col1"].Value = "Painter";
            dgv.Rows[4].Cells["col2"].Value = "600";


            dgv.Rows.Add();
            dgv.Rows[5].Cells["col1"].Value = "Tile Man";
            dgv.Rows[5].Cells["col2"].Value = "600";

            dgv.Rows.Add();
            dgv.Rows[6].Cells["col1"].Value = "Door Installer";
            dgv.Rows[6].Cells["col2"].Value = "500";

        }

        private void button1_Click(object sender, EventArgs e)
        {


            tsEarthworks earthworkForm = new tsEarthworks();
            earthworkForm.txtCostOfLabor.Text = dgv.Rows[1].Cells["col2"].Value.ToString();

            earthworkForm.ShowDialog();

            laborBox.Items.Add(earthworkForm.txtLabor.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tsSRW SRWForm = new tsSRW();
            SRWForm.txtSteelManValue.Text = dgv.Rows[3].Cells["col2"].Value.ToString();
            SRWForm.ShowDialog();

            steelManBox.Items.Add(SRWForm.txtFSteelMan.Text);
            steelManBox.Items.Add(SRWForm.txtCSteelMan.Text);
            steelManBox.Items.Add(SRWForm.txtBSteelMan.Text);
            steelManBox.Items.Add(SRWForm.txtSSteelMan.Text);
            steelManBox.Items.Add(SRWForm.txtWSteelMan.Text);
            steelManBox.Items.Add(SRWForm.txtWTSteelMan.Text);
            steelManBox.Items.Add(SRWForm.txtSCSteelMan.Text);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            tsFormworks formworks = new tsFormworks();
            formworks.txtCarpenterValue.Text  = dgv.Rows[0].Cells["col2"].Value.ToString();
            formworks.txtLaborerValue.Text = dgv.Rows[1].Cells["col2"].Value.ToString();
            formworks.ShowDialog();

            carpenterBox.Items.Add(formworks.txtCarpenter.Text);
            carpenterBox.Items.Add(formworks.txtCCarpenter.Text);
            carpenterBox.Items.Add(formworks.txtSFCarpenter.Text);
            carpenterBox.Items.Add(formworks.txtBCarpenter.Text);
            carpenterBox.Items.Add(formworks.txtRBCarpenter.Text);
            carpenterBox.Items.Add(formworks.txtSCarpenter.Text);
            carpenterBox.Items.Add(formworks.txtSCCarpenter.Text);

            laborBox.Items.Add(formworks.txtLaborer.Text);
            laborBox.Items.Add(formworks.txtCLaborer.Text);
            laborBox.Items.Add(formworks.txtSFLaborer.Text);
            laborBox.Items.Add(formworks.txtBLaborer.Text);
            laborBox.Items.Add(formworks.txtRBLabor.Text);
            laborBox.Items.Add(formworks.txtSLaborer.Text);
            laborBox.Items.Add(formworks.txtSCLaborer.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tsRCC rcc = new tsRCC();
            rcc.txtLaborerValue.Text = dgv.Rows[1].Cells["col2"].Value.ToString();
            rcc.txtMasonValue.Text = dgv.Rows[2].Cells["col2"].Value.ToString();
            rcc.ShowDialog();

            masonBox.Items.Add(rcc.txtMason.Text);
            masonBox.Items.Add(rcc.txtCMason.Text);
            masonBox.Items.Add(rcc.txtSFMason.Text);

            masonBox.Items.Add(rcc.txtBMason.Text);
            masonBox.Items.Add(rcc.txtRBMason.Text);

            masonBox.Items.Add(rcc.txtSMason.Text);
            masonBox.Items.Add(rcc.txtSFSMason.Text);
            masonBox.Items.Add(rcc.txtSCMason.Text);


            laborBox.Items.Add(rcc.txtLaborer.Text);
            laborBox.Items.Add(rcc.txtCLaborer.Text);
            laborBox.Items.Add(rcc.txtSFLaborer.Text);
            laborBox.Items.Add(rcc.txtBLaborer.Text);
            laborBox.Items.Add(rcc.txtRBLabor.Text);
            laborBox.Items.Add(rcc.txtSLaborer.Text);
            laborBox.Items.Add(rcc.txtSFSLabor.Text);
            laborBox.Items.Add(rcc.txtSCLaborer.Text);


        }

        private void button5_Click(object sender, EventArgs e)
        {
            tsMansoryWalls mansory = new tsMansoryWalls();
            mansory.txtLaborerValue.Text = dgv.Rows[1].Cells["col2"].Value.ToString();
            mansory.txtMasonValue.Text = dgv.Rows[2].Cells["col2"].Value.ToString();
            mansory.ShowDialog();


            masonBox.Items.Add(mansory.txtMason.Text);
            masonBox.Items.Add(mansory.txtinMason.Text);
            masonBox.Items.Add(mansory.txtEXTMason.Text);
            masonBox.Items.Add(mansory.txtINTMason.Text);

            laborBox.Items.Add(mansory.txtLaborer.Text);
            laborBox.Items.Add(mansory.txtinLaborer.Text);
            laborBox.Items.Add(mansory.txtEXTLaborer.Text);
            laborBox.Items.Add(mansory.txtINTLabor.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
          
            tsFlooring Flooring = new tsFlooring();
            Flooring.txtLaborerValue.Text = dgv.Rows[1].Cells["col2"].Value.ToString();
            Flooring.txtTileManValue.Text = dgv.Rows[5].Cells["col2"].Value.ToString();
            Flooring.ShowDialog();

            tileManBox.Items.Add(Flooring.txtTileMan.Text);
            tileManBox.Items.Add(Flooring.txtTBTileMan.Text);


            laborBox.Items.Add(Flooring.txtLaborer.Text);
            laborBox.Items.Add(Flooring.txtTBLaborer.Text);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            tsPaintainWorks painting = new tsPaintainWorks();
            painting.txtPainterValue.Text = dgv.Rows[4].Cells["col2"].Value.ToString();
            painting.ShowDialog();

            painterBox.Items.Add(painting.txtPainter.Text);
            painterBox.Items.Add(painting.txtEXPainter.Text);
            painterBox.Items.Add(painting.txtEXTPainter.Text);
            painterBox.Items.Add(painting.txtINTPainter.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ts_Doors doors = new ts_Doors();
            doors.txtDoorInstallerValue.Text = dgv.Rows[6].Cells["col2"].Value.ToString();
            doors.ShowDialog();

            doorBox.Items.Add(doors.txtDoorInstaller.Text);
            doorBox.Items.Add(doors.txtDDoorInstaller.Text);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            tsCeiling ceiling = new tsCeiling();
            ceiling.txtLaborerValue.Text = dgv.Rows[1].Cells["col2"].Value.ToString();
            ceiling.txtCarpenterValue.Text = dgv.Rows[0].Cells["col2"].Value.ToString();
            ceiling.ShowDialog();

            carpenterBox.Items.Add(ceiling.txtCarpenter.Text);
            carpenterBox.Items.Add(ceiling.txtPCarpenter.Text);

            laborBox.Items.Add(ceiling.txtLaborer.Text);
            laborBox.Items.Add(ceiling.txtPLaborer.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tsPlasteringWorks plasteringWorks = new tsPlasteringWorks();
            plasteringWorks.txtLaborerValue.Text = dgv.Rows[1].Cells["col2"].Value.ToString();
            plasteringWorks.txtMasonValue.Text = dgv.Rows[2].Cells["col2"].Value.ToString();
            plasteringWorks.ShowDialog();


            masonBox.Items.Add(plasteringWorks.txtMason.Text);
            masonBox.Items.Add(plasteringWorks.txtEXMason.Text);

            laborBox.Items.Add(plasteringWorks.txtLaborer.Text);
            laborBox.Items.Add(plasteringWorks.txtEXLaborer.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            int steelManMax = 0;
            foreach (var item in steelManBox.Items)
            {
                if (Convert.ToInt32(item) > steelManMax)
                    steelManMax = Convert.ToInt32(item);

            }

            int carpenterMax = 0;
            foreach (var item in carpenterBox.Items)
            {
                if (Convert.ToInt32(item) > carpenterMax)
                    carpenterMax = Convert.ToInt32(item);

            }

            int laborMax = 0;
            foreach (var item in laborBox.Items)
            {
                if (Convert.ToInt32(item) > laborMax)
                    laborMax = Convert.ToInt32(item);

            }

            int tileMax = 0;
            foreach (var item in tileManBox.Items)
            {
                if (Convert.ToInt32(item) > tileMax)
                    tileMax = Convert.ToInt32(item);

            }
            int masonMax = 0;
            foreach (var item in masonBox.Items)
            {
                if (Convert.ToInt32(item) > masonMax)
                    masonMax = Convert.ToInt32(item);

            }
            int doorMax = 0;
            foreach (var item in doorBox.Items)
            {
                if (Convert.ToInt32(item) > doorMax)
                    doorMax = Convert.ToInt32(item);

            }
            int painterMax = 0;
            foreach (var item in painterBox.Items)
            {
                if (Convert.ToInt32(item) > painterMax)
                    painterMax = Convert.ToInt32(item);

            }

            MessageBox.Show("Recommended Steelman : " + steelManMax + Environment.NewLine +
                "Recommended Carpenter : " + carpenterMax + Environment.NewLine +
                "Recommended Laborer : " + laborMax + Environment.NewLine +
                "Recommended Tileman : " + tileMax + Environment.NewLine +
                "Recommended Mason : " + masonMax + Environment.NewLine +
                "Door Installer : " + doorMax + Environment.NewLine +
                "Recommended Painter : " + painterMax);


        }
    }
}
