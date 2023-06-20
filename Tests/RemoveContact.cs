using System.Security.Cryptography;

namespace Address_Book_Test_N
{ 
    [TestFixture]
    public class RemoveContact : AuthTestBase
    {

            [Test]
            public void ContractRemover()
            {
            applicationManager.ContactHP.ContactListCheck();
            List<ContactsData> OldContact = applicationManager.ContactHP.GetContactList();
            applicationManager.ContactHP.RemoveContract(1);
            Assert.AreEqual(OldContact.Count - 1, applicationManager.ContactHP.GetContactList().Count);
            List<ContactsData> NewContact = applicationManager.ContactHP.GetContactList();
            OldContact.RemoveAt(0);
            Assert.AreEqual(OldContact, NewContact);
        }
        
    }
}


