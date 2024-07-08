using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumNunitAssignment.Base
{
    [TestFixture]
    public class SessionTimeoutTest
    {
        public  IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl("https://homeloans.sbi/calculators");

        }
        [TearDown]
        public void TearDown() {driver.Quit();}
    }
}
