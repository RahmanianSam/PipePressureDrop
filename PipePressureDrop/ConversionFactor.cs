using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipePressureDrop
{
    public static class ConversionFactor
    {
        public const double BBL_TO_FT3 = 5.6145835124493;           // unit conversion from barrel to cubic feet
        public const double BBL_TO_M3 = 0.1589873;                  // unit conversion from barrel to cubic meter
        public const double FT3_TO_M3 = 0.0283168;                  // unit conversion from cubic feet to cubic meter
        public const double CP_TO_LB_FTSec = 0.000671968994813;     // unit conversion from cp to lb/(ft.sec)
        public const double CP_TO_KG_MSec = 0.001;                  // unit conversion from cp to kg/(m.sec)
        public const double IN_TO_MM = 25.4;                        // unit conversion from inch to mm
        public const double FT_TO_M = 0.3048;                       // unit conversion from ft to m
        public const double PSI_TO_PA = 6894.75729;                 // unit conversion from psi to kPa
        public const double Pa_TO_Psi = 0.000145038;                // unit conversion from Pa to Psi
        public const double DAY_TO_SEC = 86400;                     // unit conversion from day to sec
        public const double FT_TO_IN = 12.0;                        // unit conversion from ft to inch
        public const double G = 32.174049;                          // accelation Gravity
        public const double BBL_TO_Scf = 5.615;                     // unit conversion from barrel to scf 
        public const double WATER_DENSITY = 62.4;                   // lb/ft3

    }
}
