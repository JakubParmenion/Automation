using NUnit.Framework;
using TechTalk.SpecFlow;
using UI.Automation.PageModel;
using UI.Automation.Support;

namespace UI.Automation.StepDefinitions
{
    [Binding]
    public sealed class ParmenionSteps
    {
        CalculatorHomePage pageModel;

        private ParmenionSteps()
        {
            pageModel = new CalculatorHomePage();
        }

        [Given(@"I have navigated to the ""(.*)"" page")]
        public void GivenIHaveNavigatedToThePage(string pageUrl)
        {
            pageModel.navigateToWebPage(pageUrl);
        }

        [Given(@"entered (.*) and (.*) into page fields")]
        public void GivenEnteredAndIntoPageFields(string dividend, string divisor)
        {
            pageModel.enterDividendValueIntoField(dividend);
            pageModel.enterDivisorValueIntoField(divisor);
            
        }

        [When(@"I press Divide button")]
        public void WhenIPressDivideButton()
        {
            pageModel.clickOnDivideButton();
        }

        [Then(@"the resoult showed on the screen should be equal to (.*)")]
        public void ThenTheNumberShowedOnTheScreenShouldBeEqualTo(string fraction)
        {
            string result = pageModel.getResult();
            Assert.AreEqual(fraction, result);
        }

    }
}
