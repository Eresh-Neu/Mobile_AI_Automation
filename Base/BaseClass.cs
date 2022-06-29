using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using MobileTest.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
//using OpenQA.Selenium.Appium.Android;
using TestProject.OpenSDK.Drivers.Android;


namespace MobileTest
{
    [TestFixture]
    public class BaseClass
    {
        public static IConfigurationRoot Config { get; set; }
        public static AppSettings loadSettings;
        public static string DevToken = "nqByXaJJB2oE50YOk9wX2WkBiVdo8N00fR1ji716tNw1";
        public static AndroidDriver<IWebElement> driver;

        public static AndroidDriver<IWebElement> _driver
        {
           get {return driver; }
           set {driver = value;}
        }
        [OneTimeSetUp]
        public void AssemblyInitialize()
        {
            Config = new ConfigurationBuilder()
            .AddJsonFile($"Config/Appsettings.Mobile.Test.json", optional: true)
            .Build();

        }

        public void Initialization()
        {
                      
            loadSettings = Config.Get<AppSettings>();
            string AppActivity1 = loadSettings.Devices[0].LocalSettings.AppActivity;
            string AppPackage1 = loadSettings.Devices[0].LocalSettings.AppPackage;
            string UUID = loadSettings.Devices[0].LocalSettings.uuid;
            string DeviceName = loadSettings.Devices[0].PlatformName;

            AppiumOptions cap = new AppiumOptions();
            cap.AddAdditionalCapability("udid", UUID);
            cap.AddAdditionalCapability("platformName",DeviceName);
            cap.AddAdditionalCapability("appPackage", AppPackage1 );
            cap.AddAdditionalCapability("appActivity", AppActivity1);

            _driver = new AndroidDriver<IWebElement>(null, DevToken, cap);
            
        }
    }
}
