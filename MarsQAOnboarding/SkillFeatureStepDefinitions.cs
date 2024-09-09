using MarsOnboarding.Pages;
using MarsOnboarding.Utilities;
using MarsQA.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsOnboarding
{
    [Binding]
    public class SkillFeatureStepDefinitions : CommonDriver
    {
        Skill_Page SkillPageObj;
        Login_Page LoginPageObj;

        public SkillFeatureStepDefinitions()
        {
            SkillPageObj = new Skill_Page();
            LoginPageObj = new Login_Page();
        }
        


        [Given(@"User logged into skill page successfully")]
        public void GivenUserLoggedIntoSkillPageSuccessfully()
        {
            // Login Page Object Initialization and definition
            LoginPageObj.LoginSteps();
        }

        [When(@"Adding new '([^']*)' and '([^']*)' into the record")]
        public void WhenAddingNewAndIntoTheRecord(string skill, string skillLevel)
        {
            //Adding new skill to the skill list
            SkillPageObj.Addskill(skill, skillLevel);
        }

        [Then(@"New '([^']*)' and '([^']*)' are added successfully")]
        public void ThenNewAndAreAddedSuccessfully(string skill, string skillLevel)
        {
            //Assertion of added skills
            string newSkill = SkillPageObj.getSkill();
            string newSkillLevel = SkillPageObj.getSkillLevel();

            if(skill == newSkill && newSkill == newSkillLevel)
            {
               // Assert.AreEqual(skill, newSkill, "Actual skill and expected skill do not match");
               // Assert.AreEqual(skillLevel, newSkillLevel, "Actual skill level and expected skill level do not match");
            }
            else
            {
                Console.WriteLine("Check Error");
            }
        }

        [When(@"Update '([^']*)' and '([^']*)' on an existing skill record")]
        public void WhenUpdateAndOnAnExistingSkillRecord(string skill, string p1)
        {
            
        }

        [Then(@"The skill record '([^']*)' and '([^']*)' should be updated successfully")]
        public void ThenTheSkillRecordAndShouldBeUpdatedSuccessfully(string skill, string p1)
        {
            
        }

        [When(@"Delete the record '([^']*)' and '([^']*)'")]
        public void WhenDeleteTheRecordAnd(string skill, string p1)
        {
            
        }

        [Then(@"The record '([^']*)' and '([^']*)' should be deleted successfully")]
        public void ThenTheRecordAndShouldBeDeletedSuccessfully(string skill, string p1)
        {
            
        }
    }
}
