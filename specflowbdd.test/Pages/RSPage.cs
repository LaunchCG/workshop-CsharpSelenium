using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using specflowbdd.test;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using specflowbdd.test.Pages;
using OpenQA.Selenium.Chrome;


namespace specflowbdd.test.Pages
{
    class RSPage
    {
        private IWebDriver driver;

        public RSPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void ClickPracticeUrl()
        {
            var practiceUrlElement = driver.FindElement(By.XPath("//*[text()='Practice'][1]"));
            practiceUrlElement.Click();
        }
    }
}
