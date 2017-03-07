using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace ValtechAutomation.Web
{
    /// <summary>
    /// This class has the method to return an instance of driver specified 
    /// in the app.config file
    /// </summary>
    public class DriverInstance
    {
        /// <summary>
        /// Gets the required browser.
        /// </summary>
        /// <returns></returns>
        public static IWebDriver GetBrowser()
        {
            var requiredBrowser = ConfigurationManager.AppSettings.Get("Browser").ToLower();
            switch (requiredBrowser)
            {
                case "ie":
                    return new InternetExplorerDriver();
                case "firefox":
                    return new FirefoxDriver();
                case "chrome":
                    return new ChromeDriver();
            }
            return new FirefoxDriver();
        }

    }
}
