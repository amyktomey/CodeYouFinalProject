using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class LeaveLocators
    {
        private IWebDriver _driver;

        public LeaveLocators(IWebDriver driver)
        {
            _driver = driver;
        }
        // public IWebElement LogOut => _driver.FindElement(By.XPath("//a[normalize-space()='Logout']"));
        public IWebElement ApplyLeaveButton => _driver.FindElement(By.XPath("//a[@class='oxd-icon bi-caret-down-fill oxd-select-text--arrow']"));
        public IWebElement SelectLeaveTypeButton => _driver.FindElement(By.XPath("//div[@class = 'oxd-select-text-input']" +
            "//button[normalize-space()='CAN - FMLA']"));
        // data picker here
        public IWebElement SubmitLeaveButton => _driver.FindElement(By.XPath("//button[normalize-space()=Apply']"));
        public IWebElement MyLeaveButton => _driver.FindElement(By.XPath("//a[@class = 'oxd-topbar-body-nav-item']" +
            "//button[normalize-space()='My Leave']"));
        public IWebElement MyLeaveListButton => _driver.FindElement(By.XPath("//i[@class = 'oxd-icon bi-caret-up-fill']"));
    }
}