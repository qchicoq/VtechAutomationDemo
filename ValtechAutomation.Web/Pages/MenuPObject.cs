using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechAutomation.Web.Pages
{
    /// <summary>
    /// Class Representing the Right Menu
    /// </summary>
    public class MenuPObject
    {

        [FindsBy(How = How.CssSelector, Using = ".navigation__menu__item a")]
        protected IList<IWebElement> MenuItems { get; set; }

        /// <summary>
        /// Navigates to cases page.
        /// </summary>
        /// <returns></returns>
        public CasesPObject NavigateToCasesPage()
        {
            RetrieveFromListByTitle("Cases")?.Click();
            return InitializeElements.OnPage<CasesPObject>();
        }

        /// <summary>
        /// Navigates to jobs page.
        /// </summary>
        /// <returns></returns>
        public JobsPObject NavigateToJobsPage()
        {
            RetrieveFromListByTitle("Jobs")?.Click();
            return InitializeElements.OnPage<JobsPObject>();
        }

        /// <summary>
        /// Navigates to jobs page.
        /// </summary>
        /// <returns></returns>
        public ServicesPObject NavigateToServicesPage()
        {
            RetrieveFromListByTitle("Services")?.Click();
            return InitializeElements.OnPage<ServicesPObject>();
        }

        /// <summary>
        /// Retrieves element using title string from list.
        /// </summary>
        /// <param name="locator">The locator.</param>
        /// <returns></returns>
        private IWebElement RetrieveFromListByTitle(string locator)
        {
            return MenuItems.FirstOrDefault(_ => _.GetAttribute("title").Contains(locator));
        }
    }
}