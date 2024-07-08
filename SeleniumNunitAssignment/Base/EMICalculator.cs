using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumNunitAssignment.Base
{
    public class EMICalculator
    {
        public IWebDriver driver;
        public WebDriverWait wait;
        
        public EMICalculator()
        {
            // Initialize WebDriver
            driver = new ChromeDriver();
            driver.Url = "https://homeloans.sbi/calculators";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
           
        }

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl("https://homeloans.sbi/calculators");
        }
        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}

