Feature: MainFlow
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Publish job on job portal
	Given I navigate to application
	And I login into bravoTALENTS
	When I create new job
	And I click on ready for review button
	And I click on advertise button
	And I click on publish button
	Then The job is published on job portal

Scenario: Closed job on job portal
	Given I navigate to application
	And I login into bravoTALENTS
	When I create new job
	And I click on ready for review button
	And I click on advertise button
	And I click on publish button
	Then The job is published on job portal
	And I go back to ATS
	When I click on closed button
	Then The job is closed on job portal

Scenario: Finish job on job portal
	Given I navigate to application
	And I login into bravoTALENTS
	When I create new job
	And I click on ready for review button
	And I click on advertise button
	And I click on publish button
	Then The job is published on job portal
	And I go back to ATS
	When I click on closed button
	And I click on finish button
	Then The job is finished on job portal

Scenario: Republish job on job portal after close job
	Given I navigate to application
	And I login into bravoTALENTS
	When I create new job
	And I click on ready for review button
	And I click on advertise button
	And I click on publish button
	And I click on closed button
	And I click on publish button on the status pipeline
	Then The job is published on job portal

Scenario: Revert job description 
	Given I navigate to application
	And I login into bravoTALENTS
	When I create new job
	And I click on ready for review button
	And I click on advertise button
	And I click on publish button
	And I click on job Ad button on navigation bar
	And I edit job description
	And I click on revert change button
	Then The job description is Reverted

Scenario: Republish job on job portal after edit job description
	Given I navigate to application
	And I login into bravoTALENTS
	When I create new job
	And I click on ready for review button
	And I click on advertise button
	And I click on publish button
	And I click on view job post link
	And I click on job Ad button on navigation bar
	And I edit job description
	And I click on republish your job button
	Then The job description is republished

