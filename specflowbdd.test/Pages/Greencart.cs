using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using specflowbdd.test;
using specflowbdd.test.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;



namespace specflowbdd.test.Pages
{
    
    public class Greencart
    {
        private IWebDriver driver;
        public Greencart(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void Searchvegies(string vegname)
        {
            IWebElement searchlist = driver.FindElement(By.XPath("//*[text()='GREEN']/following-sibling::*/form/input"));
            searchlist.SendKeys(vegname);
            IWebElement productdisplayed = driver.FindElement(By.XPath("//*[text()='Cauliflower - 1 Kg']"));
            Console.WriteLine(productdisplayed.Text);
            productdisplayed.Click();
         
            
            
        }


    }
          

        
        
 }

