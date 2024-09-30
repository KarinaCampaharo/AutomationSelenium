using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace MeuProjeto.PageObjects
{
    public class BaseLogin
    {
        private IWebDriver Driver;
        private WebDriverWait Wait;


        private IWebElement userName => Driver.FindElement(By.XPath("//input[@id='username']"));

        private IWebElement facaLogin => Driver.FindElement(By.XPath("//a[contains(text(),'Sign in')]"));

        private IWebElement enterPassword => Driver.FindElement(By.XPath("//input[@id='password']"));
        private IWebElement clickbutton => Driver.FindElement(By.XPath("//button[@type='submit']"));
        // private IWebElement clickOk => Driver.FindElement(By.XPath(""));

        public const int DefaultWaitInSeconds = 10;


        public BaseLogin()
        {
            Driver = Hooks.GetDriver();
        }

        public void NavigateTo()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            Driver.Navigate().GoToUrl("https://www.linkedin.com");
        }


        public void ClicarLogin()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            facaLogin.Click();
        }

        public void EnterUser(String username)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            userName.SendKeys(username);
        }



        public void Password(String password)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            enterPassword.SendKeys(password);
        }


        public void ClickButton()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            clickbutton.Click();
        }


    }
}
