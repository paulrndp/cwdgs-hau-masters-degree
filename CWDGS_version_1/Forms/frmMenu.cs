using CWDGS_version_1.Forms.Bungalow;
using CWDGS_version_1.Forms.New;
using CWDGS_version_1.Forms.Projects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CWDGS_version_1.Forms
{
    public partial class frmMenu : Form
    {
  

        public frmMenu()
        {
            InitializeComponent();

        }

        private void btnBungalow_Click(object sender, EventArgs e)
        {
            //frmBungalow myBungalow = new frmBungalow();
           // myBungalow.ShowDialog();

            frmNew newProject = new frmNew();
            newProject.ShowDialog();

        }

        private void btnStory_Click(object sender, EventArgs e)
        {
            //frmBungalow bungalow = new frmBungalow();
           // bungalow.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnScope_Click(object sender, EventArgs e)
        {
            //frmScope scope = new frmScope();
            // scope.ShowDialog();

            frmProjects myProjects = new frmProjects();
            myProjects.ShowDialog();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTwoStory mytwostory = new frmTwoStory();
            mytwostory.Show();
        }

   
    }
}
