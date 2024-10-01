using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MeuProjeto.PageObjects;

public class WebDriverFactory
{
    private static IWebDriver _driver;

    public static IWebDriver GetDriver()
    {
        if (_driver == null)
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
          
        }
        return _driver;
    }

    public static void CloseDriver()
    {
        if (_driver != null)
        {
            _driver.Quit();
            _driver = null;
        }
    }
}