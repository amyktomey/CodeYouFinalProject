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
    }
}
