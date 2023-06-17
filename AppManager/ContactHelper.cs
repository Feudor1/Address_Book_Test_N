using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;

namespace Address_Book_Test_N
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager)
        { }
        public ContactHelper AddANewContact(ContactsData contact)
        {
            manager.Navi.GoToHomePage();
            driver.FindElement(By.LinkText("add new")).Click();
            FillTheContactData(contact);
            manager.Navi.GoToHomePage();
            return this;
        }

        public ContactHelper RemoveContract(int i)
        {
            manager.Navi.GoToHomePage();
            SelectContact(i);
            FindDeleteButton();
            manager.Navi.GoToHomePage();
            return this;
        }

        public ContactHelper EditAccount(ContactsData newDAta)
        {
            manager.Navi.GoToHomePage();
            FindEditButton();
            FillTheContactData(newDAta);
            FindUpdateGroupButton();
            manager.Navi.GoToHomePage();
            return this;
        }
        public ContactHelper FillTheContactData(ContactsData contact)
        {
            Type(By.Name("firstname"), contact.FirstName);
            Type(By.Name("middlename"), contact.MiddleName);
            Type(By.Name("lastname"), contact.LastName);
            Type(By.Name("nickname"), contact.NickName);
            Type(By.Name("title"), contact.Title);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("address"), contact.Adress);
            Type(By.Name("home"), contact.HomeTelephone);
            Type(By.Name("mobile"), contact.MobileTelephone);
            Type(By.Name("work"), contact.WorkTelephone);
            Type(By.Name("fax"), contact.Fax);
            Type(By.Name("email"), contact.Email);
            Type(By.Name("email2"), contact.Email2);
            Type(By.Name("email3"), contact.Email3);
            Type(By.Name("homepage"), contact.Homepage);
            Type(By.Name("byear"), contact.Birthyear);
            Type(By.Name("ayear"), contact.Annivyear);
            Type(By.Name("address2"), contact.Address2);
            Type(By.Name("phone2"), contact.Home);
            Type(By.Name("notes"), contact.Notes);
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText(contact.Birthaday);
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText(contact.Birthmonth);
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText(contact.Annivday);
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText(contact.Annivmonth);
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }

        public ContactHelper SelectContact(int i)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + i + "]")).Click();
            return this;
        }

        public void ContactListCheck()
        {
            manager.Navi.GoToHomePage();
            if (driver.FindElements(By.Name("selected[]")).Count <= 0)

            {
                driver.FindElement(By.LinkText("add new")).Click();
                Type(By.Name("firstname"), "Если контактов нет");
                Type(By.Name("middlename"), "Если контактов нет");
                Type(By.Name("lastname"), "Если контактов нет");
                //Вот эта дичь для поиска кнопки Enter
                driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
                manager.Navi.GoToGroupPage();
            }

        }

        public ContactHelper FindEditButton()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }
        public ContactHelper FindUpdateGroupButton()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper FindDeleteButton()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            driver.SwitchTo().Alert().Accept();
            return this;
        }

        public List<ContactsData> GetContactList()
        {
 
            List<ContactsData> contacts = new List <ContactsData>();
            manager.Navi.GoToHomePage();
            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("input[type='checkbox'][name='selected[]']"));

            foreach (IWebElement element in elements)
            {
                ContactsData contact = new ContactsData(element.Text);
                contacts.Add(new ContactsData(element.Text));
            }
            return contacts;
        }
    }
}
