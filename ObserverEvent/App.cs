namespace Padroes;

public class App
{
    public string Nome { get; set; }
    public int Mensagens { get; set; }
    public App (string nome)
    {
        Nome = nome;
        Mensagens = 0;
    }
    
    public void ReceberNovaMensagem(){
        Mensagens++;
    }
}