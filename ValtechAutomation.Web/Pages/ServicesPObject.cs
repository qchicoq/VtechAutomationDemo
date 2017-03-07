namespace ValtechAutomation.Web.Pages
{
    /// <summary>
    /// Class Representing Services Page 
    /// </summary>
    public class ServicesPObject
    {
        HeaderVerifier _header;

        /// <summary>
        /// Gets the header text.
        /// </summary>
        /// <returns></returns>
        public string GetHeaderText()
        {
            _header = InitializeElements.OnPage<HeaderVerifier>();
            return _header.GetHeaderText();
        }
    }
}