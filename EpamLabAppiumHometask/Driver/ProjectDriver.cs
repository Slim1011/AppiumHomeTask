using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLabAppiumHometask.Driver
{
    public class ProjectDriver
    {
        private static AndroidDriver<AndroidElement> driver;

        public static AndroidDriver<AndroidElement> getDriver()
        {
            if (driver == null)
            {
                driver = new AndroidDriver<AndroidElement>(Capabilities.Capabilities.getAppiumServerUri(), Capabilities.Capabilities.getCapabilities());
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            }
            return driver;
        }
        public static void quitDriver()
        {
            driver.Quit();
        }
    }
}
