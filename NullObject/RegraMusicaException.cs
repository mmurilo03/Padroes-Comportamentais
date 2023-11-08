namespace Padroes;

public class RegraMusicaException : Exception
{
    public RegraMusicaException(string message) : base(message)
    {

    }

    public RegraMusicaException(string message, Exception cause) : base(message, cause)
    {
        
    }
}