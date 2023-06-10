namespace Address_Book_Test_N
{ 
    [TestFixture]
    public class RemoveContact : TestBase
    {

            [Test]
            public void ContractRemover()
            {
                app.ContactHP.RemoveContract(1);
            }
        
    }
}


