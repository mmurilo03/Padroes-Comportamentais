namespace Padroes;

public class CalcularSedex: ICalcularFrete
{
    public double CalcularFrete(double dist)
    {
        int distanciaPorKm = 22;
        double frete = dist/distanciaPorKm;
        Console.WriteLine($"Frete Sedex custa: R${Math.Round(frete, 2)}");
        return frete;
    }
}