namespace Address_Book_Test_N
{
    public class TestSuteFixture
    {
        public static ApplicationManager applicationManager;

        [SetUp]
        public void InintApplicationManager()
        {
            applicationManager = new ApplicationManager();
            applicationManager.Navi.GoToHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void StopApplicationManager()
        {
            applicationManager.Stop();
        }
    }
}