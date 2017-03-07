using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ValtechAutomation.Web.Pages
{
    /// <summary>
    /// Class Representing Navigation from the Homepage
    /// </summary>
    public class HomeNavigationPObject
    {
        [FindsBy(How = How.CssSelector, Using = ".news-item__listing-link")]
        protected IWebElement LatestNewsBottomLocator { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#contacticon .hamburger__front_lang")]
        protected IWebElement ContactIcon { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#navigation-toggle-button .hamburger__front")]
        protected IWebElement MenuLink { get; set; }

        private IWebDriver _driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeNavigationPObject"/> class.
        /// </summary>
        public HomeNavigationPObject()
        {
            _driver = TestBase.Driver;
        }

        /// <summary>
        /// Navigates to latest news section on home page.
        /// </summary>
        /// <returns></returns>
        public LatestNewsPObject NavigateToLatestNews()
        {
            try
            {
                Actions actions = new Actions(_driver);
                actions.MoveToElement(LatestNewsBottomLocator);
                actions.Perform();
            }
            catch (NoSuchElementException)
            {
                
            }
            
           return InitializeElements.OnPage<LatestNewsPObject>();
        }

        /// <summary>
        /// Navigates to contact page.
        /// </summary>
        /// <returns></returns>
        public ContactPObject NavigateToContact()
        {
            ContactIcon.Click();
            return InitializeElements.OnPage<ContactPObject>();
        }

        /// <summary>
        /// Opens the menu.
        /// </summary>
        /// <returns></returns>
        public MenuPObject OpenMenu()
        {
            MenuLink.Click();
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(5));
            //Wait for menu title to show on page
            wait.Until(_ => _.FindElement(By.CssSelector(".menulist-header")).Displayed);
            return InitializeElements.OnPage<MenuPObject>();
        }
    }
}
