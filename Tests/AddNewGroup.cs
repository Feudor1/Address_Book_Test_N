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
            app.GruopHP.CreateGroup(group);

        }

        [Test]
        public void CreateEmptyGroup()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
            app.GruopHP.CreateGroup(group);
        }

    }
}
