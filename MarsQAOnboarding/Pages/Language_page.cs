using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class Language_Page
    {
        public void CreateLanguagePage(IWebDriver driver)
        {
            try
            {
                // Navigate to Profile module 
                IWebElement profileModule = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
                profileModule.Click();
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Assert.Fail("Profile module button has not found");
            }


            // Select Language sub-module
            IWebElement languageSubmodule = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            languageSubmodule.Click();
            Thread.Sleep(1000);

            // Select Add button
            IWebElement addnewButton = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addnewButton.Click();

            // Add language
            IWebElement addLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
            addLanguage.SendKeys("Kannada");

            // Choose Language level
            IWebElement languageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
            languageLevel.Click();

            // Create a SelectElement object to interact with the dropdown
            SelectElement selectElement = new SelectElement(languageLevel);

            // Get all options from the dropdown
            IList<IWebElement> options = selectElement.Options;

            // Create a Random object
            Random random = new Random();

            // Generate a random index
            int randomIndex = random.Next(options.Count);

            // Select the option by the randomly generated index
            selectElement.SelectByIndex(randomIndex);

            // Optional: Print out the selected option for verification
            Console.WriteLine("Selected option: " + options[randomIndex].Text);

            IWebElement newLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));

            Assert.That(newLanguage.Text == "Kannada", "Language not created");

            //if(newLanguage.Text == "Kannada")
            //{
            //    Assert.Pass("Language is created successfully");
            //}
            //else
            //{
            //    Assert.Fail("Unable to create Language");
            //}
        }


        public void EditLanguagePage(IWebDriver driver)
        {
            
        }

        public void DeleteLanguagePage(IWebDriver driver)
        {

        }
    }
}
