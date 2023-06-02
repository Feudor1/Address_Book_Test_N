using OpenQA.Selenium;


namespace Address_Book_Test_N
{
    public class HelperBase
    {
        protected IWebDriver driver;
        public HelperBase (IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}