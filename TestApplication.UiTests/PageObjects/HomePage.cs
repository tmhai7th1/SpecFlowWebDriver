using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TestApplication.UiTests.Drivers;

namespace TestApplication.UiTests.PageObjects
{
    public class HomePage : BasePage
    {
        public HomePage(WebDriver driver) : base(driver) { }

        public void GoToHomePage(string url)
        {
            webDriver.Current.Manage().Window.Maximize();
            webDriver.Current.Navigate().GoToUrl(url);
        }

        public void SelectedBoxCategory ()
        {
            var categoryIdwrp = FindsBy(By.Id("categoryId-wrp"));
            categoryIdwrp.Click();
        }

        public void SelectedCategory()
        {
            var categoryIdoption = FindsBy(By.Id("categoryId-wrp-option-9299"));
            categoryIdoption.Click();
        }

        public void EnterSearchQuery(string text)
        {
            var searchQuery = FindsBy(By.Id("search-query"));
            searchQuery.Clear();
            searchQuery.SendKeys(text);
        }

        public void EnterSearchLocation(string text)
        {
            var searchLocation = FindsBy(By.CssSelector("input#search-area"));
            searchLocation.Clear();
            searchLocation.SendKeys(text);
        }

        public void SelectedBoxSearchDistance()
        {
            var boxSearchDistance = FindsBy(By.Id("srch-radius-wrp"));
            boxSearchDistance.Click();
        }

        public void SelectedSearchDistance()
        {
            var searchDistance = FindsBy(By.Id("srch-radius-wrp-option-250"));
            searchDistance.Click();
        }

        public SearchResultPage ClickSearchButton()
        {
            var searchButton = FindsBy(By.ClassName("header__search-button"));
            searchButton.Click();
            return new SearchResultPage(webDriver);
        }
    }
}
