using OpenQA.Selenium;
using SeleniumNunitAssignment.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System.Threading;
using System.Linq.Expressions;
using NUnit.Framework.Legacy;


namespace SeleniumNunitAssignment.TestScript
{
    [TestFixture]
    public class Module1 : TestBase
    {
        [Test]  //1.Homepage Navigation Verification

        public void HomePageNavigation()
        {
            Console.WriteLine(driver.Title);

            string expectedTitle = "SBI Credit Card Online  | SBI Card";
            string ActualTitle = driver.Title;
            Console.WriteLine($"Hompage title verified:{ActualTitle}");

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(driver.FindElement(By.CssSelector("nav")), "Navigation links are not present.");
            Console.WriteLine("Navigation links are present.");

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(driver.FindElement(By.CssSelector("footer")), "Footer is not present.");
            Console.WriteLine("Footer is present.");

             /*Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(driver.FindElement(By.CssSelector(".banner")), "Banners are not present.");
             Console.WriteLine("Banners are  present.");*/
         



        }

        [Test]   //2.Navigation to Credit Cards Section

        public void NavigationToCreditCard()
        {
            //Console.WriteLine("Navigated to SBICard homepage.");
            IWebElement creditCardLink = driver.FindElement(By.LinkText("Credit Cards"));
            creditCardLink.Click();


            Console.WriteLine("Navigated to the 'Credit Cards' section.Page title:" + driver.Title);
            string expectedTitle1 = "Credit Card - Best Credit Cards in India & their Types | SBI Card";
            string actualTitle1 = driver.Title;
            if (true)
            {
                Console.WriteLine($"Credit Card title Page verified:{actualTitle1}");


            }
            else
            {

                Console.WriteLine($"Credit Card title Page not verified:{actualTitle1}");
            }
        }
        [Test]     //3. Search Functionality
        public void SearchForSpecificCard()
        {
            Console.WriteLine("Navigated to SBICard homepage.");

            IWebElement SearchBox = driver.FindElement(By.Name("search"));
            SearchBox.Click();
            Thread.Sleep(1000);

            SearchBox.SendKeys("SBI Platinum Card");
            Thread.Sleep(5000);

            IWebElement search1 = driver.FindElement(By.XPath("/html/body/div[1]/section[1]/nav/div/ul/li[7]/div[1]/label/span"));
            search1.Click();

            //var searchResults = driver.FindElement(By.XPath("/html/body/div[1]/section[3]"));
           //ClassicAssert.IsNotNull(searchResults,"No search results Found");
            

            Thread.Sleep(10000);
            driver.Quit();

        }
        [Test] //4.Offers Section
        public void offers()
        {
            Console.WriteLine("Navigated to SBICard offerspage.");
            IWebElement Offer = driver.FindElement(By.XPath("/html/body/div[1]/section[1]/nav/div/ul/li[4]/a"));
            Offer.Click();
        }
        /*[Test] //5.Contact Us    This Scenarios contact us is not available
        public void ContactUs()
        {
            Console.WriteLine("Navigated to ContactUs.");

            IWebElement Offer = driver.FindElement(By.XPath("/html/body/div[1]/section[1]/div/div/ul[2]/li[1]/a"));
            Offer.Click();
            Thread.Sleep(1000);
        }*/
        [Test]  //7.Social Media Integration - Follow on Facebook
        public void followonfacebook()
        {
            Console.WriteLine("Navigated to Follow Facebook Window.");
            IWebElement facebook = driver.FindElement(By.XPath("/html/body/div[1]/section[1]/div/div/ul[3]/li[1]/a"));
            facebook.Click();
            Thread.Sleep(10000);

        }
        [Test] //1.Invalid Search Negative Test 

        public void InvalidSearch()
        {
            IWebElement SearchBox = driver.FindElement(By.Name("search"));
            SearchBox.Click();
            Thread.Sleep(1000);

            SearchBox.SendKeys("zzzzz");
            Thread.Sleep(5000);

            IWebElement search1 = driver.FindElement(By.XPath("/html/body/div[1]/section[1]/nav/div/ul/li[7]/div[1]/label/span"));
            search1.Click();
        }
        [Test]  //8.Card Application Process(Positive Test)

        public void ApplyCard()
        {
            IWebElement Apply = driver.FindElement(By.XPath("/html/body/div[1]/section[1]/nav/div/ul/li[6]/a"));
            Apply.Click();
            Thread.Sleep(10000);

            IWebElement ClickSelectCard = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div[17]/a[1]"));
            ClickSelectCard.Click();
            Thread.Sleep(10000);
            IWebElement StartApplyCard = driver.FindElement(By.Id("primaryButtonLoaderId"));
            StartApplyCard.Click();
            Thread.Sleep(10000);
            IWebElement PersonalDetailsClick = driver.FindElement(By.ClassName("LandingPage_GoToImage__2O9x_"));
            PersonalDetailsClick.Click();
            Thread.Sleep(1000);
            IWebElement Fname = driver.FindElement(By.Name("firstName"));
            Fname.SendKeys("Sajid");
            Thread.SpinWait(1000);
            IWebElement Mname = driver.FindElement(By.Name("middleName"));
            Mname.SendKeys("Ahammad");
            Thread.SpinWait(1000);
            IWebElement Lname = driver.FindElement(By.Name("lastName"));
            Lname.SendKeys("Shaik");
            Thread.SpinWait(1000);
            IWebElement Number = driver.FindElement(By.Id("mobileNo"));
            Number.SendKeys("9704170418");
            IWebElement buttonclick = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[4]/div[2]/div/form/div[2]/div[1]/label/input"));
            buttonclick.Click();
            IWebElement Submit = driver.FindElement(By.XPath("//*[@id=\'primaryButtonLoaderId\']"));
            Submit.Click();
            Thread.Sleep(5000);




            //Thread.SpinWait(1000);

        }
        [Test]  //16.Invalid Card Application Process(Positive Test)

        public void InvalidApplyCard()
        {
            IWebElement Apply = driver.FindElement(By.XPath("/html/body/div[1]/section[1]/nav/div/ul/li[6]/a"));
            Apply.Click();
            Thread.Sleep(10000);

            IWebElement ClickSelectCard = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div[17]/a[1]"));
            ClickSelectCard.Click();
            Thread.Sleep(10000);
            IWebElement StartApplyCard = driver.FindElement(By.Id("primaryButtonLoaderId"));
            StartApplyCard.Click();
            Thread.Sleep(10000);
            IWebElement PersonalDetailsClick = driver.FindElement(By.ClassName("LandingPage_GoToImage__2O9x_"));
            PersonalDetailsClick.Click();
            Thread.Sleep(1000);
            IWebElement Fname = driver.FindElement(By.Name("firstName"));
            Fname.SendKeys(".....");
            Thread.SpinWait(1000);
            IWebElement Mname = driver.FindElement(By.Name("middleName"));
            Mname.SendKeys("@$*&");
            Thread.SpinWait(1000);
            IWebElement Lname = driver.FindElement(By.Name("lastName"));
            Lname.SendKeys("!!!!!");
            Thread.SpinWait(1000);
            IWebElement Number = driver.FindElement(By.Id("mobileNo"));
            Number.SendKeys("12345678");
            IWebElement buttonclick = driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[4]/div[2]/div/form/div[2]/div[1]/label/input"));
            buttonclick.Click();
            IWebElement Submit = driver.FindElement(By.XPath("//*[@id=\'primaryButtonLoaderId\']"));
            Submit.Click();
            Thread.Sleep(5000);




            //Thread.SpinWait(1000);

        }

        // 6. interactive Calculator -Emi Calculator ( Positive Test )

        [TestFixture]
        public class EMICalculatorTests : EMICalculator
        {
            [Test]
            public void TestEMICalculator()
            {
                // Navigate to the EMI Calculator page
               // NavigateToUrl("https://homeloans.sbi/calculators");
                driver.Manage().Window.Maximize();

                var loanAmountElement = driver.FindElement(By.XPath("//*[@id=\'loanamount_DEFAULTEMICAL\']"));
                loanAmountElement.Clear();
                loanAmountElement.SendKeys("9000000");
                Thread.Sleep(10000);

                var loanTenureElement = driver.FindElement(By.XPath("//*[@id=\'loanTenureValue_DEFAULTEMICAL\']"));
                loanTenureElement.Clear();
                loanTenureElement.SendKeys("5");
                Thread.Sleep(10000);

                var InterestRate = driver.FindElement(By.XPath("//*[@id=\'loanInterestRate_DEFAULTEMICAL\']"));
                InterestRate.Clear();
                InterestRate.SendKeys("12");
                Thread.Sleep(10000);
                // Wait for the EMI to be calculated (you may need to add a wait here)

                // Get the EMI displayed
               /* IWebElement emiElement = driver.FindElement(By.Id("totalEmiDef"));
                string emi = emiElement.Text;*/

                // Verify and Print the calculated EMI
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(By.Id("totalEmiDef"),"Detailed Calculations Ar not showning.");
                Console.WriteLine("Emi Detailed Calculation Are Displayed");


            }
            //3. invalid input in Emi calculator (Negative Test)

            [Test]
            public void InvalidTestEMICalculator()
            {
                // Navigate to the EMI Calculator page
                NavigateToUrl("https://homeloans.sbi/calculators");

                var loanAmountElement = driver.FindElement(By.XPath("//*[@id=\'loanamount_DEFAULTEMICAL\']"));
                loanAmountElement.Clear();
                loanAmountElement.SendKeys("0");
                Thread.Sleep(10000);

                var loanTenureElement = driver.FindElement(By.XPath("//*[@id=\'loanTenureValue_DEFAULTEMICAL\']"));
                loanTenureElement.Clear();
                loanTenureElement.SendKeys("50");
                Thread.Sleep(10000);

                var InterestRate = driver.FindElement(By.XPath("//*[@id=\'loanInterestRate_DEFAULTEMICAL\']"));
                InterestRate.Clear();
                InterestRate.SendKeys("15");
                Thread.Sleep(10000);
                // Wait for the EMI to be calculated (you may need to add a wait here)

                // Get the EMI displayed
               /* IWebElement emiElement = driver.FindElement(By.Id("totalEmiDef"));
                string emi = emiElement.Text;*/

                // Verify and Print the calculated EMI
                Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsNotNull(By.Id("totalEmiDef"), "Detailed Calculations Ar not showning.");
                Console.WriteLine("Emi Detailed Are Invalid");


            }
        }
        //11.Timeout Handling -Session Timeout management 

        [TestFixture]
        public class TestTimeoutSessions:SessionTimeoutTest
        {
            // private object driver;

            [Test]
            public void TestTimeout()
            {
                //step 1 leaving the website idle for a duration that triggers a session timeout
                int sessionTimeoutDurationInSeconds = 60;
                Thread.Sleep(sessionTimeoutDurationInSeconds * 100);

                driver.Navigate().GoToUrl("https://www.sbicard.com/");
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                

            }
            

        }
        [TestFixture]
        public class ContactUs : ContactUsForm
        {
            [Test]
            public void TestContactUs()
            {
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("/html/body/div[2]/div[1]/div[1]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector("div.templates-content-list-item:nth-child(7) > div:nth-child(1) > a:nth-child(1) > span:nth-child(1) > img:nth-child(1)")).Click();
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[1]/div/div[4]/section/div[2]/div/div/div[2]/div[2]/div[1]/div[1]")).Click();
                Thread.Sleep(5000);
               /* driver.FindElement(By.Id("i-text-1")).SendKeys("Sajid");
                Thread.Sleep(5000);
                driver.FindElement(By.Name("last-name")).SendKeys("Shaik");
                Thread.Sleep(5000);
                driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/div[1]/div/div/div/div/div[2]/div[3]/div[2]/div")).Click();
                Thread.Sleep(5000);*/
            }
        }
    }
}

            









    


