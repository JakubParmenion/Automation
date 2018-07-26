using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SpecflowTest.Pages
{
    public class CalculatorPage:BasePage
    {
        public CalculatorPage()
        {

        }
        public IWebElement PageHeading => BasePageDriver.FindElement(By.CssSelector("[class='jumbotron'] h1"));
        public IWebElement Numerator => BasePageDriver.FindElement(By.Id("Numerator"));
        public IWebElement Denominator => BasePageDriver.FindElement(By.Id("Denominator"));
        public IWebElement DivideButton => BasePageDriver.FindElement(By.Id("Submit"));
        public IWebElement DivisionResult => BasePageDriver.FindElement(By.CssSelector("Form"));

        public bool GoToCalculatorPage()
        {
            WebdriverManager.GetCurrentWebdriverInstance().Url = "http://localhost:51077";
            return PageHeading.Text.Equals("Parmenion Calculator");
        }

        public String Division(string x, string y)
        {
            Numerator.SendKeys(x);
            Denominator.SendKeys(y);
            DivideButton.Click();

            return DivisionResult.Text;
        }
    }
}
