namespace Padroes;

public class DocumentoModeracao: IDocumento
{
    public IDocumento Aprovar()
    {
        Console.WriteLine("Este documento foi Publicado");
        return new DocumentoPublicado();
    }

    public void Estado()
    {
        Console.WriteLine("Este documento está em Moderação");
    }

    public IDocumento Reprovar()
    {
        Console.WriteLine("Este documento voltou para Rascunho");
        return new DocumentoRascunho();
    }
}