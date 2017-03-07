using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechAutomation.Web.Pages
{
    /// <summary>
    /// Class Representing the Contact Page 
    /// </summary>
    public class ContactPObject
    {
        [FindsBy(How = How.CssSelector, Using = ".contactcities li")]
        protected IList<IWebElement> OfficeLinkListLocator { get; set; }

        /// <summary>
        /// Gets the office count.
        /// </summary>
        /// <returns></returns>
        public int GetOfficeCount()
        {
            try
            {
                return OfficeLinkListLocator.Count;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}