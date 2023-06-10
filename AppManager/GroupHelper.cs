using OpenQA.Selenium;

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

        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Navi.GoToGroupPage();
            SelectGroup(v);
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

        public GroupHelper Remove(int v)
        {
            manager.Navi.GoToGroupPage();
            SelectGroup(v);
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

        public GroupHelper SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
            return this;
        }
    }
}
