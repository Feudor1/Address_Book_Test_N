using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Address_Book_Test_N
{
    public class TestBase
    {
        
        protected IWebDriver driver;
        protected StringBuilder verificationErrors;
        protected string baseURL;
        protected bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "http://localhost/addressbook/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        protected void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL);
        }
        protected void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }
        protected void LogOut()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }
        protected void GoToGroupPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        protected void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        protected void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        protected void AddANewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        protected void DeleteGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }
        protected void FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }
        protected void FillTheContactData(ContactsData contact)
        {
            driver.FindElement(By.Name("firstname")).SendKeys(contact.FirstName);
            driver.FindElement(By.Name("middlename")).SendKeys(contact.MiddleName);
            driver.FindElement(By.Name("lastname")).SendKeys(contact.LastName);
            driver.FindElement(By.Name("nickname")).SendKeys(contact.NickName);
            driver.FindElement(By.Name("title")).SendKeys(contact.Title);
            driver.FindElement(By.Name("company")).SendKeys(contact.Company);
            driver.FindElement(By.Name("address")).SendKeys(contact.Adress);
            driver.FindElement(By.Name("home")).SendKeys(contact.HomeTelephone);
            driver.FindElement(By.Name("mobile")).SendKeys(contact.MobileTelephone);
            driver.FindElement(By.Name("work")).SendKeys(contact.WorkTelephone);
            driver.FindElement(By.Name("fax")).SendKeys(contact.Fax);
            driver.FindElement(By.Name("email")).SendKeys(contact.Email);
            driver.FindElement(By.Name("email2")).SendKeys(contact.Email2);
            driver.FindElement(By.Name("email3")).SendKeys(contact.Email3);
            driver.FindElement(By.Name("homepage")).SendKeys(contact.Homepage);
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(contact.Birthaday);
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(contact.Birthmonth);
            driver.FindElement(By.Name("byear")).SendKeys(contact.Birthyear);
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText(contact.Annivday);
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText(contact.Annivmonth);
            driver.FindElement(By.Name("ayear")).SendKeys(contact.Annivmonth);
            driver.FindElement(By.Name("address2")).SendKeys(contact.Address2);
            driver.FindElement(By.Name("phone2")).SendKeys(contact.Home);
            driver.FindElement(By.Name("notes")).SendKeys(contact.Notes);
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
        }
        protected void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
        }
    }
}
