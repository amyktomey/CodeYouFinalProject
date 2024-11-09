using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class AdminLocators
    {
        private IWebDriver _driver;

        public AdminLocators(IWebDriver driver)
        {
            _driver = driver;
        }

        public string pageURL = "https://opensource-demo.orangehrmlive.com/";

        public IWebElement UsernameTextBox => _driver.FindElement(By.ClassName("oxd-form"))
            .FindElement(By.XPath("//input[@name='username']"));
        public IWebElement PasswordTextBox => _driver.FindElement(By.ClassName("oxd-form"))
            .FindElement(By.XPath("//input[@name='password']"));
        public IWebElement LoginButton => _driver.FindElement(By.ClassName("oxd-form"))
            .FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement SearchUsersTextBox => _driver.FindElement
            (By.XPath("//div[@class='oxd-input-group oxd-input-field-bottom-space']" +
                "//div//input[@class='oxd-input oxd-input--active']"));
        public IWebElement SearchResetInputButton => _driver.FindElement
            (By.XPath("//button[normalize-space()='Reset']"));
        public IWebElement SearchUsersSubmitButton => _driver.FindElement
            (By.XPath(("//button[normalize-space()='Search']")));

        // *** EDIT USER PAGE LOCATORS ***

        public IWebElement EditUserButton => _driver.FindElement(By.XPath("//div[@class='oxd-topbar-header']]"));
 //       public IWebElement InputUseRoleAdmin => _driver.FindElement(By.XPath("//div[contains(text(),'Admin')]"));   Select uiser role
 //       public IWebElement InputUseRoleESS => _driver.FindElement(By.XPath("//div[contains(text(),'ESS')]"));
        public IWebElement InputEmployeeName => _driver.FindElement(By.XPath("//div[@class='oxd-topbar-header']"));
 //       public IWebElement StatusEnabled => _driver.FindElement(By.XPath("//div[contains(text(),'Enabled')]"));
 //       public IWebElement StatusDisabled=> _driver.FindElement(By.XPath("//div[contains(text(),'Enabled')]"));
        public IWebElement InputUserName => _driver.FindElement(By.XPath("//div[@class='oxd-topbar-header']"));
        public IWebElement ChangePasswordCheckbox => _driver.FindElement(By.XPath("//div[@class='oxd-topbar-header']"));
        public IWebElement CancelChangesrButton => _driver.FindElement(By.XPath("//div[@class='oxd-topbar-header']"));
        public IWebElement SaveUserButton => _driver.FindElement(By.XPath("//div[@class='oxd-topbar-header']"));

    }
}
