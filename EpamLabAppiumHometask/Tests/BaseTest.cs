using EpamLabAppiumHometask.BusinessObject;
using EpamLabAppiumHometask.Driver;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLabAppiumHometask.Tests
{
    public class BaseTest
    {
        
        protected GmailBusinessObject gmailBusinessObject;
       
        [SetUp]
        public void SetUp()
        {
            gmailBusinessObject = new GmailBusinessObject(ProjectDriver.getDriver());
        }

        [TearDown]
        public void TearDown()
        {
            ProjectDriver.quitDriver();
        }
    }
}
