using MarsOnboarding.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnboarding.Pages
{
    public class Login_Page : CommonDriver
    {
        private IWebElement SignInButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement Email => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        public IWebElement Password => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        public IWebElement RememberMe => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[3]/div/input"));
        public IWebElement LoginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

        //IWebElement welcomeText = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span"));
        public void LoginSteps()
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();
            SignInButton.Click();
            Thread.Sleep(1000);
            Email.SendKeys("lava@gmail.com");
            Password.SendKeys("Password@1");
            RememberMe.Click();
            Thread.Sleep(2000);
            LoginButton.Click();
            Thread.Sleep(4000);
        }


    }    }

