Feature: AddingItemsToTheBascket
	In order to buy oranges
	As a online customer
	I want to be able to add items to my shopping cart

@mytag
Scenario: Add an item to the bascket
	Given I select 'oranges' to be added to my shopping basket
	When I am looking at the shopping basket
	Then I can see that 'oranges' are added to my basket

	Scenario: Add two of the same item to the basket
	Given I select 'oranges' twice to be added to my shopping cart
	When I am looking at the shopping basket
	Then I can see that 'oranges' are added to my basket

	Scenario: Add an fruit not available 
	Given I a request is made for a fruit that is not in stock
	When I am looking at the shopping basket
	Then I can see that the unavailable item was not added to the sopping cart


