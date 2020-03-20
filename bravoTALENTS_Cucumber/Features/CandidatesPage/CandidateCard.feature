Feature: CandidateCard
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Edit info of the first candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I click on the first candidate row
	And I click on the Edit Info button
	And I edit information of candidate with <Mobile> and <Gender> and <Martial Status> and <City>
	And I click on Save Edit Info button
	Then the info of candidate should be updated <Mobile> and <Gender> and <Martial Status> and <City>
Examples: 
| FirstName | LastName  | Mobile     | Gender | Martial Status | City |
| e2e       | candidate | 1234567890 | Male   | Single         | HCM  |


Scenario Outline: Add a attachment into the first candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I upload a attachment into the candidate	
	Then the uploaded attachement should be displayed
Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Add a tag into the first candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add a tag "E2e" into the candidate
	Then the tag "E2e" should be displayed
Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Change status of the candidate to Applied
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I change the status to Applied
	And I close the candidate card panel
	Then the status of the candidate should be "Applied"
Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Change status of the candidate to In Review
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I change the status to In Review
	And I close the candidate card panel
	Then the status of the candidate should be "In Review"
Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Change status of the candidate to Phone Interview
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I change the status to Phone Interview
	And I close the candidate card panel
	Then the status of the candidate should be "Phone Interview"
Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Change status of the candidate to On-site Interview
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I change the status to On-site Interview
	And I close the candidate card panel
	Then the status of the candidate should be "On-site Interview"
Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Change status of the candidate to Offer
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I change the status to Offer
	And I close the candidate card panel
	Then the status of the candidate should be "Offer"
Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Change status of the candidate to Hired
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I change the status to Hired
	And I close the candidate card panel
	Then the status of the candidate should be "Hired"
Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Reject the first candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I reject the candidate
	Then the message "This candidate has been rejected." should be displayed 
Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: Undo Reject the first candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I reject the candidate
	And I undo reject the candidate
	Then the candidate should be undo rejected successfully
Examples: 
| FirstName | LastName  |
| e2e       | candidate | 

Scenario Outline: View job of the first candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on the View Job link
	Then the job of the candidate should be displayed
Examples: 
| FirstName | LastName  |
| e2e       | candidate |
