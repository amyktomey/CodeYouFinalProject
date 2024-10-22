using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CodeYouFinalProject
{
    [TestClass]
    public class UnitTest1
    {
        public IWebDriver? _driver;
        public AdminLocators? _adminLocators;
        public AdminSeleniumHelpers? _adminSeleniumHelpers;


        [TestInitialize]

        public void SetUp()
        {
            _driver = new ChromeDriver();
            _adminLocators = new AdminLocators(_driver);
            _adminSeleniumHelpers = new AdminSeleniumHelpers(_driver);
        }

        [TestMethod]
        public void LoginToSite()
        {
            _adminSeleniumHelpers.Login("Admin");
        }

        [TestMethod]
        public void AdminSearchForUser()
        {
         _adminSeleniumHelpers.AdminSearch();       
        }
        [TestMethod]
        public void AdminEditUser()
        {
            _adminSeleniumHelpers.AdminSearch();
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