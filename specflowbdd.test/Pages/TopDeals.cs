using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using specflowbdd.test;
using specflowbdd.test.Pages;


namespace specflowbdd.test.Pages
{
    
    public class TopDeals
    {
        private IWebDriver driver;
        public TopDeals(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
