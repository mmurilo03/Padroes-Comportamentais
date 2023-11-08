namespace Padroes;

public sealed class MusicaNull : IMusica
{
    private static readonly IMusica MUSICA_NULA = new MusicaNull();
    public void Reproduzir()
    {
        throw new RegraMusicaException("Música não existe");
    }

    public void Parar()
    {
        throw new RegraMusicaException("Música não existe");
    }

    public void PegarAtributos()
    {
        Console.WriteLine("Esta música é nula");
    }

    public static IMusica Instance
    {
        get
        {
            return MUSICA_NULA;
        }
    }
}