namespace UI.Tests.Steps

{ 

    using TechTalk.SpecFlow;
    using UI.Tests.PO;
    using FluentAssertions;


    [Binding]
    public class CalculatorSteps
    {
        Calculator calculator = new Calculator();


        [Given(@"I am on the Parmenion Calculator page")]
        public void GivenIAmOnTheParmenionCalculatorPage()
        {
            calculator.Navgiate_to_Calculator();
        }
        
        [When(@"I send the ""(.*)"" Numerator ""(.*)"" Denominator")]
        public void WhenISendTheNumeratorDenominator(string p0, string p1)
        {
            calculator.Click_nume_link(p0);
            calculator.Click_deno_link(p1);
        
        }


        [Then(@"I should see the NaN")]
        public void ThenIShouldSeeThe()
        {
            calculator.Click_Submit_Button();
            // the retuning text NaN should be changed to something more meaningful
          
        }
        [Then(@"I should see the correct answer")]
        public void ThenIShouldSeeTheCorrectAnswer()
        {
            calculator.Click_Submit_Button();
            var result = calculator.GetResult();
            result.Should().EndWithEquivalent("10");
        }



    }
}
