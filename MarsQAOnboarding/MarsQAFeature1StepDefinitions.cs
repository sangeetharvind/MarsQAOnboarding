using MarsQA.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace MarsOnboarding
{
    [Binding]
    public class MarsQAFeature1StepDefinitions
    {
        [Given(@"I logged into MarsQA successfuly")]
        public void GivenILoggedIntoMarsQASuccessfuly(IWebDriver driver)
        {
            Join_Page joinPageobj = new Join_Page();
            joinPageobj.JoinActions(driver);
        }

        [When(@"I navigate to Profile pages")]
        public void WhenINavigateToProfilePages(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
        }

        [When(@"I logged into SignIn page successfully")]
        public void WhenILoggedIntoSignInPageSuccessfully(IWebDriver driver)
        {
            SignIn_Page signinPageObj = new SignIn_Page();
            signinPageObj.SignInActions(driver);

        }
    }
}
