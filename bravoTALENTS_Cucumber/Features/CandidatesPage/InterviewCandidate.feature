Feature: InterviewCandidate
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Scenario Outline: Schedule an interview to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Interview tab
	And I schedule an interview to the candidate with the interviewer is "E2E@mailinator.com"
	Then the interview should be scheduled successfully

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Update status passed for the interview of the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Interview tab
	And I schedule an interview to the candidate with the interviewer is "E2E@mailinator.com"
	And I navigate to the detail of the interview
	And I update status of the interview to Passed with the comment is "Good"
	Then the status of the interviewe should be Passed with the comment is "Good"

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Update status failed for the interview of the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Interview tab
	And I schedule an interview to the candidate with the interviewer is "E2E@mailinator.com"
	And I navigate to the detail of the interview
	And I update status of the interview to Failed with the comment is "Bad"
	Then the status of the interviewe should be Failed with the comment is "Bad"

Examples: 
| FirstName | LastName  |
| e2e       | candidate |


Scenario Outline: Update result from passed to failed for the interview of the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Interview tab
	And I schedule an interview to the candidate with the interviewer is "E2E@mailinator.com"
	And I navigate to the detail of the interview
	And I update status of the interview to Passed with the comment is "Good"
	And I update the result of the interview from Passed to Failed with the ccomment is "Bad"
	Then the status of the interviewe should be Failed with the comment is "Bad"

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Update result from failed to passed for the interview of the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Interview tab
	And I schedule an interview to the candidate with the interviewer is "E2E@mailinator.com"
	And I navigate to the detail of the interview
	And I update status of the interview to Failed with the comment is "Bad"
	And I update the result of the interview from Failed to Passed with the ccomment is "Good"
	Then the status of the interviewe should be Passed with the comment is "Good"

Examples: 
| FirstName | LastName  |
| e2e       | candidate |