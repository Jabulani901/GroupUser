using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninject;

namespace GroupUser.UnitTest.Account
{
    [TestClass]
    public class AccountTest
    {
        private readonly IAccountDataAccessService _accountdataAccess;


        public AccountTest()
        {
            using (IKernel kernel = new StandardKernel(new DataAccessModule()))
            {
                _accountdataAccess = kernel.Get<IAccountDataAccessService>();
            }
        }



        [TestMethod]
        public void ValidateUserLoginDetails()
        {
            bool isValidUser = _accountdataAccess.ValidateUserLogin("ss.vincen@gmail.com", Crypto.Hash("Password"));
            Assert.AreEqual(true, isValidUser);
        }
    }
}
