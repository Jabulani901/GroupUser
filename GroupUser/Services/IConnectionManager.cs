using System.Data;

namespace GroupUser.Services
{
    public interface IConnectionManager
    {
        IDbConnection UserManagementDB();
    }
}
