Feature: GumtreeFeature
	I search for Cars, Vans & Utes
	I click on a Page Number of the pager
	I click on a random advert on this page
	I click on Images button on advert
	I cycle through all available images by clicking the right slider

@Browser_Firefox
@BasePage
Scenario: Verify search engine from Gumtree
	Given I go on Gumtree website
	When I search on Gumtree
	And I click on Page Number of the pager
	And I click  on a random advert on this page
	And I click  on Images button on advert
	Then I cycle through all available images by clicking the right  slider
