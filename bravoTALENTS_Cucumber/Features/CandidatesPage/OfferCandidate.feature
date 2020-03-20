Feature: OfferCandidate
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


Scenario Outline: Create an offer with send email to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Offer tab
	And I create an offer to the candidate with Salary is "999" and Report to "E2E@mailinator.com"
	And I send email offer to the candidate
	Then the offer should be created successfully and Email Offer button is not displayed

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Create an offer without send email to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Offer tab
	And I create an offer without send email to the candidate with Salary is "999" and Report to "E2E@mailinator.com"
	Then the offer should be created successfully and Email Offer button is displayed

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Update status accepted to the offer of the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Offer tab
	And I create an offer without send email to the candidate with Salary is "999" and Report to "E2E@mailinator.com"
	And I update status offer to Accepted with the comment "Accept"
	Then the status offer should be Accepted

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Update status rejected to the offer of the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Offer tab
	And I create an offer without send email to the candidate with Salary is "999" and Report to "E2E@mailinator.com"
	And I update status offer to Rejected with the comment "Reject"
	Then the status offer should be Rejected

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Update offer of the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Offer tab
	And I create an offer without send email to the candidate with Salary is "999" and Report to "E2E@mailinator.com"
	And I update offer of the candidate with the salary is "9999"
	Then the offer should be upgrade with salary is "9,999"

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Send email offer after creating an offer to the candidate
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Offer tab
	And I create an offer without send email to the candidate with Salary is "999" and Report to "E2E@mailinator.com"
	And I click on Email Offer button
	And I send email offer to the candidate
	Then the offer should be sent to the candidate and Email Offer button is not displayed

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Update result of the offer from Accepted to Rejected
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Offer tab
	And I create an offer without send email to the candidate with Salary is "999" and Report to "E2E@mailinator.com"
	And I update status offer to Accepted with the comment "Accept"
	And I update the result of the offer from Accepted to Rejected with the comment "Reject"
	Then the status offer should be Rejected

Examples: 
| FirstName | LastName  |
| e2e       | candidate |

Scenario Outline: Update result of the offer from Rejected to Accepted
	Given I navigate to application
	And I login into bravoTALENTS
	And I navigate to Candidate screen
	And I change candidate mode to All
	And I click on Add candidate button
	And I create candidate with <FirstName> and <LastName>
	And I click on the first candidate row
	And I add an application to the candidate
	And I click on View CV
	And I navigate to Offer tab
	And I create an offer without send email to the candidate with Salary is "999" and Report to "E2E@mailinator.com"
	And I update status offer to Rejected with the comment "Reject"
	And I update the result of the offer from Rejected to Accepted with the comment "Accept"
	Then the status offer should be Accepted

Examples: 
| FirstName | LastName  |
| e2e       | candidate |
