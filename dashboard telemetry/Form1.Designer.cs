namespace dashboard_telemetry
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_open = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.button_close = new System.Windows.Forms.Button();
            this.label_port = new System.Windows.Forms.Label();
            this.textBox_Recieve = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(237, 46);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(75, 23);
            this.button_open.TabIndex = 1;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(372, 181);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(416, 175);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(110, 48);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(121, 21);
            this.comboBox_port.TabIndex = 3;
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(318, 46);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 23);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(75, 51);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(29, 13);
            this.label_port.TabIndex = 5;
            this.label_port.Text = "Port:";
            // 
            // textBox_Recieve
            // 
            this.textBox_Recieve.Location = new System.Drawing.Point(110, 91);
            this.textBox_Recieve.Multiline = true;
            this.textBox_Recieve.Name = "textBox_Recieve";
            this.textBox_Recieve.Size = new System.Drawing.Size(231, 35);
            this.textBox_Recieve.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Recieve);
            this.Controls.Add(this.label_port);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label_port;
        private System.Windows.Forms.TextBox textBox_Recieve;
        private System.IO.Ports.SerialPort serialPort1;
    }
}

