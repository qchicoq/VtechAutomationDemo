# VtechAutomationDemo
Toolset and Library Used
•	Selenium Webdriver  2.53.1
•	Selenium Support classes  2.53.1
•	NUnit 3.4.1
•	NUnit Test Adapter 3.41
•	Chromedriver
•	InternetExplorer driver
•	Sandcastle for documentation

Setup and Config
•	In the Test project, the Environment Uri can be specified under the AutUrl key
•	 url = https://www.valtech.com/
•	The required browser can be specified using the Browser key Options are 
1)	firefox
2)	ie
3)	chrome
SetUp.cs class is required to be in the same namespace as all the tests. 
Initial Build
When solution is first loaded, an internet connection is needed to restore the required libraries via nugget. Simple build should update libraries with their correct version.

Description
There are two projects in the solution. ValtechAutomation.Web and ValtechAutomation.Tests   
ValtechAutomation.Web holds the page objects, Driver instance class, Test initialization base classes and methods.
ValtechAutomation.Tests   references ValtechAutomation.Web project.
 
Page Object model used for easy maintenance, and code reuse. End user Workflow exposed as public methods from the class representing the Page. Internal DSL created for easy scripting.
Writing Tests
•	All test class inherits from the TestBase class, for setup and tear down methods reuse;
•	Scripting of a Test cases is started by calling the static property from the ValtechWeb class, which in turn returns an instance of the required page objects with its element initialized through page factory class. 
•	Public method available on this instance can then be used to mimic required end user behaviour on the Application under test.
 

More Details on Available APIs are included in the Auto generated documentation.
