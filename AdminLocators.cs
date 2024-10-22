using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using static System.Net.WebRequestMethods;

namespace CodeYouFinalProject
{
    public class AdminLocators
    {
        private IWebDriver _driver;
        private const string AdminTab = ("]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a");
        
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

        // *** good to here... 

        public IWebElement SelectAdminButton => _driver.FindElement(By.ClassName("oxd-main-menu"))
            .FindElement(By.XPath(AdminTab));

        public IWebElement AdminInputUsername => _driver.FindElement(By.ClassName("oxd-form"))
            .FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[1]/div/div[1]/div/div[2]/input"));
        
            public IWebElement AdminClickSearchButton => _driver.FindElement(By.ClassName("oxd-form-actions"))
            .FindElement(By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[1]/div[2]/form/div[2]/button[2]"));

 //       public IWebElement AdminEditUserButton => 
    }
}