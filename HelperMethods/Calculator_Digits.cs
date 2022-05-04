using MobileTest.PageElements;
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

        Calculator_digits_Elements digitElement = new Calculator_digits_Elements();       

       public void ClickOndigits(int val)
        {
            switch (val)
            {
                case 0:
                    driver.FindElement(By.Id(digitElement.zero)).Click();
                    break;
                case 1:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_1")).Click();
                    break;

                case 2:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_2")).Click();
                    break;

                case 3:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_3")).Click();
                    break;

                case 4:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_4")).Click();
                    break;

                case 5:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_5")).Click();
                    break;
                case 6:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_6")).Click();
                    break;
                case 7:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_7")).Click();
                    break;
                case 8:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_8")).Click();
                    break;
                case 9:
                    driver.FindElement(By.Id("com.android.calculator2:id/digit_9")).Click();
                    break;
            }
        }
    }
}
