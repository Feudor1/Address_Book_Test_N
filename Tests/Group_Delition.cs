namespace Address_Book_Test_N
{
    [TestFixture]
    public class GroupDelitionTests : AuthTestBase
    {
        [Test]
        public void TheGroupDelitionTest()
        {
            applicationManager.GruopHP.GroupListCheck();
            List<GroupData> Oldgroups = applicationManager.GruopHP.GetGroupList();
            applicationManager.GruopHP.Remove();
            Assert.AreEqual(Oldgroups.Count - 1, applicationManager.GruopHP.GetGroupList().Count);
            List<GroupData> Newgroups = applicationManager.GruopHP.GetGroupList();
            GroupData toBeRemoved = Oldgroups[0];
            Oldgroups.RemoveAt(0);
            Assert.AreEqual(Oldgroups, Newgroups);

            foreach (GroupData group in Newgroups) 
            {
                Assert.AreNotEqual(group.Id, toBeRemoved.Id);
            }
        }
    }
}
