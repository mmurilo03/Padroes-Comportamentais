namespace Padroes;

public class CalcularFretePAC: ICalcularFrete
{
    public double CalcularFrete(double dist)
    {
        int distanciaPorKm = 28;
        double frete = dist/distanciaPorKm;
        Console.WriteLine($"Frete PAC custa: R${Math.Round(frete, 2)}");
        return frete;
    }
}