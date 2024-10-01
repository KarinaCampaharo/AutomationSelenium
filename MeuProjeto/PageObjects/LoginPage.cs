using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;



namespace MeuProjeto.PageObjects;

public class LoginPage : BasePage
{
    private readonly WebDriverWait _wait;

    // Constructor that accepts the WebDriver instance and passes it to the base class
    public LoginPage(IWebDriver driver) : base(driver)
    {
        _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10)); // Explicit wait for 10 seconds
    }

    // Elements located explicitly using By selectors

    

    private IWebElement UsernameField => _wait.Until(driver =>
           driver.FindElement(By.Id("i0116")));
    private IWebElement ClickLogin => _wait.Until(driver =>
           driver.FindElement(By.XPath("//input[@id='idSIButton9']")));
    private IWebElement PasswordField => _wait.Until(driver =>
           driver.FindElement(By.Id("i0118")));
    private IWebElement ClickButton => _wait.Until(driver =>
           driver.FindElement(By.XPath("//div[@id='lightbox']/div[3]/div/div[2]/div/div[5]/div/div/div/div/input")));

    private IWebElement Yes_button => _wait.Until(driver =>
           driver.FindElement(By.Id("idSIButton9")));
    


    /*private IWebElement UsernameField => _wait.Until(ExpectedConditions.ElementIsVisibles(By.XPath("//input[@id='username']")));
    private IWebElement PasswordField => _wait.Until(ExpectedConditions.ElementIsVisible(By.Id("password")));
    private IWebElement LoginButton => _wait.Until(ExpectedConditions.ElementIsVisible(By.Id("loginButton")));
    */
    // Methods to interact with the page

    public void EnterCredentials(string username, string password)
    {
        
        UsernameField.SendKeys(username);
        ClickLogin.Click();
        PasswordField.SendKeys(password);
        ClickButton.Click();
        Yes_button.Click();


    }



}

