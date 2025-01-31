namespace Transflower.DesignPatterns.Command.Inventory;
public class PriceModifier
{
    private readonly List<ICommand> _commands;
    private ICommand _command;

    /*
    public PriceModifier()
        {
            _commands = new List<ICommand>();
        }

    */
    public PriceModifier() => _commands = new List<ICommand>();

    public void SetCommand(ICommand command) => _command = command;

    public void Invoke()
    {
        _commands.Add(_command);
        _command.ExecuteAction();
    }
}