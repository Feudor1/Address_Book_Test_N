namespace Address_Book_Test_N
{
    [TestFixture]
    public class GroupDelitionTests : TestBase
    {
        [Test]
        public void TheGroupDelitionTest()
        {
            applicationManager.GruopHP.Remove(1);
        }
    }
}
