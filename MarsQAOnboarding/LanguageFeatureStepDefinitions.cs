using System;
using TechTalk.SpecFlow;
using MarsOnboarding.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
            languagepage.AddLanguage(language, level);

        }

        [Then(@"New record with '([^']*)' and '([^']*)' are added successfully")]
        public void ThenNewRecordWithAndAreAddedSuccessfully(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            string actualText = languagepage.Notification();
            string expectedText = language + " has been added to your languages";
            Assert.That(actualText, Is.EqualTo(expectedText));
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
            //Assert.That(languagepage.Notification(),language + "has been updated to your languages", "Not updated!");
            string actualText = languagepage.Notification();
            string expectedText = language + " has been updated to your languages";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Delete the '([^']*)' record")]
        public void WhenDeleteTheRecord(string language)
        { 
            Language_Page languagepage = new Language_Page();
            languagepage.DeleteLanguage(language);
        }


        [Then(@"The record '([^']*)' should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully(string language)
        {
            Language_Page languagepage = new Language_Page();

            string actualText = languagepage.Notification();
            string expectedText = language + " has been deleted from your languages";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        [When(@"Adding valid '([^']*)' and invalid '([^']*)' to the language list")]
        public void WhenAddingValidAndInvalidToTheLanguageList(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            languagepage.AddLanguage(language, level);
        }

        [Then(@"User should get an error")]
        public void ThenUserShouldGetAnError()
        {
            Language_Page languagepage = new Language_Page();
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        [When(@"Adding invalid '([^']*)' and valid '([^']*)' to the language list")]
        public void WhenAddingInvalidAndValidToTheLanguageList(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            languagepage.AddLanguage(language, level);
        }

        [Then(@"User should have an error")]
        public void ThenUserShouldHaveAnError()
        {
            Language_Page languagepage = new Language_Page();
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }


        [When(@"Adding invalid '([^']*)' and invalid '([^']*)' to the language list")]
        public void WhenAddingInvalidAndInvalidToTheLanguageList(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            languagepage.AddLanguage(language, level);
        }

        [Then(@"User should get an error popup")]
        public void ThenUserShouldGetAnErrorPopup()
        {
            Language_Page languagepage = new Language_Page();
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Update valid '([^']*)' and invalid '([^']*)' on an existing language record")]
        public void WhenUpdateValidAndInvalidOnAnExistingLanguageRecord(string language, string level)
         {
            Language_Page languagepage = new Language_Page();
            languagepage.UpdateLanguages(language, level);
        }

        [Then(@"User should get an error system cannot accept record with valid language and invalid language level")]
        public void ThenUserShouldGetAnErrorSystemCannotAcceptRecordWithValidLanguageAndInvalidLanguageLevel()
        {
            Language_Page languagepage = new Language_Page();
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Updating invalid '([^']*)' and valid '([^']*)' to the languages list")]
        public void WhenUpdaingInvalidAndValidToTheLanguagesList(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            languagepage.AddLanguage(language, level);
        }


        [Then(@"User should have a error system cannot accept record with invalid language and valid language level")]
        public void ThenUserShouldHaveAErrorSystemCannotAcceptRecordWithInvalidLanguageAndValidLanguageLevel()

        {
            Language_Page languagepage = new Language_Page();
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }


        [When(@"Updating invalids '([^']*)' and invalid '([^']*)' to the languages list")]
        public void WhenUpdatingInvalidsAndInvalidToTheLanguagesList(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            languagepage.UpdateLanguages(language, level);
        }

        [Then(@"User should get a error popups system cannot accept record with invalid language and invalid language level")]
        public void ThenUserShouldGetAErrorPopupsSystemCannotAcceptRecordWithInvalidLanguageAndInvalidLanguageLevel()

        {
            Language_Page languagepage = new Language_Page();
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        [When(@"After adding four new '([^']*)' and '([^']*)' to the language list")]
        public void WhenAfterAddingFourNewAndToTheLanguageList(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            
        }
        [Then(@"User should not be able to add new record")]
        public void ThenUserShouldNotBeAbleToAddNewRecord()
        {
            Language_Page languagepage = new Language_Page();
            

        }
        [When(@"Adding duplicate valid '([^']*)' and valid '([^']*)' to the language list")]
        public void WhenAddingDuplicateValidAndValidToTheLanguageList(string language, string level)
        {
            Language_Page languagepage = new Language_Page();
            languagepage.AddLanguage(language, level);
        }

        [Then(@"User should get an duplicate error")]
        public void ThenUserShouldGetAnDuplicateError()
        {
            Language_Page languagepage = new Language_Page();
            string actualText = languagepage.Notification();
            string expectedText = "Duplicated data";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

    }

}
