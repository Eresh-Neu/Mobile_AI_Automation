using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobileTest.HelperMethods
{
    public class Calculator_Oparators : BaseClass
    {
        public void ClickOnOperations(string val)
        {
            //click on oprators in the calaculator
            switch (val)
            {
                case "Plus":
                    driver.FindElementById("com.android.calculator2:id/op_add").Click();
                    break;
                case "Minus":
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_1")).Click();
                    break;

                case "Equal":
                    driver.FindElementById("com.android.calculator2:id/eq").Click();
                    break;
            }

        }
    }
}
