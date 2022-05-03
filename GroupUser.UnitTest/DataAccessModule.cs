using Ninject.Modules;

namespace GroupUser.UnitTest
{
    public class DataAccessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IAccountDataAccessService>().To<DataAccessService>();
        }
    }
}
