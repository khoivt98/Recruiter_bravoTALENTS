Feature: Job
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Create job manually successful
	Given I navigate to application
	And I login into bravoTALENTS
	When I click Create job button
	And I enter text into job title field
	And I click on the Create from scratch button
	And I select job category
	And I select job type
	And I select position level
	And I select location
	And I click on create button
	Then I create new job successful

Scenario: Create job from template successful
	Given I navigate to application
	And I login into bravoTALENTS
	When I click Create job button
	And I enter text into job title field
	And I click on the job in the template list
	And I click on create and edit button
	Then I create new job successful

Scenario: Close the create job panel successful
	Given I navigate to application
	And I login into bravoTALENTS
	When I click Create job button
	And I click the X icon
	Then The create job panel should closed

