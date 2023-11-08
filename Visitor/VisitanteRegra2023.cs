namespace Padroes;

public class VisitanteRegra2023 : IVisitante
{
    private double ValorPorKm { get; set; }

    public VisitanteRegra2023(double valorPorKm)
    {
        ValorPorKm = valorPorKm;
    }
    public double Visitar(PassagemComum passagem)
    {
        return passagem.Distancia * ValorPorKm;
    }

    public double Visitar(PassagemEstudante passagem)
    {
        return passagem.Distancia * ValorPorKm * 0.5;
    }
}