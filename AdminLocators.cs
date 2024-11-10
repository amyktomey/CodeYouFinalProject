using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class AdminLocators
    {
        private IWebDriver _driver;

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
        public IWebElement SearchUsersTextBox => _driver.FindElement
            (By.XPath("//div[@class='oxd-input-group oxd-input-field-bottom-space']" +
                "//div//input[@class='oxd-input oxd-input--active']"));
        public IWebElement SearchResetInputButton => _driver.FindElement
            (By.XPath("//button[normalize-space()='Reset']"));
        public IWebElement SearchUsersSubmitButton => _driver.FindElement
            (By.XPath(("//button[normalize-space()='Search']")));
        public IWebElement DeleteUserButton => _driver.FindElement(By.XPath("/i[@class ='oxd-icon bi-trash']"));
        // go to Admin Add User page
        public IWebElement EditUserButton => _driver.FindElement(By.XPath("//i[@class ='oxd-icon bi-pencil-fill']"));
        public IWebElement AddNewUserButton => _driver.FindElement(By.XPath("//button[normalize-space()='Add']"));
        public IWebElement SelectAdminForRole => _driver.FindElement(By.XPath("//div[@class='oxd-grid-item oxd-grid-item--gutters user-password-cell']" +
             "//button[normalize-space()='Admin']"));  
        public IWebElement SelectESSForRole => _driver.FindElement(By.XPath("//div[@class='oxd-grid-item oxd-grid-item--gutters user-password-cell']" +
             "//button[normalize-space()='ESS']"));
        public IWebElement InputEmployeeName => _driver.FindElement(By.XPath("//div[@class='oxd-autocomplete-text-input--after']"));
        public IWebElement DisableUser => _driver.FindElement(By.XPath("//div[@class = 'oxd-select-text oxf-select-text--active']" +
            "//button[normalize-space()='Disabled']\""));
        public IWebElement EnableUser => _driver.FindElement(By.XPath("//div[@class = 'oxd-select-text oxf-select-text--active']" +
             "//button[normalize-space()='Enabled']\""));
        public IWebElement InputUserrname => _driver.FindElement(By.XPath("//input[@placeholder='Type for hints...']"));

        public IWebElement InputNewPassword => _driver.FindElement(By.XPath("//input[normalize-space()='Passwordl']"));
        public IWebElement ConfirmPassword => _driver.FindElement(By.XPath("//input[@class='oxd-input oxd-input--active']"));
        public IWebElement CancelUserSaveButton => _driver.FindElement(By.XPath("//button[normalize-space()='Cancel']"));
        public IWebElement AddUserSaveButton => _driver.FindElement(By.XPath("//button[normalize-space()='Save']"));

     
        public IWebElement LogOut => _driver.FindElement(By.XPath("//a[normalize-space()='Logout']"));
    }
} 
