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
        public void FindRestaurentsAndClick()
        {
            
            commonMethods.ResetAndWaitForReady(2000);
            driver.FindElementById("com.android.packageinstaller:id/permission_allow_button").Click();
            Thread.Sleep(15000);
            restaurents.ClickOnRestaurents();
            IWebElement source = driver.FindElementByXPath(rPE.Delivery);
            IWebElement destination = driver.FindElementByXPath(rPE.TheFoxHouse);
            commonMethods.Swipe(source, destination);
            //TouchActions action = new TouchActions(driver);
            //action.ClickAndHold(element).MoveToElement(ele);
            //action.Perform();
            // driver.FindElementByXPath(restaurents.KFCOldParhamRoad).Click();
            restaurents.ClickOnRestaurentName();
            Thread.Sleep(3000);
            commonMethods.ClickOnElement(rPE.DailySpecial);
            Thread.Sleep(3000);
            commonMethods.ClickOnElement(rPE.TuesdaySpecial);
            Thread.Sleep(3000);
            commonMethods.ClickOnElement(rPE.AddItem);
            Thread.Sleep(3000);
            commonMethods.ClickOnElement(rPE.AddCart);
            Thread.Sleep(3000);
            commonMethods.ClickOnElement(rPE.CheckOut);
            driver.Report().Test("FindRestaurents");
        }
        [TearDown]
        public void CloseApp()
        {
            driver.Report().DisableReports(true);
            _driver.CloseApp();

        }
    }
}
