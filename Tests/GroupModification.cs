namespace Address_Book_Test_N
{
    [TestFixture]
    public class GroupModification : TestBase
    {
        [Test]
        public void TheGroupModificatonTest()
            {
            GroupData newData = new GroupData("2.5 Lesson Group");
            newData.Header = "Header Header";
            newData.Footer = "Footer Footer";
            applicationManager.GruopHP.Modify(1, newData);
            }
        
    }
}
