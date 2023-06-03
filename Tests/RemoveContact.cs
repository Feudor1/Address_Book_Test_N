namespace Address_Book_Test_N
{ 
    [TestFixture]
    public class RemoveContact : TestBase
    {

            [Test]
            public void ContractRemover()
            {
                applicationManager.ContactHP.RemoveContract();
            }
        
    }
}


