namespace Address_Book_Test_N
{ 
    [TestFixture]
    public class RemoveContact : AuthTestBase
    {

            [Test]
            public void ContractRemover()
            {
            applicationManager.ContactHP.ContactListCheck();
            applicationManager.ContactHP.RemoveContract(1);
            }
        
    }
}


