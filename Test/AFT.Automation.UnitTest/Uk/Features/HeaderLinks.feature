@HeaderLinks
Feature: HeaderLinks

Scenario Outline: HeaderLinks_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
	When I click this header link <Details>
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\HeaderLinks.xlsx
Examples: 
	| Browser | QAsites | Details | Scenario |
