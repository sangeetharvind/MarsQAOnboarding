using MarsOnboarding.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnboarding.Pages
{
    public class Skill_Page : CommonDriver
    {
        public IWebElement SkillsTab => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        public IWebElement AddNew => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        public IWebElement AddSkillTextbox => driver.FindElement(By.Name("name"));
        public IWebElement ChooseSkillLevel => driver.FindElement(By.Name("level"));
        public IWebElement AddButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        public IWebElement NewSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        public IWebElement NewSkilllevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        public IWebElement UpdateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        public IWebElement UpdateSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[1]"));
        public IWebElement UpdateSkillLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[2]/tr/td[2]"));
        public IWebElement PencilIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        public IWebElement DeleteSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
        public void Addskill(string skill, string skillLevel)
        {
            //Click on Skill Tab
            SkillsTab.Click();
            Thread.Sleep(1000);

            //Click on AddNew button
            AddNew.Click();
            Thread.Sleep(1000);

            //Enter the skills that has to be added
            AddSkillTextbox.SendKeys(skill);
            Thread.Sleep(1000);

            //Choose the skill level
            ChooseSkillLevel.Click();
            Thread.Sleep(1000);

            //Click on Add button
            AddButton.Click();
            Thread.Sleep(1000);

            IWebElement messageBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]"));

            //get the text of the message element
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            //Verify the expected message text
            string expectedmessage1 = skill + "has been added to your record";
            string expectedmessage2 = "This skill is already existed";
            string expectedmessage3 = "Duplicated data";
            string expectedmessage4 = "Please enter skill and skill level";

            Assert.That(actualMessage, Is.EqualTo(expectedmessage1).Or.EqualTo(expectedmessage2).Or.EqualTo(expectedmessage3).Or.EqualTo(expectedmessage4), "msg");
        }
        public string getSkill()
        {
            return NewSkill.Text;
        }
        public string getSkillLevel()
        {
            return NewSkilllevel.Text;
        }
        public void UpdateSkills(string skill, string skillLevel)
        {

            //click onto New Update Language
            NewSkill.Click();
            Thread.Sleep(1000);
            //update the skills that has to be added
            AddSkillTextbox.SendKeys(skill);
            Thread.Sleep(1000);

            //update the language level
            UpdateSkillLevel.Click();
            Thread.Sleep(1000);

            //Click on Update button
            UpdateButton.Click();
            Thread.Sleep(1000);

            IWebElement messageBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]"));

            //get the text of the message element
            string actualMessage = messageBox.Text;
            Console.WriteLine(actualMessage);

            //Verify the expected message text
            string expectedmessage1 = skill + "has been updated to your record";
            string expectedmessage2 = "This language is already existed";

            Assert.That(actualMessage, Is.EqualTo(expectedmessage1).Or.EqualTo(expectedmessage2), "msgg");
        }
        public string getUpdateSkill()
        {
            return UpdateSkill.Text;
        }
        public string getUpdateSkillLevel()
        {
            return UpdateSkillLevel.Text;
        }
    }
    //public void DeleteSkill(string skill, string skilllevel)
    //{

    //}
}
    

