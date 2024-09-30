using System;
using MeuProjeto.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MeuProjeto.StepDefinitions
{
    [Binding]
    public class LoginPageStepDefinitions : BaseLogin
    {

        BaseLogin baseLogin = new BaseLogin();

        [Given(@"Eu estou Logado na Página do Linkedin")]
        public void GivenEuAcesseiAPaginaDeLogin()
        {

            baseLogin.NavigateTo();

        }

        [When(@"Cliquei em Faca Login")]
        public void WhenCliqueiEmFacaLogin()
        {
            baseLogin.ClicarLogin();
        }

        [When(@"Inserir o usuário")]
        public void WhenInserirOUsuario()
        {
            baseLogin.EnterUser("******@gmail.com");

        }

        /* [When(@"Cliquei em Continuar")]
         public void WhenCliqueiEmNext()
         {
             baseLogin.ClickNext();
         }

         */
        [When("Preenchi a Senha")]
        public void WhenPreenchiASenha()
        {
            baseLogin.Password("*******");

        }

        [Then(@"Cliquei em Button Next")]
        public void WhenCliqueiEmButtonNext()
        {
            baseLogin.ClickButton();
        }

        /*
                [When(@"Cliquei em OK")]
                public void WhenCliqueiEmOK()
                {
                    baseLogin.ClickOk();
                }


                [Then(@"então serei logado")]
                public void ThenEntaoSereiLogado()
                {
                    throw new PendingStepException();
                }*/

    }


}
