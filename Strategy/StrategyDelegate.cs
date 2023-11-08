namespace Padroes;
public class StrategyDelegate
{
    public delegate double CalcularFrete(double dist);
    public void TestarDelegate()
    {
        CalcularFrete calcularFrete = new(CalcularFreteSedex);
        calcularFrete.Invoke(2500);
        calcularFrete = CalcularFretePAC;
        calcularFrete.Invoke(2500);
    }

    public double CalcularFreteSedex(double dist)
    {
        int distanciaPorKm = 22;
        double frete = dist/distanciaPorKm;
        Console.WriteLine("Frete Sedex custa: R$" + Math.Round(frete, 2));
        return frete;
    }
    public double CalcularFretePAC(double dist)
    {
        int distanciaPorKm = 28;
        double frete = dist/distanciaPorKm;
        Console.WriteLine("Frete PAC custa: R$" + Math.Round(frete, 2));
        return frete;
    }
}