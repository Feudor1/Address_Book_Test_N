using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Address_Book_Test_N
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(IWebDriver driver) : base(driver)
        { }
        public void AddANewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        public void FillTheContactData(ContactsData contact)
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
    }
}
