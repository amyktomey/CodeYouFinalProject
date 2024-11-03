using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class AdminSeleniumHelpers
    {
        private IWebDriver _driver;
        public _adminLocators _adminLocators;
        public MenuBarLocators _menuBarLocators;

        public AdminSeleniumHelpers(IWebDriver driver)
        {
            _driver = driver;
            _adminLocators = new _adminLocators(_driver);
            _menuBarLocators = new MenuBarLocators(_driver);
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

        public void AdminSearchUser()
        {
           _menuBarLocators.AdminTab.Click();
           _adminLocators.SearchUsersTextBox.SendKeys("WrongName");
           _adminLocators.SearchResetInputButton.Click();
           _adminLocators.SearchUsersTextBox.SendKeys("FMLName");
           _adminLocators.SearchUsersSubmitButton.Click();
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