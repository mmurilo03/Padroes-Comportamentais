namespace Padroes;

public class DocumentoRascunho: IDocumento
{
    public IDocumento Aprovar()
    {
        Console.WriteLine("Este documento foi para Moderação");
        return new DocumentoModeracao();
    }

    public void Estado()
    {
        Console.WriteLine("Este documento está em Rascunho");
    }

    public IDocumento Reprovar()
    {
        Console.WriteLine("Este documento está em Rascunho");
        return this;
    }
}