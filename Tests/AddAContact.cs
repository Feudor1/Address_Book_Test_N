namespace Address_Book_Test_N
{
    [TestFixture]
    public class AddAContact : TestBase
    {

        [Test]
        public void CreateNewContact()
        {
            applicationManager.Navi.GoToHomePage();
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
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.ContactHP.AddANewContact();
            applicationManager.ContactHP.FillTheContactData(contact);
            applicationManager.Navi.GoToHomePage();
            applicationManager.Auth.LogOut();
        }
    }
}
