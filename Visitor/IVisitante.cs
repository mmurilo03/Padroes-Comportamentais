namespace Padroes;

public interface IVisitante
{
    double Visitar(PassagemComum passagem);
    double Visitar(PassagemEstudante passagem);
}