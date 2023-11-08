namespace Padroes;

public interface IDocumento
{
    IDocumento Aprovar();

    IDocumento Reprovar();

    void Estado();
}