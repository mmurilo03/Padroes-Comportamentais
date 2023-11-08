namespace Padroes;

public class TV
{
    public bool Estado {get; set;}

    public TV()
    {
        Estado = false;
    }

    public void Ligar()
    {
        Estado = true;
        
        Console.WriteLine("TV está ligada até o Metallica lançar música boa.");
    }
}