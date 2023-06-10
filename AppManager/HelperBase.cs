using OpenQA.Selenium;

namespace Address_Book_Test_N
{
    public class HelperBase
    {
        protected ApplicationManager manager;
        protected IWebDriver driver;
        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            this.driver = manager.Driver;
        }

        protected void Type(By locator, string text)
        {
            //Не самый важный кейс, не трогаем поля группы, если они null
            if (text != null)
            {
                driver.FindElement(locator).SendKeys(text);
            }
        }
    }
}