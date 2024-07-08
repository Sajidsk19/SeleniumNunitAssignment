using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNunitAssignment.Base
{
    public class ContactUsForm
    {
        public IWebDriver driver;
        public WebDriverWait wait;

        [SetUp]
        public void open()
        {
            driver = new ChromeDriver();
            driver.Url = "https://forms.app/en/templates/contact-forms";
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);


        }
        [TearDown]
        public void close()
        { driver.Quit(); }
    }
}
