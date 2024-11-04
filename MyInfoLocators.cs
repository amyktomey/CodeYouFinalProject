using OpenQA.Selenium;

namespace CodeYouFinalProject
{
    public class MyInfoLocators
    {
        private IWebDriver _driver;

        public string PersonalDetailsTabXPath = ("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[1]/div[2]/div[1]/a");
        public string FullNameInputBoxXPath =  ("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[1]/form/div[1]/div/div/div/div[2]/div[1]/div[2]/input");
        public string SaveDetailsButtonXPath =  ("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/div/div[2]/div[2]/div/form/div[2]/button");



        public MyInfoLocators(IWebDriver driver)
        {
            _driver = driver;
        }
        public IWebElement PersonalDetailsTab => _driver.FindElement(By.XPath(PersonalDetailsTabXPath));
        public IWebElement FullNameInputBox =>  _driver.FindElement(By.XPath(FullNameInputBoxXPath));
         public IWebElement SaveDetailsButton =>  _driver.FindElement(By.XPath(SaveDetailsButtonXPath));
    }
}
