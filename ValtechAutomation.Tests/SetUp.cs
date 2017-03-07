using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ValtechAutomation.Web;

namespace ValtechAutomation.Tests
{

    [SetUpFixture]
    public class Setup
    {
        /// <summary>
        /// Run Method Only Once before tests
        /// </summary>
        [OneTimeSetUp]
        public void Start()
        {
            TestBase.BeginSuiteExecution();
        }

        /// <summary>
        /// Run Method Only Once After tests
        /// </summary>
        [OneTimeTearDown]
        public void End()
        {
            TestBase.EndSuiteExecution();
        }
    }
}
