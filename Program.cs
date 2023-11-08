namespace Padroes;

public class Program
{
    public static void Main(string[] args)
    {
        //Padrão Strategy
        Console.WriteLine("==============Padrão Strategy==============");
        StrategyDelegate strategy = new();
        strategy.TestarDelegate();

        CalcularSedex sedex = new();
        sedex.CalcularFrete(2500);
        CalcularFretePAC pac = new();
        pac.CalcularFrete(2500);
        Console.WriteLine("===========================================");

        //Padrão State
        Console.WriteLine("==============Padrão State==============");
        Documento doc = new(new DocumentoRascunho());

        doc.Estado(); //Rascunho
        doc.Aprovar(); //Moderação
        doc.Estado();
        doc.Aprovar(); // Publicado
        doc.Estado();
        doc.Reprovar(); // Moderação
        doc.Reprovar(); // Rascunho
        doc.Reprovar(); // Rascunho
        Console.WriteLine("========================================");

        //Padrão Observer
        Console.WriteLine("==============Padrão Observer==============");
        App app = new("YouTube");
        AreaDeNotificacao areaDeNotificacao = new(app);
        Observer observer = new();
        areaDeNotificacao.Subscribe(observer);
        areaDeNotificacao.Atualizar();
        Console.WriteLine("===========================================");

        //Padrão command
        Console.WriteLine("==============Padrão command==============");
        Som som = new();
        TV tv = new();
        
        Command ligarSom = som.Ligar; 
        Command ligarTV = tv.Ligar; 

        SistemaAutomatizado sistemaAutomatizado = new();

        sistemaAutomatizado.AddCommand(ligarSom);
        sistemaAutomatizado.AddCommand(ligarTV);

        sistemaAutomatizado.ExecutarComandos();
        Console.WriteLine("==========================================");

        //Padrão Template Method
        Console.WriteLine("==============Padrão Template Method==============");
        Estrutura estrutura = new();
        estrutura.Imprimir();
        Console.WriteLine("==================================================");

        //Padrão Chain of Responsability
        Console.WriteLine("==============Chain of Responsability=============");
        CartaoCredito cartaoCredito = new(100);
        PagSeguro pagSeguro = new(200);
        cartaoCredito.Proximo = pagSeguro;
        cartaoCredito.TentarPagamento(150);
        Console.WriteLine("===================================================");

        //Padrão Visitor
        Console.WriteLine("==============Visitor==============");
        VisitanteRegra2023 visitanteRegra2023 = new(4.5);
        CalculadorDePassagem calculadorDePassagem = new(visitanteRegra2023);
        PassagemComum passagemComum = new(50);
        PassagemEstudante passagemEstudante = new(50);

        Console.WriteLine($"O preço da passagem comum é: R${calculadorDePassagem.CalcularPassagem(passagemComum)}");
        Console.WriteLine($"O preço da passagem de estudante é: R${calculadorDePassagem.CalcularPassagem(passagemEstudante)}");
        Console.WriteLine("===================================");

        //Padrão NullObject
        Console.WriteLine("==============Padrão NullObject==============");
        IMusica musicaNull = new MusicaNull();
        IMusica musicaConcreta = new MusicaConcreta(21542, "Monster", "Skillet");

        List<IMusica> musicasPossivelmenteNulas = new() { musicaNull, musicaConcreta };

        foreach(IMusica musica in musicasPossivelmenteNulas)
        {
            musica.PegarAtributos();
        }
        
        // musicaConcreta.Parar();
        // musicaConcreta.Parar();
        Console.WriteLine("==============================================");
    }
    
}