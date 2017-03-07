using ValtechAutomation.Web.Pages;

namespace ValtechAutomation.Web
{
    /// <summary>
    /// This class will be the entry point
    /// It is a form of factory class that will create 
    /// instances of page objects. This means scripter does 
    /// not need to know about specific class names representing pages. 
    /// </summary>
    public class ValtechWeb
    {
        /// <summary>
        /// Gets the home navigation.
        /// </summary>
        /// <value>
        /// The home navigation.
        /// </value>
        public static HomeNavigationPObject HomeNavigation
        {
            get { return InitializeElements.OnPage<HomeNavigationPObject>(); }
        }
        
    }
}
