## TechnicalTest Project
This project was created to be able to run web ui tests for multiple browsers with Selenium and SpecFlow. 

This project also takes a screenshot after each step and embeds the screnshot in the final report 

Configures SpecFlow to be able to easily use Selenium for WebTesting

Creating automated web tests to test an application in addition to testing the application with unit tests is a good practice. 

SpecFlow supports behavior driven development and acceptance tests driven development.

### Set up environment build project
- Install visual studio 2017
- Install Nuget
- Install the SpecFlow Visual Studio extension
- .Net core 2.1

### Important parts
#### test-appsettings.json
Browser type and url default are defined here. System supports 3 browsers such as Chrome, Explorer and Firefox, which are set value the same CHROME, IE, FIREFOX 

```
{
  "BaseUrl": "https://www.gumtree.com.au",
  "browser": "CHROME"
}

```
#### GumtreeFeature.feature
Here are the scenarios defined.
