namespace Padroes;

public class MusicaConcreta : IMusica
{
    private long Id { get; set; }
    private string Nome { get; set; }
    private string Compositor { get; set; }
    private bool Tocando { get; set; }

    public MusicaConcreta(long id, string nome, string compositor)
    {   
        Id = id;
        Nome = nome;
        Compositor = compositor;
    }

    public void Parar()
    {
        if (!Tocando)
        {
            throw new RegraMusicaException("A música não está tocando.");
        }
        Tocando = false;
    }

    public void Reproduzir()
    {
        if (Tocando)
        {
            throw new RegraMusicaException("A música já está tocando.");
        }
        Tocando = true;
    }

    public void PegarAtributos()
    {
        Console.WriteLine($"Id da música {Id}");
        Console.WriteLine($"Nome da música {Nome}");
        Console.WriteLine($"Compositor da música {Compositor}");
    }
}