using EpamLabAppiumHometask.Pages;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;


namespace EpamLabAppiumHometask.BusinessObject
{
    public class GmailBusinessObject
    {
        private readonly InitialPage initialPage;
        private readonly NewEmailPage newEmailPage;
        private readonly UnsortedEmailsPage unsortedEmailsPage;
        public GmailBusinessObject(AppiumDriver<AndroidElement> driver)
        {
            initialPage = new InitialPage(driver);
            newEmailPage = new NewEmailPage(driver);
            unsortedEmailsPage = new UnsortedEmailsPage(driver);
        }

        public GmailBusinessObject EnterGmailAndSkipPopup()
        {
            initialPage.ClickGotItBTN().ClickTakeMeToGmailBTN().ClickGotItPopUpBTN();
            return this;
        }

        public GmailBusinessObject SendNewEmail(string receiver, string subject)
        {
            unsortedEmailsPage.ClickComposeButton();
            newEmailPage.SkipInformationWindow().SendKeysToFieldTo(receiver)
                        .SendKeysToSubjectField(subject).ClickButtonSendEmail();
            return this;
        }
        public string GetTextFromMailSubject()
        {
            return  unsortedEmailsPage.GetTextFromNewMailSubject();
             
        }

        public GmailBusinessObject DeleteEmail()
        {
            unsortedEmailsPage.ClickEmailImage();
            unsortedEmailsPage.ClickDeleteButton();
            return this;
        }
    }
}
