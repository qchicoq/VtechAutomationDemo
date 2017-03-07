namespace ValtechAutomation.Web.Pages
{
    /// <summary>
    /// Class Representing the Cases Page 
    /// </summary>
    public class CasesPObject
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