namespace Address_Book_Test_N
{
    public class TestBase
    {

        protected ApplicationManager applicationManager;

        [SetUp]
        public void SetupTest()
        {
            applicationManager = new ApplicationManager();
            applicationManager.Navi.GoToHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
        }

    }
}
