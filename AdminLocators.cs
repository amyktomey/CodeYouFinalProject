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
        public IWebElement EditUserButton => _driver.FindElement(By.XPath("//div[@class='oxd-topbar-header']]"));
    }
}
