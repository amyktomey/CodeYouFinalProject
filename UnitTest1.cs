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
        public void AdminUserManagement()
        {
            _adminSeleniumHelpers.Login("Admin");
            _adminSeleniumHelpers.AdminSearchUser();
            _adminSeleniumHelpers.AdminEditUser();
            _adminSeleniumHelpers.AdminSearchUser();
  //          _adminSeleniumHelpers.AdminDeleteUser();
            _adminSeleniumHelpers.AdminSearchUser();
        }

        [TestMethod]
        public void AdminAddNewAdmin()
        {
            _adminSeleniumHelpers.Login("Admin");


        }
        [TestMethod]
        public void MyInfoChangeName()
        {
            _adminSeleniumHelpers.Login("Admin");
 //           _adminSeleniumHelpers.AdminSearchUser();
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

//Josh Roehrig
//6:59 PM
////div[@class='oxd-input-group oxd-input-field-bottom-space']
//Caitlin Starkey
//7:01 PM
//public IWebElement userRoleDropdownOptionAdmin => userRoleDropdown.FindElement(By.XPath("./descendant::*[@role='option' and contains(./*, 'Admin')]"));
//Josh Roehrig
//7:14 PM
////button[text()='Reset']
////button[normalize-space(text())='Reset']
////button[normalize-space()='Reset']
//Jonathan Tate
//7:19 PM
//What about an index after the save button?
//Alex McTeague
//7:20 PM
//For these two specific buttons, it also looks like they have unique attributes type=button and type=submit

//So you could do //button[@type='submit']
//input[@name='username']
//Josh Roehrig
//7:49 PM
//SendKeys(Keys.ArrowDown);
//(Keys.Control + "a");
//SendKeys(Keys.Delete);