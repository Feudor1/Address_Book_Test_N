namespace Address_Book_Test_N
{
    [TestFixture]
    public class AddNewGroup : TestBase

    {
        [Test]
        public void CreateNewGroupTest()
        {
            applicationManager.Navi.GoToHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.Navi.GoToGroupPage();
            applicationManager.GruopHP.InitGroupCreation();
            GroupData group = new GroupData("lECTION GROUP");
            group.Header = "Header";
            group.Footer = "Footer";
            applicationManager.GruopHP.FillGroupForm(group);
            applicationManager.GruopHP.SubmitGroupCreation();
            applicationManager.Navi.GoToGroupPage();
            applicationManager.Auth.LogOut();

        }
    }
}
