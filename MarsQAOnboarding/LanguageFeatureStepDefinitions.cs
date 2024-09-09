using System;
using TechTalk.SpecFlow;
using MarsOnboarding.Pages;

namespace MarsOnboarding
{
    [Binding]
    public class LanguageFeatureStepDefinitions 
    {
        [Given(@"User is logged into localhost successfully")]
        public void GivenUserIsLoggedIntoLocalhostSuccessfully()
        {
            Login_Page loginpage = new Login_Page();
            loginpage.LoginSteps();
        }

        [When(@"Adding new '([^']*)' and '([^']*)' to the language list")]
        public void WhenAddingNewAndToTheLanguageList(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            languagepage.AddLanguage(language,level);

        }

        [Then(@"New record with '([^']*)' and '([^']*)' are added successfully")]
        public void ThenNewRecordWithAndAreAddedSuccessfully(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            string actualText = languagepage.Notification();
            string expectedText = language + "has been added to your languages";    

        }

        [When(@"Update '([^']*)' and '([^']*)' on an existing language record")]
        public void WhenUpdateAndOnAnExistingLanguageRecord(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            languagepage.UpdateLanguages(language, level);
        }

        [Then(@"the record with '([^']*)' and '([^']*)' should update successfully")]
        public void ThenTheRecordWithAndShouldUpdateSuccessfully(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            string actualText = languagepage.Notification();
            string expectedText = language + "has been updated to your languages";
        }

        [When(@"Delete the record <Language> and <LanguageLevel>")]
        public void WhenDeleteTheRecordLanguageAndLanguageLevel()
        {
            Language_Page languagepage = new Language_Page();
            languagepage.DeleteLanguages();
        }

        [Then(@"The record <Language> and <LanguageLevel> should be deleted successfully")]
        public void ThenTheRecordLanguageAndLanguageLevelShouldBeDeletedSuccessfully()
        {
            
        }

    }
}
