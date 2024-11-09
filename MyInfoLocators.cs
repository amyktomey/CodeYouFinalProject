using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class MyInfoLocators
    {
        private IWebDriver _driver;

        public MyInfoLocators(IWebDriver driver)
        {
            _driver = driver;
        }
  //      public IWebElement PersonalDetailsTab => _driver.FindElement(By.XPath("//a[@class='orangehrm-tabs-item --active']//button[normalize-space()='Personal Details']"));
        public IWebElement FirstNameInputBox => _driver.FindElement(By.XPath("//input[@placeholder='First Name']"));
        public IWebElement LastNameInputBox => _driver.FindElement(By.XPath("//input[@placeholder='Middle Name']"));
        public IWebElement SaveDetailsButton => _driver.FindElement(By.XPath
            ("//div[@class='orangehrm-horizontal-padding orangehrm-vertical-padding']//button[@type='submit'][normalize-space()='Save']"));
        
        // public IWebElement EditUserButton => _driver.FindElement(By.XPath("//div[@class='oxd-topbar-header']]"));
        public IWebElement SelectUserRole => _driver.FindElement(By.XPath(""));
        //       public IWebElement InputUseRoleAdmin => _driver.FindElement(By.XPath("//div[contains(text(),'Admin')]"));   Select uiser role
        //       public IWebElement InputUseRoleESS => _driver.FindElement(By.XPath("//div[contains(text(),'ESS')]"));
        public IWebElement InputEmployeeName => _driver.FindElement(By.XPath("//div[@class='oxd-topbar-header']"));

        public IWebElement SelectUseStatus => _driver.FindElement(By.XPath(""));
        //       public IWebElement StatusEnabled => _driver.FindElement(By.XPath("//div[contains(text(),'Enabled')]"));
        //       public IWebElement StatusDisabled=> _driver.FindElement(By.XPath("//div[contains(text(),'Enabled')]"));
        public IWebElement InputUserName => _driver.FindElement(By.XPath("//div[@class='oxd-topbar-header']"));
        public IWebElement ChangePasswordCheckbox => _driver.FindElement(By.XPath("//div[@class='oxd-topbar-header']"));

        public IWebElement InputNewPassword => _driver.FindElement(By.XPath(""));
        public IWebElement VerifyNewPassword => _driver.FindElement(By.XPath(""));
        //        public IWebElement CancelChangesButton => _driver.FindElement(By.XPath("/"));

        public IWebElement SelectBrowseButton =>_driver.FindElement(By.XPath("//button[normalize-space()='Browse']"));
        public IWebElement InputFileName => _driver.FindElement(By.LinkText("")); 
        public IWebElement SaveUserButton => _driver.FindElement(By.XPath(""));
    }
}
// <i data-v-bddebfba="" data-v-1b0f05a0="" class="oxd-icon bi-upload oxd-file-input-icon"></i>       browse SH //input[@type='file']