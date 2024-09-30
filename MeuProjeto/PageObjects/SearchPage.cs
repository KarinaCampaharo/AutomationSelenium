using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using MeuProjeto.PageObjects;
using System;


namespace MeuProjeto.PageObjects
{
    public class SearchPage : BaseLogin

    {

        private IWebDriver Driver;
        private WebDriverWait Wait;

        private IWebElement fieldSearch => Driver.FindElement(By.XPath("//div[@id='global-nav-typeahead']/input"));
        private IWebElement responseOption => Driver.FindElement(By.XPath("//div[@id='global-nav-typeahead']/input"));


        public SearchPage()
        {
            Driver = Hooks.GetDriver();
        }
        public void Pesquisa(String name)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            fieldSearch.SendKeys(name);
        }

        public void Response()
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            responseOption.Clear();
        }




    }
}
