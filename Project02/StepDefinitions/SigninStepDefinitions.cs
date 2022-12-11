using Project02.Pages;
using System;
using TechTalk.SpecFlow;

namespace Project02.StepDefinitions
{
    [Binding]
    public class SigninStepDefinitions
    {
        Signinpage signinpage;

        public  SigninStepDefinitions()
        {
            signinpage = new Signinpage();
        }
        [Given(@"I login with my Username and Password")]
        public void GivenILoginWithMyUsernameAndPassword()
        {
            signinpage.EnterUsername();
            signinpage.EnterPassword();

        }

        [When(@"I click on the Login button")]
        public void WhenIClickOnTheLoginButton()
        {
            signinpage.ClickLoginButton();
        }

        [Then(@"Then i should login to the app")]
        public void ThenThenIShouldLoginToTheApp()
        {
         
        }
    }
}
