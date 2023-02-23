using System.Data;

namespace FluentApi;

public interface IConnectionInitializerStage
{
    public IDbConnection Connect();
}