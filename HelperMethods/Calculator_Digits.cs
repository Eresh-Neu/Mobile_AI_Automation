using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestProject.OpenSDK.Drivers.Android;

namespace MobileTest.HelperMethods
{
   public class Calculator_Digits : BaseClass
    {
        public void Addition(int First, int Second) {
            Thread.Sleep(1000);
            digits(First);
            driver.Report().Step("Click on digit 2", screenshot: true);
            driver.FindElementById("com.android.calculator2:id/op_add").Click();
            digits(Second);
            driver.FindElementById("com.android.calculator2:id/eq").Click();
            var val = _driver.FindElementById("com.android.calculator2:id/result").Text;
            Assert.AreEqual("7", val);
            driver.Report().Step("Displayed 7", screenshot: true);
        }        

        public void ResetAndWaitForReady(int sec)
        {
            driver.ResetApp();
            Thread.Sleep(sec);
        }
        public void digits(int val)
        {
            switch (val)
            {
                case 0:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_2")).Click();
                    break;
                case 1:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_2")).Click();
                    break;

                case 2:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_2")).Click();
                    break;

                case 3:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_2")).Click();
                    break;

                case 4:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_2")).Click();
                    break;

                case 5:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_5")).Click();
                    break;
            }
        }
    }
}
