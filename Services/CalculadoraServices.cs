namespace Hiper.HiperDev.Git.Services
{
    public class CalculadoraServices : ICalculadoraServices
    {
        public double Dividir(double n1, double n2) => n1 / n2;

        public double Multiplicar(double n1, double n2) => n1 * n2;

        public double Somar(double n1, double n2) => n1 + n2;

        public double Subtrair(double n1, double n2) => n1 - n2;
    }
}
