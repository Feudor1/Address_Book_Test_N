using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.ComponentModel;

namespace Address_Book_Test_N
{
    public class ApplicationManager
    {
        protected bool acceptNextAlert = true;
        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;
        protected IWebDriver driver;
        protected string baseURL;
        private static ThreadLocal <ApplicationManager> applicationmanager = new ThreadLocal<ApplicationManager>();

        public ApplicationManager()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost/addressbook/";
            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);
        }

        ~ApplicationManager()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public IWebDriver Driver 
        {
            get 
            {
                return driver;
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }
        public NavigationHelper Navi
        {
            get
            {
                return navigationHelper;
            }
        }

        public GroupHelper GruopHP
        {
            get
            {
                return groupHelper;
            }
        }

        public ContactHelper ContactHP
        {
            get
            {
                return contactHelper;
            }
        }   

        public static ApplicationManager GetInstance ()
        {
            if (!applicationmanager.IsValueCreated)
            {
                applicationmanager.Value = new ApplicationManager();
            }
            return applicationmanager.Value;
        }

        public void Quit()
        {

            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }

        }

    }
}
