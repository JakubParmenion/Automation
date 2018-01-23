using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace UI.Automation.Libraries
{
    public class Base
    {
        public static IWebDriver driver
        {
            get; set;
        }
        public static void GetBrowser()
        {
            driver = new ChromeDriver();
        }

        [BeforeScenario]
        public void StartASession()
        {
            GetBrowser();          
        }

        [AfterScenario]
        public void Close()
        {
            driver.Close();
        }

        public static void NavigateToUrl()
        {      
            driver.Navigate().GoToUrl("http://localhost:51077/");
        }

    }
}
