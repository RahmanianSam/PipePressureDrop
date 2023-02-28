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
        public Form1()
        {
            InitializeComponent();
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
                bool bValidGeometry = true;
                double length = 152.4;
                double diameter = 0.050673;
                double angle = 3.00;
                int numSeg = 1;

                var pipe_profiles = new Dictionary<string, List<double>>();
                pipe_profiles.Add("Distance", new List<double>());
                pipe_profiles.Add("Pressure", new List<double>());
                pipe_profiles.Add("Liquid Holdup", new List<double>());
                pipe_profiles.Add("delp_hydro", new List<double>());
                pipe_profiles.Add("delp_fric", new List<double>()); 

                string log_content = "";
                double pin = Double.Parse(this.InletP_textBox.Text);
                double pout = 0.0;
                var dist_list = pipe_profiles["Distance"];
                var pressure_list = pipe_profiles["Pressure"];
                dist_list.Add(0);
                pressure_list.Add(pin / 1000.0);
                double qo = Double.Parse(this.qo_textBox.Text);
                double qw = Double.Parse(this.qw_textBox.Text);
                double qg = Double.Parse(this.qg_textBox.Text);
                double miu_o = Double.Parse(this.OilVisc_textBox.Text);
                double miu_g = Double.Parse(this.GasVisc_textBox.Text);
                double miu_w = Double.Parse(this.WaterVisc_textBox.Text);
                PipeSystem pipeSys = new PipeSystem();
                FluidProperties prop = new FluidProperties(miu_o, miu_w, miu_g);
                PressureDropModel pdm = new PressureDropModel(prop);

                for (int iComp = 0; iComp < nComp; iComp++)
                {
                    length = Double.Parse(this.PipeDataGrid.Rows[iComp].Cells[1].Value.ToString());
                    diameter = Double.Parse(this.PipeDataGrid.Rows[iComp].Cells[0].Value.ToString());
                    angle = Double.Parse(this.PipeDataGrid.Rows[iComp].Cells[2].Value.ToString());
                    numSeg = int.Parse(this.PipeDataGrid.Rows[iComp].Cells[3].Value.ToString());

                    if (length == null || diameter == null || angle == null)
                    {
                        PipeDataGrid.Rows[iComp].DefaultCellStyle.BackColor = Color.Red;
                        bValidGeometry = false;
                    }
                    
                    log_content = "-----------------------------------------------" + System.Environment.NewLine;
                    Pipe pipe = new Pipe(length, diameter, angle, pdm, numSeg);
                    pipeSys.Add(pipe);

                }

                pout = pipeSys.CalculatePipeSystem_POut(pin, qo, qg, qw, ref pipe_profiles, ref log_content);
                this.OutletP_textBox.Text = pout.ToString();
                this.Log_TextBox.Text += log_content;
                plot(pipe_profiles);

                if (!bValidGeometry)
                {
                    return;
                }
                else
                {
                    for (int iComp = 0; iComp < nComp; iComp++)
                    {
                        PipeDataGrid.Rows[iComp].DefaultCellStyle.BackColor = Color.White;
                    }
                }


            }
            catch (Exception except)
            {
                this.Log_TextBox.Text += "Error: " + except.Message;
            }

        }


        private void plot(Dictionary<string, List<double>> profile_dict)
//private void plot(Dictionary<...> profile_dict)
        {
            var x_list = profile_dict["Distance"];
            var p_list = profile_dict["Pressure"];
            var Liq_Hp = profile_dict["Liquid Holdup"];
            var delp_hydro = profile_dict["delp_hydro"];
            var delp_fric = profile_dict["delp_fric"];
            // remove previous series on the chart
            for (int iSeri = 0, nSeri = this.pressure_chart.Series.Count; iSeri < nSeri; iSeri++)
                this.pressure_chart.Series.RemoveAt(0);


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
            pressure_chart.Series["Pressure Profile"].BorderWidth = 3;
            pressure_chart.Series[0].IsVisibleInLegend = false;
            pressure_chart.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Gray;
            pressure_chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Gray;
            pressure_chart.ChartAreas[0].AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            pressure_chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;

            pressure_chart.ChartAreas[0].AxisX.TitleFont = new Font("Sans Serif", 10, FontStyle.Bold);
            pressure_chart.ChartAreas[0].AxisY.TitleFont = new Font("Sans Serif", 10, FontStyle.Bold);

            // adding the data on the chart
            for (int iData = 0, nData = x_list.Count(); iData < nData; iData++)
            {
                double x = x_list[iData];
                double y = p_list[iData];
                pressure_chart.Series[0].Points.AddXY(x, y);
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

    
    }
}
