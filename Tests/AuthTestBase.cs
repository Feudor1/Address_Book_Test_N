namespace Address_Book_Test_N
{
    public class AuthTestBase : TestBase
    {
        [SetUp]
        public void SetupLogin()
        {
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
        }
    }
}
