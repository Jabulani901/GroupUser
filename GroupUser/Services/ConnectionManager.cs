using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GroupUser.Services
{
    public class ConnectionManager : IConnectionManager
    {
        public IDbConnection UserManagementDB()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["UserManagementDBEntities"].ConnectionString);
        }
    }
}