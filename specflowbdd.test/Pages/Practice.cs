using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using specflowbdd.test;
using specflowbdd.test.Pages;


namespace specflowbdd.test.Pages
{
    public class Practice
    {
        private IWebDriver driver;

        public Practice(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void EnterNameEmail(string name, string email)
        {
            var nameElement = driver.FindElement(By.XPath("//*[@id='name']"));
            var emailElement = driver.FindElement(By.XPath("//*[@id='email']"));
            nameElement.SendKeys(name);
            emailElement.SendKeys(email);
        }

        public void ClickSubmit()
        {
            var submitElement = driver.FindElement(By.XPath("//*[@id='form-submit']"));
            submitElement.Click();
        }

        public void ClickPractice1()
        {
            IWebElement practice1Element = driver.FindElement(By.XPath("//*[text()='Automation Practise - 1']"));
            practice1Element.Click();
        }
    }
}

