using TechTalk.SpecFlow;

namespace UI.Automation.Support
{
    [Binding]
    public sealed class Hooks
    {
        //framework is static only because AfterFeature needs to be static
        private static ITestingFramework framework;

        private Hooks()
        {
            framework = new Selenium();
        }

        [BeforeFeature]
        static public void BeforeFeature()
        {

        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            framework.maximize();
            framework.cleanAllCookies();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            
        }

        [AfterFeature]
        static public void AfterFeature()
        {
            framework.quiteAndFinish();
        }
    }
}
