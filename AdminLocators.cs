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

        public IWebElement UsernameTextBox => _driver.FindElement(By.XPath("//input[@placeholder='Username']"));
        public IWebElement PasswordTextBox => _driver.FindElement(By.XPath("//input[@placeholder='Password']"));
        public IWebElement LoginButton => _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
    };
}