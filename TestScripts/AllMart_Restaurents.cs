using MobileTest.HelperMethods;
using MobileTest.PageElements;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using TestProject.OpenSDK.Drivers.Android;

namespace MobileTest.TestScripts
{
    [TestFixture]
    public class AllMart_Restaurents : BaseClass
    {
        public CommonMethods commonMethods;
        public Retaurents_Page restaurents;
        public Restaurents_Page_Elements rPE;
        [SetUp]
        public void Setup()
        {
            Initialization();
            commonMethods = new CommonMethods();
            restaurents = new Retaurents_Page();
            rPE = new Restaurents_Page_Elements();
        }
        [Test]
        public void FindRestaurent()
        {
            commonMethods.ResetAndWaitForReady(2000);
            commonMethods.CloseAlert();
            restaurents.ClickOnRestaurents();
            driver.Report().Test("FindRestaurents");
        }
        [Test]
        public void FindRestaurentsAndAddItem()
        {
            //find restaurents
            commonMethods.ResetAndWaitForReady(2000);
            commonMethods.CloseAlert();
            //driver.FindElementById("com.android.packageinstaller:id/permission_allow_button").Click();
            //Thread.Sleep(15000);
            restaurents.ClickOnRestaurents();
            IWebElement source = driver.FindElementByXPath(rPE.Delivery);
            IWebElement destination = driver.FindElementByXPath(rPE.TheFoxHouse);
            commonMethods.Swipe(source, destination);
            restaurents.ClickOnRestaurentName();
            commonMethods.ClickOnElement(rPE.DailySpecial);
            commonMethods.ClickOnElement(rPE.TuesdaySpecial);
            commonMethods.ClickOnElement(rPE.AddItem);
            commonMethods.ClickOnElement(rPE.AddCart);
            commonMethods.ClickOnElement(rPE.CheckOut);
            driver.Report().Test("FindRestaurentsAndAddItem");
        }
        [TearDown]
        public void CloseApp()
        {
            driver.Report().DisableReports(true);
            _driver.CloseApp();
        }
    }
}
