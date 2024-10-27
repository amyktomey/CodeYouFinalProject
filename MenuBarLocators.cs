using OpenQA.Selenium;
using Selenium.Extensions;

namespace CodeYouFinalProject
{
    public class MenuBarLocators
    {
        private IWebDriver _driver;
        public string AdminTabCss = ("#app > div.oxd-layout.orangehrm-upgrade-layout > div.oxd-layout-navigation >" +
            " aside > nav > div.oxd-sidepanel-body > ul > li:nth-child(1)");

        public MenuBarLocators(IWebDriver driver)
        {
            _driver = driver;
        }

  //          public IWebElement SearchBox => _driver.FindElement(By.Id("app")).FindElement(By.ClassName("oxd-main-menu-search"));

            public IWebElement AdminTab => _driver.FindElement(By.Id("app")).FindElement(By.ClassName("oxd-main-menu"))
                .FindElement(By.CssSelector(AdminTabCss));
 //         public IWebElement PIMTab => _driver.FindElement(By.Id("app")).FindElement(By.ClassName("oxd-main-menu"))
//              .FindElement(By.LinkText("PIM"));
//            public IWebElement LeaveTab = _driver.FindElement(By.Id("app")).FindElement(By.ClassName("oxd-main-menu").FindElement(By.LinkText("Leave"));
        //     public IWebElement TimeTab = ;
        //     public IWebElement RecruitTab = ;
        //     public IWebElement DashboardTab = ;
        //     public IWebElement DirectoryTab = ;
        //     public IWebElement MaintenanceTab = ;
        //     public IWebElement ClaimTab = ;
        //     public IWebElement BuzzTab = ;
    }
}
