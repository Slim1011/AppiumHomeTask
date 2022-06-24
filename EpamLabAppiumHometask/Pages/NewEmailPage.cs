using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLabAppiumHometask.Pages
{
    public class NewEmailPage : BasePage
    {
        public NewEmailPage(AppiumDriver<AndroidElement> driver) : base(driver)
        {

        }

        private readonly string _infoWindowCloseButton = "android:id/button1";
        private readonly string _toField = "//android.view.ViewGroup/android.widget.EditText";
        private readonly string _receiversList = "peoplekit_listview_flattened_row";
        private readonly string _subjectField = "com.google.android.gm:id/subject";
        private readonly string _composeEmailField = "com.google.android.gm:id/body_wrapper";
        private readonly string _composeTextField = "com.google.android.gm:id/wc_body";
        private readonly string _sendEmailButton = "com.google.android.gm:id/send";
        
        public NewEmailPage SkipInformationWindow()
        {
            driver.FindElementById(_infoWindowCloseButton).Click();
            return this;
        }

        public NewEmailPage SendKeysToFieldTo(string receiver)
        {
            driver.FindElementByXPath(_toField).SendKeys(receiver);
            driver.FindElementById(_receiversList).Click();
            return this;
        }

        public NewEmailPage SendKeysToSubjectField(string subject)
        {
            driver.FindElementById(_subjectField).SendKeys(subject);
            return this;
        }

        public NewEmailPage SendTextToComposeField(string messageText)
        {
            driver.FindElementById(_composeEmailField).Click();;
            driver.FindElementById(_composeTextField).SendKeys(messageText);
            return this;
        }
        public NewEmailPage ClickButtonSendEmail()
        {
            driver.FindElementById(_sendEmailButton).Click();
            return this;
        }
    }
}
