using Padroes;

public class CartaoCredito : MetodoPagamentoChain {
    public CartaoCredito(double saldo) : base(saldo)
    {
        
    }

    protected override void EfetuarPagamento(double valor){
        Saldo -= valor;
        Console.WriteLine($"Pagamento efetuado no cartão de crédito no valor: R${valor}.");
    }    

}