namespace UI.Tests.PO
{ 


   using System;
   using OpenQA.Selenium;
   using OpenQA.Selenium.Support.PageObjects;
   using OpenQA.Selenium.Support.UI;
   using System.Configuration;
   using UI.Tests.Helper;


    public class Calculator
    {
        public WebDriverWait Wait { get; set; }
        public By Result = By.XPath("/html/body/div[2]/div/div/form");

        public Calculator()
        {
            PageFactory.InitElements(Web_Drivers.Driver, this);
            Wait = new WebDriverWait(Web_Drivers.Driver, new TimeSpan(0, 0, 60));
        }


        [FindsBy(How = How.Id, Using = "Numerator")] private IWebElement nume;

        [FindsBy(How = How.Id, Using = "Denominator")] private IWebElement deno;

        [FindsBy(How = How.Id, Using = "Submit")] private IWebElement divide;

      
        public string GetResult()
        {
            return Web_Drivers.Driver.FindElement(Result).Text;
        }
        public void Navgiate_to_Calculator()
        {
            var calcultor = ConfigurationManager.AppSettings["BaseUrl"];
            Web_Drivers.Driver.Navigate().GoToUrl(calcultor);
        }
        public void Click_nume_link(string Numerator)
        {
            try
            {
                nume.SendKeys(Numerator);
            }
            catch (Exception e)
            {

                throw new Exception("No elements found", e);
            }
        }
        public void Click_deno_link(string Denominator)
        {
            try
            {
                deno.SendKeys(Denominator);
            }
            catch (Exception e)
            {

                throw new Exception("No elements found", e);
            }
        }
        public void Click_Submit_Button()
        {
            try
            {
                divide.Click();
            }
            catch (Exception e)
            {

                throw new Exception("No elements found", e);
            }
        }

        public void Maximise()
        {
            Web_Drivers.Driver.Manage().Window.Maximize();
        }


    }
}
