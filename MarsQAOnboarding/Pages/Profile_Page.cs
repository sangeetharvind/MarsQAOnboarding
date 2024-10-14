using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using MarsOnboarding.Utilities;

namespace MarsOnboarding.Pages
{
    public class ProfilePage : CommonDriver
    {
        public void GoToLangaugeTab()
        {
            //Clicking on Language module in the Profile page
            IWebElement LangaugeTab = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            LangaugeTab.Click();
            Thread.Sleep(1000);
        }
    }
}
            


