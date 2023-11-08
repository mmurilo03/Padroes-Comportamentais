namespace Padroes;

public class DocumentoPublicado: IDocumento
{
    public IDocumento Aprovar()
    {
        Console.WriteLine("Este documento está Publicado");
        return this;
    }

    public void Estado()
    {
        Console.WriteLine("Este documento está Publicado");
    }

    public IDocumento Reprovar()
    {
        Console.WriteLine("Este documento voltou para Moderação");
        return new DocumentoModeracao();
    }
}