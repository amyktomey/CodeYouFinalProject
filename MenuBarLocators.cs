using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class MenuBarLocators
    {
        private IWebDriver _driver;

        public MenuBarLocators(IWebDriver driver)
        {
            _driver = driver;
        }

 //        public IWebElement NAME-IT => _driver.FindElement(By.LOCATOR("description")).FindElement(By.LOCATOR("description"));

        public IWebElement AdminTab => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a/span"));
        public IWebElement LeaveTab => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[3]/a/span"));
        public IWebElement MyInfoTab => _driver.FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[6]/a"));
    }
}