namespace Address_Book_Test_N
{
    [SetUpFixture]
    public class TestSuteFixture
    {
        public static ApplicationManager app;

        [SetUp]
        public void InintApplicationManager()
        {
            app = new ApplicationManager();
            app.Navi.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
        }

        [TearDown]
        public void StopApplicationManager()
        {
            app.Stop();
        }
    }
}