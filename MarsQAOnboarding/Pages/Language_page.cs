using MarsOnboarding.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnboarding.Pages
{
    public class Language_Page : CommonDriver
    {
        private IWebElement AddNew => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement AddLanguageTextbox => driver.FindElement(By.Name("name"));
        private IWebElement ChooseLanguageLevel => driver.FindElement(By.XPath("//select[@name='level']"));
        private IWebElement AddButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement UpdateLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td[1]"));
        private IWebElement UpdateLanguagelevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[4]/tr/td[2]"));
        private IWebElement UpdateButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        private IWebElement PencilIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        private IWebElement DeleteLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));

        public void AddLanguage(string language, string level)
        {
            //Click on Language Tab
            AddNew.Click();
            Thread.Sleep(1000);
            //Enter the Language that has to be added
            AddLanguageTextbox.SendKeys(language);
            Thread.Sleep(1000);

            //Choose the Language level

            ChooseLanguageLevel.SendKeys(level);
            ChooseLanguageLevel.Click();
            Thread.Sleep(1000);

            //Click on Add button
            AddButton.Click();
            Thread.Sleep(1000);

            //IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));

        }
        public string Notification()
        {
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            return messageBox.Text;
        }
        //public string getLanguage()
        //{
        //    return AddLanguageTextbox.Text;
        //}
        //public string getLanguageLevel()
        //{
        //    return ChooseLanguageLevel.Text;
        //}
        public void UpdateLanguages(string language, string level)
        {
            Thread.Sleep(1000);
            PencilIcon.Click();
            Thread.Sleep(1000);

            //click onto New Update Language
            UpdateLanguage.Click();
            Thread.Sleep(1000);
            UpdateLanguage.Clear();
            //update the language that has to be added
            UpdateLanguage.SendKeys(language);
            Thread.Sleep(1000);

            //update the language level
            UpdateLanguagelevel.Click();
            Thread.Sleep(1000);
            UpdateLanguagelevel.Clear();
            UpdateLanguagelevel.SendKeys(level);
            Thread.Sleep(1000);

            //Click on Update button
            UpdateButton.Click();
            Thread.Sleep(1000);

            //IWebElement messageBox = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]"));

            ////get the text of the message element
            //string actualMessage = messageBox.Text;
            //Console.WriteLine(actualMessage);

            ////Verify the expected message text
            //string expectedmessage1 = language + "has been updated to your record";
            //string expectedmessage2 = "This language is already existed";

            //Assert.That(actualMessage, Is.EqualTo(expectedmessage1).Or.EqualTo(expectedmessage2), "msgg");
        }
        public string getUpdateLanguage()
        {
            return UpdateLanguage.Text;
        }
        public string getUpdateLanguageLevel()
        {
            return UpdateLanguagelevel.Text;
        }
        public void DeleteLanguages()
        {
            DeleteLanguage.Click();
            Thread.Sleep(2000);
        }
    }
}

