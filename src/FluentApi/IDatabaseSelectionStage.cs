namespace FluentApi;

public interface IDatabaseSelectionStage
{
    public IUserSelectionStage AndDatabase(string database);
}