using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class AdminSeleniumHelpers
    {
        private IWebDriver _driver;
        public AdminLocators _adminLocators;
        public MenuBarLocators _menuBarLocators;
        public MyInfoLocators _myInfolocators;
       public MyInfoSeleniumHeplers _myInfoSeleniumHelpers;

        public AdminSeleniumHelpers(IWebDriver driver)
        {
            _driver = driver;
            _adminLocators = new AdminLocators(_driver);
            _menuBarLocators = new MenuBarLocators(_driver);
            _myInfolocators = new MyInfoLocators(_driver);
            _myInfolocators = new MyInfoLocators(_driver);
           _myInfoSeleniumHelpers = new MyInfoSeleniumHeplers(_driver);
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