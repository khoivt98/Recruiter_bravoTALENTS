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

Scenario: Create job from templates successful
	Given I navigate to application
	And I login into bravoTALENTS
	When I click Create job button
	And I enter text into job title field
	And I click on the job in the template list
	And I click on create and edit button
	Then I create new job from library successful 

Scenario: Create job from previous jobs successful
	Given I navigate to application
	And I login into bravoTALENTS
	When I click Create job button
	And I enter text into job title field
	And I click on the job in the previous jobs list
	And I click on create and edit button
	Then I create new job from library successful 

Scenario: Close the create job panel successful by using X icon
	Given I navigate to application
	And I login into bravoTALENTS
	When I click Create job button
	And I click the X icon
	Then The create job panel should closed

Scenario: Close the create job manually panel successful by using X icon
	Given I navigate to application
	And I login into bravoTALENTS
	When I click Create job button
	And I enter text into job title field
	And I click on the Create from scratch button
	And I click the X icon in the create job manually panel
	Then The create job manually panel should closed

Scenario: Close the create job and review job panel successful by using X icon
	Given I navigate to application
	And I login into bravoTALENTS
	When I click Create job button
	And I enter text into job title field
	And I click on the job in the template list
	And I click the X icon in the create job and review job panel
	Then The create job and review job panel should closed

Scenario: Close the create job manually panel successful by using cancel button
	Given I navigate to application
	And I login into bravoTALENTS
	When I click Create job button
	And I enter text into job title field
	And I click on the Create from scratch button
	And I click the cancel button in the create job manually panel
	Then The create job manually panel should closed

Scenario: Close the create job and review job panel successful by using cancel button
	Given I navigate to application
	And I login into bravoTALENTS
	When I click Create job button
	And I enter text into job title field
	And I click on the job in the template list
	And I click the cancel button in the create job and review job panel
	Then The create job and review job panel should closed

Scenario: The data in review panel is changed when I click on another job in template list
	Given I navigate to application
	And I login into bravoTALENTS
	When I click Create job button
	And I enter text into job title field
	And I click on the job in the template list
	Then The job title in list and preview panel is equal
