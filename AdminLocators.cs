using OpenQA.Selenium;
using OpenQA.Selenium.BiDi.Modules.BrowsingContext;

namespace CodeYouFinalProject
{
    public class AdminLocators
    {
        IWebDriver _driver;
        public AdminLocators(IWebDriver driver)
        {
            _driver = driver;
        }
        public string pageURL = "https://opensource-demo.orangehrmlive.com/auth/login";

        public IWebElement UsernameTextBox => _driver.FindElement(By.XPath("//input=[@name = 'username']"));
        public IWebElement PasswordTextBox => _driver.FindElement(By.XPath("//input=[@name = 'password']"));
        public IWebElement LoginButton => _driver.FindElement(By.XPath("//button [text()= 'Login']"));
    }
}
//By Tag Name: Selects elements based on their tag names, such as //input, which selects all input elements.
//By Attribute: Locates items based on their attributes.
//For example, //input[@name=’username’] selects an input element with the name attribute set to ‘username’.
//By Text Content: Finds items that contain certain text, such as //button[text()=’Submit’] picks a button labeled ‘Submit’.