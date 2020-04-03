using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TestApplication.UiTests.Drivers;
using TestApplication.UiTests.Utility;

namespace TestApplication.UiTests.PageObjects
{
    public class SearchResultPage : BasePage
    {
        public SearchResultPage(WebDriver driver) : base(driver) { }

        private List<IWebElement> lstPageNumber;
        private int countImage;
        public string GetLabelResult()
        {
            return  (new SelectElement(FindsBy(By.CssSelector("div.results-per-page-selector select")))).SelectedOption.Text;
        }

        public int GetNumbertOfMostRecentResult()
        {
            var searchResultSpage = FindsBy(By.CssSelector("section[class^='search-results-page__'] div[class*='search-results-page__main-ads-wrapper']"));
            webDriver.Current.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.TIMEWAITING);
            return searchResultSpage.FindElements(By.CssSelector("a[id^='user-ad-']")).Count;
        }

        public void ClickPageNumber2()
        {
            lstPageNumber = FindsBys(By.CssSelector("div[class='page-number-navigation'] a"));
            IWebElement element = lstPageNumber[2];
            webDriver.Wait.Until<bool>(driver =>
            {
                try
                {
                    return element.Enabled;
                }
                catch (Exception)
                {
                    return false;
                }
            });
        
            element.Click();
        }

        public void ClickPageNumber3()
        {
           IWebElement element = lstPageNumber[3];
           webDriver.Wait.Until<bool>(driver =>
                {
                    try
                    {
                        return element.Enabled;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                });

            element.Click();
        }

        public void ClickPageNumber4()
        {
            IWebElement element = lstPageNumber[4];
            webDriver.Wait.Until<bool>(driver =>
            {
                try
                {
                    return element.Enabled;
                }
                catch (Exception)
                {
                    return false;
                }
            });

            element.Click();
        }

        public void ClickItemTopAdResult()
        {
           var lstItem = FindsBys(By.CssSelector("section[class^='search-results-page__'] div[class*='panel-body--flat-panel-shadow'] a[id^='user-ad-']"));
           lstItem[3].Click();
        }

        public void ClickImagesButton()
        {
            var imagesButton = FindsBy(By.CssSelector("div[class='vip-ad-image__legend'] button"));
            string contentImage = imagesButton.Text.Trim();
            countImage = Int32.Parse(contentImage.Replace("images", "")) -1;
            imagesButton.Click();
        }

        public void ClickButtonNextImage()
        {
            var buttonNextImage = FindsBy(By.CssSelector("div[class='vip-ad-gallery__controls'] button[class$='__nav-btn--next']"));
            for (int i = 0; i < countImage; i++)
            {
                webDriver.Wait.Until<bool>(driver =>
                {
                    try
                    {
                        return buttonNextImage.Enabled;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                });
                buttonNextImage.Click();
            }
        }
    }
}
