using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechAutomation.Web
{
    /// <summary>
    /// This class holds the Reposibility on initializing 
    /// elements declare in page objects
    /// </summary>
    public class InitializeElements
    {
        private static IWebDriver _driver;

        /// <summary>
        /// Generic method turns Page object Type
        /// with declared elements initialized using the Pagefactory class
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T OnPage<T>() where T : new()
        {
            _driver = TestBase.Driver;
            var page = new T();
            PageFactory.InitElements(_driver, page);
            return page;
        }
    }
}
