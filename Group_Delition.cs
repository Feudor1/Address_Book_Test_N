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
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupPage();
            SelectGroup(1);
            DeleteGroup();
            GoToGroupPage();
            LogOut();
        }
    }
}
