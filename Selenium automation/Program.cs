using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_automation
{
   

    internal class Program
    {

        // Create a reference for Chrome browser
        IWebDriver driver = new ChromeDriver();

        
        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.Intialize();
            prog.ExecuteTest();
            prog.CloseTest();
        }
        [SetUp]
        public void Intialize()
        {
            // go to Amazon Page
            driver.Navigate().GoToUrl("http://www.amazon.com");
        }
        [Test]
        public void ExecuteTest()
        {
            // Make a browser full screen
            driver.Manage().Window.Maximize();


            IWebElement firstName = driver.FindElement(By.Id("u_0_m"));
            firstName.SendKeys("John");

            IWebElement lastName = driver.FindElement(By.Id("u_0_o"));
            lastName.SendKeys("Wick");

            IWebElement email = driver.FindElement(By.Id("u_0_r"));
            email.SendKeys("asdasdsd@gmail.com");

            IWebElement reEnterEmail = driver.FindElement(By.Id("u_0_u"));
            reEnterEmail.SendKeys("asdasdasd@gmail.com");

            IWebElement password = driver.FindElement(By.Id("u_0_w"));
            password.SendKeys("myawesomepassword");

            IWebElement month = driver.FindElement(By.Id("month"));
            var selectElementMonth = new SelectElement(month);
            selectElementMonth.SelectByValue("12");

            IWebElement day = driver.FindElement(By.Id("day"));
            var selectElementDay = new SelectElement(day);
            selectElementDay.SelectByValue("7");

            IWebElement year = driver.FindElement(By.Id("year"));
            var selectElementYear = new SelectElement(year);
            selectElementYear.SelectByValue("2005");

            IWebElement genderButton = driver.FindElement(By.Id("u_0_7"));
            genderButton.Click();

            IWebElement signUpButton = driver.FindElement(By.Id("u_0_13"));
            signUpButton.Click();




        }

        [TearDown]
        public void CloseTest()
        {
            
        }
    }

}
