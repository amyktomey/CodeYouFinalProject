using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CodeYouFinalProject
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver _driver;
        public AdminLocators _adminLocators;
        public AdminSeleniumHelpers _adminSeleniumHelpers;
        public MenuBarLocators _menuBarLocators;
        public MyInfoLocators _myInfolocators;
        public MyInfoSeleniumHeplers _myInfoSeleniumHelpers;
        public LeaveLocators _leaveLocators;

        [TestInitialize]

        public void SetUp()
        {
            _driver = new ChromeDriver();
            _adminLocators = new AdminLocators(_driver);
            _adminSeleniumHelpers = new AdminSeleniumHelpers(_driver);
            _menuBarLocators = new MenuBarLocators(_driver);
            _myInfolocators = new MyInfoLocators(_driver);
            _myInfoSeleniumHelpers = new MyInfoSeleniumHeplers(_driver);
            _leaveLocators = new LeaveLocators(_driver);
        }

        [TestMethod]
        public void LoginToSite()
        {
            _adminSeleniumHelpers.Login("Admin");
            //      //     ******* Assert for mismatch ... wrong input negative FAIL pass*******
        }

        [TestMethod]
        public void AdminEditOrDeleteUser()
        {
            _adminSeleniumHelpers.Login("Admin");
            _adminSeleniumHelpers.AdminSearchUser();
            _adminSeleniumHelpers.AdminEditUser();
            _adminSeleniumHelpers.AdminSearchUser();
            _adminSeleniumHelpers.AdminDeleteUser();
            _adminSeleniumHelpers.AdminSearchUser();
        }

        [TestMethod]
        public void AdminAddNewAdmin()
        {
            _adminSeleniumHelpers.Login("Admin");
            _adminSeleniumHelpers.AdminNewUser();
            _adminSeleniumHelpers.AdminPasswordReset();
            _adminSeleniumHelpers.AdminVerifyWorkingPassword();


        }
        [TestMethod]
        public void MyInfoChangeName()
        {
            _adminSeleniumHelpers.Login("Admin");
            _menuBarLocators.MyInfoTab.Click();
            _myInfoSeleniumHelpers.MyInfoChangeUsername();
        }

        [TestMethod]
        public void LeavePageAddDelete()
        {
            _adminSeleniumHelpers.Login("Admin");
            _leaveLocators.MyLeaveButton.Click();
            _leaveLocators.ApplyLeaveButton.Click();
            _leaveLocators.SelectLeaveTypeButton.Click();
            // insert  helper for date picker
            _leaveLocators.SubmitLeaveButton.Click();
            _leaveLocators.MyLeaveListButton.Click();
           // Cancel leave here
        }

        [TestMethod]
        public void LogOut()
        {
            _adminSeleniumHelpers.LogOutOfSite();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}

//public IWebElement userRoleDropdownOptionAdmin => userRoleDropdown.FindElement(By.XPath("./descendant::*[@role='option' and contains(./*, 'Admin')]"));
//Josh Roehrig
