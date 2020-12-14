using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWDGS_version_1.Forms.Bungalow.Flooring
{
    public partial class frmFlooring : Form
    {
        public frmFlooring()
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

        private void flooring()
        {

            try
            {
     
                double area = Convert.ToDouble(txtArea.Text);
                double preffered = Convert.ToDouble(txtPreffered.Text);
                double finish = Convert.ToDouble(txtFinish.Text);

                double workers = Convert.ToDouble(txtWorkers.Text);
                double tileMan = Convert.ToDouble(txtTileMan.Text);

                double a = (area * 2 / (preffered * finish ));
                double result =  round_up_to_even(a);
                txtWorkers.Text = result.ToString();

                double b = (area / (result * finish));
                workers = (int)Math.Ceiling(b);
                txtDays.Text = workers.ToString();

                double c = result / 2;
                tileMan = (int)Math.Ceiling(c);
                txtTileMan.Text = tileMan.ToString();

                double d = result - tileMan;
                txtLaborer.Text = d.ToString();

                int tileManValue = Convert.ToInt32(txtTileManValue.Text );
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text );

                int myDay = Convert.ToInt32(txtDays.Text);
                int myTileMan = Convert.ToInt32(txtTileMan.Text);
                int myLaborer = Convert.ToInt32(txtLaborer.Text);

                int e = (myLaborer * myDay * laborerValue) + (myTileMan * myDay * tileManValue);
                txtCostOfLabor.Text = e.ToString();


            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }

        private void flooringTB()
        {

            try
            {

                double TBarea = Convert.ToDouble(txtTBArea.Text);
                double TBpreffered = Convert.ToDouble(txtTBPreffered.Text);
                double TBfinish = Convert.ToDouble(txtTBFinish.Text);

                double TBworkers = Convert.ToDouble(txtTBWorkers.Text);
                double TBtileMan = Convert.ToDouble(txtTBTileMan.Text);

                double a = (TBarea * 2 / (TBpreffered * TBfinish));
                double result = round_up_to_even(a);
                txtTBWorkers.Text = result.ToString();

                double b = (TBarea / (result * TBfinish));
                TBworkers = (int)Math.Ceiling(b);
                txtTBDays.Text = TBworkers.ToString();

                double c = result / 2;
                TBtileMan = (int)Math.Ceiling(c);
                txtTBTileMan.Text = TBtileMan.ToString();

                double d = result - TBtileMan;
                txtTBLaborer.Text = d.ToString();

                int tileManValue = Convert.ToInt32(txtTileManValue.Text);
                int laborerValue = Convert.ToInt32(txtLaborerValue.Text);

                int TBmyDay = Convert.ToInt32(txtTBDays.Text);
                int TBmyTileMan = Convert.ToInt32(txtTBTileMan.Text);
                int TBmyLaborer = Convert.ToInt32(txtTBLaborer.Text);

                int e = (TBmyLaborer * TBmyDay * laborerValue) + (TBmyTileMan * TBmyDay * tileManValue);
                txtTBCostOfLabor.Text = e.ToString();


            }
            catch (DivideByZeroException e)
            {
                MessageBox.Show("Exception caught" + e);
                throw;
            }

        }
        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            if (txtArea.Text == "" || txtArea.Text == "0" || txtPreffered.Text=="" || txtPreffered.Text =="0")
            {

            }
            else
            {
                flooring();
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtArea.Text == "" || txtPreffered.Text == "")
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    txtFinish.Text = txtMosaic.Text;
            
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    txtFinish.Text = txtCeramic.Text;
                
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    txtFinish.Text = txtVitrified.Text;
                    
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    txtFinish.Text = txtGranite.Text;
                   
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    txtFinish.Text = txtMarble.Text;
                   
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    txtFinish.Text = txtGlazed.Text;
                   
                }
            }
            else
            {

                if (comboBox1.SelectedIndex == 0)
                {
                    txtFinish.Text = txtMosaic.Text;
                    flooring();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    txtFinish.Text = txtCeramic.Text;
                    flooring();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    txtFinish.Text = txtVitrified.Text;
                    flooring();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    txtFinish.Text = txtGranite.Text;
                    flooring();
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    txtFinish.Text = txtMarble.Text;
                    flooring();
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    txtFinish.Text = txtGlazed.Text;
                    flooring();
                }
            }
        
        }

        private void txtPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtArea.Text == "" || txtArea.Text == "0" || txtPreffered.Text == "" || txtPreffered.Text == "0")
            {

            }
            else
            {
                flooring();
            }
        }

        private void frmFlooring_Load(object sender, EventArgs e)
        {
            //comboBox1.SelectedIndex = 0;
        }

        private void txtTBArea_TextChanged(object sender, EventArgs e)
        {
            if (txtTBArea.Text == "" || txtTBArea.Text == "0" || txtTBPreffered.Text == "" || txtTBPreffered.Text == "0")
            {

            }
            else
            {
                flooringTB();
            }
        }

        private void txtTBPreffered_TextChanged(object sender, EventArgs e)
        {
            if (txtTBArea.Text == "" || txtTBArea.Text == "0" || txtTBPreffered.Text == "" || txtTBPreffered.Text == "0")
            {

            }
            else
            {
                flooringTB();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (txtTBArea.Text == "" || txtTBPreffered.Text == "")
            {
                if (comboBox2.SelectedIndex == 0)

                {
                    txtTBFinish.Text = txtTBMosiac.Text;
               
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    txtTBFinish.Text = txtTBCeramic.Text;
               
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    txtTBFinish.Text = txtTBVitrified.Text;
                 
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    txtTBFinish.Text = txtTBGranite.Text;
               
                }
                else if (comboBox2.SelectedIndex == 4)
                {
                    txtTBFinish.Text = txtTBMarble.Text;
               
                }
                else if (comboBox2.SelectedIndex == 5)
                {
                    txtTBFinish.Text = txtTBGlazed.Text;
                 
                }
            }
            else
            {
                if (comboBox2.SelectedIndex == 0)

                {
                    txtTBFinish.Text = txtTBMosiac.Text;
                    flooringTB();
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    txtTBFinish.Text = txtTBCeramic.Text;
                    flooringTB();
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    txtTBFinish.Text = txtTBVitrified.Text;
                    flooringTB();
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    txtTBFinish.Text = txtTBGranite.Text;
                    flooringTB();
                }
                else if (comboBox2.SelectedIndex == 4)
                {
                    txtTBFinish.Text = txtTBMarble.Text;
                    flooringTB();
                }
                else if (comboBox2.SelectedIndex == 5)
                {
                    txtTBFinish.Text = txtTBGlazed.Text;
                    flooringTB();
                }
            }

           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmTB tb = new frmTB();
            tb.ShowDialog();
            txtTBMosiac.Text = tb.txtMosaicTB.Text;
            txtTBCeramic.Text = tb.txtCeramicTB.Text;
            txtTBVitrified.Text = tb.txtVitrifiedTB.Text;
            txtTBGranite.Text = tb.txtGraniteTB.Text;
            txtTBMarble.Text = tb.txtMarbleTB.Text;
            txtTBGlazed.Text = tb.txtGlazedTB.Text;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEXC exc = new frmEXC();
            exc.ShowDialog();
            txtMosaic.Text = exc.txtMosaic.Text;
            txtCeramic.Text = exc.txtCeramic.Text;
            txtVitrified.Text = exc.txtVitrified.Text;
            txtGranite.Text = exc.txtGranite.Text;
            txtMarble.Text = exc.txtMarble.Text;
            txtGlazed.Text = exc.txtGlazed.Text;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
