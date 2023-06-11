namespace Address_Book_Test_N
{
    public class TestBase
    {

        protected ApplicationManager applicationManager;

        [SetUp]
        public void SetupApplicationManager()
        {
            applicationManager = ApplicationManager.GetInstance();
        }

    }
}
