namespace kata_dotnet_core_start.Lib;

public sealed class CommandSet : List<Command>
{
    private CommandSet(IEnumerable<Command> commands) : base(commands) { }

    public static implicit operator CommandSet(Command[] commands) => new(commands);
}
