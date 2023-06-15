namespace Address_Book_Test_N
{
    [TestFixture]
    public class GroupModification : AuthTestBase
    {
        [Test]
        public void TheGroupModificatonTest()
            {
            applicationManager.GruopHP.GroupListCheck();
            GroupData newData = new GroupData("2.5 Lesson Group");
            newData.Header = "Header Header";
            newData.Footer = "Footer Footer";
            applicationManager.GruopHP.Modify(newData);
            }
        
    }
}
