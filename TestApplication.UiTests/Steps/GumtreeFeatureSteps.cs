using FluentAssertions;
using System;
using TechTalk.SpecFlow;
using TestApplication.UiTests.PageObjects;

namespace TestApplication.UiTests
{
    [Binding]
    public class GumtreeFeatureSteps
    {
        private readonly HomePage _homePage;
        private  SearchResultPage _searchResultPage;
        public GumtreeFeatureSteps(HomePage homePage)
        {
            _homePage = homePage;
        }

        [Given(@"I go on Gumtree website")]
        public void GivenIGoOnGumtreeWebsite()
        {
            _homePage.GoToHomePage("https://www.gumtree.com.au");

        }
        
        [When(@"I search on Gumtree")]
        public void WhenISearchOnGumtree()
        {
            _homePage.SelectedBoxCategory();
            _homePage.SelectedCategory();
            _homePage.EnterSearchQuery("Toyota");
            _homePage.EnterSearchLocation("Wollongong Region, NSW");
            _homePage.SelectedBoxSearchDistance();
            _homePage.SelectedSearchDistance();
            _searchResultPage = _homePage.ClickSearchButton();
        }
        
        [When(@"I click on Page Number of the pager")]
        public void WhenIClickOnPageNumberOfThePager()
        {
            string contentLabel = _searchResultPage.GetLabelResult();
            contentLabel.Should().Contain(_searchResultPage.GetNumbertOfMostRecentResult().ToString());
            _searchResultPage.ClickPageNumber2();
            contentLabel.Should().Contain(_searchResultPage.GetNumbertOfMostRecentResult().ToString());
            _searchResultPage.ClickPageNumber3();
            contentLabel.Should().Contain(_searchResultPage.GetNumbertOfMostRecentResult().ToString());
            _searchResultPage.ClickPageNumber4();
            contentLabel.Should().Contain(_searchResultPage.GetNumbertOfMostRecentResult().ToString());
        }
        
        [When(@"I click  on a random advert on this page")]
        public void WhenIClickOnARandomAdvertOnThisPage()
        {
            _searchResultPage.ClickItemTopAdResult();
        }
        
        [When(@"I click  on Images button on advert")]
        public void WhenIClickOnImagesButtonOnAdvert()
        {
            _searchResultPage.ClickImagesButton();
        }
        
        [Then(@"I cycle through all available images by clicking the right  slider")]
        public void ThenICycleThroughAllAvailableImagesByClickingTheRightSlider()
        {
            _searchResultPage.ClickButtonNextImage();
        }
    }
}
