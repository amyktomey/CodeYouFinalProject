using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class AdminLocators
    {
        IWebDriver _driver;
        public AdminLocators(IWebDriver driver)
        {
            _driver = driver;
        }
        public string pageURL = "https://opensource-demo.orangehrmlive.com/auth/login";

        public IWebElement UsernameTextBox => _driver.FindElement(By.XPath("//div=[@class = 'input.oxd-input.oxd-input--active']"));
        public IWebElement PasswordTextBox => _driver.FindElement(By.XPath("//div=[@class = 'input.oxd-input.oxd-input--active']"));
        public IWebElement LoginButton => _driver.FindElement(By.XPath("//div=[@class = 'button.oxd-button.oxd-button--medium.oxd-button--main.orangehrm-login-button']"));
    }
}
//  xpath=//tagname[@Attribute=’Value’]
// _driver.FindElement(By.XPath("//div[@class = 'inventory_details_price']"));
