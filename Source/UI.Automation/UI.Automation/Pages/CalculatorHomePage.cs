using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Automation.Libraries;

namespace UI.Automation.Pages
{
    public class CalculatorHomePage
    {
        // public IWebDriver driver = null;

        public CalculatorHomePage()
        {
            PageFactory.InitElements(Base.driver, this);
        }


        [FindsBy(How = How.Id, Using = "Numerator")]
        public IWebElement Numerator { get; set; }

        [FindsBy(How = How.Id, Using = "Denominator")]
        public IWebElement Denominator { get; set; }

        [FindsBy(How = How.Id, Using = "Submit")]
        public IWebElement DivideButton { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/form")]
        public IWebElement Result { get; set; }

        public void EnterNumbersIntoCalculator(string num, string deno)
        {
            Numerator.SendKeys(num);
            Denominator.SendKeys(deno);
        }

        public void PerformDivision(string num, string deno)
        {
            EnterNumbersIntoCalculator(num, deno);
            SelectDivision();
        }

        public void SelectDivision()
        {
            DivideButton.Click();
        }

        public string GetResult()
        {
            string resultValue = Result.Text;
            var result = resultValue.Split('/');
            return result[1].Trim();
        }
    }
}
