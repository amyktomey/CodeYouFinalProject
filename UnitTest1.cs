using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CodeYouFinalProject
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver _driver;
        public _adminLocators _adminLocators;
        public AdminSeleniumHelpers _adminSeleniumHelpers;
        public MenuBarLocators _menuBarLocators;

        [TestInitialize]

        public void SetUp()
        {
            _driver = new ChromeDriver();
            _adminLocators = new _adminLocators(_driver);
            _adminSeleniumHelpers = new AdminSeleniumHelpers(_driver);
            _menuBarLocators = new MenuBarLocators(_driver);
        }

        [TestMethod]
        public void LoginToSite()
        {
            _adminSeleniumHelpers.Login("Admin");

  //          NUnit.Framework.Assert.That(_adminLocators.UsernameTextBox, Is.EqualTo("Admin"));
        }

        [TestMethod]

        public void AdminSearchForUser()
        {
            _adminSeleniumHelpers.Login("Admin");
            _adminSeleniumHelpers.AdminSearchUser();
        }
        [TestMethod]
        public void AdminEditUser()
        {
  //          _adminSeleniumHelpers.AdminSearch();
        }
        [TestMethod]
        public void AdminDeleteUser()
        {

        }
        [TestMethod]
        public void AdminAddNewAdmin()
        {

        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}