using System;

namespace MLlib
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public static class ReLU
    {
        public static double Calc(double x)
        {
            return Math.Max(0, x);
        }

        public static double CalcDeriv(double x)
        {
            return x <= 0 ? 0 : 1;
        }
    }
}
