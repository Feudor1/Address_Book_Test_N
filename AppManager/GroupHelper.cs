using OpenQA.Selenium;
using System.Data;

namespace Address_Book_Test_N
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager) : base(manager)
        {
        }
        public GroupHelper InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public void GroupListCheck() 
        {
            //if (driver.FindElement(By.XPath("//span[contains(@class, 'group')]")).Count)
            int i = 0;
            i = driver.FindElements(By.CssSelector(".group")).Count;

            if (driver.FindElements(By.CssSelector(".group")).Count > 0)

            {
                manager.addNewGroup.CreateNewGroupTest();
            }

        }
        public GroupHelper Modify(GroupData newData)
        {
            manager.Navi.GoToGroupPage();
            SelectGroup();
            FindEditButton();
            FillGroupForm(newData);
            FindUpdateGroupButton();
            manager.Navi.GoToGroupPage();
            return this;

        }

        public GroupHelper CreateGroup(GroupData group)
        {
            manager.Navi.GoToGroupPage();
            InitGroupCreation();
            FillGroupForm(group);
            SubmitGroupCreation();
            manager.Navi.GoToGroupPage();
            return this;
        }

        public GroupHelper Remove()
        {
            manager.Navi.GoToGroupPage();
            SelectGroup();
            DeleteGroup();
            manager.Navi.GoToGroupPage();
            return this;
        }

        public GroupHelper SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
            return this;
        }

        public GroupHelper FindUpdateGroupButton()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public GroupHelper FindEditButton()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }
        public GroupHelper DeleteGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }
        public GroupHelper FillGroupForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }

        public GroupHelper SelectGroup()
        {
            driver.FindElement(By.Name("selected[]")).Click();
            return this;
        }
    }
}
