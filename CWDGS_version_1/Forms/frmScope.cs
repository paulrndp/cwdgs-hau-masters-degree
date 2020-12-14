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
    public partial class frmScope : Form
    {
        public frmScope()
        {
            InitializeComponent();
        }

        private void frmScope_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }
    }
}
