using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class AdminLocators
    {
        private IWebDriver _driver;
        public string UsersTextBox = ("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/input");
        public string SearchResetButton = ("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[1]");
        public string UsersSubmitButton = ("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]");


        public AdminLocators(IWebDriver driver)
        {
            _driver = driver;
        }

        public string pageURL = "https://opensource-demo.orangehrmlive.com/";

        public IWebElement UsernameTextBox => _driver.FindElement(By.ClassName("oxd-form"))
            .FindElement(By.XPath("//input[@name='username']"));
        public IWebElement PasswordTextBox => _driver.FindElement(By.ClassName("oxd-form"))
            .FindElement(By.XPath("//input[@name='password']"));
        public IWebElement LoginButton => _driver.FindElement(By.ClassName("oxd-form"))
            .FindElement(By.XPath("//button[@type='submit']"));
        public IWebElement SearchUsersTextBox => _driver.FindElement(By.XPath(UsersTextBox));
        public IWebElement SearchResetInputButton => _driver.FindElement(By.XPath(SearchResetButton));
 //       public IWebElement SearchUsersSubmitButton => _driver.FindElement(By.XPath(UsersSubmitButton));
    }
}
