using System;
using System.Configuration;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ValtechAutomation.Web
{
    /// <summary>
    /// All Test class inherits from this class
    /// Class contains Setup and Clean up methods
    /// </summary>
    [TestFixture]
    public abstract class TestBase
    {
        internal static IWebDriver Driver;
        private static Uri _siteUrl; 

        /// <summary>
        /// Starts the test case. Runs before each Test.
        /// </summary>
        [SetUp]
        protected void StartTestCase()
        {
            NavigateToSite();
        }

        /// <summary>
        /// Ends the test case. Runs after each Test.
        /// </summary>
        [TearDown]
        protected void EndTestCase()
        {
            Driver.Manage().Cookies.DeleteAllCookies();
        }

        /// <summary>
        /// Begins the suite execution.
        /// </summary>
        public static void BeginSuiteExecution()
        {
            Driver = DriverInstance.GetBrowser();
            _siteUrl = new Uri(ConfigurationManager.AppSettings.Get("AutUrl"));
            InitializeWebDriver();
        }

        /// <summary>
        /// Ends the suite execution.
        /// </summary>
        public static void EndSuiteExecution()
        {
            Driver?.Quit();
        } 
       
        /// <summary>
        /// Initializes the driver.
        /// </summary>
        private static void InitializeWebDriver()
        {
        //    Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));
           Driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(40));
            Driver.Manage().Window.Maximize();
        }
        
        /// <summary>
        /// Navigates to site.
        /// </summary>
        private static void NavigateToSite()
        {
           Driver?.Navigate().GoToUrl(_siteUrl);
        }
    }
}

