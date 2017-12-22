@Sportsbook
Feature: Sportsbook

Scenario Outline: Sportsbook_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
	When I click the sportsbook link
	Then I should see the sportsbook iframe

@Source:Source\Sportsbook.xlsx
Examples: 
	| Browser | QAsites |