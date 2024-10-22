using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class AdminSeleniumHelpers
    {
        private IWebDriver _driver;
        public AdminLocators _adminLocators;

        public AdminSeleniumHelpers(IWebDriver driver)
        {
            _driver = driver;
            _adminLocators = new AdminLocators(_driver);
        }

        public void NavigateToURL(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void Login(string Admin)
        {
            NavigateToURL(_adminLocators.pageURL);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _adminLocators.UsernameTextBox.SendKeys("Admin");
            _adminLocators.PasswordTextBox.SendKeys("admin123");
            _adminLocators.LoginButton.Click();
        }

        public void AdminSearch()
        {
            _adminLocators.SelectAdminButton.Click();
            _adminLocators.AdminInputUsername.SendKeys("FMLName");
            _adminLocators.AdminClickSearchButton.Click();
        }
        public void AdminEditUser()
        {
  //          _adminLocators.AdminEditUserButton.Click();
  //          _adminLocators.AdminInputUserChanges.SendKeys(" ");
 //           _adminLocators.AdminSaveUserButton.Click();
        }

        public void AdminDeleteUser()
        {
 //           _adminLocators.AdminDeleteUserButton.Click();
        }
        public void Logout()
        {
        
        }
    }
}