using System.Data;

namespace Order.Repository.Base
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
    }
}
