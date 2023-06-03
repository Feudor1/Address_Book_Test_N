using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Address_Book_Test_N
{
    [TestFixture]
    public class GroupDelitionTests : TestBase
    {
        [Test]
        public void TheGroupDelitionTest()
        {
            applicationManager.Navi.GoToHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.Navi.GoToGroupPage();
            applicationManager.GruopHP.SelectGroup(1);
            applicationManager.GruopHP.DeleteGroup();
            applicationManager.Navi.GoToGroupPage();
            applicationManager.Auth.LogOut();
        }
    }
}
