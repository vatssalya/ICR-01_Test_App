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
            OpenWire.Proxy.SinkPin sinkPin1 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SourcePin sourcePin1 = new OpenWire.Proxy.SourcePin();
            OpenWire.Proxy.StatePin statePin1 = new OpenWire.Proxy.StatePin();
            Mitov.SignalLab.BinMask binMask1 = new Mitov.SignalLab.BinMask();
            OpenWire.Proxy.SourcePin sourcePin2 = new OpenWire.Proxy.SourcePin();
            OpenWire.Proxy.SinkPin sinkPin2 = new OpenWire.Proxy.SinkPin();
            OpenWire.Proxy.SourcePin sourcePin3 = new OpenWire.Proxy.SourcePin();
            OpenWire.Proxy.SourcePin sourcePin4 = new OpenWire.Proxy.SourcePin();
            Mitov.SignalLab.Threading threading1 = new Mitov.SignalLab.Threading();
            Mitov.SignalLab.ThreadingQueue threadingQueue1 = new Mitov.SignalLab.ThreadingQueue();
            this.digital_InputComponent1 = new NI_6001.Digital_InputComponent(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.numericEditArray1 = new NationalInstruments.UI.WindowsForms.NumericEditArray();
            this.digital_OutputComponent1 = new NI_6001.Digital_OutputComponent(this.components);
            this.analog_InputComponent1 = new NI_6001.Analog_InputComponent(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.anlog_OutputComponent1 = new NI_6001.Anlog_OutputComponent(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.waveformGraph2 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot2 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis2 = new NationalInstruments.UI.XAxis();
            this.yAxis2 = new NationalInstruments.UI.YAxis();
            this.analogOut_AO1Component1 = new NI_6001.AnalogOut_AO1Component(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.waveformGraph3 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot3 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis3 = new NationalInstruments.UI.XAxis();
            this.yAxis3 = new NationalInstruments.UI.YAxis();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.numericEditArray2 = new NationalInstruments.UI.WindowsForms.NumericEditArray();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.waveformGraph4 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot4 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis4 = new NationalInstruments.UI.XAxis();
            this.yAxis4 = new NationalInstruments.UI.YAxis();
            this.aI1Component1 = new NI_6001.AI1Component(this.components);
            this.aI_2Component1 = new NI_6001.AI_2Component(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.waveformGraph5 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot5 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis5 = new NationalInstruments.UI.XAxis();
            this.yAxis5 = new NationalInstruments.UI.YAxis();
            this.aI_3Component1 = new NI_6001.AI_3Component(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.waveformGraph6 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot6 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis6 = new NationalInstruments.UI.XAxis();
            this.yAxis6 = new NationalInstruments.UI.YAxis();
            this.aI_4Component1 = new NI_6001.AI_4Component(this.components);
            this.button9 = new System.Windows.Forms.Button();
            this.waveformGraph7 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot7 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis7 = new NationalInstruments.UI.XAxis();
            this.yAxis7 = new NationalInstruments.UI.YAxis();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.player1 = new Mitov.SignalLab.Player(this.components);
            this.noiseStats1 = new Mitov.SignalLab.NoiseStats(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.digital_InputComponent1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditArray1.ItemTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digital_OutputComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analog_InputComponent1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anlog_OutputComponent1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.analogOut_AO1Component1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditArray2.ItemTemplate)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI1Component1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI_2Component1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI_3Component1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI_4Component1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseStats1)).BeginInit();
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
            // analog_InputComponent1
            // 
            this.analog_InputComponent1.Error += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs>(this.analog_InputComponent1_Error);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(341, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 203);
            this.panel3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(223, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "AI_0";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformGraph1.Location = new System.Drawing.Point(341, 0);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph1.Size = new System.Drawing.Size(307, 181);
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
            this.panel4.Controls.Add(this.waveformGraph2);
            this.panel4.Location = new System.Drawing.Point(3, 215);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 211);
            this.panel4.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(226, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "AO_0";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // waveformGraph2
            // 
            this.waveformGraph2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformGraph2.Location = new System.Drawing.Point(-11, 7);
            this.waveformGraph2.Name = "waveformGraph2";
            this.waveformGraph2.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot2});
            this.waveformGraph2.Size = new System.Drawing.Size(309, 177);
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
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(577, 414);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "AO_1";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // waveformGraph3
            // 
            this.waveformGraph3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformGraph3.Location = new System.Drawing.Point(341, 228);
            this.waveformGraph3.Name = "waveformGraph3";
            this.waveformGraph3.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot3});
            this.waveformGraph3.Size = new System.Drawing.Size(311, 178);
            this.waveformGraph3.TabIndex = 1;
            this.waveformGraph3.UseColorGenerator = true;
            this.waveformGraph3.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis3});
            this.waveformGraph3.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis3});
            // 
            // waveformPlot3
            // 
            this.waveformPlot3.XAxis = this.xAxis3;
            this.waveformPlot3.YAxis = this.yAxis3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.numericEditArray2);
            this.panel2.Location = new System.Drawing.Point(3, 3);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(699, 226);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(304, 200);
            this.panel6.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(226, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "AI_1";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // waveformGraph4
            // 
            this.waveformGraph4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformGraph4.Location = new System.Drawing.Point(699, 226);
            this.waveformGraph4.Name = "waveformGraph4";
            this.waveformGraph4.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot4});
            this.waveformGraph4.Size = new System.Drawing.Size(314, 178);
            this.waveformGraph4.TabIndex = 1;
            this.waveformGraph4.UseColorGenerator = true;
            this.waveformGraph4.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis4});
            this.waveformGraph4.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis4});
            // 
            // waveformPlot4
            // 
            this.waveformPlot4.XAxis = this.xAxis4;
            this.waveformPlot4.YAxis = this.yAxis4;
            // 
            // aI1Component1
            // 
            this.aI1Component1.Error += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs>(this.aI1Component1_Error);
            // 
            // aI_2Component1
            // 
            this.aI_2Component1.Error += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs>(this.aI_2Component1_Error);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.button7);
            this.panel7.Location = new System.Drawing.Point(699, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(304, 200);
            this.panel7.TabIndex = 6;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Location = new System.Drawing.Point(226, 175);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "AI_2";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // waveformGraph5
            // 
            this.waveformGraph5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformGraph5.Location = new System.Drawing.Point(699, 3);
            this.waveformGraph5.Name = "waveformGraph5";
            this.waveformGraph5.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot5});
            this.waveformGraph5.Size = new System.Drawing.Size(310, 178);
            this.waveformGraph5.TabIndex = 1;
            this.waveformGraph5.UseColorGenerator = true;
            this.waveformGraph5.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis5});
            this.waveformGraph5.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis5});
            // 
            // waveformPlot5
            // 
            this.waveformPlot5.XAxis = this.xAxis5;
            this.waveformPlot5.YAxis = this.yAxis5;
            // 
            // aI_3Component1
            // 
            this.aI_3Component1.Error += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs>(this.aI_3Component1_Error);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.button8);
            this.panel5.Controls.Add(this.waveformGraph6);
            this.panel5.Location = new System.Drawing.Point(338, 442);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(304, 200);
            this.panel5.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(229, 163);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "AI_3";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // waveformGraph6
            // 
            this.waveformGraph6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformGraph6.Location = new System.Drawing.Point(4, 0);
            this.waveformGraph6.Name = "waveformGraph6";
            this.waveformGraph6.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot6});
            this.waveformGraph6.Size = new System.Drawing.Size(300, 167);
            this.waveformGraph6.TabIndex = 1;
            this.waveformGraph6.UseColorGenerator = true;
            this.waveformGraph6.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis6});
            this.waveformGraph6.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis6});
            // 
            // waveformPlot6
            // 
            this.waveformPlot6.XAxis = this.xAxis6;
            this.waveformPlot6.YAxis = this.yAxis6;
            // 
            // aI_4Component1
            // 
            this.aI_4Component1.Error += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs>(this.aI_4Component1_Error);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(938, 616);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 0;
            this.button9.Text = "AI_4";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // waveformGraph7
            // 
            this.waveformGraph7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.waveformGraph7.Location = new System.Drawing.Point(703, 432);
            this.waveformGraph7.Name = "waveformGraph7";
            this.waveformGraph7.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot7});
            this.waveformGraph7.Size = new System.Drawing.Size(310, 178);
            this.waveformGraph7.TabIndex = 1;
            this.waveformGraph7.UseColorGenerator = true;
            this.waveformGraph7.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis7});
            this.waveformGraph7.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis7});
            // 
            // waveformPlot7
            // 
            this.waveformPlot7.XAxis = this.xAxis7;
            this.waveformPlot7.YAxis = this.yAxis7;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(304, 200);
            this.panel8.TabIndex = 8;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(36, 450);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(142, 42);
            this.button10.TabIndex = 9;
            this.button10.Text = "Audio";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(37, 522);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(141, 44);
            this.button11.TabIndex = 10;
            this.button11.Text = "BarCode_Scanner";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // player1
            // 
            this.player1.ClockPin = sinkPin1;
            this.player1.OutputPin = sourcePin1;
            this.player1.ProgressPin = statePin1;
            this.player1.PumpPriority = ((uint)(0u));
            this.player1.SampleRate = 100000D;
            // 
            // noiseStats1
            // 
            this.noiseStats1.Alpha = 1D;
            this.noiseStats1.BinMask = binMask1;
            this.noiseStats1.DCBinWidth = ((uint)(3u));
            this.noiseStats1.FrequencyOutputPin = sourcePin2;
            this.noiseStats1.HarmonicBinWidth = ((uint)(3u));
            this.noiseStats1.InputPin = sinkPin2;
            this.noiseStats1.MaxDataVal = 32767D;
            this.noiseStats1.MinDataVal = -32767D;
            this.noiseStats1.NumberTerms = ((uint)(4u));
            this.noiseStats1.NumHarmonics = ((uint)(5u));
            this.noiseStats1.OutputPin = sourcePin3;
            this.noiseStats1.SamplingWindowStep = ((uint)(0u));
            this.noiseStats1.SpectrumOutputPin = sourcePin4;
            threadingQueue1.Size = ((uint)(15u));
            threading1.Queue = threadingQueue1;
            this.noiseStats1.Threading = threading1;
            this.noiseStats1.WindowThreshold = 0D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 644);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.waveformGraph7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.waveformGraph5);
            this.Controls.Add(this.waveformGraph1);
            this.Controls.Add(this.waveformGraph4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.waveformGraph3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel8);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.digital_InputComponent1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericEditArray1.ItemTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digital_OutputComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analog_InputComponent1)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anlog_OutputComponent1)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.analogOut_AO1Component1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericEditArray2.ItemTemplate)).EndInit();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI1Component1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI_2Component1)).EndInit();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI_3Component1)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aI_4Component1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noiseStats1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Digital_InputComponent digital_InputComponent1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private NationalInstruments.UI.WindowsForms.NumericEditArray numericEditArray1;
        private Digital_OutputComponent digital_OutputComponent1;
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
        private AnalogOut_AO1Component analogOut_AO1Component1;
        private System.Windows.Forms.Button button5;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph3;
        private NationalInstruments.UI.WaveformPlot waveformPlot3;
        private NationalInstruments.UI.XAxis xAxis3;
        private NationalInstruments.UI.YAxis yAxis3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private NationalInstruments.UI.WindowsForms.NumericEditArray numericEditArray2;
        private AI1Component aI1Component1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button6;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph4;
        private NationalInstruments.UI.WaveformPlot waveformPlot4;
        private NationalInstruments.UI.XAxis xAxis4;
        private NationalInstruments.UI.YAxis yAxis4;
        private AI_2Component aI_2Component1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button7;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph5;
        private NationalInstruments.UI.WaveformPlot waveformPlot5;
        private NationalInstruments.UI.XAxis xAxis5;
        private NationalInstruments.UI.YAxis yAxis5;
        private AI_3Component aI_3Component1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button8;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph6;
        private NationalInstruments.UI.WaveformPlot waveformPlot6;
        private NationalInstruments.UI.XAxis xAxis6;
        private NationalInstruments.UI.YAxis yAxis6;
        private AI_4Component aI_4Component1;
        private System.Windows.Forms.Button button9;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph7;
        private NationalInstruments.UI.WaveformPlot waveformPlot7;
        private NationalInstruments.UI.XAxis xAxis7;
        private NationalInstruments.UI.YAxis yAxis7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private Mitov.SignalLab.Player player1;
        private Mitov.SignalLab.NoiseStats noiseStats1;
    }
}

