Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Login successful
	Given I navigate to application
	And I login into bravoTALENTS
	Then I should navigate to jobs page
