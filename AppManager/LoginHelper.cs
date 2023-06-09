﻿using OpenQA.Selenium;
using System.Security.Principal;

namespace Address_Book_Test_N
{
    public class LoginHelper : HelperBase
    {


        public LoginHelper(ApplicationManager manager) : base(manager)
        { 
        
        }
        public void Login(AccountData account)
        {
            if (IsloggedIn())
            {
                if (IsloggedIn(account))
                {
                    return;
                }
                Logout();

            }
            Type(By.Name("user"), account.Username);
            Type(By.Name("pass"), account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }

        public bool IsloggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

        public bool IsloggedIn(AccountData account)
        {
            return IsloggedIn()
                &&
                driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text 
                == "(" +account.Username + ")";
        }

        public void Logout()
        {
            if (IsloggedIn())
            {
                driver.FindElement(By.LinkText("Logout")).Click();
              // Может пригодится позже 
              //  driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
              //  driver.FindElement(By.Name("user"));

            }

        }

    }
}
