using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class MenuBarLocators
    {
        private IWebDriver _driver;

        public string AdminTabXPath = ("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a/span");
        public string LeaveTabXPath = ("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[3]/a/span");
        public string MyInfoTabXPath = ("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[6]/a");

        public MenuBarLocators(IWebDriver driver)
        {
            _driver = driver;
        }

 //        public IWebElement NAME-IT => _driver.FindElement(By.LOCATOR("description")).FindElement(By.LOCATOR("description"));

        public IWebElement AdminTab => _driver.FindElement(By.XPath(AdminTabXPath));
        public IWebElement LeaveTab => _driver.FindElement(By.XPath(LeaveTabXPath));
        public IWebElement MyInfoTab => _driver.FindElement(By.XPath(MyInfoTabXPath));
    }
}