Feature: JobList
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Follow the first job successfully
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the check box of the first job
	And I click on follow icon in the job action bar
	Then The first job should be followed

Scenario: Unfollow the first job successfully
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the check box of the first job
	And I click on follow icon in the job action bar
	And I click on unfollow icon in the job action bar
	Then The first job should be unfollowed

Scenario: Filter all follow job successfully
	Given I navigate to application
	And I login into bravoTALENTS
	When I click on Followed button
	Then All follow job is displayed in the list

Scenario: Filter job by draft successfully
	Given I navigate to application
	And I login into bravoTALENTS
	When I click on draft pipeline
	Then All draft job is displayed in the list

Scenario: Filter job by pending successfully
	Given I navigate to application
	And I login into bravoTALENTS
	When I click on pending pipeline
	Then All pending job is displayed in the list

Scenario: Filter job by published successfully
	Given I navigate to application
	And I login into bravoTALENTS
	When I click on published pipeline
	Then All published job is displayed in the list

Scenario: Filter job by closed successfully
	Given I navigate to application
	And I login into bravoTALENTS
	When I click on closed pipeline
	Then All closed job is displayed in the list

Scenario: Filter job by finished successfully
	Given I navigate to application
	And I login into bravoTALENTS
	When I click on finished pipeline
	Then All finished job is displayed in the list
