using NUnit.Framework;
using ValtechAutomation.Web;
namespace ValtechAutomation.Tests.Tests
{
    /// <summary>
    /// Class Representing Navigation from Homepage
    /// </summary>
    public class NavigationTests : TestBase
    {
        /// <summary>
        /// Shoulds the display Latest news when home page is loaded.
        /// Quesiton 1
        /// </summary>
        [Test]
        public void Should_DisplayNews_WhenHomePageIsLoaded()
        {
            Assert.That(ValtechWeb
                .HomeNavigation
                .NavigateToLatestNews()
                .IsDisplayed(), "Latest News Section is not displayed");
        }

        /// <summary>
        /// Shoulds the display correct no of news when home page is loaded.
        /// Question 1
        /// </summary>
        [Test]
        public void Should_DisplayCorrectNoOfNews_WhenHomePageIsLoaded()
        {
            Assert.That(ValtechWeb
                .HomeNavigation
                .NavigateToLatestNews()
                .IsDisplayed(3), "No of listing is incorrect");
        }

        /// <summary>
        /// Should the display correct h1 title when cases page is loaded.
        /// Question 2
        /// </summary>
        [Test]
        public void Should_DisplayCorrectH1Title_WhenCasesPageIsLoaded()
        {
            Assert.That(ValtechWeb
                .HomeNavigation
                .OpenMenu()
                .NavigateToCasesPage()
                .GetHeaderText()
                .Contains("Cases"), "Wrong title is diplayed for Cases Page");
        }

        /// <summary>
        /// Shoulds the display correct h1 title when services page is loaded.
        /// Question 2
        /// </summary>
        [Test]
        public void Should_DisplayCorrectH1Title_WhenServicesPageIsLoaded()
        {
            Assert.AreEqual("Services", ValtechWeb
                .HomeNavigation
                .OpenMenu()
                .NavigateToServicesPage()
                .GetHeaderText()
                , "Wrong title is diplayed for Services Page");
        }

        /// <summary>
        /// Shoulds the display correct h1 title when jobs page is loaded.
        /// Question 2
        /// </summary>
        [Test]
        public void Should_DisplayCorrectH1Title_WhenJobsPageIsLoaded()
        {
            Assert.That(ValtechWeb
                .HomeNavigation
                .OpenMenu()
                .NavigateToJobsPage()
                .GetHeaderText()
                .Contains("Jobs"), "Wrong title is diplayed for Jobs Page");
        }

        /// <summary>
        /// Shoulds the display correct no of offices when contact page is loaded.
        /// Question 3
        /// </summary>
        [Test]
        public void Should_DisplayCorrectNoOfOffices_WhenContactPageIsLoaded()
        {
            Assert.AreEqual(30, ValtechWeb
                .HomeNavigation
                .NavigateToContact()
                .GetOfficeCount(), "Wrong No of Offices is diplayed");
        }

    }
}
