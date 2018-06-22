namespace PooVuelingNMock3
{
    public interface ICalculadora
    {
        ICalculadora calcu { get; set; }

        int Suma(int num1, int num2);
        int Resta(int num1, int num2);
        int Multiplicacion(int num1, int num2);
        int Division(int num1, int num2);
    }
}