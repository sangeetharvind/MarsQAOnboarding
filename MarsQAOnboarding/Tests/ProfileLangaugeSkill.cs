using MarsOnboarding.Utilities;
using MarsQA.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnboarding.Tests
{
    [TestFixture]
    public class ProfileLangaugeSkill : CommonDriver
    {
        [SetUp]
        public void SetUpStep()
        {
            Join_Page joinPageobj = new Join_Page();
            joinPageobj.JoinActions(driver);

            driver.Navigate().GoToUrl("http://localhost:5000/");
            driver.Manage().Window.Maximize();

            SignIn_Page signinPageObj = new SignIn_Page();
            signinPageObj.SignInActions(driver);

        }
        [Test]
        public void CreateLanguage_test()
        {
            Language_Page languagePageObj = new Language_Page();
            languagePageObj.CreateLanguagePage(driver);
        }
        [Test]
        public void EditLanguage_test()
        {
            Language_Page languagePageObj = new Language_Page();
            languagePageObj.EditLanguagePage(driver);

        }
        [Test]
        public void DeleteLanguage_test()
        {
            Language_Page languagePageObj = new Language_Page();
            languagePageObj.DeleteLanguagePage(driver);
        }
        [Test]
        public void CreateSkill_test()
        {

        }
        [Test]
        public void EditSkill_test()
        {

        }
        [Test]
        public void DeleteSkill_test()
        {

        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
