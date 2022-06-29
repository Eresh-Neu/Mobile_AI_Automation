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
        [SetUp]
        public void Setup()
        {
            Initialization();
        }
        [Test]
        public void FindRestaurentsAndClick()
        {
            driver.ResetApp();
            Thread.Sleep(3000);
            driver.FindElementById("com.android.packageinstaller:id/permission_allow_button").Click();
            //Thread.Sleep(15000);
            WaitForElement(driver.FindElementByXPath("//android.widget.TextView[@text = 'Restaurants']"), 5);
            driver.FindElementByXPath("//android.widget.TextView[@text = 'Restaurants']").Click();
            IWebElement ele = driver.FindElementByXPath("//android.widget.TextView[@text = 'Delivery']");
            IWebElement element = driver.FindElementByXPath("//android.widget.TextView[@text = 'The Fox House']");
            WaitForElement(element, 5);
            TouchActions action = new TouchActions(driver);
            action.ClickAndHold(element).MoveToElement(ele);
            action.Perform();
            driver.FindElementByXPath("//android.widget.TextView[@text = 'KFC Old Parham Road']").Click();
            Thread.Sleep(3000);
            driver.FindElementByXPath("//android.widget.RelativeLayout[1]/android.widget.FrameLayout//android.view.View").Click();
            Thread.Sleep(3000);
            driver.FindElementByXPath("//android.widget.LinearLayout/android.widget.RelativeLayout//android.view.View").Click();
            Thread.Sleep(3000);
            driver.FindElementByXPath("//android.widget.TextView[@text = 'Add']").Click();
            Thread.Sleep(3000);
            driver.FindElementByXPath("//android.widget.TextView[@text = 'Add to Cart']").Click();
            Thread.Sleep(3000);
            driver.FindElementByXPath("//android.widget.TextView[@text = 'Checkout (1 item)']").Click();
        }

        public void WaitForElement(IWebElement ele, int retries )
        {
            while (retries > 0)
            {
                if (ele.Displayed)
                {
                    break;
                }
                else
                {
                    Thread.Sleep(2000);
                }
            }
        }
    }
}
