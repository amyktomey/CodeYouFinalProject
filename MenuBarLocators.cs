using OpenQA.Selenium;
using Selenium.Extensions;

namespace CodeYouFinalProject
{
    public class MenuBarLocators
    {
        private IWebDriver _driver;

         public string AdminTabXPath = ("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a/span");
        public MenuBarLocators(IWebDriver driver)
        {
            _driver = driver;
        }
        //       sample text below***
        //        public IWebElement NAME-IT => _driver.FindElement(By.LOCATOR("description")).FindElement(By.LOCATOR("description"));

        public IWebElement AdminTab => _driver.FindElement(By.Id("app")).FindElement(By.XPath(AdminTabXPath));
        //     public IWebElement PIMTab => ;
        //     public IWebElement LeaveTab => ;
        //     public IWebElement TimeTab => ;
        //     public IWebElement RecruitTab => ;
        //     public IWebElement DashboardTab => ;
        //     public IWebElement DirectoryTab => ;
        //     public IWebElement MaintenanceTab => ;
        //     public IWebElement ClaimTab => ;
        //     public IWebElement BuzzTab => ;
    }
}

//.FindElement(By.ClassName("oxd-main-menu"))
