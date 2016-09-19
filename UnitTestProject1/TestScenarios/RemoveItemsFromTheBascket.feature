Feature: RemoveItemsFromTheBasket
	In order be able to buy what I need
	As a customer who shops online
	I want to be able to remove items from my bascket 

@mytag
Scenario: Add two numbers
	Given I select 'oranges' to be added to my shopping basket
	When I am looking at the shopping basket
	Then I remove 'oranges' from my basket
	And check that the basket is empty 
