Feature: Candidate
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add a new candidate successfully
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	Then the created candidate will be displayed in the candidate list
Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Follow the first candidate successfully
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the checkbox of the first candidate
	And I click on follow icon
	Then the candidate should be followed
Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Unfollow the first candidate successfully
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the checkbox of the first candidate
	And I click on follow icon
	And I click on the checkbox of the first candidate
	And I click on unfollow icon
	Then the candidate should be unfollowed
Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Add an application into the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the checkbox of the first candidate
	And I add an application Accountant into the candidate
	Then the candidate is added the selected application
Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario: Import candidate file successfully
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click into the Import Candidate
	And I import the CSV file from my computer
	Then the candidates from the file should be imported successfully



