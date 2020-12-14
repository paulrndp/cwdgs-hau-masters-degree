using CWDGS_version_1.Forms;
using MaterialSkinExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CWDGS_version_1
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm ());
        }
    }
}
