using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using SpecflowTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpecflowTest.Steps
{
    [Binding]
    public class DivisionSteps : Pages.BaseSteps
    {
        [Given(@"I have launched the calculator application")]
        public void GivenIHaveLaunchedTheCalculatorApplication()
        {
            CalculatorPage calculatorPage = new CalculatorPage();
            Assert.IsTrue(calculatorPage.GoToCalculatorPage());
        }

        [When(@"I divide (.*) by (.*)")]
        public void WhenIDivideBy(String numerator, String denominator)
        {
            CalculatorPage calculatorPage = new CalculatorPage();
            String DivisionResult = calculatorPage.Division(numerator, denominator);
            ScenarioContext.Current.Add("DivisionResult", DivisionResult);
        }

        [Then(@"the result is (.*)")]
        public void ThenTheResultIs(String expectedResult)
        {
            String DivisionResult = (String) ScenarioContext.Current["DivisionResult"];
            var extractedResult = DivisionResult.Replace(@"/", "").Trim();

            if(expectedResult.Equals("infinity"))
            {
                int result = (int)extractedResult.ToCharArray()[0];
                Assert.IsTrue(result == 0x0000221e);
            }
            else
            Assert.IsTrue(extractedResult.Equals(expectedResult));
        }
    }
}
