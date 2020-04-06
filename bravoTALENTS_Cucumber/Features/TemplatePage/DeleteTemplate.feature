Feature: DeleteTemplate
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Delete template with checkbox
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to templates screen
	When I click on create template button
	And I enter template name
	And I select template type is job
	And I click create button
	Then The job template is created
	When I back to template list
	And I show deleted templates
	And I click into the check box of the first template
	And I click on delete icon 
	Then The first template should be deleted

Scenario: Delete template in quick card
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to templates screen
	When I click on create template button
	And I enter template name
	And I select template type is job
	And I click create button
	Then The job template is created
	When I click on quick card button
	And I click into the delete template button
	Then The template should be deleted

Scenario: Delete template in template detail
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to templates screen
	When I click on create template button
	And I enter template name
	And I select template type is job
	And I click create button
	Then The job template is created
	When I click into the delete template button in template detail
	Then The template should be deleted in template detail