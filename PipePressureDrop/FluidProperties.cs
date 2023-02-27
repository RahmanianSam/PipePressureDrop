using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipePressureDrop
{
    public class FluidProperties
    {
        private double m_miu_o_stc;
        private double m_miu_w_stc;
        private double m_miu_g_stc;
        public FluidProperties(double miu_o_stc, double miu_w_stc, double miu_g_stc)
        {
            m_miu_o_stc = miu_o_stc * (1 / ConversionFactor.CP_TO_KG_MSec);
            m_miu_w_stc = miu_w_stc * (1 / ConversionFactor.CP_TO_KG_MSec);
            m_miu_g_stc = miu_g_stc * (1 / ConversionFactor.CP_TO_KG_MSec);
        }

        public double CalculateRs(double p)               // solution gas-oil ratio, scf/stb
        {
            return 0.0461 * Math.Pow(p, 1.205);
        }

        public double CalculateBo(double p)               // oil formation volume factor, bbl/stb
        {
            double rs = CalculateRs(p);
            double bo = 0.972 + Math.Pow((rs * 0.00048 + 0.1026), 1.175);
            return bo;
        }

        public double CalculateBg(double p)               // gas formation volume factor, ft3/scf
        {
            return 16 / p;
        }
        public double CalculateOilDensity(double p)       // oil density, lb/ft3
        {
            double rs = CalculateRs(p);
            double bo = CalculateBo(p);
            double rho_o = (53.04 + 0.01254 * rs) / bo;
            return rho_o;
        }

        public double CalculateGasDensity(double p)       // gas density, lb/ft3
        {
            double rho_g = 0.0028 * p;
            return rho_g;
        }

        public double CalculateWaterDensity(double p)     // water density, lb/ft3
        {
            return 62.4;
        }

        public double CalculateWaterViscosity(double p)   // water viscoity, cp
        {
            return m_miu_w_stc;
        }
        public double CalculateOilViscosity(double p)     // oil viscosity, cp
        {
            return m_miu_o_stc;
        }
        public double CalculateGasViscosity(double p)     // gas viscosity, cp
        {
            return m_miu_g_stc;
        }
    }
}
