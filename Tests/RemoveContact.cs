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
            List<ContactsData> OldAccount = applicationManager.ContactHP.GetContactList();
            applicationManager.ContactHP.RemoveContract(1);
            List<ContactsData> NewAccount = applicationManager.ContactHP.GetContactList();
            OldAccount.RemoveAt(0);
            Assert.AreEqual(OldAccount, NewAccount);
        }
        
    }
}


