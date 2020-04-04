Feature: GumtreeFeature
	I search for Cars, Vans & Utes
	I click on a Page Number of the pager
	I click on a random advert on this page
	I click on Images button on advert
	I cycle through all available images by clicking the right slider


@BasePage
Scenario: Verify search engine from Gumtree
	When I search Categories 'Cars & Vehicles;Cars, Vans & Utes' and Keywords 'Toyota' and Location 'Wollongong Region, NSW' and Radius '250 KM'
	And I click on page mumber of the pager
	And I click on a random advert on this page
	And I click on Images button on advert
	Then I cycle through all available images by clicking the right slider
