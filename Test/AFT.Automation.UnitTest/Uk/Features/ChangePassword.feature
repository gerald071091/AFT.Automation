@ChangePassword
Feature: ChangePassword

Scenario Outline: ChangePassword_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
	And I login using the following <LoginDetails>
	And I proceed to change password page
	And I click the change password button
	And I provide the following <Details>
	When I click the update button
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\ChangePassword.xlsx
Examples: 
	| Browser | QAsites | LoginDetails | Details | Scenario |

