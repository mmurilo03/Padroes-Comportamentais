namespace Padroes;

public class Som
{
    public bool Estado {get; set;}

    public Som()
    {
        Estado = false;
    }

    public void Ligar()
    {
        Estado = true;
        
        Console.WriteLine("Som está ligado até A APPLE se tornar custo benefício.");
    }
}