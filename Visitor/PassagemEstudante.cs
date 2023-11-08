namespace Padroes;

public class PassagemEstudante : IPassagem
{
    public double Distancia { get; set; }

    public PassagemEstudante(double distancia)
    {
        Distancia = distancia;
    }

    public double aceitar(IVisitante visitante)
    {
        return visitante.Visitar(this);
    }
}