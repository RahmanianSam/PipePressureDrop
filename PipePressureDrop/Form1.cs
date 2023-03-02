using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PipePressureDrop
{
    public partial class Form1 : Form
    {
        bool m_isFiledUnit = false;
        public Form1()
        {
            InitializeComponent();
            this.SI_radioButton.Checked = true;
            
            PipeDataGrid.Rows.Add();
            PipeDataGrid.Rows[0].Cells[0].Value = 2.0;
            PipeDataGrid.Rows[0].Cells[1].Value = 500.0;
            PipeDataGrid.Rows[0].Cells[2].Value = 30.0;
            PipeDataGrid.Rows[0].Cells[3].Value = 1;
            for (int i = 0; i < PipeDataGrid.Columns.Count - 1; i++)
            {
                PipeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            PipeDataGrid.Columns[PipeDataGrid.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < PipeDataGrid.Columns.Count; i++)
            {
                int colw = PipeDataGrid.Columns[i].Width;
                PipeDataGrid.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                PipeDataGrid.Columns[i].Width = colw;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
           {
                PipeDataGrid.RowTemplate.Height = 30;
                int nComp = PipeDataGrid.Rows.Count - 1;
                double length = 152.4;
                double diameter = 0.050673;
                double angle = 3.00;
                int numSeg = 1;



                var pipe_profiles = new Dictionary<string, List<double>>();
                pipe_profiles.Add("Distance", new List<double>());
                pipe_profiles.Add("Pressure", new List<double>());
                pipe_profiles.Add("Liquid Holdup", new List<double>());
                pipe_profiles.Add("Reynolds number", new List<double>());


                string log_content = "";

                double pout = 0.0;
                var dist_list = pipe_profiles["Distance"];
                var pressure_list = pipe_profiles["Pressure"];
                var holdup_List = pipe_profiles["Liquid Holdup"];
                holdup_List.Add(0);
                dist_list.Add(0);


                double qo_input = Double.Parse(this.qo_textBox.Text);
                double qo = m_isFiledUnit ? qo_input * ConversionFactor.BBL_TO_M3 : qo_input;

                double qw_input = Double.Parse(this.qw_textBox.Text);
                double qw = m_isFiledUnit ? qw_input * ConversionFactor.BBL_TO_M3 : qw_input;

                double qg_input = Double.Parse(this.qg_textBox.Text);
                double qg = m_isFiledUnit ? qg_input * ConversionFactor.BBL_TO_M3 : qg_input;

                double miu_o_input = Double.Parse(this.OilVisc_textBox.Text);
                double miu_o = m_isFiledUnit ? miu_o_input * ConversionFactor.CP_TO_KG_MSec : miu_o_input;

                double miu_g_input = Double.Parse(this.GasVisc_textBox.Text);
                double miu_g = m_isFiledUnit ? miu_g_input * ConversionFactor.CP_TO_KG_MSec : miu_g_input;

                double miu_w_input = Double.Parse(this.WaterVisc_textBox.Text);
                double miu_w = m_isFiledUnit ? miu_w_input * ConversionFactor.CP_TO_KG_MSec : miu_w_input;

                double pin_input = Double.Parse(this.InletP_textBox.Text);
                double pin = m_isFiledUnit ? pin_input * ConversionFactor.PSI_TO_PA : pin_input;
                pressure_list.Add(pin / 1000.0);
                PipeSystem pipeSys = new PipeSystem();
                FluidProperties prop = new FluidProperties(miu_o, miu_w, miu_g);
                PressureDropModel pdm = new PressureDropModel(prop);

                for (int iComp = 0; iComp < nComp; iComp++)
                {
                    double length_input = Double.Parse(this.PipeDataGrid.Rows[iComp].Cells[1].Value.ToString());
                    length = m_isFiledUnit ? length_input * ConversionFactor.FT_TO_M : length_input;

                    double diameter_input = Double.Parse(this.PipeDataGrid.Rows[iComp].Cells[0].Value.ToString());
                    diameter = m_isFiledUnit ? diameter_input * ConversionFactor.FT_TO_M : diameter_input;

                    angle = Double.Parse(this.PipeDataGrid.Rows[iComp].Cells[2].Value.ToString());
                    numSeg = int.Parse(this.PipeDataGrid.Rows[iComp].Cells[3].Value.ToString());
                    log_content = "-----------------------------------------------" + System.Environment.NewLine;
                    Pipe pipe = new Pipe(length, diameter, angle, pdm, numSeg);
                    pipeSys.Add(pipe);

                }

                pout = pipeSys.CalculatePipeSystem_POut(pin, qo, qg, qw, ref pipe_profiles, ref log_content);
                this.OutletP_textBox.Text = pout.ToString();
                this.Log_TextBox.Text += log_content;
                plot(pipe_profiles);
            }

            catch (Exception except)
            {
                this.Log_TextBox.Text += "Error: " + except.Message;
            }

        }

        
        private void plot(Dictionary<string, List<double>> profile_dict)

        {
            var x_list = profile_dict["Distance"];
            var p_list = profile_dict["Pressure"];
            var holdup_list = profile_dict["Liquid Holdup"];
            // remove previous series on the chart
            for (int iSeri = 0, nSeri = this.pressure_chart.Series.Count; iSeri < nSeri; iSeri++)
                this.pressure_chart.Series.RemoveAt(0);
                this.reynolds_chart.Series.RemoveAt(0);

            // set up the min and max of the axes
            double Xmin = x_list.Min();
            double Xmax = x_list.Max();
            double Ymin = p_list.Min();
            double Ymax = p_list.Max();


            // add a new seri to the chart
            pressure_chart.Series.Add("Pressure Profile");


            // format the data display & axes titles & gridlines
            pressure_chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            pressure_chart.ChartAreas[0].AxisY.LabelStyle.Format = "#.##";
            pressure_chart.ChartAreas[0].AxisX.LabelStyle.Format = "#.#";
            pressure_chart.ChartAreas[0].AxisX.Minimum = Xmin;
            pressure_chart.ChartAreas[0].AxisX.Maximum = Xmax;
            pressure_chart.ChartAreas[0].AxisY.Minimum = Ymin;
            pressure_chart.ChartAreas[0].AxisY.Maximum = Ymax;
            pressure_chart.ChartAreas[0].AxisY.Title = "Pressure (kPa)";
            pressure_chart.ChartAreas[0].AxisX.Title = "X (m)";
            pressure_chart.Series[0].IsVisibleInLegend = false;
            pressure_chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            pressure_chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            pressure_chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            pressure_chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;

            pressure_chart.ChartAreas[0].AxisX.TitleFont = new Font("Sans Serif", 10, FontStyle.Bold);
            pressure_chart.ChartAreas[0].AxisY.TitleFont = new Font("Sans Serif", 10, FontStyle.Bold);

            // adding the data on the chart
            for (int iData = 0, nData = p_list.Count(); iData < nData; iData++)
            {
                double x = x_list[iData];
                double y = p_list[iData];
                pressure_chart.Series[0].Points.AddXY(x, y);
            }

            reynolds_chart.Series.Add("holdup vs Distance");

            double X_Rmin = x_list.Min();
            double X_Rmax = x_list.Max();
            double Y_Rmin = holdup_list.Min();
            double Y_Rmax = holdup_list.Max();
            // format the data display & axes titles & gridlines
            reynolds_chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            reynolds_chart.ChartAreas[0].AxisY.LabelStyle.Format = "0.##";
            reynolds_chart.ChartAreas[0].AxisX.LabelStyle.Format = "#.#";
            reynolds_chart.ChartAreas[0].AxisX.Minimum = X_Rmin;
            reynolds_chart.ChartAreas[0].AxisX.Maximum = X_Rmax;
            reynolds_chart.ChartAreas[0].AxisY.Minimum = Y_Rmin;
            reynolds_chart.ChartAreas[0].AxisY.Maximum = Y_Rmax;
            reynolds_chart.ChartAreas[0].AxisY.Title = "Hold Up";
            reynolds_chart.ChartAreas[0].AxisX.Title = "X (m)";
            reynolds_chart.Series[0].IsVisibleInLegend = false;
            reynolds_chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            reynolds_chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            reynolds_chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            reynolds_chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;

            reynolds_chart.ChartAreas[0].AxisX.TitleFont = new Font("Sans Serif", 10, FontStyle.Bold);
            reynolds_chart.ChartAreas[0].AxisY.TitleFont = new Font("Sans Serif", 10, FontStyle.Bold);
            //added
            // adding the data on the chart
            for (int iData = 0, nData = holdup_list.Count(); iData < nData; iData++)
            {
                double x = x_list[iData];
                double y = holdup_list[iData];
                reynolds_chart.Series[0].Points.AddXY(x, y);
            }

        }




        private void PipeDataGrid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(PipeDataGrid_KeyPress);
        }

        private void PipeDataGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void unit_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.Field_radioButton.Checked)
            {
                m_isFiledUnit = true;

                this.labelqom3day.Text = "bbl/day";
                double qo_field = Double.Parse(this.qo_textBox.Text) / ConversionFactor.BBL_TO_M3;
                this.qo_textBox.Text = qo_field.ToString();

                this.labelqwm3day.Text = "bbl/day";
                double qw_field = Double.Parse(this.qw_textBox.Text) / ConversionFactor.BBL_TO_M3;
                this.qw_textBox.Text = qw_field.ToString();

                this.labelqgm3day.Text = "bbl/day";
                double qg_field = Double.Parse(this.qg_textBox.Text) / ConversionFactor.BBL_TO_M3;
                this.qg_textBox.Text = qg_field.ToString();

                this.labelOilkgms.Text = "cp";
                double miuo_field = Double.Parse(this.OilVisc_textBox.Text) / ConversionFactor.CP_TO_KG_MSec;
                this.OilVisc_textBox.Text = miuo_field.ToString();

                this.labelWaterkgms.Text = "cp";
                double miuw_field = Double.Parse(this.WaterVisc_textBox.Text) / ConversionFactor.CP_TO_KG_MSec;
                this.WaterVisc_textBox.Text = miuo_field.ToString();

                this.labelGaskgms.Text = "cp";
                double miug_field = Double.Parse(this.GasVisc_textBox.Text) / ConversionFactor.CP_TO_KG_MSec;
                this.GasVisc_textBox.Text = miug_field.ToString();

                this.labelInletPa.Text = "Psi";
                double pin_field = Double.Parse(this.InletP_textBox.Text) / ConversionFactor.PSI_TO_PA;
                this.InletP_textBox.Text = pin_field.ToString();

                this.labelOutletPa.Text = "Psi";
                this.OutletP_textBox.Text = pout.ToString();
                double pin_field = Double.Parse(this.InletP_textBox.Text) / ConversionFactor.PSI_TO_PA;
                this.InletP_textBox.Text = pin_field.ToString();

                int nComp = PipeDataGrid.Rows.Count - 1;
                this.ColumnDimeter.HeaderText = "D (ft)";
                this.ColumnLength.HeaderText = "L (ft)";
                for (int iComp = 0; iComp < nComp; iComp++)
                {
                    double length_input = Double.Parse(this.PipeDataGrid.Rows[iComp].Cells[1].Value.ToString());
                    double length = length_input / ConversionFactor.FT_TO_M;
                    this.PipeDataGrid.Rows[iComp].Cells[1].Value = length.ToString();

                    double diameter_input = Double.Parse(this.PipeDataGrid.Rows[iComp].Cells[0].Value.ToString());
                    double diameter =diameter_input / ConversionFactor.FT_TO_M;
                    this.PipeDataGrid.Rows[iComp].Cells[0].Value = diameter.ToString();
                }
            }
            else
            {
                m_isFiledUnit = false;

                this.labelqom3day.Text = "m3 / day";
                double qo_si = Double.Parse(this.qo_textBox.Text) *  ConversionFactor.BBL_TO_M3;
                this.qo_textBox.Text = qo_si.ToString();

                this.labelqwm3day.Text = "m3 / day";
                double qw_si = Double.Parse(this.qw_textBox.Text) *  ConversionFactor.BBL_TO_M3;
                this.qw_textBox.Text = qw_si.ToString();

                this.labelqgm3day.Text = "m3 / day";
                double qg_si = Double.Parse(this.qg_textBox.Text) *  ConversionFactor.BBL_TO_M3;
                this.qg_textBox.Text = qg_si.ToString();

                this.labelOilkgms.Text = "kgm/sec";
                double miuo_si = Double.Parse(this.OilVisc_textBox.Text) * ConversionFactor.CP_TO_KG_MSec;
                this.OilVisc_textBox.Text = miuo_si.ToString();

                this.labelWaterkgms.Text = "kgm/sec";
                double miuw_si = Double.Parse(this.WaterVisc_textBox.Text) * ConversionFactor.CP_TO_KG_MSec;
                this.WaterVisc_textBox.Text = miuw_si.ToString();

                this.labelGaskgms.Text = "kgm/sec";
                double miug_si = Double.Parse(this.GasVisc_textBox.Text) * ConversionFactor.CP_TO_KG_MSec;
                this.GasVisc_textBox.Text = miug_si.ToString();

                this.labelInletPa.Text = "Pa";
                double pin_field = Double.Parse(this.InletP_textBox.Text) * ConversionFactor.PSI_TO_PA;
                this.InletP_textBox.Text = pin_field.ToString();

                this.labelOutletPa.Text = "Psi";

                this.ColumnDimeter.HeaderText = "D (m)";
                this.ColumnLength.HeaderText = "L (m)";
                int nComp = PipeDataGrid.Rows.Count - 1;
                for (int iComp = 0; iComp < nComp; iComp++)
                {
                    double length_input = Double.Parse(this.PipeDataGrid.Rows[iComp].Cells[1].Value.ToString());
                    double length = length_input * ConversionFactor.FT_TO_M;
                    this.PipeDataGrid.Rows[iComp].Cells[1].Value = length.ToString();

                    double diameter_input = Double.Parse(this.PipeDataGrid.Rows[iComp].Cells[0].Value.ToString());
                    double diameter =diameter_input * ConversionFactor.FT_TO_M;
                    this.PipeDataGrid.Rows[iComp].Cells[0].Value = diameter.ToString();
                }
            }

        }
    }
}
