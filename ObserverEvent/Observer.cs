namespace Padroes;

public class Observer : IObserver<App>
{
    public void OnCompleted()
    {
        Console.WriteLine("Completo");
    }

    public void OnError(Exception error)
    {
        Console.WriteLine("Erro");
    }

    public void OnNext(App value)
    {
        Console.WriteLine($"{value.Nome} tem {value.Mensagens} mensagens.");
    }
}