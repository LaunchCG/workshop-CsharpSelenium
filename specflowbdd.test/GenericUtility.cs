using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using specflowbdd.test;
using specflowbdd.test.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Configuration;


namespace specflowbdd.test
{
    public class GenericUtility
    {
        public static void KillObjectInstances(string ProcessName)
        {
            Process[] myAllProcesses = Process.GetProcessesByName(ProcessName);
            if (myAllProcesses.Count() != 0)
            {
                foreach (Process objProcess in myAllProcesses)
                {
                    try
                    {
                        objProcess.Kill();
                    }

                    catch { }
                }
            }
            myAllProcesses = null;
        }

        public static void WaitForHTMLPageToLoad(IWebDriver webDriver)
        {
            IWait<IWebDriver> wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(30.00));
            wait.Until(driver1 => ((IJavaScriptExecutor)webDriver).ExecuteScript("return document.readyState").Equals("complete"));
        }

        public static void SimpleWaitOf10Sec(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        public static void SimpleWaitOf2Sec(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }
    }
}

