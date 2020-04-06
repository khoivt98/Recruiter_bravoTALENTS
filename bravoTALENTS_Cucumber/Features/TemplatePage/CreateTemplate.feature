Feature: CreateTemplate
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Create job template
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to templates screen
	When I click on create template button
	And I enter template name
	And I select template type is job
	And I click create button
	Then The job template is created

Scenario: Create email template
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to templates screen
	When I click on create template button
	And I enter template name
	And I select template type is email
	And I click create button
	Then The email template is created

Scenario: Create interview prep template
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to templates screen
	When I click on create template button
	And I enter template name
	And I select template type is interview prep
	And I click create button
	Then The interview prep template is created
