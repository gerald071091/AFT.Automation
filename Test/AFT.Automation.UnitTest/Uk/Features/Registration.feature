@Registration
Feature: Registration

Scenario Outline: Registration_Url_Verification
	Given I am on the home page of <QAsites> and using <Browser>
	When I click the join now button
	Then I should see the registration page

@source:Source\Registration.xlsx
Examples: 
	| Browser | QAsites |

Scenario Outline: Registration_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
	And I click the join now button
	And I provide the <Details> depending on <Scenario>
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\Registration.xlsx
Examples: 
	| Browser | QAsites | Details | Scenario |