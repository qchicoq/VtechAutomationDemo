using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechAutomation.Web.Pages
{
    /// <summary>
    /// Class Representing the latest news Section
    /// </summary>
    public class LatestNewsPObject
    {
        #region Page Elements

        [FindsBy(How = How.CssSelector, Using = ".news-post__listing-header .block-header")]
        protected IWebElement SectionLocator { get; set; }


        [FindsBy(How = How.CssSelector, Using = ".news-post__listing .bloglisting-compact")]
        protected IList<IWebElement> ListingLocator { get; set; }

        #endregion


        /// <summary>
        /// Determines whether section is displayed.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is displayed; otherwise, <c>false</c>.
        /// </returns>
        public bool IsDisplayed()
        {
            return SectionLocator.Displayed;
        }

        /// <summary>
        /// Determines whether the specified no of listing is displayed.
        /// </summary>
        /// <param name="noOfListing">The no of listing.</param>
        /// <returns>
        ///   <c>true</c> if the specified no of listing is displayed; otherwise, <c>false</c>.
        /// </returns>
        public bool IsDisplayed(int noOfListing)
        {
            return SectionLocator.Displayed && ListingLocator.Count >= noOfListing;
        }
    }
}