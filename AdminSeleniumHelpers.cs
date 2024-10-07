using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class AdminSeleniumHelpers
    {
        IWebDriver _driver;
        public AdminLocators _adminLocators;

        public AdminSeleniumHelpers(AdminLocators adminLocators)
        {
            _adminLocators = adminLocators;
        }

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
            NavigateToURL(_adminLocators.pageURL);
            _adminLocators.UsernameTextBox.SendKeys(Admin);
            _adminLocators.PasswordTextBox.SendKeys("admin123");
            _adminLocators.LoginButton.Click();
        }
    }
}
