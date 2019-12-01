using RelevantCodes.ExtentReports;
using SpecflowPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;

namespace SpecflowTests.Utils
{
    [Binding]
    public class Start : Driver
    {
        [BeforeScenario]
        //[BeforeTestRun]
        public static void SetUp()
        {
            {
                //Launch the browser
                Initialize();
                Thread.Sleep(500);

                //Call the Login Class            
                SpecflowPages.Utils.LoginPage.LoginStep();

            }
        
        }

        [AfterScenario]
        //[AfterTestRun]
        public static void TearDown()
        {
            //Close the browser
            //Close();
        }

    }
}
