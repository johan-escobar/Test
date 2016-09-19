Feature: CalculateBasketTotal
	In order to be able to purchase 
	As a online customer
	I want to know how much I will be paying

@mytag
Scenario: Calculate The total of one item
	Given I select 'oranges' to be added to my shopping basket
	When I am looking at the shopping basket
	Then I check the total is '25'

Scenario: Calculate The total of two items
	Given I select 'oranges' to be added to my shopping basket
	And I select 'apples' to be added to my shopping basket
	When I am looking at the shopping basket
	Then I check the total is '85'

Scenario: calculate an empty basket
	Given I try to calculate an empty basket
	When I am looking at the shopping basket
	Then I check an error message is returned