using OpenQA.Selenium;

namespace Address_Book_Test_N
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper (IWebDriver driver) : base(driver)
        {}
        public void InitGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
        }

        public void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }
        public void DeleteGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
        }
        public void FillGroupForm(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).SendKeys(group.Name);
            driver.FindElement(By.Name("group_header")).SendKeys(group.Header);
            driver.FindElement(By.Name("group_footer")).SendKeys(group.Footer);
        }
        public void SelectGroup(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + index + "]")).Click();
        }
    }
}
