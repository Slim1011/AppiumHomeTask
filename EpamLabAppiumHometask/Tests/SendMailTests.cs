using EpamLabAppiumHometask.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLabAppiumHometask.Tests
{
    class SendMailTests : BaseTest
    {

        private readonly string _receiver = "angidrit1011@gmail.com";
        private readonly string _subject = "Hello Slim!! "+ RandomNumberGenerator.GetRandomNumber();
        
        [Test]
        public void SendAndDeleteNewEmail()
        {
            gmailBusinessObject.EnterGmailAndSkipPopup()
                .SendNewEmail(_receiver, _subject);
            Assert.AreEqual(gmailBusinessObject.GetTextFromMailSubject(), _subject);
            gmailBusinessObject.DeleteEmail();
            Assert.AreNotEqual(gmailBusinessObject.GetTextFromMailSubject(), _subject);
        }
    }
}
