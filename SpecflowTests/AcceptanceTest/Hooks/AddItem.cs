using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest.Hooks.Add
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have opened my browser and navigated to the URL")]
        public void GivenIHaveOpenedMyBrowserAndNavigatedToTheURL()
        {
            SpecflowPages.Utils.LoginPage.LoginStep();
            SpecflowPages.Driver.NavigateUrl();
        }


        [Given(@"searched for books and selected first item from the listing")]
        public void GivenSearchedForBooksAndSelectedFirstItemFromTheListing()
        {
            SpecflowPages.Utils.AddRemoveFunction.Searchbooks();
        }
           
        
        [When(@"I press add to cart")]
        public void WhenIPressAddToCart()
        {
            SpecflowPages.Utils.AddRemoveFunction.Addtocart();

            Driver.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            //closing the checkout window
            System.Windows.Forms.SendKeys.SendWait("{ESC}");
            
        }
        
        [Then(@"that item should be added to my cart")]
        public void ThenThatItemShouldBeAddedToMyCart()
        {
            SpecflowPages.Utils.AddRemoveFunction.Addvalidate();

                                              
        }

        [Then(@"that item is removed from the cart")]
        public void ThenThatItemIsRemovedFromTheCart()
        {
            SpecflowPages.Utils.AddRemoveFunction.Removefromcart();
            SpecflowPages.Utils.AddRemoveFunction.Removevalidate();
        }


    }
}
