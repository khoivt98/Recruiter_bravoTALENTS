Feature: JobAd
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Save job as template 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on job ad button
	And i click on save as template button
	And I click on the link in the message
	Then I navigate to template detail screen

Scenario: Remove job description 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on job ad button
	And I click on job description
	And I remove job description
	Then The missing title and description message is displayed 

Scenario: Input duplicated titles in job description 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on job ad button
	And I click on job description
	And I input duplicated titles
	Then The duplicated titles message is displayed 

Scenario: Job description smaller than 150 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on job ad button
	And I click on job description
	And I input Job description smaller than 150
	Then The job content smaller than 150 message is displayed 

Scenario: Job description missing title 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on job ad button
	And I click on job description
	And I input Job description missing title
	Then The missing title message is displayed 

Scenario: Job description missing description 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on job ad button
	And I click on job description
	And I input Job description missing description
	Then The missing description message is displayed 

Scenario: Job description missing description follow title 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on job ad button
	And I click on job description
	And I input Job description missing description follow title 
	Then The missing description follow title  message is displayed 

Scenario: Edit the job infomation with negotiable salary
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on job ad button
	And I click on the right side
	And I edit all fields in the job information 
	And I click on the negotiable checkbox
	And I click on the save button
	Then The job information is updated

Scenario: Edit the job infomation without negotiable salary
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on job ad button
	And I click on the right side
	And I edit all fields in the job information
	And I click on the negotiable checkbox
	And I input the salary
	And I click on the save button
	Then The job information is updated

Scenario: Edit apply before date
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on job ad button
	And I click on the calendar icon
	And I select date
	Then The apply before date is updated