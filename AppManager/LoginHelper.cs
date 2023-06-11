using OpenQA.Selenium;

namespace Address_Book_Test_N
{
    public class LoginHelper : HelperBase
    {


        public LoginHelper(ApplicationManager manager) : base(manager)
        { 
        
        }
        public void Login(AccountData account)
        {
            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }
        public void Logout(AccountData account)
        {
            driver.FindElement(By.Name("logout")).Click();
        }

    }
}
