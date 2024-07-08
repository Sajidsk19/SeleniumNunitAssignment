using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumNunitAssignment.Utils;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;


namespace SeleniumNunitAssignment.Base
{
    public class TestBase
    {

#pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        public IWebDriver driver;
#pragma warning restore NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method

        public WebDriverWait wait;


        [SetUp]
        public void Open()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.sbicard.com/";
            Thread.Sleep(1000);
            
        }
        [TearDown]
        public void Close() {driver.Quit();}

       
        


        
    }
}

