using OpenQA.Selenium;

namespace Address_Book_Test_N
{
    public class LoginHelper : HelperBase
    {


        public LoginHelper(IWebDriver driver) : base(driver)
        { }
        public void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }
        public void LogOut()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
    }
}
