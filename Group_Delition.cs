using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace Address_Book_Test_N
{
    [TestFixture]
    public class GroupDelitionTests : TestBase
    {
        [Test]
        public void TheGroupDelitionTest()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToGroupPage();
            groupHelper.SelectGroup(1);
            groupHelper.DeleteGroup();
            navigationHelper.GoToGroupPage();
            loginHelper.LogOut();
        }
    }
}
