using OpenQA.Selenium;
using MarsQA.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA.Pages
{
    public class Home
    {
        public void ProfilePage(IWebDriver driver)
        {
            //wait
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]", 10);
            
            // Navigate to Profile module 
            IWebElement profileModule = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]"));
            profileModule.Click();
            Thread.Sleep(2000);
        }
    }
}
