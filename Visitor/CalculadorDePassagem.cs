namespace Padroes;

public class CalculadorDePassagem
{
    public IVisitante Visitante { get; set; }

    public CalculadorDePassagem(IVisitante visitante)
    {
        Visitante = visitante;
    }

    public double CalcularPassagem(IPassagem passagem)
    {
        return passagem.aceitar(Visitante);
    }
}