namespace FluentApi;

public interface IServerSelectionStage
{
    public IDatabaseSelectionStage ForServer(string server);
}