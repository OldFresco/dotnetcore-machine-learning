using System;

namespace MachineLearning.Math
{
    public static class SigmoidFunction
    {
        public static double Calc(double x)
        {
            return 1 / (1 + System.Math.Exp(-x));
        }

        public static double CalcDeriv(double x)
        {
            var s = Calc(x);
            return s * (1 - s);
        }
    }
}
