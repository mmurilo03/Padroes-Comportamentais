namespace Padroes;

public class PassagemComum : IPassagem
{
    public double Distancia { get; set; }

    public PassagemComum(double distancia)
    {
        Distancia = distancia;
    }

    public double aceitar(IVisitante visitante)
    {
        return visitante.Visitar(this);
    }
}