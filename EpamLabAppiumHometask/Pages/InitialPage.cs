using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLabAppiumHometask.Pages
{
    class InitialPage : BasePage
    {
        public InitialPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {
        }

        private readonly string GotItBTN = "welcome_tour_got_it";
        private readonly string TakeMeToGmailBTN = "action_done";
        private readonly string GotItPopUpBTN = "next_button";
        public InitialPage ClickGotItBTN()
        {
            driver.FindElementById(GotItBTN).Click();
            return this;
        }

        public InitialPage ClickTakeMeToGmailBTN()
        {
            driver.FindElementById(TakeMeToGmailBTN).Click();
            return this;
        }

        public InitialPage ClickGotItPopUpBTN()
        {
            driver.FindElementById(GotItPopUpBTN).Click();
            return this;
        }
    }
}
