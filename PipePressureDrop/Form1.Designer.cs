
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CalculatePOut_btn = new System.Windows.Forms.Button();
            this.PipeDataGrid = new System.Windows.Forms.DataGridView();
            this.ColumnDimeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAngle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSegColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelViscOIL = new System.Windows.Forms.Label();
            this.labelViscwater = new System.Windows.Forms.Label();
            this.labelViscgas = new System.Windows.Forms.Label();
            this.OilVisc_textBox = new System.Windows.Forms.TextBox();
            this.WaterVisc_textBox = new System.Windows.Forms.TextBox();
            this.GasVisc_textBox = new System.Windows.Forms.TextBox();
            this.labelOilkgms = new System.Windows.Forms.Label();
            this.labelWaterkgms = new System.Windows.Forms.Label();
            this.labelGaskgms = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Log_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.labelqo = new System.Windows.Forms.Label();
            this.qo_textBox = new System.Windows.Forms.TextBox();
            this.labelqom3day = new System.Windows.Forms.Label();
            this.labelqw = new System.Windows.Forms.Label();
            this.qw_textBox = new System.Windows.Forms.TextBox();
            this.labelqwm3day = new System.Windows.Forms.Label();
            this.labelqg = new System.Windows.Forms.Label();
            this.qg_textBox = new System.Windows.Forms.TextBox();
            this.labelqgm3day = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelInlet = new System.Windows.Forms.Label();
            this.InletP_textBox = new System.Windows.Forms.TextBox();
            this.labelInletPa = new System.Windows.Forms.Label();
            this.labelOutlet = new System.Windows.Forms.Label();
            this.OutletP_textBox = new System.Windows.Forms.TextBox();
            this.labelOutletPa = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pressure_tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pressure_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reynolds_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SI_radioButton = new System.Windows.Forms.RadioButton();
            this.Field_radioButton = new System.Windows.Forms.RadioButton();
            this.Units = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PipeDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.pressure_tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pressure_chart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reynolds_chart)).BeginInit();
            this.Units.SuspendLayout();
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
            // ColumnDimeter
            // 
            this.ColumnDimeter.HeaderText = "D (m)";
            this.ColumnDimeter.MaxInputLength = 300;
            this.ColumnDimeter.MinimumWidth = 12;
            this.ColumnDimeter.Name = "ColumnDimeter";
            this.ColumnDimeter.Width = 30;
            // 
            // ColumnLength
            // 
            this.ColumnLength.HeaderText = "L (m)";
            this.ColumnLength.MaxInputLength = 300;
            this.ColumnLength.MinimumWidth = 12;
            this.ColumnLength.Name = "ColumnLength";
            this.ColumnLength.Width = 30;
            // 
            // ColumnAngle
            // 
            this.ColumnAngle.HeaderText = "Angle (deg)";
            this.ColumnAngle.MaxInputLength = 300;
            this.ColumnAngle.MinimumWidth = 12;
            this.ColumnAngle.Name = "ColumnAngle";
            this.ColumnAngle.Width = 50;
            // 
            // NumSegColumn
            // 
            this.NumSegColumn.HeaderText = "Num Segments";
            this.NumSegColumn.MaxInputLength = 300;
            this.NumSegColumn.MinimumWidth = 12;
            this.NumSegColumn.Name = "NumSegColumn";
            this.NumSegColumn.Width = 50;
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
            // labelViscOIL
            // 
            this.labelViscOIL.AutoSize = true;
            this.labelViscOIL.Location = new System.Drawing.Point(146, 69);
            this.labelViscOIL.Name = "labelViscOIL";
            this.labelViscOIL.Size = new System.Drawing.Size(112, 32);
            this.labelViscOIL.TabIndex = 0;
            this.labelViscOIL.Text = "Visc Oil";
            // 
            // labelViscwater
            // 
            this.labelViscwater.AutoSize = true;
            this.labelViscwater.Location = new System.Drawing.Point(146, 140);
            this.labelViscwater.Name = "labelViscwater";
            this.labelViscwater.Size = new System.Drawing.Size(151, 32);
            this.labelViscwater.TabIndex = 1;
            this.labelViscwater.Text = "Visc Water";
            // 
            // labelViscgas
            // 
            this.labelViscgas.AutoSize = true;
            this.labelViscgas.Location = new System.Drawing.Point(146, 214);
            this.labelViscgas.Name = "labelViscgas";
            this.labelViscgas.Size = new System.Drawing.Size(128, 32);
            this.labelViscgas.TabIndex = 2;
            this.labelViscgas.Text = "Visc Gas";
            // 
            // OilVisc_textBox
            // 
            this.OilVisc_textBox.Location = new System.Drawing.Point(316, 63);
            this.OilVisc_textBox.Name = "OilVisc_textBox";
            this.OilVisc_textBox.Size = new System.Drawing.Size(223, 38);
            this.OilVisc_textBox.TabIndex = 1;
            this.OilVisc_textBox.Text = "0.002";
            // 
            // WaterVisc_textBox
            // 
            this.WaterVisc_textBox.Location = new System.Drawing.Point(316, 137);
            this.WaterVisc_textBox.Name = "WaterVisc_textBox";
            this.WaterVisc_textBox.Size = new System.Drawing.Size(223, 38);
            this.WaterVisc_textBox.TabIndex = 2;
            this.WaterVisc_textBox.Text = "0.001";
            // 
            // GasVisc_textBox
            // 
            this.GasVisc_textBox.Location = new System.Drawing.Point(316, 214);
            this.GasVisc_textBox.Name = "GasVisc_textBox";
            this.GasVisc_textBox.Size = new System.Drawing.Size(223, 38);
            this.GasVisc_textBox.TabIndex = 3;
            this.GasVisc_textBox.Text = "0.000015";
            // 
            // labelOilkgms
            // 
            this.labelOilkgms.AutoSize = true;
            this.labelOilkgms.Location = new System.Drawing.Point(600, 61);
            this.labelOilkgms.Name = "labelOilkgms";
            this.labelOilkgms.Size = new System.Drawing.Size(116, 32);
            this.labelOilkgms.TabIndex = 6;
            this.labelOilkgms.Text = "kg/(m.s)";
            // 
            // labelWaterkgms
            // 
            this.labelWaterkgms.AutoSize = true;
            this.labelWaterkgms.Location = new System.Drawing.Point(600, 140);
            this.labelWaterkgms.Name = "labelWaterkgms";
            this.labelWaterkgms.Size = new System.Drawing.Size(116, 32);
            this.labelWaterkgms.TabIndex = 7;
            this.labelWaterkgms.Text = "kg/(m.s)";
            // 
            // labelGaskgms
            // 
            this.labelGaskgms.AutoSize = true;
            this.labelGaskgms.Location = new System.Drawing.Point(600, 220);
            this.labelGaskgms.Name = "labelGaskgms";
            this.labelGaskgms.Size = new System.Drawing.Size(116, 32);
            this.labelGaskgms.TabIndex = 8;
            this.labelGaskgms.Text = "kg/(m.s)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelGaskgms);
            this.groupBox2.Controls.Add(this.labelWaterkgms);
            this.groupBox2.Controls.Add(this.labelOilkgms);
            this.groupBox2.Controls.Add(this.GasVisc_textBox);
            this.groupBox2.Controls.Add(this.WaterVisc_textBox);
            this.groupBox2.Controls.Add(this.OilVisc_textBox);
            this.groupBox2.Controls.Add(this.labelViscgas);
            this.groupBox2.Controls.Add(this.labelViscwater);
            this.groupBox2.Controls.Add(this.labelViscOIL);
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
            this.Log_TextBox.Size = new System.Drawing.Size(1354, 326);
            this.Log_TextBox.TabIndex = 11;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Log_TextBox);
            this.groupBox6.Location = new System.Drawing.Point(901, 941);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1434, 429);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Output Logs";
            // 
            // labelqo
            // 
            this.labelqo.AutoSize = true;
            this.labelqo.Location = new System.Drawing.Point(246, 51);
            this.labelqo.Name = "labelqo";
            this.labelqo.Size = new System.Drawing.Size(47, 32);
            this.labelqo.TabIndex = 0;
            this.labelqo.Text = "qo";
            // 
            // qo_textBox
            // 
            this.qo_textBox.AcceptsTab = true;
            this.qo_textBox.Location = new System.Drawing.Point(316, 45);
            this.qo_textBox.Name = "qo_textBox";
            this.qo_textBox.Size = new System.Drawing.Size(195, 38);
            this.qo_textBox.TabIndex = 4;
            this.qo_textBox.Text = "158.99";
            // 
            // labelqom3day
            // 
            this.labelqom3day.AutoSize = true;
            this.labelqom3day.Location = new System.Drawing.Point(562, 45);
            this.labelqom3day.Name = "labelqom3day";
            this.labelqom3day.Size = new System.Drawing.Size(108, 32);
            this.labelqom3day.TabIndex = 2;
            this.labelqom3day.Text = "m3/day";
            // 
            // labelqw
            // 
            this.labelqw.AutoSize = true;
            this.labelqw.Location = new System.Drawing.Point(246, 114);
            this.labelqw.Name = "labelqw";
            this.labelqw.Size = new System.Drawing.Size(51, 32);
            this.labelqw.TabIndex = 3;
            this.labelqw.Text = "qw";
            // 
            // qw_textBox
            // 
            this.qw_textBox.AcceptsTab = true;
            this.qw_textBox.Location = new System.Drawing.Point(316, 108);
            this.qw_textBox.Name = "qw_textBox";
            this.qw_textBox.Size = new System.Drawing.Size(195, 38);
            this.qw_textBox.TabIndex = 5;
            this.qw_textBox.Text = "0";
            // 
            // labelqwm3day
            // 
            this.labelqwm3day.AutoSize = true;
            this.labelqwm3day.Location = new System.Drawing.Point(562, 114);
            this.labelqwm3day.Name = "labelqwm3day";
            this.labelqwm3day.Size = new System.Drawing.Size(108, 32);
            this.labelqwm3day.TabIndex = 5;
            this.labelqwm3day.Text = "m3/day";
            // 
            // labelqg
            // 
            this.labelqg.AutoSize = true;
            this.labelqg.Location = new System.Drawing.Point(246, 176);
            this.labelqg.Name = "labelqg";
            this.labelqg.Size = new System.Drawing.Size(47, 32);
            this.labelqg.TabIndex = 6;
            this.labelqg.Text = "qg";
            // 
            // qg_textBox
            // 
            this.qg_textBox.AcceptsTab = true;
            this.qg_textBox.Location = new System.Drawing.Point(316, 176);
            this.qg_textBox.Name = "qg_textBox";
            this.qg_textBox.Size = new System.Drawing.Size(195, 38);
            this.qg_textBox.TabIndex = 6;
            this.qg_textBox.Text = "28316.85";
            // 
            // labelqgm3day
            // 
            this.labelqgm3day.AutoSize = true;
            this.labelqgm3day.Location = new System.Drawing.Point(562, 176);
            this.labelqgm3day.Name = "labelqgm3day";
            this.labelqgm3day.Size = new System.Drawing.Size(108, 32);
            this.labelqgm3day.TabIndex = 8;
            this.labelqgm3day.Text = "m3/day";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelqgm3day);
            this.groupBox3.Controls.Add(this.qg_textBox);
            this.groupBox3.Controls.Add(this.labelqg);
            this.groupBox3.Controls.Add(this.labelqwm3day);
            this.groupBox3.Controls.Add(this.qw_textBox);
            this.groupBox3.Controls.Add(this.labelqw);
            this.groupBox3.Controls.Add(this.labelqom3day);
            this.groupBox3.Controls.Add(this.qo_textBox);
            this.groupBox3.Controls.Add(this.labelqo);
            this.groupBox3.Location = new System.Drawing.Point(44, 719);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox3.Size = new System.Drawing.Size(837, 256);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Flow Rates";
            // 
            // labelInlet
            // 
            this.labelInlet.AutoSize = true;
            this.labelInlet.Location = new System.Drawing.Point(228, 73);
            this.labelInlet.Name = "labelInlet";
            this.labelInlet.Size = new System.Drawing.Size(69, 32);
            this.labelInlet.TabIndex = 0;
            this.labelInlet.Text = "Inlet";
            // 
            // InletP_textBox
            // 
            this.InletP_textBox.AcceptsTab = true;
            this.InletP_textBox.Location = new System.Drawing.Point(316, 73);
            this.InletP_textBox.Name = "InletP_textBox";
            this.InletP_textBox.Size = new System.Drawing.Size(195, 38);
            this.InletP_textBox.TabIndex = 7;
            this.InletP_textBox.Text = "7239540.0";
            // 
            // labelInletPa
            // 
            this.labelInletPa.AutoSize = true;
            this.labelInletPa.Location = new System.Drawing.Point(575, 79);
            this.labelInletPa.Name = "labelInletPa";
            this.labelInletPa.Size = new System.Drawing.Size(50, 32);
            this.labelInletPa.TabIndex = 2;
            this.labelInletPa.Text = "Pa";
            // 
            // labelOutlet
            // 
            this.labelOutlet.AutoSize = true;
            this.labelOutlet.Location = new System.Drawing.Point(218, 136);
            this.labelOutlet.Name = "labelOutlet";
            this.labelOutlet.Size = new System.Drawing.Size(92, 32);
            this.labelOutlet.TabIndex = 3;
            this.labelOutlet.Text = "Outlet";
            // 
            // OutletP_textBox
            // 
            this.OutletP_textBox.AcceptsTab = true;
            this.OutletP_textBox.Location = new System.Drawing.Point(316, 136);
            this.OutletP_textBox.Name = "OutletP_textBox";
            this.OutletP_textBox.ReadOnly = true;
            this.OutletP_textBox.Size = new System.Drawing.Size(195, 38);
            this.OutletP_textBox.TabIndex = 8;
            // 
            // labelOutletPa
            // 
            this.labelOutletPa.AutoSize = true;
            this.labelOutletPa.Location = new System.Drawing.Point(575, 136);
            this.labelOutletPa.Name = "labelOutletPa";
            this.labelOutletPa.Size = new System.Drawing.Size(50, 32);
            this.labelOutletPa.TabIndex = 5;
            this.labelOutletPa.Text = "Pa";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelOutletPa);
            this.groupBox4.Controls.Add(this.OutletP_textBox);
            this.groupBox4.Controls.Add(this.labelOutlet);
            this.groupBox4.Controls.Add(this.labelInletPa);
            this.groupBox4.Controls.Add(this.InletP_textBox);
            this.groupBox4.Controls.Add(this.labelInlet);
            this.groupBox4.Location = new System.Drawing.Point(44, 989);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox4.Size = new System.Drawing.Size(837, 209);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pressure";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 1241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(402, 111);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate Outlet Pressure";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pressure_tabControl);
            this.groupBox5.Location = new System.Drawing.Point(901, 39);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1434, 880);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "PipeProperty Profile";
            // 
            // pressure_tabControl
            // 
            this.pressure_tabControl.Controls.Add(this.tabPage1);
            this.pressure_tabControl.Controls.Add(this.tabPage2);
            this.pressure_tabControl.Location = new System.Drawing.Point(30, 37);
            this.pressure_tabControl.Name = "pressure_tabControl";
            this.pressure_tabControl.SelectedIndex = 0;
            this.pressure_tabControl.Size = new System.Drawing.Size(1366, 816);
            this.pressure_tabControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pressure_chart);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1346, 758);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pressure";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pressure_chart.Series.Add(series1);
            this.pressure_chart.Size = new System.Drawing.Size(1283, 694);
            this.pressure_chart.TabIndex = 10;
            this.pressure_chart.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reynolds_chart);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1346, 758);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "HoldUp";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reynolds_chart
            // 
            chartArea2.Name = "ChartArea1";
            this.reynolds_chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.reynolds_chart.Legends.Add(legend2);
            this.reynolds_chart.Location = new System.Drawing.Point(27, 21);
            this.reynolds_chart.Name = "reynolds_chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.reynolds_chart.Series.Add(series2);
            this.reynolds_chart.Size = new System.Drawing.Size(1313, 720);
            this.reynolds_chart.TabIndex = 0;
            this.reynolds_chart.Text = "chart1";
            // 
            // SI_radioButton
            // 
            this.SI_radioButton.AutoSize = true;
            this.SI_radioButton.Checked = true;
            this.SI_radioButton.Location = new System.Drawing.Point(17, 37);
            this.SI_radioButton.Name = "SI_radioButton";
            this.SI_radioButton.Size = new System.Drawing.Size(136, 36);
            this.SI_radioButton.TabIndex = 13;
            this.SI_radioButton.TabStop = true;
            this.SI_radioButton.Text = "SI Unit";
            this.SI_radioButton.UseVisualStyleBackColor = true;
            this.SI_radioButton.CheckedChanged += new System.EventHandler(this.unit_radioButton_CheckedChanged);
            // 
            // Field_radioButton
            // 
            this.Field_radioButton.AutoSize = true;
            this.Field_radioButton.Location = new System.Drawing.Point(17, 79);
            this.Field_radioButton.Name = "Field_radioButton";
            this.Field_radioButton.Size = new System.Drawing.Size(173, 36);
            this.Field_radioButton.TabIndex = 14;
            this.Field_radioButton.Text = "Field Unit";
            this.Field_radioButton.UseVisualStyleBackColor = true;
            // 
            // Units
            // 
            this.Units.Controls.Add(this.SI_radioButton);
            this.Units.Controls.Add(this.Field_radioButton);
            this.Units.Location = new System.Drawing.Point(633, 1220);
            this.Units.Name = "Units";
            this.Units.Size = new System.Drawing.Size(257, 131);
            this.Units.TabIndex = 15;
            this.Units.TabStop = false;
            this.Units.Text = "Units";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2368, 1362);
            this.Controls.Add(this.Units);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.CalculatePOut_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(2400, 1450);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "CMG Practicum";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
            this.groupBox5.ResumeLayout(false);
            this.pressure_tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pressure_chart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reynolds_chart)).EndInit();
            this.Units.ResumeLayout(false);
            this.Units.PerformLayout();
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
        private System.Windows.Forms.Label labelViscOIL;
        private System.Windows.Forms.Label labelViscwater;
        private System.Windows.Forms.Label labelViscgas;
        private System.Windows.Forms.TextBox OilVisc_textBox;
        private System.Windows.Forms.TextBox WaterVisc_textBox;
        private System.Windows.Forms.TextBox GasVisc_textBox;
        private System.Windows.Forms.Label labelOilkgms;
        private System.Windows.Forms.Label labelWaterkgms;
        private System.Windows.Forms.Label labelGaskgms;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Log_TextBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label labelqo;
        private System.Windows.Forms.TextBox qo_textBox;
        private System.Windows.Forms.Label labelqom3day;
        private System.Windows.Forms.Label labelqw;
        private System.Windows.Forms.TextBox qw_textBox;
        private System.Windows.Forms.Label labelqwm3day;
        private System.Windows.Forms.Label labelqg;
        private System.Windows.Forms.TextBox qg_textBox;
        private System.Windows.Forms.Label labelqgm3day;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelInlet;
        private System.Windows.Forms.TextBox InletP_textBox;
        private System.Windows.Forms.Label labelInletPa;
        private System.Windows.Forms.Label labelOutlet;
        private System.Windows.Forms.TextBox OutletP_textBox;
        private System.Windows.Forms.Label labelOutletPa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabControl pressure_tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataVisualization.Charting.Chart pressure_chart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart reynolds_chart;
        private System.Windows.Forms.RadioButton SI_radioButton;
        private System.Windows.Forms.RadioButton Field_radioButton;
        private System.Windows.Forms.GroupBox Units;
    }
}

