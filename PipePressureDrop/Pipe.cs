using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipePressureDrop

{
    //Pipe
    public class Pipe
    {
        # region member_variables
        private double m_length;
        private double m_diameter;
        private double m_inclination_angle;
        private double m_area;
        private double m_inletPressure;
        public double m_log_content;
        private double m_num_seg;
        private PressureDropModel m_pressureDropModel;
        # endregion

        # region properties
        public double Length
        {
            get { return m_length; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Length of pipe should be positive.");
                }
                else
                {
                    m_length = value;
                }
            }
        }
        public double Diameter
        {
            get { return m_diameter; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Diameter of pipe should be positive.");
                }
                else
                {
                    m_diameter = value;
                }
            }
        }

        public double InclinationAngle
        {
            get { return m_inclination_angle; }
            set
            {
                if (value < 0 || value > 360)
                {
                    throw new Exception("Inclination angle of pipe should be in the range of 0 and 360.");
                }
                else
                {
                    m_inclination_angle = value;
                }
            }
        }

        public double Area
        {
            get { return m_area; }
        }

        public double InletPressure
        {
            get { return m_inletPressure; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("InletPressure of pipe should be positive.");
                }
                else
                {
                    m_inletPressure = value;
                }
            }
        }

        public double Num_Seg
        {
            get { return m_num_seg; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Number of Segment for pipe should be positive.");
                }
                else
                {
                    m_num_seg = value;
                }
            }
        }

        public PressureDropModel PressureDropModel
        {
            get { return m_pressureDropModel; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Pressure Model Can Not be null");
                }
                else
                {
                    m_pressureDropModel = value;
                }
            }
        }
        # endregion

        # region constructors
        public Pipe(double length, double diameter, double inclination_angle, PressureDropModel pressureDropModel, double num_seg)
        {
            Length = length;
            Diameter = diameter;
            InclinationAngle = inclination_angle;
            PressureDropModel = pressureDropModel;
            m_area = (Math.PI * Math.Pow(m_diameter, 2) / 4.0);
            Num_Seg = num_seg;
        }

        public Pipe(Pipe origPipe)
        {
            this.Length = origPipe.Length;
            this.Diameter = origPipe.Diameter;
            this.InclinationAngle = origPipe.InclinationAngle;
            this.PressureDropModel = origPipe.PressureDropModel;
            this.m_area = origPipe.Area;
        }

        #endregion
        //added
        # region method
        public double CalculateOutletPressure(double inletPress, double qo, double qg, double qw, ref string m_log_content,
                                              ref Dictionary<string, List<double>> pipe_profiles, double numSeg = 1)
        {

            double len_seg = Length / numSeg;
            double seg_pin = inletPress;
            double pout_seg = inletPress;
            m_log_content += " seg#     X (m)      Pressure (kPa)" + System.Environment.NewLine;
            m_log_content += "-----------------------------------------------" + System.Environment.NewLine;
            var dist_list = pipe_profiles["Distance"];
            var pressure_list = pipe_profiles["Pressure"];
            var holdup_List = pipe_profiles["Liquid Holdup"];
            double hp = 0;

            for (int i_seg = 0; i_seg < numSeg; i_seg++)
            {
                pout_seg = m_pressureDropModel.CalculatePressureLoss(seg_pin, m_area, Diameter, InclinationAngle, len_seg, qo, qg, qw, out hp);
                pressure_list.Add(pout_seg / 1000.0);
                double x = dist_list.Last() + len_seg;
                dist_list.Add(x);
                holdup_List.Add(hp);
                seg_pin = pout_seg;
                m_log_content +=$" {i_seg + 1}          {Math.Round(x, 2)}         { Math.Round((pout_seg / 1000.0),4)} " + System.Environment.NewLine;

            }

            m_log_content += "-----------------------------------------------" + System.Environment.NewLine;
            return pout_seg;
        }
        #endregion
    }
}
