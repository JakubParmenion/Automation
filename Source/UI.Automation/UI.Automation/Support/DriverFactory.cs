using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UI.Automation.StepDefinitions
{
    class DriverFactory
    {
        private static string selectedBrowser = "headless";
        private static IWebDriver driver;

        public static IWebDriver get()
        {
            if (driver == null)
                switch (selectedBrowser)
                {
                    case "chrome":
                        driver = setChromeDriver();
                        break;
                    default:
                        driver = setHeadlessChromeDriver();
                        break;
                }
            return driver;
        }

        public static void finish()
        {
            driver = null;
        }

        private static IWebDriver setChromeDriver()
        {

            IWebDriver driver = new ChromeDriver();

            return driver;
        }

        private static IWebDriver setHeadlessChromeDriver()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("--headless");
            chromeOptions.AddArgument("--disable-gpu");
            IWebDriver driver = new ChromeDriver(chromeOptions);

            return driver;
        }
    }
}
