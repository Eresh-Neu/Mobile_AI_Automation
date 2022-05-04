using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MobileTest.HelperMethods
{
    public class Calculator_addition : BaseClass
    {

        Calculator_Oparators oprator = new Calculator_Oparators();
        Calculator_Digits digit = new Calculator_Digits();
        public void Addition(int First, int Second)
        {
            Thread.Sleep(1000);
            digit.ClickOndigits(First);
            driver.Report().Step("Click on digit 2", screenshot: true);
            driver.FindElementById("com.android.calculator2:id/op_add").Click();
            digit.(Second);
            oprator.ClickOnOperations("Equal");
            var val = _driver.FindElementById("com.android.calculator2:id/result").Text;
            Assert.AreEqual("7", val);
            driver.Report().Step("Displayed 7", screenshot: true);
        }
    }
}
