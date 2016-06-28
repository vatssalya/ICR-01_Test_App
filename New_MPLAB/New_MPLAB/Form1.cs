using NationalInstruments;
using NationalInstruments.UI;
using NationalInstruments.DAQmx;
using NationalInstruments.NI4882;
using NationalInstruments.VisaNS;
using NationalInstruments.Analysis;
using NationalInstruments.Analysis.Conversion;
using NationalInstruments.Analysis.SignalGeneration;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.IO;


namespace New_MPLAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var processInfo = new ProcessStartInfo(@"C:\\Users\\vaka\\Desktop\\Test1.bat");

            processInfo.CreateNoWindow = false;

            processInfo.UseShellExecute = false;

            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = Process.Start(processInfo);

            process.Start();

            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            //string last4 = output.Substring(output.Length - 0, 10);
            string error = process.StandardError.ReadToEnd();
            MessageBox.Show(output);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://192.168.1.103/cfg/testctrl.htm");
            Process.Start(sInfo);
            string a = WebUtility.HtmlEncode("");
            string b = WebUtility.HtmlDecode(a);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\\Users\\vaka\\Desktop\\PICKit3.pdf");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://192.168.1.103/cfg/testctrl.htm");
            Process.Start(sInfo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                button4.Enabled = false;
                uint[] generatedData = new uint[daqTask1Component1.NumberOfChannelsToWrite];

                // TODO: Populate data to write.
                //throw new System.NotImplementedException("You must populate the data to write before writing the data.");

                generatedData[0] = 00000000;

                daqTask1Component1.WriteAsync(generatedData);

                double[] controlData = NationalInstruments.DataConverter.Convert<double[]>(generatedData);
                numericEditArray1.SetValues(controlData);
            }
            catch (NationalInstruments.DAQmx.DaqException ex)
            {
                MessageBox.Show(ex.Message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button4.Enabled = true;
            }
        }

        private void daqTask1Component1_WriteCompleted(object sender, NationalInstruments.DAQmx.ComponentModel.WriteCompletedEventArgs e)
        {
            button4.Enabled = true;
        }

        private void daqTask1Component1_Error(object sender, NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs e)
        {
            // TODO: Handle DAQ errors.
            string message = e.Exception.Message;
            MessageBox.Show(message, "DAQ Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            daqTask1Component1.StopTask();
            button4.Enabled = true;
        }

           
                
    }
}
