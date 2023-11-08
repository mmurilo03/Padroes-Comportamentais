namespace Padroes;

public abstract class MetodoPagamentoChain
{
    public MetodoPagamentoChain? Proximo { get; set; }
    public double Saldo;

    public MetodoPagamentoChain(double saldo)
    {
        Saldo = saldo;
    }

    public bool SaldoSuficiente(double valor)
    {
        return valor < Saldo;
    }

    public void TentarPagamento(double valor)
    {
        if(SaldoSuficiente(valor))
        {
            EfetuarPagamento(valor);
        } else {
            if (Proximo == null)
            {
                Console.WriteLine("Não existem mais métodos de pagamento.");
            } else 
            {
                Console.WriteLine("Este pagamento não tem saldo suficiente, tentando próximo método");
                Proximo.TentarPagamento(valor);
            }
        }
    }

    protected abstract void EfetuarPagamento(double Valor);

    
}