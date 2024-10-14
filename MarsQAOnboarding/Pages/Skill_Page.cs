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
        private IWebElement SkillsTab => driver.FindElement(By.XPath("//a[@data-tab='second']"));
        private IWebElement AddNew => driver.FindElement(By.XPath("//div[@class='ui teal button']"));
        private IWebElement AddSkillTextbox => driver.FindElement(By.Name("name"));
        private IWebElement ChooseSkillLevel => driver.FindElement(By.Name("level"));
        private IWebElement AddButton => driver.FindElement(By.XPath("//input[@class='ui teal button ']"));
        //private IWebElement NewSkill => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
        //private IWebElement NewSkilllevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private IWebElement UpdateButton => driver.FindElement(By.XPath("//input[@class='ui teal button']"));
        private IWebElement UpdateSkill => driver.FindElement(By.XPath("//input[@name='name']"));
        private IWebElement UpdateSkillLevel => driver.FindElement(By.XPath("//select[@name='level']"));
        private IWebElement PencilIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        //private IWebElement DeleteSkills => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));
        public void Addskill(string skill, string level)
        {
            //Click on Skill Tab
            Wait.WaitToBeClickable(driver, "XPath", "//a[@data-tab='second']", 10);
            SkillsTab.Click();


            //Click on AddNew button
            AddNew.Click();

            //Enter the skills that has to be added
            AddSkillTextbox.SendKeys(skill);
            

            //Choose the skill level
            ChooseSkillLevel.SendKeys(level);
            ChooseSkillLevel.Click();
            

            //Click on Add button
            AddButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 10);
        }
        public string Notification()
        {
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            return messageBox.Text;
            
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
        }
        public void UpdateSkills(string skill, string level)
        {
            //navigate to skill tab
            
            SkillsTab.Click();
            //click onto Update Language
            Wait.WaitToBeVisible(driver, "XPath", "//a[@data-tab='second']", 20);
            PencilIcon.Click();
            

            //update the skills that has to be added
            AddSkillTextbox.Clear();
            AddSkillTextbox.SendKeys(skill);
            Thread.Sleep(1000);

            //update the language level
            UpdateSkillLevel.Click();
            Thread.Sleep(1000);
            UpdateSkillLevel.SendKeys(level);
            //Click on Update button
            UpdateButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
        }
        public void DeleteSkill(string Skillname)
        {
            SkillsTab.Click();
            By deleteSkill = By.XPath("//td[text()='" + Skillname + "']/following-sibling::td/span[@class='button'][2]");
            //Wait.WaitToBeClickable(driver, "XPath", "td[text()='skill']/following-sibling::td/span[@class='button'][2]", 10);
            Thread.Sleep(5000);
            driver.FindElement(deleteSkill).Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
        }
    }
} 


