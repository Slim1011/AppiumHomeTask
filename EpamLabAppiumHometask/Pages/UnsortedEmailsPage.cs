using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLabAppiumHometask.Pages
{
    public class UnsortedEmailsPage : BasePage
    {
        public UnsortedEmailsPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {

        }

        private readonly string _composeButton = "compose_button";
        private readonly string _subjectFromNewMail = "//android.view.ViewGroup[1]/android.widget.TextView[3]";
        private readonly string _emailImage = "//android.view.ViewGroup[1]/android.widget.ImageView[1]";
        private readonly string _deleteButton = "delete";

        public UnsortedEmailsPage ClickComposeButton()
        {
            driver.FindElementById(_composeButton).Click();
            return this;
        }

        public string GetTextFromNewMailSubject()
        {
           return driver.FindElementByXPath(_subjectFromNewMail).Text;
        }
        public UnsortedEmailsPage ClickEmailImage()
        {
            driver.FindElementByXPath(_emailImage).Click();
            return this;
        }

        public UnsortedEmailsPage ClickDeleteButton()
        {
            driver.FindElementById(_deleteButton).Click();
            return this;
        }
    }
}
