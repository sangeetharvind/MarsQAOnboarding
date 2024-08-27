using OpenQA.Selenium;
using MarsQA.Utilities;

namespace MarsQA.Pages
{
    public class Join_Page
    {
       public void JoinActions(IWebDriver driver)
        {
            // Launch MarsQA
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
         
            // Join
            // Check if user can click Join
            IWebElement join1 = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/button"));
            join1.Click();
            Thread.Sleep(1000);

            // Identify Firstname textbox and enter valid Firstname
            IWebElement firstnameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/input"));
            firstnameTextbox.SendKeys("Sangeetha");
            Thread.Sleep(2000);

            // Identify Lastname textbox and enter valid Lastname
            IWebElement lastnameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[2]/input"));
            lastnameTextbox.SendKeys("Narayan");
            

            // Identify Email textbox and enter valid Email
            IWebElement emailTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[3]/input"));
            var rnd = new Random();
            var email = "sang" + rnd.Next(999).ToString() + "@gmail.com";
            emailTextbox.SendKeys(email);
           

            // Identify Password textbox and enter valid Password
            IWebElement passwordTextbox1 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[4]/input"));
            passwordTextbox1.SendKeys("Sang123");
            

            // Identify ConfirmPassword textbox and enter valid ConfirmPassword
            IWebElement confirmpasswordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[5]/input"));
            confirmpasswordTextbox.SendKeys("Sang123");
            

            // Identify by clicking Terms and ConditionsIWebElement firstnameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[1]/input"));
            IWebElement termsandconditionsCheckbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/form/div[6]/div/div/input"));
            termsandconditionsCheckbox.Click();
            Thread.Sleep(2000);

            // Identify login button and click on it
            IWebElement join = driver.FindElement(By.Id("submit-btn"));
            join.Click();
            Wait.WaitToBeClickable(driver, "Id", "submit-btn", 2);
        }
    }
}
