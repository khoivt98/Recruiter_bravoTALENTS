Feature: CVCandidate
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Add Summary to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I add Summary with "E2E Summary"
	Then the summary should be added with "E2E Summary"

Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Add Work Experience to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I add Work Experience to the candidate with Company is "E2E" and Position is "E2E Work Experience"
	Then the Title of added item should be "E2E Work Experience"

Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Add Education to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I add Educations with Name Of School is "E2E Education"
	Then the Title of added item should be "E2E Education"

Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Add Language Skill to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I add Language Skill with Language Name is "E2E Language"
	Then the Title of added item should be "E2E Language"

Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Add Project to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I add Project with Project Name is "E2E Project"
	Then the Title of added item should be "E2E Project"

Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Add Course to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I add Course with Course Name is "E2E Course"
	Then the Title of added item should be "E2E Course"

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Add Certification to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I add Certification with Certification Name is "E2E Certification"
	Then the Title of added item should be "E2E Certification"

Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Add Reference to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I add Reference with Full Name is "E2E Reference" and Email is "E2E@mailinator.com" and Phone is "0123456789"
	Then the Title of added item should be "E2E Reference"

Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Edit Work Experience to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I add Work Experience to the candidate with Company is "E2E Work Experience" and Position is "E2E Work Experience"
	And I edit the added Work Experience with Company is "E2E Work Experience updated" and Position is "E2E Work Experience updated"
	Then the Title of added item should be "E2E Work Experience updated"

Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Remove Work Experience to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I click on View CV
	And I add Work Experience to the candidate with Company is "E2E" and Position is "E2E Work Experience"
	And I remove the added Work Experience
	Then the Work Experience should be removed

Examples: 
| FirstName | LastName  |
| e2e       | candidate | 




