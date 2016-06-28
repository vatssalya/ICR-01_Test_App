using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.DAQmx;
using NationalInstruments.NI4882;
using NationalInstruments.VisaNS;
using NationalInstruments.NetworkVariable;
using NationalInstruments.NetworkVariable.WindowsForms;
using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Analysis.Dsp;
using NationalInstruments.Analysis.Dsp.Filters;
using NationalInstruments.Analysis.Math;
using NationalInstruments.Analysis.Monitoring;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.Tdms;
using NationalInstruments.UI.WindowsForms;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                uint[] acquiredData = digital_InputComponent1.Read();
                double[] controlData = NationalInstruments.DataConverter.Convert<double[]>(acquiredData);
                numericEditArray1.SetValues(controlData);
            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void digital_InputComponent1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            digital_InputComponent1.StopTask();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button2.Enabled = false;
                uint[] generatedData = new uint[digital_OutputComponent1.NumberOfChannelsToWrite];

                // TODO: Populate data to write.
                //throw new System.NotImplementedException("You must populate the data to write before writing the data.");

                generatedData[0] = 00001000;
                digital_OutputComponent1.WriteAsync(generatedData);

                double[] controlData = NationalInstruments.DataConverter.Convert<double[]>(generatedData);
                numericEditArray2.SetValues(controlData);
            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button2.Enabled = true;
            }
        }

        private void digital_OutputComponent1_WriteCompleted(object sender, NationalInstruments.DAQmx.ComponentModel.WriteCompletedEventArgs e)
        {
            button2.Enabled = true;
        }

        private void digital_OutputComponent1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            digital_OutputComponent1.StopTask();
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                NationalInstruments.AnalogWaveform<double>[] acquiredData = analog_InputComponent1.Read();
               // waveformGraph1.PlotWaveforms(acquiredData);
            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void analog_InputComponent1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            analog_InputComponent1.StopTask();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                button4.Enabled = false;
                NationalInstruments.AnalogWaveform<double>[] generatedData = new NationalInstruments.AnalogWaveform<double>[anlog_OutputComponent1.NumberOfChannelsToWrite];

                // TODO: Populate data to write.
                //throw new System.NotImplementedException("You must populate the data to write before writing the data.");

                int numberOfPoints = 100;
                AnalogWaveform<double> analogWaveform = new AnalogWaveform<double>(numberOfPoints);

                for (int i = 0; i < numberOfPoints; i++)
                {
                    analogWaveform.Samples[i].Value = 3;
              }

                generatedData[0] = analogWaveform;
                generatedData[1] = analogWaveform;


                anlog_OutputComponent1.WriteAsync(generatedData);
                waveformGraph2.PlotWaveforms(generatedData);
            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button4.Enabled = true;
            }
        }

        private void anlog_OutputComponent1_WriteCompleted(object sender, NationalInstruments.DAQmx.ComponentModel.WriteCompletedEventArgs e)
        {
            button4.Enabled = true;
        }

        private void anlog_OutputComponent1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            anlog_OutputComponent1.StopTask();
            button4.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*try
            {
                button5.Enabled = false;
                NationalInstruments.AnalogWaveform<double>[] generatedData = new NationalInstruments.AnalogWaveform<double>[analogOut_AO1Component1.NumberOfChannelsToWrite];

                // TODO: Populate data to write.
                //throw new System.NotImplementedException("You must populate the data to write before writing the data.");
                int numberOfPoints1 = 100;
                AnalogWaveform<double> analogWaveform = new AnalogWaveform<double>(numberOfPoints1);

                for (int j = 0; j < numberOfPoints1; j++)
                {
                    analogWaveform.Samples[j].Value = 1.41;

                }

                generatedData[1] = analogWaveform;
                analogOut_AO1Component1.WriteAsync(generatedData);
                waveformGraph3.PlotWaveforms(generatedData);
            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button5.Enabled = true;
            }
        }

        private void analogOut_AO1Component1_WriteCompleted(object sender, NationalInstruments.DAQmx.ComponentModel.WriteCompletedEventArgs e)
        {
            button5.Enabled = true;
        }

        private void analogOut_AO1Component1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            analogOut_AO1Component1.StopTask();
            button5.Enabled = true;*/
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                NationalInstruments.AnalogWaveform<double>[] acquiredData = aI1Component1.Read();
                waveformGraph4.PlotWaveforms(acquiredData);
            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void aI1Component1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            aI1Component1.StopTask();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                NationalInstruments.AnalogWaveform<double>[] acquiredData = aI_2Component1.Read();
                waveformGraph5.PlotWaveforms(acquiredData);
            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void aI_2Component1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            aI_2Component1.StopTask();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                NationalInstruments.AnalogWaveform<double>[] acquiredData = aI_3Component1.Read();
                waveformGraph6.PlotWaveforms(acquiredData);
            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void aI_3Component1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            aI_3Component1.StopTask();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                NationalInstruments.AnalogWaveform<double>[] acquiredData = aI_4Component1.Read();
                waveformGraph7.PlotWaveforms(acquiredData);
            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void aI_4Component1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            aI_4Component1.StopTask();
        }

        
        

        
    }
}
