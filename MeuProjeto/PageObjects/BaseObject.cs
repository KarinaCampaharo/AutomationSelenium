using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace MeuProjeto.PageObjects;

public abstract class BasePage
{
    protected readonly IWebDriver _driver;

    protected BasePage(IWebDriver driver)
    {
        _driver = driver;
    }

    // Common method to navigate to a page
    public void NavigateTo(string url)
    {
        _driver.Navigate().GoToUrl(url);
    }
}