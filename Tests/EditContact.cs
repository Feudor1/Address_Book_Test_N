﻿namespace Address_Book_Test_N
{
    [TestFixture]
    public class EditContact : TestBase
    {
        [Test]
        public void ContactEditor()
        {
            ContactsData NewDAta = new ContactsData("Petr");
            NewDAta.MiddleName = "Petrov";
            NewDAta.LastName = "Petrovich";
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
            applicationManager.ContactHP.EditAccount(NewDAta, 3);
        }
    }
}