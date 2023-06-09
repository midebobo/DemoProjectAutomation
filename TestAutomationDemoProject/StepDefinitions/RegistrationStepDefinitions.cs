using System;
using TechTalk.SpecFlow;
using TestAutomationDemoProject.PageObject;

namespace TestAutomationDemoProject.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {
        RegistrationPage registrationPage;
        
        public  RegistrationStepDefinitions() 
        { 
        registrationPage = new RegistrationPage();
        
        }
        
        
        
        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"I enter my First name")]
        public void GivenIEnterMyFirstName()
        {
            registrationPage.EnterFirstName();
        }

        [Given(@"I enter Lat name")]
        public void GivenIEnterLatName()
        {
           registrationPage.EnterLastName();
        }

        [Given(@"I enter my Address")]
        public void GivenIEnterMyAddress()
        {
            registrationPage.EnterAddress();
        }

        [Given(@"I enter my Email")]
        public void GivenIEnterMyEmail()
        {
            registrationPage.EnterEmail();
        }

        [Given(@"I enter my Phone Number")]
        public void GivenIEnterMyPhoneNumber()
        {
            registrationPage.EnterPhoneNumber();
        }

        [Given(@"I enter my Password")]
        public void GivenIEnterMyPassword()
        {
            registrationPage.EnterPassword();
        }

        [Given(@"I enter my Confirm Password")]
        public void GivenIEnterMyConfirmPassword()
        {
            registrationPage.EnterConfirmPassword();
        }

        [When(@"I click on Submit")]
        public void WhenIClickOnSubmit()
        {
            registrationPage.ClickOnSubmit();
        }

        [Then(@"I should be able to Register Successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
