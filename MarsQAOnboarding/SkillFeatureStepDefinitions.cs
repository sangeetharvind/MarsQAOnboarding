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
        [Given(@"User logged into skills page successfully")]
        public void GivenUserLoggedIntoSkillsPageSuccessfully()
        {
            Login_Page loginpage = new Login_Page();
            loginpage.LoginSteps();
        }

        [When(@"Adding new '([^']*)' and '([^']*)' into the record")]
        public void WhenAddingNewAndIntoTheRecord(string skill, string level)
        {
            Skill_Page skillpage = new Skill_Page();
            skillpage.Addskill(skill, level);
        }

        [Then(@"New '([^']*)' and '([^']*)' are added successfully")]
        public void ThenNewAndAreAddedSuccessfully(string skill, string level)
        {
            Skill_Page skillpage = new Skill_Page();
            string actualText = skillpage.Notification();
            string expectedText = skill + " has been added to your skills";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Update '([^']*)' and '([^']*)' on an existing skill record")]
        public void WhenUpdateAndOnAnExistingSkillRecord(string skill, string level)
        {
            Skill_Page skillpage = new Skill_Page();
            skillpage.UpdateSkills(skill, level);
        }

        [Then(@"The skill record '([^']*)' and '([^']*)' should be updated successfully")]
        public void ThenTheSkillRecordAndShouldBeUpdatedSuccessfully(string skill, string level)
        {
            Skill_Page skillpage = new Skill_Page();
            string actualText = skillpage.Notification();
            string expectedText = skill + " has been updated to your skills";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Delete the record '([^']*)' record")]
        public void WhenDeleteTheRecordRecord(string skill)
        {
            Skill_Page skillpage = new Skill_Page();
            skillpage.DeleteSkill(skill);
        }

        [Then(@"The record '([^']*)' should be delete successfully")]
        public void ThenTheRecordShouldBeDeleteSuccessfully(string skill)
        {
            Skill_Page skillpage = new Skill_Page();
            string actualText = skillpage.Notification();
            string expectedText = skill + " has been deleted";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        [When(@"Adding valid '([^']*)' and invalid '([^']*)' into the record")]
        public void WhenAddingValidAndInvalidIntoTheRecord(string skill, string level)
        {
            Skill_Page skillpage = new Skill_Page();
            skillpage.Addskill(skill, level);
        }

        [Then(@"User should get an error in popup")]
        public void ThenUserShouldGetAnErrorInPopup()
        {
            Skill_Page skillpage = new Skill_Page();
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Adding invalid '([^']*)' and valid '([^']*)' into the record")]
        public void WhenAddingInvalidAndValidIntoTheRecord(string skill, string level)
        {
            Skill_Page skillpage = new Skill_Page();
            skillpage.Addskill(skill, level);
        }

        [Then(@"User should get an error in popup accordingly")]
        public void ThenUserShouldGetAnErrorInPopupAccordingly()
        {
            Skill_Page skillpage = new Skill_Page();
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Adding invalid '([^']*)' and invalid '([^']*)' into the record")]
        public void WhenAddingInvalidAndInvalidIntoTheRecord(string skill, string level)
        {
            Skill_Page skillpage = new Skill_Page();
            skillpage.Addskill(skill, level);
        }

        [When(@"Update valid '([^']*)' and invalid '([^']*)' on an existing skill record")]
        public void WhenUpdateValidAndInvalidOnAnExistingSkillRecord(string skill, string level)
        {
            Skill_Page skillpage = new Skill_Page();
            skillpage.UpdateSkills(skill, level);
        }

        [Then(@"Error message should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed()
        {
            Skill_Page skillpage = new Skill_Page();
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }

        [When(@"Update invalid '([^']*)' and invalid '([^']*)' on an existing skill record")]
        public void WhenUpdateInvalidAndInvalidOnAnExistingSkillRecord(string skill, string level)
        {
            Skill_Page skillpage = new Skill_Page();
            skillpage.UpdateSkills(skill, level);
        }

        [Then(@"Error message has to be displayed")]
        public void ThenErrorMessageHasToBeDisplayed()
        {
            Skill_Page skillpage = new Skill_Page();
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        [When(@"Adding duplicated valid '([^']*)' and valid '([^']*)' to the language list")]
        public void WhenAddingDuplicatedValidAndValidToTheLanguageList(string skill, string level)
        {
            Skill_Page skillpage = new Skill_Page();
            skillpage.Addskill(skill, level);
        }

        [Then(@"User should get an duplicated error")]
        public void ThenUserShouldGetAnDuplicatedError()
        {
            Skill_Page skillpage = new Skill_Page();
            string actualText = skillpage.Notification();
            string expectedText = "This skill is already exist in your skill list.";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }
        [When(@"Updating invalid '([^']*)' and valid '([^']*)' on an existing skill record")]
        public void WhenUpdatingInvalidAndValidOnAnExistingSkillRecord(string skill, string level)
        {
            Skill_Page skillpage = new Skill_Page();
            skillpage.Addskill(skill, level);
        }

        [Then(@"Error message should be display in popup")]
        public void ThenErrorMessageShouldBeDisplayInPopup()
        {
            Skill_Page skillpage = new Skill_Page();
            string actualText = skillpage.Notification();
            string expectedText = "Please enter skill and experience level";
            Assert.That(actualText, Is.EqualTo(expectedText));
        }


    }
}
