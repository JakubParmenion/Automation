using OpenQA.Selenium;
using System;
using System.Threading;
using UI.Automation.StepDefinitions;

namespace UI.Automation.Support
{
    class Selenium : ITestingFramework
    {
        IWebDriver driver = DriverFactory.get();

        public void maximize()
        {
            driver.Manage().Window.Maximize();
        }

        public void cleanAllCookies()
        {
            driver.Manage().Cookies.DeleteAllCookies();
        }

        public void click(String xPath)
        {
            driver.FindElement(By.XPath(xPath)).Click();
        }

        public void quiteAndFinish()
        {
            driver.Quit();
            DriverFactory.finish();
        }

        public void navigateToWebPage(String pageUrl)
        {
            driver.Navigate().GoToUrl(pageUrl);
        }

        public void sendKeys(String xPath, String keys)
        {
            driver.FindElement(By.XPath(xPath)).SendKeys(keys);
        }

        public string getText(String xPath)
        {
            return driver.FindElement(By.XPath(xPath)).Text;
        }

    }
}
