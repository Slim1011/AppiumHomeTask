using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamLabAppiumHometask.Capabilities
{
    public class Capabilities
    {
        private static readonly string _platformNameCapability = "Android";
        private static readonly string _deviceNameCapability = "emulator-5554";
        private static readonly string _appPackageCapability = "com.google.android.gm";
        private static readonly string _appActivityCapability = "com.google.android.gm.ConversationListActivityGmail";
        private static readonly string _uri = "http://localhost:4723/wd/hub";

        public static AppiumOptions getCapabilities()
        {
            AppiumOptions driverOption = new AppiumOptions();
            driverOption.AddAdditionalCapability(MobileCapabilityType.PlatformName, _platformNameCapability);
            driverOption.AddAdditionalCapability(MobileCapabilityType.DeviceName, _deviceNameCapability);
            driverOption.AddAdditionalCapability("appPackage", _appPackageCapability);
            driverOption.AddAdditionalCapability("appActivity", _appActivityCapability);

            return driverOption;
        }

        public static Uri getAppiumServerUri()
        {
            try
            {
                return new Uri(_uri);
            }
            catch (UriFormatException e)
            {
                Console.WriteLine(e);
            }
            return null;
        }
    }
}
