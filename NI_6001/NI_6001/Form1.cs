using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NI_6001
{



    public partial class Form1 : Form
    {

        int instumentStatus = 0;


        public Form1()
        {
            InitializeComponent();
        }


        private void SetLogic()
        {

            try
            {
               // button1.Enabled = false;
                uint[] generatedData = new uint[daqTask1Component1.NumberOfChannelsToWrite];

                // TODO: Populate data to write.
               // throw new System.NotImplementedException("You must populate the data to write before writing the data.");

                daqTask1Component1.WriteAsync(generatedData);
                generatedData[0] = 0x10;


                double[] controlData = NationalInstruments.DataConverter.Convert<double[]>(generatedData);
               // numericEditArray1.SetValues(controlData);
            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               // button1.Enabled = true;
            }


        }


        private void daqTask1Component1_WriteCompleted(object sender, NationalInstruments.DAQmx.ComponentModel.WriteCompletedEventArgs e)
        {
       
        }

        private void daqTask1Component1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            daqTask1Component1.StopTask();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Enabled = true;
            led1.OffColor = Color.Yellow;
            this.Refresh();


            instumentStatus = initNIUSB6001();

            if(instumentStatus==0)
               SetLogic();




        }

        private void Form1_Load(object sender, EventArgs e)
        {


            label1.Enabled = false;
            led1.OffColor = Color.Black;
            this.Refresh();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            label1.Enabled = false;
            led1.OffColor = Color.Black;
            this.Refresh();
        }

        private int initNIUSB6001()
        {


            try
            {
   
               // button1.Enabled = false;
                uint[] generatedData = new uint[daqTask1Component1.NumberOfChannelsToWrite];

                // TODO: Populate data to write.
               // throw new System.NotImplementedException("You must populate the data to write before writing the data.");

                daqTask1Component1.WriteAsync(generatedData);
                generatedData[0] = 0x00;


                double[] controlData = NationalInstruments.DataConverter.Convert<double[]>(generatedData);
               // numericEditArray1.SetValues(controlData);
  

            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //button1.Enabled = true;
                Close();
                return 1;

            }



            return 0;


        }





    }
}
