using Microsoft.AspNetCore.Authorization;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using GroupUser.Services;

namespace GroupUser
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IConnectionManager, ConnectionManager>();
            container.RegisterType<IAccountDataAccessService, DataAccessService>();
            container.RegisterType<IAuthorizationHandler, PermissionHandler>();
            container.RegisterType<IAuthorizationPolicyProvider, AuthorizationPolicyProvider>();


            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}