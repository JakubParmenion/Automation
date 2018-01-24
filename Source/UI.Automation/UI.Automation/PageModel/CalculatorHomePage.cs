using System;
using System.Threading;
using TechTalk.SpecFlow;
using UI.Automation.Support;

namespace UI.Automation.PageModel
{
    public sealed class CalculatorHomePage
    {
        private ITestingFramework framework;

        private string textFieldDividendXpath = "//*[@id='Numerator']";
        private string textFieldDivisorXpath = "//*[@id='Denominator']";
        private string buttonDivideXpath = "//*[@id='Submit']";
        private string textFractionXpath = "/html/body/div[2]/div/div/form";

        public CalculatorHomePage()
        {
            framework = new Selenium();
        } 

        internal void navigateToWebPage(string pageUrl)
        {
            framework.navigateToWebPage(pageUrl);
        }


        internal void enterDividendValueIntoField(string dividend)
        {
            framework.sendKeys(textFieldDividendXpath, dividend);
        }

        internal void enterDivisorValueIntoField(string divisor)
        {
            framework.sendKeys(textFieldDivisorXpath, divisor);
        }

        internal void clickOnDivideButton()
        {
            framework.click(buttonDivideXpath);
            
        }

        internal string getResult()
        {
            return framework.getText(textFractionXpath).Remove(0,2);
        }
    }
}
