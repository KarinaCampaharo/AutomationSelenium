using TechTalk.SpecFlow;
using OpenQA.Selenium;
using MeuProjeto.PageObjects;
using NUnit.Framework;

[Binding]
public class LoginSteps
{
    private readonly IWebDriver _driver;
    private readonly LoginPage _loginPage;
   // private readonly DashboardPage _dashboardPage;

    public LoginSteps()
    {
        // Get the shared WebDriver instance from the factory
        _driver = WebDriverFactory.GetDriver();

        // Pass the shared WebDriver instance to the page objects
        _loginPage = new LoginPage(_driver);
       //_dashboardPage = new DashboardPage(_driver);
    }

    [Given(@"I navigate to the login page")]
    public void GivenINavigateToTheLoginPage()
    {
        _loginPage.NavigateTo("https://app360qas.crm.dynamics.com/main.aspx?appid=7a259cb5-63b0-ec11-9841-000d3a3367aa&pagetype=custom&name=abi_homepage_c0e42");
    }

    [When(@"I login the App")]
    public void WhenIClickTheLoginButton()
    {
        _loginPage.EnterCredentials("********", "*********");
    }

  


    /* [When(@"I enter my credentials")]
     public void WhenIEnterMyCredentials()
     {
         //_loginPage.EnterCredentials("sanches.ka@hotmail.com", "ksc12345**@");
     }

     */

    [Then(@"I should see the dashboard")]
    public void ThenIShouldSeeTheDashboard()
    {
       // Assert.IsTrue(_dashboardPage.IsDashboardVisible());
    }

    // AfterScenario hook to close WebDriver after the scenario is finished
   /* [AfterScenario]
    public void AfterScenario()
    {
        WebDriverFactory.CloseDriver();
    }
   */
}