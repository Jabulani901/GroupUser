using System.Collections.Generic;
using GroupUser.Models;

namespace GroupUser.Helper
{
    public class Data
    {
        private readonly IAccountDataAccessService _accountdataAccess;

        public Data(IAccountDataAccessService dataAccessService)
        {
            _accountdataAccess = dataAccessService;
        }


        public IEnumerable<NavigationMenuView> GetMenues(string username)
        {
            return _accountdataAccess.GetPermissionsByUsername(username);
        }
    }
}