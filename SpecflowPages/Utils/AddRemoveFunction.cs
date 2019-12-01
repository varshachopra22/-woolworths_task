using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;

namespace SpecflowPages.Utils
{
    public class AddRemoveFunction
    {
        public static void Searchbooks()
        {
            //Searching for books in search box
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Driver.driver.FindElement(By.Id("gh-ac")).SendKeys("Books");
            Driver.driver.FindElement(By.Id("gh-btn")).Click();

            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.driver;
            js.ExecuteScript("window.scrollBy(0,700)");

            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            var btn = Driver.driver.FindElement(By.XPath("//li[@id='srp-river-results-listing1']//a[@class='s-item__link']"));
            btn.Click();
        }

        public static void Addtocart()
        {
            //adding item to cart
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.driver.FindElement(By.XPath("//*[@id='atcRedesignId_btn']")).Click();

        }
        public static void Removefromcart()
        {
            //click view cart
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            Driver.driver.FindElement(By.Id("vi-viewInCartBtn")).Click();
            //Removing the item from cart
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[3]/div/div/div/div[2]/div/div/div/div/div[2]/span[2]/button")).Click();
        }

        public static void Addvalidate()
        {
           
            //Validating if the item is added to the cart
            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            string ExpectedValue = "1";
            string ActualValue = Driver.driver.FindElement(By.Id("qtyTextBox")).GetAttribute("value");

            Assert.IsTrue(ExpectedValue == ActualValue, "Item added to cart: " + ActualValue);
        }

        public static void Removevalidate()
        {

            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            bool isdisplayed = Driver.driver.FindElement(By.XPath("/html/body/div[4]/div/div[3]/div/div/div[1]/span/span")).Displayed;
            Assert.IsTrue(isdisplayed, "the item is removed from cart");
    
        }
    }
}
