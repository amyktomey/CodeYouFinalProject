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
        private MyInfoSeleniumHeplers _myInfoSeleniumHelpers;

        [TestInitialize]

        public void SetUp()
        {
            _driver = new ChromeDriver();
            _adminLocators = new AdminLocators(_driver);
            _adminSeleniumHelpers = new AdminSeleniumHelpers(_driver);
            _menuBarLocators = new MenuBarLocators(_driver);
            _myInfolocators = new MyInfoLocators(_driver);
            _myInfoSeleniumHelpers = new MyInfoSeleniumHeplers(_driver);
        }

           [TestMethod]
        public void LoginToSite()
       {
           _adminSeleniumHelpers.Login("Admin");
 //      //     ******* Add a check for mismatch ... wrong input*******
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
        [TestMethod]
        public void MyInfoChangeName()
        {
            _adminSeleniumHelpers.Login("Admin");
            _menuBarLocators.MyInfoTab.Click();
            _myInfoSeleniumHelpers.MyInfoChangeUsername();
        }

        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}