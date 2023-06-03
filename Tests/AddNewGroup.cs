namespace Address_Book_Test_N
{
    [TestFixture]
    public class AddNewGroup : TestBase

    {
        [Test]
        public void CreateNewGroupTest()
        {
            GroupData group = new GroupData("lECTION GROUP");
            group.Header = "Header";
            group.Footer = "Footer";
            applicationManager.Navi.GoToGroupPage();
            applicationManager.GruopHP.CreateGroup(group);
            applicationManager.Navi.GoToGroupPage();
            applicationManager.Auth.LogOut();

        }

        [Test]
        public void CreateEmptyGroup()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            applicationManager.Navi.GoToGroupPage();
            applicationManager.GruopHP.CreateGroup(group);
            applicationManager.Navi.GoToGroupPage();
            applicationManager.Auth.LogOut();

        }

    }
}
