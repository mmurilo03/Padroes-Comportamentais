using Padroes;

public class PagSeguro : MetodoPagamentoChain {
    public PagSeguro(double saldo) : base(saldo)
    {
        
    }

    protected override void EfetuarPagamento(double valor)
    {
        Saldo -= valor;
        Console.WriteLine($"Pagamento efetuado no pagseguro no valor: R${valor}.");
    }
}