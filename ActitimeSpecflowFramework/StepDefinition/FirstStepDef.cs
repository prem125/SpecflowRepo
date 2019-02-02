﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ActitimeSpecflowFramework.StepDefinition
{
    [Binding]
    public sealed class FirstStepDef
    {

      public  IWebDriver driver;
        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
            driver = new ChromeDriver();   
        }

        [When(@"Enter the Url")]
        public void WhenEnterTheUrl()
        {
            driver.Url = "https://www.google.com";
        }

        [Then(@"Verify Title of Google Page")]
        public void ThenVerifyTitleOfGooglePage()
        {
            String title = driver.Title;
            Assert.AreEqual(title, "Google");
        }

    }
}
