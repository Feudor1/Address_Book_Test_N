namespace Address_Book_Test_N
{
    [TestFixture]
    public class GroupDelitionTests : TestBase
    {
        [Test]
        public void TheGroupDelitionTest()
        {
            applicationManager.Navi.GoToGroupPage();
            applicationManager.GruopHP
                .SelectGroup(1)
                .DeleteGroup();
            applicationManager.Navi.GoToGroupPage();
            applicationManager.Auth.LogOut();
        }
    }
}
