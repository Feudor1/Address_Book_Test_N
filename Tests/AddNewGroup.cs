using System.Collections.Generic;
using System.Security.Cryptography;

namespace Address_Book_Test_N
{
    [TestFixture]
    public class AddNewGroup : AuthTestBase

    {
        [Test]
        public void CreateNewGroupTest()
        {
            GroupData group = new GroupData("lECTION GROUP");
            group.Header = "Header";
            group.Footer = "Footer";

            List<GroupData> Oldgroups = applicationManager.GruopHP.GetGroupList();

            applicationManager.GruopHP.CreateGroup(group);

            List <GroupData> Newgroups = applicationManager.GruopHP.GetGroupList();
            Oldgroups.Add(group);
            Oldgroups.Sort();
            Newgroups.Sort();   
            Assert.AreEqual(Oldgroups, Newgroups);

        }



        [Test]
        public void CreateEmptyGroup()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            List<GroupData> Oldgroups = applicationManager.GruopHP.GetGroupList();

            applicationManager.GruopHP.CreateGroup(group);

            List<GroupData> Newgroups = applicationManager.GruopHP.GetGroupList();
            Oldgroups.Add(group);
            Oldgroups.Sort();
            Newgroups.Sort();
            Assert.AreEqual(Oldgroups, Newgroups);
        }

        [Test]
        public void CreateBadNameGroupCreation()
        {
            GroupData group = new GroupData("a'a");
            group.Header = "Header";
            group.Footer = "Footer";

            List<GroupData> Oldgroups = applicationManager.GruopHP.GetGroupList();

            applicationManager.GruopHP.CreateGroup(group);

            List<GroupData> Newgroups = applicationManager.GruopHP.GetGroupList();
            //Oldgroups.Add(group);
            Oldgroups.Sort();
            Newgroups.Sort();
            Assert.AreEqual(Oldgroups, Newgroups);

        }

    }
}
