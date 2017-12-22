@ForgotPassword
Feature: ForgotPassword

Scenario Outline: ForgotPassword_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
	And I click the forgot password link
	And I provide the following <Details>
	When I click the send button
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\ForgotPassword.xlsx
Examples: 
	| Browser | QAsites | Details | Scenario |


