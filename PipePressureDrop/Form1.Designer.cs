
namespace PipePressureDrop
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CalculatePOut_btn = new System.Windows.Forms.Button();
            this.PipeDataGrid = new System.Windows.Forms.DataGridView();
            this.NumSegColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDimeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OilVisc_textBox = new System.Windows.Forms.TextBox();
            this.WaterVisc_textBox = new System.Windows.Forms.TextBox();
            this.GasVisc_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Log_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.qo_textBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.qw_textBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.qg_textBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.InletP_textBox = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.OutletP_textBox = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pressure_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pressure_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pressure_tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pressure_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // CalculatePOut_btn
            // 
            this.CalculatePOut_btn.Location = new System.Drawing.Point(695, 3420);
            this.CalculatePOut_btn.Name = "CalculatePOut_btn";
            this.CalculatePOut_btn.Size = new System.Drawing.Size(355, 102);
            this.CalculatePOut_btn.TabIndex = 12;
            this.CalculatePOut_btn.Text = "Calculate Outlet Pressure";
            this.CalculatePOut_btn.UseVisualStyleBackColor = true;
            // 
            // PipeDataGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PipeDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PipeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PipeDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDimeter,
            this.ColumnLength,
            this.ColumnAngle,
            this.NumSegColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PipeDataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.PipeDataGrid.Location = new System.Drawing.Point(28, 37);
            this.PipeDataGrid.Name = "PipeDataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PipeDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PipeDataGrid.RowHeadersWidth = 102;
            this.PipeDataGrid.RowTemplate.Height = 20;
            this.PipeDataGrid.Size = new System.Drawing.Size(786, 308);
            this.PipeDataGrid.TabIndex = 0;
            // 
            // NumSegColumn
            // 
            this.NumSegColumn.HeaderText = "Num Segments";
            this.NumSegColumn.MaxInputLength = 300;
            this.NumSegColumn.MinimumWidth = 12;
            this.NumSegColumn.Name = "NumSegColumn";
            this.NumSegColumn.Width = 50;
            // 
            // ColumnAngle
            // 
            this.ColumnAngle.HeaderText = "Angle (deg)";
            this.ColumnAngle.MaxInputLength = 300;
            this.ColumnAngle.MinimumWidth = 12;
            this.ColumnAngle.Name = "ColumnAngle";
            this.ColumnAngle.Width = 50;
            // 
            // ColumnLength
            // 
            this.ColumnLength.HeaderText = "L (m)";
            this.ColumnLength.MaxInputLength = 300;
            this.ColumnLength.MinimumWidth = 12;
            this.ColumnLength.Name = "ColumnLength";
            this.ColumnLength.Width = 30;
            // 
            // ColumnDimeter
            // 
            this.ColumnDimeter.HeaderText = "D (m)";
            this.ColumnDimeter.MaxInputLength = 300;
            this.ColumnDimeter.MinimumWidth = 12;
            this.ColumnDimeter.Name = "ColumnDimeter";
            this.ColumnDimeter.Width = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PipeDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(44, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 367);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pipe Characterestics";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visc Oil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Visc Water";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Visc Gas";
            // 
            // OilVisc_textBox
            // 
            this.OilVisc_textBox.Location = new System.Drawing.Point(316, 63);
            this.OilVisc_textBox.Name = "OilVisc_textBox";
            this.OilVisc_textBox.Size = new System.Drawing.Size(223, 38);
            this.OilVisc_textBox.TabIndex = 3;
            // 
            // WaterVisc_textBox
            // 
            this.WaterVisc_textBox.Location = new System.Drawing.Point(316, 137);
            this.WaterVisc_textBox.Name = "WaterVisc_textBox";
            this.WaterVisc_textBox.Size = new System.Drawing.Size(223, 38);
            this.WaterVisc_textBox.TabIndex = 4;
            // 
            // GasVisc_textBox
            // 
            this.GasVisc_textBox.Location = new System.Drawing.Point(316, 214);
            this.GasVisc_textBox.Name = "GasVisc_textBox";
            this.GasVisc_textBox.Size = new System.Drawing.Size(223, 38);
            this.GasVisc_textBox.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(600, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 32);
            this.label11.TabIndex = 6;
            this.label11.Text = "kg/(m.s)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "kg/(m.s)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "kg/(m.s)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.GasVisc_textBox);
            this.groupBox2.Controls.Add(this.WaterVisc_textBox);
            this.groupBox2.Controls.Add(this.OilVisc_textBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(44, 427);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 282);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "FluidProperties";
            // 
            // Log_TextBox
            // 
            this.Log_TextBox.Location = new System.Drawing.Point(32, 62);
            this.Log_TextBox.Multiline = true;
            this.Log_TextBox.Name = "Log_TextBox";
            this.Log_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Log_TextBox.Size = new System.Drawing.Size(1158, 326);
            this.Log_TextBox.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Log_TextBox);
            this.groupBox6.Location = new System.Drawing.Point(901, 982);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1190, 429);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Output Logs";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(246, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 32);
            this.label18.TabIndex = 0;
            this.label18.Text = "qo";
            // 
            // qo_textBox
            // 
            this.qo_textBox.AcceptsTab = true;
            this.qo_textBox.Location = new System.Drawing.Point(333, 51);
            this.qo_textBox.Name = "qo_textBox";
            this.qo_textBox.Size = new System.Drawing.Size(195, 38);
            this.qo_textBox.TabIndex = 1;
            this.qo_textBox.Text = "158.99";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(566, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 32);
            this.label17.TabIndex = 2;
            this.label17.Text = "m3/day";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(246, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 32);
            this.label16.TabIndex = 3;
            this.label16.Text = "qw";
            // 
            // qw_textBox
            // 
            this.qw_textBox.AcceptsTab = true;
            this.qw_textBox.Location = new System.Drawing.Point(333, 114);
            this.qw_textBox.Name = "qw_textBox";
            this.qw_textBox.Size = new System.Drawing.Size(195, 38);
            this.qw_textBox.TabIndex = 4;
            this.qw_textBox.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(575, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 32);
            this.label15.TabIndex = 5;
            this.label15.Text = "m3/day";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(246, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 32);
            this.label14.TabIndex = 6;
            this.label14.Text = "qg";
            // 
            // qg_textBox
            // 
            this.qg_textBox.AcceptsTab = true;
            this.qg_textBox.Location = new System.Drawing.Point(333, 176);
            this.qg_textBox.Name = "qg_textBox";
            this.qg_textBox.Size = new System.Drawing.Size(195, 38);
            this.qg_textBox.TabIndex = 7;
            this.qg_textBox.Text = "28316.85";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(575, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 32);
            this.label13.TabIndex = 8;
            this.label13.Text = "m3/day";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.qg_textBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.qw_textBox);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.qo_textBox);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(44, 719);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Size = new System.Drawing.Size(837, 256);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flow Rates";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(228, 73);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 32);
            this.label24.TabIndex = 0;
            this.label24.Text = "Inlet";
            // 
            // InletP_textBox
            // 
            this.InletP_textBox.AcceptsTab = true;
            this.InletP_textBox.Location = new System.Drawing.Point(333, 73);
            this.InletP_textBox.Name = "InletP_textBox";
            this.InletP_textBox.Size = new System.Drawing.Size(195, 38);
            this.InletP_textBox.TabIndex = 1;
            this.InletP_textBox.Text = "7239540.0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(575, 79);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(50, 32);
            this.label23.TabIndex = 2;
            this.label23.Text = "Pa";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(218, 136);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(92, 32);
            this.label22.TabIndex = 3;
            this.label22.Text = "Outlet";
            // 
            // OutletP_textBox
            // 
            this.OutletP_textBox.AcceptsTab = true;
            this.OutletP_textBox.Location = new System.Drawing.Point(333, 136);
            this.OutletP_textBox.Name = "OutletP_textBox";
            this.OutletP_textBox.ReadOnly = true;
            this.OutletP_textBox.Size = new System.Drawing.Size(195, 38);
            this.OutletP_textBox.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(575, 136);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 32);
            this.label21.TabIndex = 5;
            this.label21.Text = "Pa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.OutletP_textBox);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.InletP_textBox);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(44, 989);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox4.Size = new System.Drawing.Size(837, 209);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pressure";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 1271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 114);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate Outlet Pressure";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pressure_tabControl
            // 
            this.pressure_tabControl.Controls.Add(this.tabPage1);
            this.pressure_tabControl.Location = new System.Drawing.Point(30, 45);
            this.pressure_tabControl.Name = "pressure_tabControl";
            this.pressure_tabControl.SelectedIndex = 0;
            this.pressure_tabControl.Size = new System.Drawing.Size(1126, 808);
            this.pressure_tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pressure_chart);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1106, 750);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pressure";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pressure_tabControl);
            this.groupBox5.Location = new System.Drawing.Point(901, 76);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1190, 880);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PipeProperty Profile";
            // 
            // pressure_chart
            // 
            chartArea1.Name = "ChartArea1";
            this.pressure_chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pressure_chart.Legends.Add(legend1);
            this.pressure_chart.Location = new System.Drawing.Point(25, 25);
            this.pressure_chart.Name = "pressure_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pressure_chart.Series.Add(series1);
            this.pressure_chart.Size = new System.Drawing.Size(1054, 694);
            this.pressure_chart.TabIndex = 0;
            this.pressure_chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2136, 1421);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.CalculatePOut_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "CMG Practicum";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PipeDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pressure_tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pressure_chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalculatePOut_btn;
        private System.Windows.Forms.DataGridView PipeDataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDimeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAngle;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumSegColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OilVisc_textBox;
        private System.Windows.Forms.TextBox WaterVisc_textBox;
        private System.Windows.Forms.TextBox GasVisc_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Log_TextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox qo_textBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox qw_textBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox qg_textBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox InletP_textBox;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox OutletP_textBox;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl pressure_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressure_chart;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

