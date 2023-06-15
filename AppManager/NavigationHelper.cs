using OpenQA.Selenium;

namespace Address_Book_Test_N
{
    public class NavigationHelper : HelperBase
    {
        private string baseURL;

        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        {
            this.baseURL = baseURL;
        }
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        public void GoToGroupPage()

        {
            if (driver.Url == baseURL + "/group.php"  && IsElementPresent(By.Name("New")))

            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
