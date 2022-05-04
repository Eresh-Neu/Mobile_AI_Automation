using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;
using MobileTest.HelperMethods;
//using OpenQA.Selenium.Appium.Android;

namespace MobileTest
{
    [Parallelizable]
    [TestFixture]
    public class Calculator_Tests:BaseClass
    {
        public Calculator_Digits Calculator_Add;
       [SetUp]
        public void Setup()
        {
            Initialization();
            Calculator_Add = new Calculator_Digits();
            driver.Report().DisableAutoTestReports(true);
        }

        [Test(Description = "Addition")]
        public void MyFirstTest()
        {
            Calculator_Add.ResetAndWaitForReady(1000);
            Calculator_Add.Addition(2,5);
            driver.Report().Test("First");
                               
        }
        [Test(Description = "subtraction")]
        public void MySecondTest()
        {
            Calculator_Add.ResetAndWaitForReady(1000);
            Calculator_Add.Addition(2,5);
            driver.Report().Test("second_test");
        }
        [TearDown]
        public void CloseApp()
        {
            _driver.CloseApp();
            driver.Report().DisableReports(true);
        }
    }
}