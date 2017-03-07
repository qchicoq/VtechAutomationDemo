using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechAutomation.Web.Pages
{
    /// <summary>
    /// Class To retrieve the H1 tag on common pages on the site
    /// </summary>
    public class HeaderVerifier
    {
        [FindsBy(How = How.CssSelector, Using = ".page-header h1")]
        protected IWebElement HeadingLocator { get; set; }

        public string GetHeaderText()
        {
            try
            {
                return HeadingLocator.Text;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}