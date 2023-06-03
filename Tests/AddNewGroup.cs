namespace Address_Book_Test_N
{
    [TestFixture]
    public class AddNewGroup : TestBase

    {
        [Test]
        public void CreateNewGroupTest()
        {
            applicationManager.Navi.GoToGroupPage();
            GroupData group = new GroupData("lECTION GROUP");
            group.Header = "Header";
            group.Footer = "Footer";
            applicationManager.GruopHP
                .InitGroupCreation()
                .FillGroupForm(group)
                .SubmitGroupCreation();
            applicationManager.Navi.GoToGroupPage();
            applicationManager.Auth.LogOut();

        }
    }
}
