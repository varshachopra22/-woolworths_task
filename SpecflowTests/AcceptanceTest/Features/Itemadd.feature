Feature: SpecFlowFeature1
	In order to purchase an item
	As a customer 
	I need to search and add that item to my cart

@mytag
Scenario: Add an item to cart
	Given I have opened my browser and navigated to the URL
	And searched for books and selected first item from the listing
	When I press add to cart
	Then that item should be added to my cart
	Then that item is removed from the cart