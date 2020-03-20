Feature: Activity
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Add Comment to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I navigate to Activity tab
	And I add Comment to the candidate with "E2E Comment"
	Then the Comment should be added with "E2E Comment"

Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Edit Comment of the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I navigate to Activity tab
	And I add Comment to the candidate with "E2E Comment"
	And I edit the added comment with " updated"
	Then the Comment should be added with "E2E Comment updated"

Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Reply Comment of the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I navigate to Activity tab
	And I reply a comment of the candidate with "E2E Reply Comment"
	Then the Reply Comment should be added with "E2E Reply Comment"

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Agree Comment of the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I navigate to Activity tab
	And I agree the comment of the candidate
	Then the Comment text should be "undo"

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Undo Agree Comment of the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I navigate to Activity tab
	And I agree the comment of the candidate
	And I undo agree the comment of the candidate
	Then the Comment text should be "Agree"

Examples: 
| FirstName | LastName  |
| e2e       | candidate |
