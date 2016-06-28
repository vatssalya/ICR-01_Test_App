namespace NI_6001
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.digital_InputComponent1 = new NI_6001.Digital_InputComponent(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.numericEditArray1 = new NationalInstruments.UI.WindowsForms.NumericEditArray();
            this.digital_OutputComponent1 = new NI_6001.Digital_OutputComponent(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.numericEditArray2 = new NationalInstruments.UI.WindowsForms.NumericEditArray();
            this.analog_InputComponent1 = new NI_6001.Analog_InputComponent(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.anlog_OutputComponent1 = new NI_6001.Anlog_OutputComponent(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.waveformGraph2 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.waveformPlot2 = new NationalInstruments.UI.WaveformPlot();
            ((System.ComponentModel.ISupportInitialize)(this.digital_InputComponent1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditArray1.ItemTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digital_OutputComponent1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditArray2.ItemTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analog_InputComponent1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anlog_OutputComponent1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).BeginInit();
            this.SuspendLayout();
            // 
            // digital_InputComponent1
            // 
            this.digital_InputComponent1.Error += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs>(this.digital_InputComponent1_Error);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numericEditArray1);
            this.panel1.Location = new System.Drawing.Point(3, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 66);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(139, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Read";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericEditArray1
            // 
            this.numericEditArray1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.numericEditArray1.ItemTemplate.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateHexadecimalMode();
            this.numericEditArray1.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.numericEditArray1.ItemTemplate.Name = "";
            this.numericEditArray1.ItemTemplate.TabIndex = 0;
            this.numericEditArray1.ItemTemplate.TabStop = false;
            this.numericEditArray1.Location = new System.Drawing.Point(2, 2);
            this.numericEditArray1.Name = "numericEditArray1";
            this.numericEditArray1.Size = new System.Drawing.Size(137, 62);
            this.numericEditArray1.TabIndex = 1;
            // 
            // digital_OutputComponent1
            // 
            this.digital_OutputComponent1.WriteCompleted += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.WriteCompletedEventArgs>(this.digital_OutputComponent1_WriteCompleted);
            this.digital_OutputComponent1.Error += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs>(this.digital_OutputComponent1_Error);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.numericEditArray2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 66);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(139, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericEditArray2
            // 
            this.numericEditArray2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.numericEditArray2.ItemTemplate.FormatMode = NationalInstruments.UI.NumericFormatMode.CreateHexadecimalMode();
            this.numericEditArray2.ItemTemplate.Location = new System.Drawing.Point(0, 0);
            this.numericEditArray2.ItemTemplate.Name = "";
            this.numericEditArray2.ItemTemplate.TabIndex = 0;
            this.numericEditArray2.ItemTemplate.TabStop = false;
            this.numericEditArray2.Location = new System.Drawing.Point(2, 2);
            this.numericEditArray2.Name = "numericEditArray2";
            this.numericEditArray2.Size = new System.Drawing.Size(137, 62);
            this.numericEditArray2.TabIndex = 1;
            // 
            // analog_InputComponent1
            // 
            this.analog_InputComponent1.Error += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs>(this.analog_InputComponent1_Error);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.waveformGraph1);
            this.panel3.Location = new System.Drawing.Point(443, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(304, 200);
            this.panel3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(226, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Read";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformGraph1.Location = new System.Drawing.Point(4, 3);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph1.Size = new System.Drawing.Size(300, 167);
            this.waveformGraph1.TabIndex = 1;
            this.waveformGraph1.UseColorGenerator = true;
            this.waveformGraph1.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph1.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // anlog_OutputComponent1
            // 
            this.anlog_OutputComponent1.WriteCompleted += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.WriteCompletedEventArgs>(this.anlog_OutputComponent1_WriteCompleted);
            this.anlog_OutputComponent1.Error += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs>(this.anlog_OutputComponent1_Error);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(5, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 200);
            this.panel4.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(226, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Write";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // waveformGraph2
            // 
            this.waveformGraph2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformGraph2.Location = new System.Drawing.Point(6, 206);
            this.waveformGraph2.Name = "waveformGraph2";
            this.waveformGraph2.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot2});
            this.waveformGraph2.Size = new System.Drawing.Size(300, 167);
            this.waveformGraph2.TabIndex = 1;
            this.waveformGraph2.UseColorGenerator = true;
            this.waveformGraph2.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis2});
            this.waveformGraph2.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis2});
            // 
            // waveformPlot2
            // 
            this.waveformPlot2.XAxis = this.xAxis2;
            this.waveformPlot2.YAxis = this.yAxis2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 506);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.waveformGraph2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.digital_InputComponent1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericEditArray1.ItemTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digital_OutputComponent1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericEditArray2.ItemTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analog_InputComponent1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anlog_OutputComponent1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Digital_InputComponent digital_InputComponent1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private NationalInstruments.UI.WindowsForms.NumericEditArray numericEditArray1;
        private Digital_OutputComponent digital_OutputComponent1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private NationalInstruments.UI.WindowsForms.NumericEditArray numericEditArray2;
        private Analog_InputComponent analog_InputComponent1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private Anlog_OutputComponent anlog_OutputComponent1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph2;
        private NationalInstruments.UI.WaveformPlot waveformPlot2;
        private NationalInstruments.UI.XAxis xAxis2;
        private NationalInstruments.UI.YAxis yAxis2;
    }
}

