using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Pipe Sysytem
namespace PipePressureDrop
{
    public class PipeSystem
    {
        #region member variable

        private List<Pipe> m_pipeList;


        #endregion

        #region properties
        public List<Pipe> PipeList
        {
            get { return m_pipeList; }
            set { m_pipeList = value; }
        }
        #endregion
        public double m_pout;


        #region constructor
        public PipeSystem()
        {
            PipeList = new List<Pipe>();
        }
        #endregion

        #region method
        public void Add(Pipe p)
        {
            PipeList.Add(p);

        }
        public double CalculatePipeSystem_POut(double inletPress, double qo, double qg, 
            double qw, ref Dictionary<string, List<double>> pipe_profiles, ref string m_log_content)
        {
            double m_pin_pipe = inletPress;
            double m_pout_pipe = inletPress;
            int i = 0;
            foreach (Pipe p in PipeList)
            {

                i++;
                m_log_content += $"Calculations in Pipe {i} Started!!" + System.Environment.NewLine;
                m_log_content += "-----------------------------------------------" + System.Environment.NewLine;
                m_pin_pipe = m_pout_pipe;
                m_pout_pipe = p.CalculateOutletPressure(m_pin_pipe, qo, qg, qw, ref m_log_content,
                                              ref pipe_profiles, p.Num_Seg);


            }
            m_log_content += "Calculation ended...! " + System.Environment.NewLine;
            return m_pout_pipe;
        }
        #endregion
    }

}
