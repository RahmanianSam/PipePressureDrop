using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipePressureDrop
{
    public class PressureDropModel
    {
        #region member variables
        private FluidProperties m_fluidProperties;
        #endregion

        #region properties
        public FluidProperties FProperties
        {
            get { return m_fluidProperties; }

        }

        #endregion


        #region constructors
        public PressureDropModel(FluidProperties fluidProperties)
        {
            m_fluidProperties = fluidProperties;

        }

        #endregion


        #region methods
        public double CalculatePressureLoss(double inletPress, double area, double diameter, double angle, double length, double inletOilFlowRate, double inletGasFlowRate, double inletWaterFlowRate)
        {
            // Units are converted to be compatible with the corrolations.
            double length_ft = length * (1.0 / ConversionFactor.FT_TO_M);
            double area_ft2 = area * (1.0 / Math.Pow(ConversionFactor.FT_TO_M, 2));
            double diameter_ft = diameter * (1.0 / ConversionFactor.FT_TO_M);
            double qo_ft3_per_s = inletOilFlowRate * (1.0 / (ConversionFactor.DAY_TO_SEC * ConversionFactor.FT3_TO_M3));
            double qw_ft3_per_s = inletWaterFlowRate * (1.0 / (ConversionFactor.DAY_TO_SEC * ConversionFactor.FT3_TO_M3));
            double qg_ft3_per_s = inletGasFlowRate * (1.0 / (ConversionFactor.DAY_TO_SEC * ConversionFactor.FT3_TO_M3));
            double pin_psi = inletPress * ConversionFactor.Pa_TO_Psi;
            double fo = qo_ft3_per_s / (qw_ft3_per_s + qo_ft3_per_s);
            double pout_psi = pin_psi;

            double pout_err = 1.0;

            while (pout_err > 0.05)
            {
                double p_ave_psi = (pin_psi + pout_psi) / 2.0;
                double rho_o = m_fluidProperties.CalculateOilDensity(p_ave_psi);
                double rho_w = m_fluidProperties.CalculateWaterDensity(p_ave_psi);
                double rho_g = m_fluidProperties.CalculateGasDensity(p_ave_psi);
                double rho_l = (fo * rho_o) + rho_w * (1.0 - fo);
                double miu_w = m_fluidProperties.CalculateWaterViscosity(p_ave_psi);
                double miu_g = m_fluidProperties.CalculateGasViscosity(p_ave_psi);
                double miu_o = m_fluidProperties.CalculateOilViscosity(p_ave_psi);
                double miu_l = (fo * miu_o) + miu_w * (1.0 - fo);
                double bo = m_fluidProperties.CalculateBo(p_ave_psi);
                double vso = qo_ft3_per_s * bo / area_ft2;
                double vsw = qw_ft3_per_s / area_ft2;
                double vsl = (fo * vso) + vsw * (1.0 - fo);
                double gor = qg_ft3_per_s / qo_ft3_per_s;
                double rs = m_fluidProperties.CalculateRs(p_ave_psi);
                double bg = m_fluidProperties.CalculateBg(p_ave_psi);
                double vsg = qo_ft3_per_s * (gor - rs / ConversionFactor.BBL_TO_Scf) * bg / area_ft2;                    // Rs is dimentionless here
                double vm = vsl + vsg;
                double lambda = vsl / vm;
                double rho_ns = rho_l * lambda + rho_g * (1.0 - lambda);
                double miu_ns = miu_l * lambda + miu_g * (1.0 - lambda);

                double miu_ns_convert = miu_ns * ConversionFactor.CP_TO_LB_FTSec;
                double re_num = rho_ns * vm * diameter_ft / miu_ns_convert;

                double fric = 0.0056 + 0.5 * Math.Pow(re_num, -0.32);
                double angle_rad = angle * 2 * Math.PI / 360.0;
                double dp_hyd = length_ft * rho_ns * Math.Sin(angle_rad) / Math.Pow(ConversionFactor.FT_TO_IN, 2);
                double dp_fric = length_ft * (fric * rho_ns * vm * Math.Abs(vm) / (2.0 * diameter_ft)) / Math.Pow(ConversionFactor.FT_TO_IN, 2) / ConversionFactor.G;
                double dp = dp_hyd + dp_fric;
                double pout_psi_new = pin_psi - dp;
                pout_err = Math.Abs(pout_psi - pout_psi_new) / pout_psi * 100.0;
                pout_psi = pout_psi_new;
            }

            double dp_out_pa = pout_psi * ConversionFactor.PSI_TO_PA;
            double pout = dp_out_pa;

            return pout;
        }

        #endregion

    }
}