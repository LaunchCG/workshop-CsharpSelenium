using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using specflowbdd.test.Pages;
using TechTalk.SpecFlow;
using specflowbdd.test;
using OpenQA.Selenium.Interactions;


namespace specflowbdd.test.Stepdefinition
{
    [Binding]
    public class Step
    {
        private readonly ScenarioContext _scenarioContext;
        private IWebDriver driver;
       
        private RSPage rspage;
        private Practice practice;
        private Greencart greencart;
        private TopDeals topdeals;
        public string filepath;
        private ScreenshotUtility Sutility;

        public Step(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }
        
        [Given(@"I open the browser and enter url")]
        public void Giveniopenthebrowserandenterurl()
        {
            
            //string chromeDriverPath = @"C:\Users\PrathyushaGoriparthi\source\repos\specflowbdd.test\specflowbdd.test\bin\Debug\net8.0";
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/");
            rspage = new RSPage(driver);
            practice = new Practice(driver);
            greencart = new Greencart(driver);
            topdeals = new TopDeals(driver);
        }
        
        [Given(@"I click on practicepage")]
        public void AndIClickOnPracticePage()
        {
            rspage.ClickPracticeUrl();
        }
     
        [Given(@"Enter")]
        public void AndEnterNameEmail(Table table)
        {
            foreach (var row in table.Rows)
            {
                var name = row["name"];
                var mail = row["mail"];
                practice.EnterNameEmail(name, mail);
            }
        }
        
        [Given(@"click on Submit button")]
        public void AndClickSubmit()
        {
            practice.ClickSubmit();
        }

        [Given(@"click on practice1")]
        public void AndClickOnPractice1()
        {
            GenericUtility.SimpleWaitOf10Sec(driver);
            practice.ClickPractice1();
           //Sutility.TakesScreenshot(driver);
        }
        
        [Then(@"open Greenkart page")]
        public void ThenOpenGreenkartPage()
        { 
            driver.Manage().Window.Maximize();
            greencart.Searchvegies("Cauliflower");
            Sutility.TakesScreenshot(driver);


            Assert.IsTrue(driver.Title.Contains("Greencart"));
                Console.WriteLine(driver.Title);
         }
        [TearDown]
        public void TearDown()
        {
            // Close the browser after each scenario
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
            }
        }

    }
}
