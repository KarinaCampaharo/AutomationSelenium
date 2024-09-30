using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

[Binding]
public class Hooks
{
    private static IWebDriver Driver;

    [BeforeScenario]
    public void InitializeWebDriver()
    {
        if (Driver == null)
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(12);

        }
    }

    [AfterScenario]
    public void CloseWebDriver()
    {
        if (Driver != null)
        {
            Driver.Quit();
            Driver = null;
        }
    }

    public static IWebDriver GetDriver()
    {
        return Driver;
    }
}
