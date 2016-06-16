using System;

namespace MLlib.Maths.ActivationFunctions
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public static class Tanh
    {
        public static double Calc(double x)
        {
            return Math.Tanh(x);
        }

        public static double CalcDeriv(double x)
        {
            var result = Math.Sinh(x) / Math.Cosh(x);
            return result;
        }
    }
}
