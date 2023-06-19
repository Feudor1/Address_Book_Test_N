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

            List<GroupData> Oldgroups = applicationManager.GruopHP.GetGroupList();

            applicationManager.GruopHP.Modify(newData);
            Assert.AreEqual(Oldgroups.Count, applicationManager.GruopHP.GetGroupList().Count);
            List<GroupData> Newgroups = applicationManager.GruopHP.GetGroupList();
            Oldgroups[0].Name = newData.Name;   
            Oldgroups.Sort();
            Newgroups.Sort();
            Assert.AreEqual(Oldgroups, Newgroups);
            //Assert.AreNotEqual(Oldgroups, Newgroups);
        }
        
    }
}
