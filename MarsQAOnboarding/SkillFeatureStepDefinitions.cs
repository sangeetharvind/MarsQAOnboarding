using MarsOnboarding.Pages;
using MarsOnboarding.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsOnboarding.Pages
{
    [Binding]
        public class SkillFeatureStepDefinitions : CommonDriver
    {
            Login_Page loginpage;
            Skill_Page skillpage;

            public SkillFeatureStepDefinitions()
            {
                loginpage = new Login_Page();
                skillpage = new Skill_Page();
            }

        [Given(@"User logged into skills page successfully")]
        public void GivenUserLoggedIntoSkillsPageSuccessfully()
        {
            
            loginpage.LoginSteps();
        }

        [When(@"Adding new '([^']*)' and '([^']*)' into the record")]
        public void WhenAddingNewAndIntoTheRecord(string skill, string level)
        {
            skillpage.ClearData();
            skillpage.Addskill(skill, level);
        }

        [Then(@"New '([^']*)' and '([^']*)' are added successfully")]
        public void ThenNewAndAreAddedSuccessfully(string skill, string level)
        {
            
            string actualText = skillpage.Notification();
            string expectedText = skill + " has been added to your skills";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Delete the record '([^']*)' record")]
        public void WhenDeleteTheRecordRecord(string skill)
        {
            
            skillpage.DeleteSkill(skill);
        }

        [Then(@"The record '([^']*)' should be delete successfully")]
        public void ThenTheRecordShouldBeDeleteSuccessfully(string skill)
        {
            
            string actualText = skillpage.Notification();
            string expectedText = skill + " has been deleted";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        [When(@"Adding valid '([^']*)' and invalid '([^']*)' into the record")]
        public void WhenAddingValidAndInvalidIntoTheRecord(string skill, string level)
        {
            
            skillpage.Addskill(skill, level);
        }

        [Then(@"User should get an error in popup")]
        public void ThenUserShouldGetAnErrorInPopup()
        {
            
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Adding invalid '([^']*)' and valid '([^']*)' into the record")]
        public void WhenAddingInvalidAndValidIntoTheRecord(string skill, string level)
        {
            
            skillpage.Addskill(skill, level);
        }

        [Then(@"User should get an error in popup accordingly")]
        public void ThenUserShouldGetAnErrorInPopupAccordingly()
        {
            
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Adding invalid '([^']*)' and invalid '([^']*)' into the record")]
        public void WhenAddingInvalidAndInvalidIntoTheRecord(string skill, string level)
        {
            
            skillpage.Addskill(skill, level);
        }

        [When(@"Update valid '([^']*)' and invalid '([^']*)' on an existing skill record")]
        public void WhenUpdateValidAndInvalidOnAnExistingSkillRecord(string skill, string level)
        {
            
            skillpage.UpdateSkills(skill, level);
        }

        [Then(@"Error message should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed()
        {
            
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Adding duplicated valid '([^']*)' and valid '([^']*)' to the language list")]
        public void WhenAddingDuplicatedValidAndValidToTheLanguageList(string skill, string level)
        {
            
            skillpage.Addskill(skill, level);
        }

        [Then(@"User should get an duplicated error")]
        public void ThenUserShouldGetAnDuplicatedError()
        {
            
            string actualText = skillpage.Notification();
            string expectedText = "This skill is already added to your skill list.";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        [When(@"Updating invalid '([^']*)' and valid '([^']*)' on an existing skill record")]
        public void WhenUpdatingInvalidAndValidOnAnExistingSkillRecord(string skill, string level)
        {
            
            skillpage.Addskill(skill, level);
        }

        [Then(@"Error message should be display in popup")]
        public void ThenErrorMessageShouldBeDisplayInPopup()
        {
            
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Update '([^']*)' and '([^']*)' on an '([^']*)' with '([^']*)' record")]
        public void WhenUpdateAndOnAnWithRecord(string skill, string level, string updatedskill, string updatedskilllevel)
        {
            skillpage.ClearData();
            // create a skill record
            skillpage.Addskill(skill, level);
            skillpage.UpdateSkills(updatedskill, updatedskilllevel);
            Thread.Sleep(2000);
        }

        [Then(@"The skill record '([^']*)' and '([^']*)' on an '([^']*)' with '([^']*)' recordshould be updated successfully")]
        public void ThenTheSkillRecordAndOnAnWithRecordshouldBeUpdatedSuccessfully(string skill, string level, string updatedskill, string updatedskilllevel)
        {
            string actualText = skillpage.Notification();
            string expectedText = updatedskill + " has been updated to your skills";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Update valid '([^']*)' and invalid '([^']*)' on an '([^']*)' with '([^']*)' existing skill record")]
        public void WhenUpdateValidAndInvalidOnAnWithExistingSkillRecord(string skill, string level, string updatedskill, string updatedskilllevel)
        {
            skillpage.ClearData();
            Thread.Sleep(2000);
            skillpage.Addskill(skill, level);
            skillpage.UpdateSkills(updatedskill, updatedskilllevel);
            Thread.Sleep(2000);
        }

        [Then(@"Error message should be displayed accordingly")]
        public void ThenErrorMessageShouldBeDisplayedAccordingly()
        {
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        
        [When(@"Updating invalid '([^']*)' and valid '([^']*)' on an existing '([^']*)' with '([^']*)' skill record")]
        public void WhenUpdatingInvalidAndValidOnAnExistingWithSkillRecord(string skill, string level, string updatedskill, string updatedskilllevel)
        {
           
            skillpage.Addskill(skill, level);
            skillpage.Addskill(updatedskill, updatedskilllevel);
        }

        [Then(@"Error message should be display in popup '([^']*)' with '([^']*)'")]
        public void ThenErrorMessageShouldBeDisplayInPopupWith(string skill, string level, string updatedskill, string updatedskilllevel)
        {
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Update invalid '([^']*)' and invalid '([^']*)' on an existing '([^']*)' with '([^']*)'skill record")]
        public void WhenUpdateInvalidAndInvalidOnAnExistingWithSkillRecord(string skill, string level, string updatedskill, string updatedskilllevel)
        {
            skillpage.Addskill(skill, level);
            skillpage.UpdateSkills(updatedskill, updatedskilllevel);
            Thread.Sleep(4000);
        }


        [Then(@"Error message has to be displayed")]
        public void ThenErrorMessageHasToBeDisplayed()
        {
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }


        [When(@"Delete the record '([^']*)' on '([^']*)' record")]
        public void WhenDeleteTheRecordOnRecord(string skill, string level )
        {
            skillpage.Addskill(skill, level);
            skillpage.DeleteSkill(skill);
            Thread.Sleep(2000);
        }

        [Then(@"The record '([^']*)'  should be deleted successfully")]
        public void ThenTheRecordShouldBeDeletedSuccessfully(string skill)
        {
            string actualText = skillpage.Notification();
            string expectedText = skill + " has been deleted";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        [When(@"Adding duplicated valid '([^']*)' and valid '([^']*)' to the '([^']*)' with '([^']*)' language list")]
        public void WhenAddingDuplicatedValidAndValidToTheWithLanguageList(string skill, string level, string duplicateskill, string duplicteskilllevel)
        {
            skillpage.Addskill(skill, level);
            skillpage.UpdateSkills(duplicateskill, duplicteskilllevel);
            Thread.Sleep(2000);
        }

        [Then(@"User should get an duplicated '([^']*)' error")]
        public void ThenUserShouldGetAnDuplicatedError(string skill, string level, string duplicateskill, string duplicteskilllevel)
        {
            string actualText = skillpage.Notification();
            string expectedText = " This skill is already added to your skill list.";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

    }
}
