namespace UI.Tests

{
    using TechTalk.SpecFlow;
    using OpenQA.Selenium.Chrome;
    using System.Configuration;
    using UI.Tests.Helper;
    using UI.Tests.PO;


    [Binding]
    public sealed class Hooks
    {
        public static string baseurl = ConfigurationManager.AppSettings["BaseUrl"];
        Calculator calculator = new Calculator();

        [BeforeFeature()]
        public static void BeforeScenario()
        {
            Web_Drivers.Driver = new ChromeDriver();
            Web_Drivers.Driver.Navigate().GoToUrl(baseurl);

        }
        [BeforeScenario]
        public void Before()
        {
            calculator.Maximise();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Web_Drivers.Driver.Quit();
        }

    }
}
