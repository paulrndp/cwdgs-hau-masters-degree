using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Plastering_Works
{
    public partial class tsPlasteringWorks : Form
    {
        public tsPlasteringWorks()
        {
            InitializeComponent();
        }
        public static double round_up_to_even(double number_to_round)
        {
            var converted_to_int = Convert.ToDouble(number_to_round);
            if (converted_to_int % 2 == 0) return Math.Round(converted_to_int, 0);

            var difference = (converted_to_int + 1) - number_to_round;
            if (difference <= 0.5) return Math.Round(converted_to_int + 1, 0);

            var vOffset = converted_to_int < 0 ? -1 : 1;
            return Math.Round(converted_to_int + vOffset, 0);
        }
        private void interior()
        {

            try
            {

                double area = Convert.ToDouble(txtArea.Text);
                double preffered = Convert.ToDouble(txtPreffered.Text);
                double finish = Convert.ToDouble(txtFinish.Text);

                double workers = Convert.ToDouble(txtWorkers.Text);
                double mason = Convert.ToDouble(txtMason.Text);

                double a = (area * 2 / (preffered * finish));
                double result = round_up_to_even(a);
                txtWorkers.Text = result.ToString();

                double b = (area / (result * finish));
                workers = (int)Math.Ceiling(b);
                txtDays.Text = workers.ToString();

                double c = result / 2;
                mason = (int)Math.Ceiling(c);
                txtMason.Text = mason.ToString();
                txtLaborer.Text = mason.ToString();


                int masonValue = Convert.ToInt32(txtMasonValue.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int myDay = Convert.ToInt32(txtDays.Text);
                int myMason = Convert.ToInt32(txtMason.Text);
                int myLaborer = Convert.ToInt32(txtLaborer.Text);

                int e = (myLaborer * myDay * laborerValue) + (myMason * myDay * masonValue);
                txtCostOfLabor.Text = e.ToString();


            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void exterior()
        {

            try
            {

                double EXarea = Convert.ToDouble(txtEXArea.Text);
                double EXpreffered = Convert.ToDouble(txtEXPreffered.Text);
                double EXfinish = Convert.ToDouble(txtEXFinish.Text);

                double EXworkers = Convert.ToDouble(txtEXWorkers.Text);
                double EXmason = Convert.ToDouble(txtEXMason.Text);

                double a = (EXarea * 2 / (EXpreffered * EXfinish));
                double result = round_up_to_even(a);
                txtEXWorkers.Text = result.ToString();

                double b = (EXarea / (result * EXfinish));
                EXworkers = (int)Math.Ceiling(b);
                txtEXDays.Text = EXworkers.ToString();

                double c = result / 2;
                EXmason = (int)Math.Ceiling(c);
                txtEXMason.Text = EXmason.ToString();
                txtEXLaborer.Text = EXmason.ToString();


                int masonValue = Convert.ToInt32(txtMasonValue.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int EXmyDay = Convert.ToInt32(txtEXDays.Text);
                int EXmyMason = Convert.ToInt32(txtEXMason.Text);
                int EXmyLaborer = Convert.ToInt32(txtEXLaborer.Text);

                int e = (EXmyLaborer * EXmyDay * laborerValue) + (EXmyMason * EXmyDay * masonValue);
                txtEXCostOfLabor.Text = e.ToString();

            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            if (txtArea.Text == "" || txtArea.Text == "0" || txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else
            {
                interior();
            }
        }

        private void txtPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtArea.Text == "" || txtArea.Text == "0" || txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else
            {
                interior();
            }
        }

        private void txtEXArea_TextChanged(object sender, EventArgs e)
        {
            if (txtEXArea.Text == "" || txtEXArea.Text == "0" || txtEXPreffered.Text == "" || txtEXPreffered.Text == "0")
            {

            }
            else
            {
                exterior();
            }
        }

        private void txtEXPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtEXArea.Text == "" || txtEXArea.Text == "0" || txtEXPreffered.Text == "" || txtEXPreffered.Text == "0")
            {

            }
            else
            {
                exterior();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPW_Interior myInterior = new frmPW_Interior();
            myInterior.ShowDialog();
            txtFinish.Text = myInterior.textbox1.Text;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPW_Exterior myExterior = new frmPW_Exterior();
            myExterior.ShowDialog();
            txtEXFinish.Text = myExterior.textbox1.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
