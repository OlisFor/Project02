Feature: Registration

I should be able to register an account

@tag1
Scenario: user should be able to rgister an account
	Given I navigate to the url "http://www.adactinhotelapp.com/"
	And I click on the New User Register Here text
	And I enter my registration form field 
	| Fields           | Values                     |
	| Username         | Olis                       |
	| Password         | wordofGod1                 |
	| Confirm Password | wordofGod1                 |
	| Full Name        | Olis Fortune Nwedozie      |
	| Email Address    | akinwunmimicael2@gmail.com |
	And I enter the capthca
	And I click check on the terms/conditions
	When I click on the register button
	Then I should be logged in to the app
