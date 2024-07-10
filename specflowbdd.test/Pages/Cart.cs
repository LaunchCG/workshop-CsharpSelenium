using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specflowbdd.test.Pages
{
    public class Cart
    {
        private IWebDriver driver;

        public Cart(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void Additem()
        {
            IWebElement additemtocart = driver.FindElement(By.XPath("//*[text()='ADD TO CART']"));
            additemtocart.Click();
        }
        public void cartinfo()
        {
            IWebElement cartinfo = driver.FindElement(By.XPath("//*[@class='cart-icon']"));
            cartinfo.Click();
        }
        public void checkout()
        { 
            
            IWebElement proceedtocheckout = driver.FindElement(By.XPath("//*[text()='PROCEED TO CHECKOUT']"));
            proceedtocheckout.Click();
        }

    }
}
