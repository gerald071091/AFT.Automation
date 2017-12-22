@Login
Feature: Login

Scenario Outline: Login_scenario
	Given I am on the home page of <QAsites> and using <Browser>
	And I enter my Username using <Username>
	And I enter my password using <Password>
	When I click the login button
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\login.xlsx
Examples: 
	| Username | Password | Scenario | Browser | QAsites |
