Feature: FilterCandidate
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Search the candidate successfully
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I input tony van into the search box
	And I click on the search icon
	Then the candidate list will display the search result

Scenario: Filter candidate with Followed
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click on the Followed menu
	Then the candidate list will display the followed candidate

Scenario: Filter candidate with status Sourced
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click on the Sourced pipeline
	Then the candidate list will display the candidates have status Sourced

Scenario: Filter candidate with status Applied
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click on the Applied pipeline
	Then the candidate list will display the candidates have status Applied

Scenario: Filter candidate with status In Review
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click on the In Review pipeline
	Then the candidate list will display the candidates have status In Review

Scenario: Filter candidate with status Phone Interview
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click on the Phone Interview pipeline
	Then the candidate list will display the candidates have status Phone Interview

Scenario: Filter candidate with status On-site Interview
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click on the On-site Interview pipeline
	Then the candidate list will display the candidates have status On-site Interview

Scenario: Filter candidate with status Offer
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click on the Offer pipeline
	Then the candidate list will display the candidates have status Offer

Scenario: Filter candidate with status Hired
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click on icon right arrow pipeline
	And I click on the Hired pipeline
	Then the candidate list will display the candidates have status Hired

Scenario: Filter candidate with status Rejected
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click into Filter icon
	And I click on the checkbox Show rejected candidates
	And I click on the Rejected pipeline
	Then the candidate list will display the candidates have status Rejected

Scenario: Filter candidate by the selected job
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click into Filter icon
	And I filter the candidate with E2E job
	Then the candidate list will display the candidates has the filtered job

Scenario: Filter candidate by the selected tag
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click into Filter icon
	And I filter the candidate with the E2e tag
	Then the candidate list will display the candidates has the filtered tag
