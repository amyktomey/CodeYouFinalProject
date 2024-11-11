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
            _menuBarLocators.AdminTab.Click();
            _adminLocators.SearchUsersTextBox.SendKeys("FMLName");
            _adminLocators.SearchUsersSubmitButton.Click();
            _adminLocators.EditUserButton.Click();
            _adminLocators.SearchUsersTextBox.SendKeys("Jane Doe");
        }

        public void AdminDeleteUser()
        { 
            _menuBarLocators.AdminTab.Click();
            _adminLocators.SearchUsersTextBox.SendKeys("Jane Doe");
            _adminLocators.SearchUsersSubmitButton.Click();
            _adminLocators.DeleteUserButton.Click();
        }

        public void AdminNewUser()
        {
            _menuBarLocators.AdminTab.Click();
            _adminLocators.AddNewUserButton.Click();
            _adminLocators.SelectAdminForRole.Click();
            _adminLocators.InputUserrname.SendKeys("DouubleOh7");
            _adminLocators.InputEmployeeName.SendKeys("Jane Dough");
            _adminLocators.EnableUser.Click();
        }
        public void AdminPasswordReset()
        {
            _adminLocators.InputNewPassword.SendKeys("Pa$$w0rd");
            _adminLocators.ConfirmPassword.SendKeys("Pa$$w0rd");
        }

        public void AdminVerifyWorkingPassword()
        {
            NavigateToURL(_adminLocators.pageURL);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _adminLocators.UsernameTextBox.SendKeys("DouubleOh7");
            _adminLocators.PasswordTextBox.SendKeys("Pa$$w0rd");
            _adminLocators.LoginButton.Click();
        }

        public void LogOutOfSite()
        {
            _adminLocators.LogOut.Click();
        }
    }
}