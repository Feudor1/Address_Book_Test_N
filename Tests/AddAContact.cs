using System.Security.Cryptography;

namespace Address_Book_Test_N
{
    [TestFixture]
    public class AddAContact : AuthTestBase
    {

        [Test]
        public void CreateNewContact()
        {
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
            List<ContactsData> OldAccount = applicationManager.ContactHP.GetContactList();
            applicationManager.ContactHP.AddANewContact(contact);
            List<ContactsData> NewAccount = applicationManager.ContactHP.GetContactList();
            OldAccount.Add(contact);
            OldAccount.Sort();
            NewAccount.Sort();
            Assert.AreEqual(OldAccount, NewAccount);
        }

        [Test]
        public void CreateEmptywContact()
        {
            ContactsData contact = new ContactsData("");
            contact.MiddleName = "";
            contact.LastName = "";
            contact.NickName = "";
            contact.Title = "";
            contact.Company = "";
            contact.Adress = "";
            contact.HomeTelephone = "";
            contact.MobileTelephone = "";
            contact.WorkTelephone = "";
            contact.Fax = "";
            contact.Email = "";
            contact.Email2 = "";
            contact.Email3 = "";
            contact.Homepage = "";
            contact.Birthaday = "-";
            contact.Birthmonth = "-";
            contact.Birthyear = "";
            contact.Annivday = "-";
            contact.Annivmonth = "-";
            contact.Annivyear = " ";
            contact.Address2 = " ";
            contact.Home = " ";
            contact.Notes = " ";
            List<ContactsData> OldAccount = applicationManager.ContactHP.GetContactList();
            applicationManager.ContactHP.AddANewContact(contact);
            List<ContactsData> NewAccount = applicationManager.ContactHP.GetContactList();
            OldAccount.Add(contact);
            OldAccount.Sort();
            NewAccount.Sort();
            Assert.AreEqual(OldAccount, NewAccount);
        }
    }
}
