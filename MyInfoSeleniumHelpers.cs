using System;
using CodeYouFinalProject;
using OpenQA.Selenium;

public class MyInfoSeleniumHeplers
{
    public IWebDriver _driver;
    public AdminLocators _adminLocators;
    public MenuBarLocators _menuBarLocators;
    public MyInfoLocators _myInfoLocators;

    public MyInfoSeleniumHeplers(IWebDriver driver)
    {
        _driver = driver;
        _adminLocators = new AdminLocators(_driver);
        _menuBarLocators = new MenuBarLocators(_driver);
        _myInfoLocators = new MyInfoLocators(_driver);
    }
    public void MyInfoChangeUsername()
    {

        _myInfoLocators.FirstNameInputBox.SendKeys(Keys.Control + "a" + Keys.Delete);
        _myInfoLocators.FirstNameInputBox.SendKeys("Jane");
        _myInfoLocators.MiddleNameInputBox.SendKeys(Keys.Control + "a" + Keys.Delete);
        _myInfoLocators.MiddleNameInputBox.SendKeys(" ");
        _myInfoLocators.LastNameInputBox.SendKeys(Keys.Control + "a" + Keys.Delete);
        _myInfoLocators.LastNameInputBox.SendKeys("Doe");
        _myInfoLocators.SaveDetailsButton.Click();
    }

    public void MyInfoFileUpload()
    { 
    
    }
}