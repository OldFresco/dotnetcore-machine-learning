namespace MLlib
{
    public interface IActivationFunction
    {
        double Calc(double x);
        double CalcDeriv(double x);
    }
}
