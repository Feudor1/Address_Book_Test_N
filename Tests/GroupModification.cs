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
            GroupData oldData = Oldgroups[0];

            applicationManager.GruopHP.Modify(newData);

            Assert.AreEqual(Oldgroups.Count, applicationManager.GruopHP.GetGroupList().Count);
            List<GroupData> Newgroups = applicationManager.GruopHP.GetGroupList();
            Oldgroups[0].Name = newData.Name;   
            Oldgroups.Sort();
            Newgroups.Sort();
            Assert.AreEqual(Oldgroups, Newgroups);


            Assert.AreEqual(Oldgroups, Newgroups);

            foreach (GroupData group in Newgroups)
            {
                if (group.Id == oldData.Id) 
                {
                    Assert.AreEqual(newData.Name, group.Name);
                }
            }

        }
        
    }
}
