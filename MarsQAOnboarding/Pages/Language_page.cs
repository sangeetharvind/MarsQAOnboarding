using MarsOnboarding.Utilities;
using OpenQA.Selenium;

namespace MarsOnboarding.Pages
{
    public class Language_Page : CommonDriver
    {
        private IWebElement AddNew => driver.FindElement(By.XPath("//div[@class='ui teal button ']"));
        private IWebElement AddLanguageTextbox => driver.FindElement(By.Name("name"));
        private IWebElement ChooseLanguageLevel => driver.FindElement(By.XPath("//select[@name='level']"));
        private IWebElement AddButton => driver.FindElement(By.XPath("//input[@value='Add']"));
        private IWebElement UpdateLanguage => driver.FindElement(By.XPath("//input[@name='name']"));
        private IWebElement UpdateLanguagelevel => driver.FindElement(By.Name("level"));
        private IWebElement UpdateButton => driver.FindElement(By.XPath("//input[@value='Update']"));
        private IWebElement PencilIcon => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i"));
        

        public void ClearData()
        {
            try
            {
                var deleteButton = driver.FindElements(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]/i"));

                foreach (var button in deleteButton)
                {
                    button.Click();
                }
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Nothing to delete");
            }
        }
        public void AddLanguage(string language, string level)
        {
            //Click on Language Tab
            AddNew.Click();
            Wait.WaitToBeClickable(driver, "XPath", "//div[@class='ui teal button ']", 10);

            //Enter the Language that has to be added
            AddLanguageTextbox.SendKeys(language);
            Thread.Sleep(1000);

            //Choose the Language level
            ChooseLanguageLevel.SendKeys(level);
            ChooseLanguageLevel.Click();
            
            //Click on Add button
            AddButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
        }
        public string Notification()
        {
            IWebElement messageBox = driver.FindElement(By.XPath("//div[@class='ns-box-inner']"));
            return messageBox.Text;
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
        }
        public void UpdateLanguages(string language, string level)
        {
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]/i", 20);
            PencilIcon.Click();
            Thread.Sleep(1000);

            //click onto Update Language
            UpdateLanguage.Clear();
            
            //update the language has to be added
            UpdateLanguage.SendKeys(language);


            //update the language level
            UpdateLanguagelevel.Click();
            UpdateLanguagelevel.SendKeys(level);
            
            //Click on Update button
            UpdateButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);
        }

        public void DeleteLanguage(string languageName)
        {
            By deleteLanguage = By.XPath("//td[text()='" + languageName + "']/following-sibling::td/span[@class='button'][2]");
            driver.FindElement(deleteLanguage).Click();
            Wait.WaitToBeVisible(driver, "XPath", "//div[@class='ns-box-inner']", 20);


        }
    }    
            
 }  