Feature: JobOverview
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Filter all candidate by click on all pipeline in Overview screen 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on the all pipeline
	Then The candidate list is filter by all and job

Scenario: Filter sourced candidate by click on sourced pipeline in Overview screen 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on the sourced pipeline
	Then The candidate list is filter by sourced and job

Scenario: Filter applied candidate by click on applied pipeline in Overview screen 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on the applied pipeline
	Then The candidate list is filter by applied and job

Scenario: Filter in review candidate by click on all pipeline in Overview screen 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on the in review pipeline
	Then The candidate list is filter by in review and job

Scenario: Filter phone interview candidate by click on all pipeline in Overview screen 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on the phone interview pipeline
	Then The candidate list is filter by phone interview and job

Scenario: Filter on site interview candidate by click on all pipeline in Overview screen 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on the on site interview pipeline
	Then The candidate list is filter by on site interview and job

Scenario: Filter offer candidate by click on all pipeline in Overview screen 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on the offer pipeline
	Then The candidate list is filter by offer and job

Scenario: Filter hired candidate by click on all pipeline in Overview screen 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on the hired pipeline
	Then The candidate list is filter by hired and job

Scenario: Filter rejected candidate by click on all pipeline in Overview screen 
	Given I navigate to application
	And I login into bravoTALENTS
	When I click into the first job
	And I click on the rejected pipeline
	Then The candidate list is filter by rejected and job

