using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Reflection;
using System.Xml.Linq;

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
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("byear")).Clear();
            driver.FindElement(By.Name("ayear")).Clear();
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("phone2")).Clear();
            driver.FindElement(By.Name("notes")).Clear();
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
            List<ContactsData> contacts = new List<ContactsData>();
            manager.Navi.GoToHomePage();
            ICollection<IWebElement> firstNames = driver.FindElements(By.CssSelector("table td:nth-child(3)"));
            ICollection<IWebElement> lastNames = driver.FindElements(By.CssSelector("table td:nth-child(2)"));

            for (int i = 0; i < firstNames.Count && i < lastNames.Count; i++)
            {
                ContactsData contact = new ContactsData(firstNames.ElementAt(i).Text, lastNames.ElementAt(i).Text);
                contacts.Add(contact);
            }

            return contacts;
        }



        //public List<ContactsData> GetContactFirstNameList()
        //{
        //    List<ContactsData> firstnameContact = new List<ContactsData>();
        //    manager.Navi.GoToHomePage();
        //    ICollection<IWebElement> firstnames = driver.FindElements(By.CssSelector("table td:nth-child(3)"));
        //    foreach (IWebElement firstname in firstnames)
        //    {
        //        ContactsData contact = new ContactsData(firstname.Text);
        //        //contact.FirstName = firstname.Text;
        //        firstnameContact.Add(contact);
        //    }
        //    return firstnameContact;
        //}

        //public List<ContactsData> GetContactLastNameList()
        //{
        //    List<ContactsData> lastnameContact = new List<ContactsData>();
        //    manager.Navi.GoToHomePage();
        //    ICollection<IWebElement> lastNames = driver.FindElements(By.CssSelector("table td:nth-child(2)"));
        //    foreach (IWebElement lastname in lastNames)
        //    {
        //        ContactsData contact = new ContactsData(lastname.Text);
        //       // contact.LastName = lastname.Text;
        //        lastnameContact.Add(contact);
        //    }
        //    return lastnameContact;
        //}
    }
}
