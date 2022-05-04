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
        public Calculator_addition calculator;
        public CommonMethods commonMethods;
       [SetUp]
        public void Setup()
        {
            Initialization();
            calculator = new Calculator_addition();
            commonMethods = new CommonMethods();
            driver.Report().DisableAutoTestReports(true);
        }

        [Test(Description = "Addition")]
        public void Addition()
        {
            commonMethods.ResetAndWaitForReady(1000);
            calculator.Addition(2, 5);            
            driver.Report().Test("Addition");                               
        }
        [Test(Description = "subtraction")]
        public void Substraction()
        {
            commonMethods.ResetAndWaitForReady(1000);
            calculator.Addition(2,5);
            driver.Report().Test("substract");
        }
        [TearDown]
        public void CloseApp()
        {
            driver.Report().DisableReports(true);
            _driver.CloseApp();
            
        }
    }
}