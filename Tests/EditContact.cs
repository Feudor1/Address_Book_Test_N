using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.Events;
using System.Data;
using System.Security.Principal;
using OpenQA.Selenium;

namespace Address_Book_Test_N
{
    [TestFixture]
    public class EditContact : AuthTestBase
    {
        [Test]
        public void ContactEditor()
        {
            
            ContactsData NewDAta = new ContactsData("Petr", "Petrov"); 
            NewDAta.MiddleName = "Petrovich";
            NewDAta.NickName = "PrtrovPetr";
            NewDAta.Title = "Petr";
            NewDAta.Company = "Roga&Copyta";
            NewDAta.Adress = "Homless";
            NewDAta.HomeTelephone = "sssss";
            NewDAta.MobileTelephone = "4646654654645";
            NewDAta.WorkTelephone = "4646546456";
            NewDAta.Fax = "465654645";
            NewDAta.Email = "sdfsadf@sdfdf.er";
            NewDAta.Email2 = "dfasdfas@sdgsdf.r";
            NewDAta.Email3 = "dfaedfdasd@adfer.rgs";
            NewDAta.Homepage = "google.com";
            NewDAta.Birthaday = "15";
            NewDAta.Birthmonth = "April";
            NewDAta.Birthyear = "1990";
            NewDAta.Annivday = "27";
            NewDAta.Annivmonth = "March";
            NewDAta.Annivyear = "2023";
            NewDAta.Address2 = "dsfasdfsadfsdf";
            NewDAta.Home = "asdfsfd";
            NewDAta.Notes = "asdfasfdfdasfdsa";
            applicationManager.ContactHP.ContactListCheck();
            List<ContactsData> OldContact = applicationManager.ContactHP.GetContactList();
            applicationManager.ContactHP.EditAccount(NewDAta);
            Assert.AreEqual(OldContact.Count, applicationManager.ContactHP.GetContactList().Count);
            List<ContactsData> NewContact = applicationManager.ContactHP.GetContactList();
            OldContact[0].FirstName = NewDAta.FirstName;
            OldContact[0].LastName = NewDAta.LastName;
            OldContact.Sort();
            NewContact.Sort();
            //Assert.AreNotEqual(OldAccount, NewAccount);
            Assert.AreEqual(OldContact, NewContact);
        }
    }
}
