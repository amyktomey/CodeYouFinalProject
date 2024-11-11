using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class LeaveSeleniumHelpers
    {
        public IWebDriver _driver;
        public AdminLocators _adminLocators;
        public MenuBarLocators _menuBarLocators;
        public LeaveLocators _leaveLocators;

        public LeaveSeleniumHelpers(IWebDriver driver)
        {
            _driver = driver;
            _adminLocators = new AdminLocators(_driver);
            _menuBarLocators = new MenuBarLocators(_driver);
            _leaveLocators = new LeaveLocators(_driver);
        }

        public void ApplyForLeave()
        {
            _menuBarLocators.LeaveTab.Click();
            _leaveLocators.ApplyLeaveButton.Click();
            _leaveLocators.SelectLeaveTypeButton.Click();
            _leaveLocators.SubmitLeaveButton.Click();
            _leaveLocators.MyLeaveButton.Click();
            _leaveLocators.MyLeaveListButton.Click();
        }

        public void CancelLeave()
        {
            _menuBarLocators.LeaveTab.Click();
            _leaveLocators.MyLeaveButton.Click();
            //  cancel the leave 
        }
    }
}