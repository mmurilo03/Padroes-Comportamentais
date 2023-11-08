namespace Padroes;

public class AreaDeNotificacao : IObservable<App>, IDisposable
{
    public App App { get; set; }
    public List<IObserver<App>> observers;

    public AreaDeNotificacao(App app)
    {
        App = app;
        observers = new List<IObserver<App>>();
    }

    public void Atualizar()
    {
        App.ReceberNovaMensagem();
        foreach(var observer in observers)
        {
            observer.OnNext(App);
        }
    }

    public void Dispose()
    {
        GC.SuppressFinalize(this);
        observers.Clear();
    }

    public IDisposable Subscribe(IObserver<App> observer)
    {
        observers.Add(observer);
        observer.OnNext(App);
        return this;
    }
}