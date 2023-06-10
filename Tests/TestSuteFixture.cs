namespace Address_Book_Test_N
{
    [SetUpFixture]
    public class TestSuteFixture
    {
        public static ApplicationManager applicationManager;

        [OneTimeSetUp]
        public void InintApplicationManager()
        {
            applicationManager = new ApplicationManager();
            applicationManager.Navi.GoToHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
        }

        [OneTimeTearDown]
        public void StopApplicationManager()
        {
            applicationManager.Stop();
        }
    }
}