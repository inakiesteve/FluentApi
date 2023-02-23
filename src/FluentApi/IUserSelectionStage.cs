namespace FluentApi;

public interface IUserSelectionStage
{
    public IPasswordSelectionStage AsUser(string user);
}