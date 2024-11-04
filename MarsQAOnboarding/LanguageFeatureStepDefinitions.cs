using TechTalk.SpecFlow;
using MarsOnboarding.Pages;
using NUnit.Framework;
using MarsOnboarding.Utilities;

namespace MarsOnboarding
{
    [Binding]
    public class LanguageFeatureStepDefinitions : CommonDriver
    {
        Login_Page loginpage;
        Language_Page languagepage;

        public LanguageFeatureStepDefinitions()
        {
            loginpage = new Login_Page();
            languagepage = new Language_Page();

        }

        [Given(@"User is logged into localhost successfully")]
        public void GivenUserIsLoggedIntoLocalhostSuccessfully()
        {
            
            loginpage.LoginSteps();
            
        }
   
        [When(@"Adding new '([^']*)' and '([^']*)' to the language list")]
        public void WhenAddingNewAndToTheLanguageList(string language, string level)
        {
            languagepage.ClearData();
            languagepage.AddLanguage(language, level);
            

        }

        [Then(@"New record with '([^']*)' and '([^']*)' are added successfully")]
        public void ThenNewRecordWithAndAreAddedSuccessfully(string language, string level)
        {
            
            string actualText = languagepage.Notification();
            string expectedText = language + " has been added to your languages";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        
        [When(@"Delete the '([^']*)' and '([^']*)' record")]
        public void WhenDeleteTheAndRecord(string language, string level)
        {
            languagepage.ClearData();
            languagepage.AddLanguage(language, level);
            
            languagepage.DeleteLanguage(language);
            Thread.Sleep(4000);
        }


        [Then(@"The record '([^']*)' should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully(string language)
        {
            

            string actualText = languagepage.Notification();
            string expectedText = language + " has been deleted from your languages";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        [When(@"Adding valid '([^']*)' and invalid '([^']*)' to the language list")]
        public void WhenAddingValidAndInvalidToTheLanguageList(string language, string level)
        {
            languagepage.ClearData();
            languagepage.AddLanguage(language, level);
        }

        [Then(@"User should get an error")]
        public void ThenUserShouldGetAnError()
        {
            
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        [When(@"Adding invalid '([^']*)' and valid '([^']*)' to the language list")]
        public void WhenAddingInvalidAndValidToTheLanguageList(string language, string level)
        {
            languagepage.ClearData();
            languagepage.AddLanguage(language, level);
        }

        [Then(@"User should have an error")]
        public void ThenUserShouldHaveAnError()
        {
            
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }


        [When(@"Adding invalid '([^']*)' and invalid '([^']*)' to the language list")]
        public void WhenAddingInvalidAndInvalidToTheLanguageList(string language, string level)
        {
            languagepage.ClearData();
            languagepage.AddLanguage(language, level);
        }

        [Then(@"User should get an error popup")]
        public void ThenUserShouldGetAnErrorPopup()
        {
            
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Updating invalids '([^']*)' and invalid '([^']*)' to the languages list")]
        public void WhenUpdatingInvalidsAndInvalidToTheLanguagesList(string language, string level)
        {
            
            languagepage.UpdateLanguages(language, level);
        }

        [Then(@"User should get a error popups system cannot accept record with invalid language and invalid language level")]
        public void ThenUserShouldGetAErrorPopupsSystemCannotAcceptRecordWithInvalidLanguageAndInvalidLanguageLevel()

        {
            
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Update '([^']*)' and '([^']*)' on an '([^']*)' and '([^']*)' existing language record")]
        public void WhenUpdateAndOnAnAndExistingLanguageRecord(string language, string level, string existinglanguage, string existinglanguagelevel)
        {
            languagepage.ClearData();
            languagepage.AddLanguage(language, level);
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
            Thread.Sleep(4000);
            languagepage.UpdateLanguages(existinglanguage, existinglanguagelevel);
            Thread.Sleep(2000);
        }

        [Then(@"the record with '([^']*)' and '([^']*)' should update '([^']*)' and '([^']*)'successfully")]
        public void ThenTheRecordWithAndShouldUpdateAndSuccessfully(string language, string level, string existinglanguage, string existinglanguagelevel)
        {
            string actualText = languagepage.Notification();
            string expectedText = existinglanguage + " has been updated to your languages";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Update valid '([^']*)' and invalid '([^']*)' on an '([^']*)' and '([^']*)' existing language record")]
        public void WhenUpdateValidAndInvalidOnAnAndExistingLanguageRecord(string language, string level, string existinglanguage, string existinglanguagelevel) 
        {
            languagepage.ClearData();
            languagepage.AddLanguage(language,level);
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
            Thread.Sleep(4000);
            languagepage.UpdateLanguages(existinglanguage, existinglanguagelevel);
            Thread.Sleep(2000);
        }

        [Then(@"User should get an error system cannot accept record with valid language and invalid  '([^']*)' and '([^']*)'language level")]
        public void ThenUserShouldGetAnErrorSystemCannotAcceptRecordWithValidLanguageAndInvalidAndLanguageLevel(string tamil, string p1)
        {
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Updating invalid '([^']*)' and valid '([^']*)' to the '([^']*)' and '([^']*)'languages list")]
        public void WhenUpdatingInvalidAndValidToTheAndLanguagesList(string language, string level, string existinglanguage, string existinglanguagelevel)
        {
            languagepage.ClearData();
            languagepage.AddLanguage(language, level);
            languagepage.AddLanguage(existinglanguage, existinglanguagelevel);
        }

        [Then(@"User should have a error system cannot accept record with invalid language and valid language '([^']*)' and '([^']*)'level")]
        public void ThenUserShouldHaveAErrorSystemCannotAcceptRecordWithInvalidLanguageAndValidLanguageAndLevel(string p0, string fluent)
        {
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Updating invalids '([^']*)' and invalid '([^']*)' to the '([^']*)' and '([^']*)' languages list")]
        public void WhenUpdatingInvalidsAndInvalidToTheAndLanguagesList(string language, string level, string existinglanguage, string existinglanguagelevel)
        {
            languagepage.ClearData();
            languagepage.AddLanguage(language, level);
            Thread.Sleep(2000);
            languagepage.UpdateLanguages(existinglanguage, existinglanguagelevel);
        }

        [Then(@"User should get a error popups system cannot accept record with invalid language and invalid language '([^']*)' and '([^']*)' level")]
        public void ThenUserShouldGetAErrorPopupsSystemCannotAcceptRecordWithInvalidLanguageAndInvalidLanguageAndLevel(string p0, string p1)
        {
            string actualText = languagepage.Notification();
            string expectedText = "Please enter language and level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Adding duplicated valid '([^']*)' and valid '([^']*)' to '([^']*)' with '([^']*)' language list")]
        public void WhenAddingDuplicatedValidAndValidToWithLanguageList(string language, string level, string existinglanguage, string existinglanguagelevel)
        {

            languagepage.AddLanguage(language, level);
            languagepage.UpdateLanguages(existinglanguage, existinglanguagelevel);
            Thread.Sleep(2000);

        }

        [Then(@"User should get an duplicated errors")]
        public void ThenUserShouldGetAnDuplicatedErrors()
        {
            string actualText = languagepage.Notification();
            string expectedText = "This language is already added to your language list.";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }


    }

}
