using System.Security.Principal;

namespace GroupUser
{
    public class MyIdentity : IIdentity
    {
        public IIdentity Identity { get; set; }

        public string AuthenticationType
        {
            get { return Identity.AuthenticationType; }
        }

        public bool IsAuthenticated
        {
            get { return Identity.IsAuthenticated; }
        }

        public string Name
        {
            get { return Identity.Name; }
        }
    }
}