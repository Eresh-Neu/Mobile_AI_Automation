using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MobileTest.HelperMethods
{
    public class CommonMethods : BaseClass
    {
        public void ResetAndWaitForReady(int sec)
        {
            driver.ResetApp();
            Thread.Sleep(sec);
        }

        public void Swipe(IWebElement source, IWebElement destiation)
        {
            TouchActions action = new TouchActions(driver);
            action.ClickAndHold(destiation).MoveToElement(source);
            action.Perform();
        }
        public void ClickOnElement(string element)
        {
            driver.FindElementByXPath(element).Click();
            Thread.Sleep(3000);
            driver.Report().Step(element,"Click on element");
            //driver.Report().Step()
        }
    }
}
