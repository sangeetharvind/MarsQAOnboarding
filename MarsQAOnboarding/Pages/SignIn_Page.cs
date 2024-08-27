using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class SignIn_Page
    {
        public void SignInActions(IWebDriver driver)
        {
            // SignIn
            // Check if user can click SignIn
            IWebElement signIn = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
            signIn.Click();
            Thread.Sleep(9000);

            try
            {

                // Identify username textbox and enter valid username
                IWebElement emailTextbox1 = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                var rnd = new Random();
                var email = "sang" + rnd.Next(999).ToString() + "@gmail.com";
                emailTextbox1.SendKeys(email);
                Thread.Sleep(2000);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter valid Username");
            }


            // Identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("Sang123");
            Thread.Sleep(2000);

            //Identify remember me checkbox is ticked
            IWebElement remembermeCheckbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
            remembermeCheckbox.Click();
            Thread.Sleep(2000);

            // Identify login button and click on it
            IWebElement loginbutton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginbutton.Click();
            Thread.Sleep(2000);

            //Check if user has logged in successfully
            IWebElement HiSang = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));

        }

    }
}
