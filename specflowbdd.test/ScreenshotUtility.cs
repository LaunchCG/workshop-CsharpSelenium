using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Chrome;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using OpenQA.Selenium.Support.Extensions;

namespace specflowbdd.test
{
    public class ScreenshotUtility
    {
        
        public void TakesScreenshot(IWebDriver driver)
        {
           
            try
            {


                ITakesScreenshot screenshotDriver = ((ITakesScreenshot)driver);

                Screenshot screenshot = screenshotDriver.GetScreenshot();

                
                string filepath = @"C:\Users\PrathyushaGoriparthi\source\repos\screenshots\Error_"+ DateTime.Now.ToString().Replace("/", "_").Replace(":", "_").Replace(" ", "_") + ".Png";

                screenshot.SaveAsFile(filepath);
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred while taking screenshot: {e.Message}");
            }



        }
    }
}
