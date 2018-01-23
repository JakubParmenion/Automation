using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using TechTalk.SpecFlow;
using UI.Automation.Libraries;
using UI.Automation.Pages;

namespace UI.Automation
{
    [Binding]
    public class TestFeatureSteps : Base
    {
        [Given(@"I am on the Parmenion Calculator Page")]
        public void GivenIAmOnTheParmenionCalculatorPage()
        {
            CalculatorHomePage page = new CalculatorHomePage();
            Base.NavigateToUrl();
        }

        [When(@"I enter two numbers (.*) and (.*)")]
        public void WhenIEnterTwoNumbersAnd(string p0, string p1)
        {
            CalculatorHomePage page = new CalculatorHomePage();
            page.EnterNumbersIntoCalculator(p0, p1);
        }

        [When(@"perform the division")]
        public void WhenPerformTheDivision()
        {
            CalculatorHomePage page = new CalculatorHomePage();
            page.SelectDivision();
        }

        [Then(@"I should expect the result to be (.*)")]
        public void ThenIShouldExpectTheResultToBe(string expectedResult)
        {
            CalculatorHomePage page = new CalculatorHomePage();
            string actualResult = page.GetResult();

            if (expectedResult == "infinity")
                expectedResult = "\u221e";
            Assert.AreEqual(expectedResult, actualResult);

        }

    }
}
