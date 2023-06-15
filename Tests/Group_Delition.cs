namespace Address_Book_Test_N
{
    [TestFixture]
    public class GroupDelitionTests : AuthTestBase
    {
        [Test]
        public void TheGroupDelitionTest()
        {
            applicationManager.GruopHP.GroupListCheck();
            applicationManager.GruopHP.Remove();
        }
    }
}
