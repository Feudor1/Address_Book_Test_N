namespace Address_Book_Test_N
{
    [SetUpFixture]
    public class TestSuteFixture
    {

        [OneTimeSetUp]
        public void InintApplicationManager()
        {
            ApplicationManager applicationManager = ApplicationManager.GetInstance();
            applicationManager.Navi.GoToHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
        }

        [OneTimeTearDown]
        public void StopApplicationManager() 
        {
            ApplicationManager.GetInstance().Quit();
        }
    }
}