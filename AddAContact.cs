using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Address_Book_Test_N;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Address_Book_Test_N
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
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
        
        [Test]
        public void TheUntitledTestCaseTest()
        {
            OpenHomePAge();
            ContactsData contact = new ContactsData("Ivanov");
            contact.MiddleName = "Ivan";
            contact.LastName = "Ivanovich";
            contact.NickName = "IvanovIvan";
            contact.Title = "Ivan";
            contact.Company = "Accesssoftec";
            contact.Adress = "Home";
            contact.HomeTelephone = "sssss";
            contact.MobileTelephone = "4646654654645";
            contact.WorkTelephone = "4646546456";
            contact.Fax = "465654645";
            contact.Email = "sdfsadf@sdfdf.er";
            contact.Email2 = "dfasdfas@sdgsdf.r";
            contact.Email3 = "dfaedfdasd@adfer.rgs";
            contact.Homepage = "google.com";
            contact.Birthaday = "15";
            contact.Birthmonth = "April";
            contact.Birthyear = "1990";
            contact.Annivday = "27";
            contact.Annivmonth = "March";
            contact.Annivyear = "2023";
            contact.Address2 = "dsfasdfsadfsdf";
            contact.Home = "asdfsfd";
            contact.Notes = "asdfasfdfdasfdsa";
            Login(new AccountData("admin", "secret"));
            AddANewContact();
            FillTheContactData(contact);
            OpenHomePAge();
            LogOut();
        }

        private void FillTheContactData(ContactsData contact)
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

        private void AddANewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }

        private void LogOut()
        {
            driver.FindElement(By.LinkText("Logout")).Click();
        }

        private void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).SendKeys(account.Password);
            driver.FindElement(By.XPath("//input[@value='Login']")).Click();
        }
        private void OpenHomePAge()
        {
            driver.Navigate().GoToUrl(baseURL);
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
