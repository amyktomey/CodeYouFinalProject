using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class AdminSeleniumHelpers
    {
        IWebDriver _driver;
        AdminLocators _AdminLocators;
        public AdminSeleniumHelpers(IWebDriver driver)
        {
            _driver = driver;
        }
        public void NavigateToURL(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }
        public void Login(string Admin)
        {
            NavigateToURL(_AdminLocators.pageURL);
            _AdminLocators.UsernameTextBox.SendKeys(Admin);
            _AdminLocators.PasswordTextBox.SendKeys("admin123");
            _AdminLocators.LoginButton.Click();
        }
    }
}
