namespace New_MPLAB
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.daqTask1Component1 = new New_MPLAB.DaqTask1Component(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.numericEditArray1 = new NationalInstruments.UI.WindowsForms.NumericEditArray();
            ((System.ComponentModel.ISupportInitialize)(this.daqTask1Component1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericEditArray1.ItemTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "Program uC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "MCLoader";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(497, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 67);
            this.button3.TabIndex = 2;
            this.button3.Text = "WebPage Tests";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // daqTask1Component1
            // 
            this.daqTask1Component1.WriteCompleted += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.WriteCompletedEventArgs>(this.daqTask1Component1_WriteCompleted);
            this.daqTask1Component1.Error += new System.EventHandler<NationalInstruments.DAQmx.ComponentModel.ErrorEventArgs>(this.daqTask1Component1_Error);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.numericEditArray1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 66);
            this.panel1.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(139, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Write";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 572);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.daqTask1Component1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericEditArray1.ItemTemplate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private DaqTask1Component daqTask1Component1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private NationalInstruments.UI.WindowsForms.NumericEditArray numericEditArray1;
            }
}

