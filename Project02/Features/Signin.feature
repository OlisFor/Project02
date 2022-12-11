Feature: Signin

Customer should be able to log in with valid credentials to use the application

@tag1
Scenario: I want to be able to login with my username and passsword
	Given I navigate to the url "http://www.adactinhotelapp.com/"
	And I login with my Username and Password
	When I click on the Login button 
	Then Then i should login to the app
