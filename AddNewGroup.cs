using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Address_Book_Test_N;
using NUnit.Framework;

namespace Address_Book_Test_N
{
    [TestFixture]
    public class AddNewGroup : TestBase

    {
        [Test]
        public void CreateNewGroupTest()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData("admin","secret"));
            navigationHelper.GoToGroupPage();
            groupHelper.InitGroupCreation();
            GroupData group = new GroupData("lECTION GROUP");
            group.Header = "Header";
            group.Footer = "Footer";
            groupHelper.FillGroupForm(group);
            groupHelper.SubmitGroupCreation();
            navigationHelper.GoToGroupPage();
            loginHelper.LogOut();

        }
    }
}
