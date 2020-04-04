using FluentAssertions;
using TechTalk.SpecFlow;
using TestApplication.UiTests.PageObjects;

namespace TestApplication.UiTests.Steps
{
    [Binding]
    public class GumtreeFeatureSteps
    {
        private readonly HomePage _homePage;
        private SearchResultPage _searchResultPage;

        public GumtreeFeatureSteps(HomePage homePage)
        {
            _homePage = homePage;
        }
        
        [When(@"I search Categories '(.*)' and Keywords '(.*)' and Location '(.*)' and Radius '(.*)'")]
        public void WhenISearchCategoriesAndKeywordsAndLocationAndRadius(string categories, string keywords, string location, string radius)
        {
            _homePage.SelectedBoxCategory();
            _homePage.SelectedCategory(categories);
            _homePage.EnterSearchQuery(keywords.Trim());
            _homePage.EnterSearchLocation(location.Trim());
            _homePage.SelectedBoxSearchDistance();
            _homePage.SelectedSearchDistance(radius);
            _searchResultPage = _homePage.ClickSearchButton();
        }
        
        [When(@"I click on page mumber of the pager")]
        public void WhenIClickOnPageMumberOfThePager()
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
        
        [When(@"I click on a random advert on this page")]
        public void WhenIClickOnARandomAdvertOnThisPage()
        {
            _searchResultPage.ClickItemTopAdResult();
        }
        
        [When(@"I click on Images button on advert")]
        public void WhenIClickOnImagesButtonOnAdvert()
        {
            _searchResultPage.ClickImagesButton();
        }
        
        [Then(@"I cycle through all available images by clicking the right slider")]
        public void ThenICycleThroughAllAvailableImagesByClickingTheRightSlider()
        {
            _searchResultPage.ClickButtonNextImage();
        }
    }
}
