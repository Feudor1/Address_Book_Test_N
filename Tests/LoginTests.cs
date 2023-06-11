namespace Address_Book_Test_N
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test] 
        public void LoginWithValidCredentials() 
        {
            //Precondition
            applicationManager.Auth.Logout();

            //Action
            AccountData account = new AccountData("admin", "secret");
            applicationManager.Auth.Login(account);

            //verification
            Assert.IsTrue(applicationManager.Auth.IsloggedIn(account));
        }

        [Test]
        public void LoginWithInValidCredentials()
        {
            //Precondition
            applicationManager.Auth.Logout();

            //Action
            AccountData account = new AccountData("admin", "123456");
            applicationManager.Auth.Login(account);

            //verification
            Assert.IsFalse(applicationManager.Auth.IsloggedIn(account));
        }
    }
}
