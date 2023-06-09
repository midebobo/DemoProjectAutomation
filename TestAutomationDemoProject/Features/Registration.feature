Feature: Registration

In order to have full Functionalities of the Website
Ill have to be Registered User

@tag1
Scenario: Registration Form
	Given I navigate to the website 
	And I enter my First name 
	And I enter Lat name
	And I enter my Address
	And I enter my Email
	And I enter my Phone Number 
	And I enter my Password
	And I enter my Confirm Password 
	When I click on Submit 
	#Then I should be able to Register Successfully 
