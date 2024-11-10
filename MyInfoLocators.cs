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
        public IWebElement PersonalDetailsTab => _driver.FindElement(By.XPath("//button[normalize-space()='Personal Details']"));
        public IWebElement FirstNameInputBox => _driver.FindElement(By.XPath("//input[@placeholder='First Name']"));
        public IWebElement MiddleNameInputBox => _driver.FindElement(By.XPath("//input[@placeholder='Middle Name']"));
        public IWebElement LastNameInputBox => _driver.FindElement(By.XPath("//input[@placeholder='Last Name']"));
        public IWebElement SaveDetailsButton => _driver.FindElement(By.XPath
            ("//div[@class='orangehrm-horizontal-padding orangehrm-vertical-padding']//button[@type='submit'][normalize-space()='Save']"));
    }
}
// <i data-v-bddebfba="" data-v-1b0f05a0="" class="oxd-icon bi-upload oxd-file-input-icon"></i>       browse SH //input[@type='file']