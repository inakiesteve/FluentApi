namespace FluentApi;

public interface IPasswordSelectionStage
{
    public IConnectionInitializerStage WithPassword(string password);
}