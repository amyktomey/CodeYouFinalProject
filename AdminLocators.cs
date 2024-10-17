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
    }
}
