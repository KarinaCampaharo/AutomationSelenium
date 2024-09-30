using MeuProjeto.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace MeuProjeto.StepDefinitions
{
    [Binding]
    public class FeatureEmQueOUsuarioFazUmaPesquisaNoLinkedinStepDefinitions

    {
        SearchPage searchPage  = new SearchPage();


        [When(@"Quando eu insiro o nome da pesquisa")]
        public void WhenQuandoEuInsiroONomeDaPesquisa()
        {
            searchPage.Pesquisa("MICHELE");
        }

        [Then(@"Exibe vários resultados")]
        public void ThenExibeVariosResultados()
        {
            searchPage.Response();
        }
    }
}
