@Casino
Feature: Casino

Scenario Outline: Casino_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
	When I click the casino link
	Then I should see the casino page with game category listing

@Source:Source\Casino.xlsx
Examples: 
	| Browser | QAsites |