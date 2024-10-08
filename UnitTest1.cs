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

        public void SetUp()
        {
            SetUp(_adminLocators);
        }

        [TestInitialize]
        public void SetUp(AdminLocators AdminLocators)
        {
            _driver = new ChromeDriver();
            _ = new AdminLocators(_driver);
            _adminSeleniumHelpers = new AdminSeleniumHelpers(_driver);
        }

        [TestMethod]
        public void ClickAdminTab()
        {
            _adminSeleniumHelpers.Login("Admin");

        }



        [TestCleanup]
        public void Cleanup()
        {
            _driver.Quit();
            _driver.Dispose();
        }
    }
}