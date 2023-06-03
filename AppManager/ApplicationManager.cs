﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

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

        public ApplicationManager()
        {
            loginHelper = new LoginHelper(driver);
            navigationHelper = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);
            driver = new ChromeDriver();
            baseURL = "http://localhost/addressbook/";
            loginHelper = new LoginHelper(driver);
            navigationHelper = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);
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

        public void Stop()
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
