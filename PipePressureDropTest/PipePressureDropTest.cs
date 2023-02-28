using Microsoft.VisualStudio.TestTools.UnitTesting;
using PipePressureDrop;
using System.Collections.Generic;


namespace PipePressureDropTest
{
    [TestClass]
    public class FluidPropertiesTest
    {
        [TestMethod]
        public void TestCalculateRs()
        {
            FluidProperties props = new FluidProperties(0.001, 0.001, 0.000015);
            double p = 14.7;
            double rs = props.CalculateRs(p);
            Assert.AreEqual(rs, 0.0461 * System.Math.Pow(p, 1.205));
        }

        [TestMethod]
        public void TestCalculateBo()
        {
            FluidProperties props = new FluidProperties(0.001, 0.001, 0.000015);
            double p1 = 15.0;
            double rs = props.CalculateRs(p1);
            double bo = props.CalculateBo(p1);
            Assert.AreEqual(bo, 0.972 + System.Math.Pow((rs * 0.00048 + 0.1026), 1.175), 0.0001);
        }

    }

    [TestClass]
    public class PressureDropModelTest
    {
        [TestMethod]
        public void TestCalculateOutletPressure_dp_fric()
        {
            FluidProperties prob = new FluidProperties(0.001, 0.001, 0.000015);
            PressureDropModel pd = new PressureDropModel(prob);
            double pin = 101325.0;
            double d = 0.15;
            double area = System.Math.PI * System.Math.Pow(d, 2) / 4;
            double angle = 0.0;         // Ignored the effect of friction pressure
            double length = 1.0;
            double qo = 0.0000001;
            double qw = 0.01;
            double qg = 0.00000001;
            double reynolds = 0.0;

            double pout = pd.CalculatePressureLoss(pin, area, d, angle, length, qo, qg, qw, ref reynolds);
            Assert.AreEqual(pout, pin, 0.0001 * pin);
        }

        [TestMethod]
        public void TestCalculateOutletPressure_dp_hyd()
        {
            FluidProperties prob = new FluidProperties(0.001, 0.001, 0.000015);
            PressureDropModel pd = new PressureDropModel(prob);
            double pin = 101325.0;
            double d = 0.15;
            double area = System.Math.PI * System.Math.Pow(d, 2) / 4;
            double angle = 90;         // Ignored the effect of friction pressure
            double length = 1.0;
            double qo = 0.0000001;
            double qw = 0.01;
            double qg = 0.00000001;
            double reynolds = 0.0;
            double pout = pd.CalculatePressureLoss(pin, area, d, angle, length, qo, qg, qw, ref reynolds);

            double dp_hyd_est = 1000.0 * 9.81 * 1.0;
            double pout_est = pin - dp_hyd_est;
            Assert.AreEqual(pout, pout_est, 0.0001 * pout);
        }
    }

    [TestClass]
    public class PipeTest
    {
        [TestMethod]
        public void TestPipeCalculateOutletPressure_1_segment()
        {
            double pin = 7239540.0;
            double diameter = 0.050673;
            double area = System.Math.PI * System.Math.Pow(diameter, 2) / 4;
            double angle = 30.0;
            double length = 152.4;
            double qo = 158.99;
            double qw = 0.00;
            double qg = 28316.85;
            double muo = 0.002;
            double mug = 0.000015;
            double muw = 0.001;
            int numSeg = 1;

            string log_content = "-------------------------------" + System.Environment.NewLine;
            FluidProperties prob = new FluidProperties(muo, muw, mug);
            PressureDropModel pd = new PressureDropModel(prob);
            var pipe_profiles = new Dictionary<string, List<double>>();
            pipe_profiles.Add("Distance", new List<double>());
            pipe_profiles.Add("Pressure", new List<double>());
            pipe_profiles.Add("Liquid Holdup", new List<double>());
            pipe_profiles.Add("Reynolds number", new List<double>());
            var dist_list = pipe_profiles["Distance"];
            var pressure_list = pipe_profiles["Pressure"];
            var re_List = pipe_profiles["Reynolds number"];
            pressure_list.Add(pin);
            dist_list.Add(0);
            re_List.Add(0);
            Pipe pipe_1 = new Pipe(length, diameter, angle, pd, numSeg);
            double pout = pipe_1.CalculateOutletPressure(pin, qo, qg, qw, ref log_content, ref pipe_profiles, numSeg);

            Assert.AreEqual(pout, 6935726.61909728, 0.001 * pout);
        }

        [TestMethod]
        public void TestPipeCalculateOutletPressure_10_segment()
        {
            double pin = 7239540.0;
            double diameter = 0.050673;
            double area = System.Math.PI * System.Math.Pow(diameter, 2) / 4;
            double angle = 30.0;
            double length = 152.4;
            double qo = 158.99;
            double qw = 0.00;
            double qg = 28316.85;
            double muo = 0.002;
            double mug = 0.000015;
            double muw = 0.001;
            int numSeg = 10;
            string log_content = "-------------------------------" + System.Environment.NewLine;
            FluidProperties prob = new FluidProperties(muo, muw, mug);
            PressureDropModel pd = new PressureDropModel(prob);
            Pipe pipe_1 = new Pipe(length, diameter, angle, pd, numSeg);
            var pipe_profiles = new Dictionary<string, List<double>>();
            pipe_profiles.Add("Distance", new List<double>());
            pipe_profiles.Add("Pressure", new List<double>());
            pipe_profiles.Add("Liquid Holdup", new List<double>());
            pipe_profiles.Add("Reynolds number", new List<double>());
            var dist_list = pipe_profiles["Distance"];
            var pressure_list = pipe_profiles["Pressure"];
            var re_List = pipe_profiles["Reynolds number"];
            pressure_list.Add(pin);
            dist_list.Add(0);
            re_List.Add(0);
            double pout = pipe_1.CalculateOutletPressure(pin, qo, qg, qw, ref log_content, ref pipe_profiles, numSeg);



            Assert.AreEqual(pout, 6935819.08867015, 0.001 * pout);
        }
    }
}
