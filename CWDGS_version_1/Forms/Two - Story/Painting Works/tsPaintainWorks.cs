using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Painting_Works
{
    public partial class tsPaintainWorks : Form
    {
        public tsPaintainWorks()
        {
            InitializeComponent();
        }

        private void interiorSkimCoat()
        {

            try
            {
                decimal area = Convert.ToDecimal(txtArea.Text);
                decimal preffered = Convert.ToDecimal(txtPreffered.Text);
                decimal finish = Convert.ToDecimal(txtFinish.Text);

                decimal workers = Convert.ToDecimal(txtWorkers.Text);
                decimal a = (area / (preffered * finish));
                workers = (int)Math.Ceiling(a);
                txtWorkers.Text = workers.ToString();
                txtPainter.Text = workers.ToString();

                decimal days = Convert.ToDecimal(txtDays.Text);
                decimal b = (area / (workers * finish));
                days = (int)Math.Ceiling(b);
                txtDays.Text = days.ToString();

                decimal painterValue = Convert.ToDecimal(txtPainterValue.Text);
                decimal painter = Convert.ToDecimal(txtPainter.Text);

                decimal c = (painter * days * painterValue);
             
                txtCostOfLabor.Text = c.ToString();


            }

            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void exteriorSkimCoat()
        {

            try
            {
                decimal EXarea = Convert.ToDecimal(txtEXArea.Text);
                decimal EXpreffered = Convert.ToDecimal(txtEXPreffered.Text);
                decimal EXfinish = Convert.ToDecimal(txtEXFinish.Text);

                decimal EXworkers = Convert.ToDecimal(txtEXWorkers.Text);
                decimal a = (EXarea / (EXpreffered * EXfinish));
                EXworkers = (int)Math.Ceiling(a);
                txtEXWorkers.Text = EXworkers.ToString();
                txtEXPainter.Text = EXworkers.ToString();

                decimal EXdays = Convert.ToDecimal(txtEXDays.Text);
                decimal b = (EXarea / (EXworkers * EXfinish));
                EXdays = (int)Math.Ceiling(b);
                txtEXDays.Text = EXdays.ToString();

                decimal painterValue = Convert.ToDecimal(txtPainterValue.Text);
                decimal EXpainter = Convert.ToDecimal(txtEXPainter.Text);

                decimal c = (EXpainter * EXdays * painterValue);

                txtEXCostOfLabor.Text = c.ToString();


            }

            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void interior()
        {

            try
            {
                decimal INTarea = Convert.ToDecimal(txtINTArea.Text);
                decimal INTpreffered = Convert.ToDecimal(txtINTPreffered.Text);
                decimal INTfinish = Convert.ToDecimal(txtINTFinish.Text);

                decimal INTworkers = Convert.ToDecimal(txtINTWorkers.Text);
                decimal a = (INTarea / (INTpreffered * INTfinish));
                INTworkers = (int)Math.Ceiling(a);
                txtINTWorkers.Text = INTworkers.ToString();
                txtINTPainter.Text = INTworkers.ToString();

                decimal INTdays = Convert.ToDecimal(txtINTDays.Text);
                decimal b = (INTarea / (INTworkers * INTfinish));
                INTdays = (int)Math.Ceiling(b);
                txtINTDays.Text = INTdays.ToString();

                decimal painterValue = Convert.ToDecimal(txtPainterValue.Text);
                decimal INTpainter = Convert.ToDecimal(txtINTPainter.Text);

                decimal c = (INTpainter * INTdays * painterValue);

                txtINTCostOfLabor.Text = c.ToString();


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
                decimal EXTarea = Convert.ToDecimal(txtEXTArea.Text);
                decimal EXTpreffered = Convert.ToDecimal(txtEXTPreffered.Text);
                decimal EXTfinish = Convert.ToDecimal(txtEXTFinish.Text);

                decimal EXTworkers = Convert.ToDecimal(txtEXTWorkers.Text);
                decimal a = (EXTarea / (EXTpreffered * EXTfinish));
                EXTworkers = (int)Math.Ceiling(a);
                txtEXTWorkers.Text = EXTworkers.ToString();
                txtEXTPainter.Text = EXTworkers.ToString();

                decimal EXTdays = Convert.ToDecimal(txtEXTDays.Text);
                decimal b = (EXTarea / (EXTworkers * EXTfinish));
                EXTdays = (int)Math.Ceiling(b);
                txtEXTDays.Text = EXTdays.ToString();

                decimal painterValue = Convert.ToDecimal(txtPainterValue.Text);
                decimal EXTpainter = Convert.ToDecimal(txtEXTPainter.Text);

                decimal c = (EXTpainter * EXTdays * painterValue);

                txtEXTCostOfLabor.Text = c.ToString();


            }

            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (txtEXTArea.Text == "" || txtEXTArea.Text == "0" || txtEXTPreffered.Text == "" || txtEXTPreffered.Text == "0")
            {

            }
            else
            {
                exterior();
            }
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            if (txtArea.Text == "" || txtArea.Text == "0" || txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else
            {
                interiorSkimCoat();     
            }

        }

        private void txtPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtArea.Text == "" || txtArea.Text == "0" || txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else
            {
                interiorSkimCoat();
            }
        }

        private void txtEXArea_TextChanged(object sender, EventArgs e)
        {
            if (txtEXArea.Text == "" || txtEXArea.Text == "0" || txtEXPreffered.Text == "" || txtEXPreffered.Text == "0")
            {

            }
            else
            {
                exteriorSkimCoat();
            }
        }

        private void txtEXPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtEXArea.Text == "" || txtEXArea.Text == "0" || txtEXPreffered.Text == "" || txtEXPreffered.Text == "0")
            {

            }
            else
            {
                exteriorSkimCoat();
            }
        }

        private void txtINTArea_TextChanged(object sender, EventArgs e)
        {
            if (txtINTArea.Text == "" || txtINTArea.Text == "0" || txtINTPreffered.Text == "" || txtINTPreffered.Text == "0")
            {

            }
            else
            {
                interior();
            }
        }

        private void txtINTPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtINTArea.Text == "" || txtINTArea.Text == "0" || txtINTPreffered.Text == "" || txtINTPreffered.Text == "0")
            {

            }
            else
            {
                interior();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
           
                    txtINTFinish.Text = txtINTTexture.Text;
                    interior();
      

                }
                else
                {
                    txtINTFinish.Text = txtINTEnamel.Text;
                    interior();
                }
            }
            catch (Exception)
            {


            }
        }

        private void tsPaintainWorks_Load(object sender, EventArgs e)
        {
            try
            {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void txtEXTArea_TextChanged(object sender, EventArgs e)
        {
            if (txtEXTArea.Text == "" || txtEXTArea.Text == "0" || txtEXTPreffered.Text == "" || txtEXTPreffered.Text == "0")
            {

            }
            else
            {
                exterior();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex == 0)
                {

                    txtEXTFinish.Text = txtEXTTexture.Text;
                    exterior();


                }
                else
                {
                    txtEXTFinish.Text = txtEXTEnamel.Text;
                    exterior();
                }
            }
            catch (Exception)
            {


            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmIntSkimCoat intSkimCoat = new frmIntSkimCoat();
            intSkimCoat.ShowDialog();
            txtFinish.Text = intSkimCoat.textbox1.Text;


        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmExtSkimCoat extSkimCoat = new frmExtSkimCoat();
            extSkimCoat.ShowDialog();
            txtEXFinish.Text = extSkimCoat.textbox1.Text;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmPWs_Interior myInterior = new frmPWs_Interior();
            myInterior.ShowDialog();
            txtINTTexture.Text = myInterior.text1.Text;
            txtINTEnamel.Text = myInterior.text2.Text;
            txtINTFinish.Clear();


        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmPWs_Exterior myExterior = new frmPWs_Exterior();
            myExterior.ShowDialog();
            txtEXTTexture.Text = myExterior.text1.Text;
            txtEXTEnamel.Text = myExterior.text2.Text;
            txtINTFinish.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
