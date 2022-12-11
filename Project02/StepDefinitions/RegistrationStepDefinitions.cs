using Project02.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        RegistrationClass registrationClass;
        public RegistrationStepDefinitions()
        {
            registrationClass = new RegistrationClass();
        }

        [Given(@"I navigate to the url ""([^""]*)""")]
        public void GivenINavigateToTheUrl(string url)
        {
            registrationClass.LaunchURl(url);
        }
     
        [Given(@"I click on the New User Register Here text")]
        public void GivenIClickOnTheNewUserRegisterHereText()
        {
            registrationClass.ClickNewUserRegisterHere();
        }

        [Given(@"I enter my registration form field")]
        public void GivenIEnterMyRegistrationFormField(Table table)
        {
            registrationClass.RegistrationDetails(table);
        }

        [Given(@"I enter the capthca")]
        public void GivenIEnterTheCapthca()
        {
            
        }


        [Given(@"I click check on the terms/conditions")]
        public void GivenIClickCheckOnTheTermsConditions()
        {
            registrationClass.ClickTerms();
        }

        [When(@"I click on the register button")]
        public void WhenIClickOnTheRegisterButton()
        {
            registrationClass.ClickRegister();
        }

        [Then(@"I should be logged in to the app")]
        public void ThenIShouldBeLoggedInToTheApp()
        {
            
        }
    }
}
