namespace Padroes;

public class SistemaAutomatizado
{
    public List<Command> Commands;

    public SistemaAutomatizado()
    {
        Commands = new List<Command>();
    }

    public void AddCommand(Command command)
    {
        Commands.Add(command);
    }

    public void ExecutarComandos()
    {
        foreach(Command command in Commands)
        {
            command.Invoke();
        }
    }
}