@ResponsibleGaming
Feature: ResponsibleGaming

Scenario Outline: ResponsibleGaming_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
    And I login using the following <LoginDetails>
	And I click the my account link
	And I click responsible gaming link
	And I provide the <Details> depending on <Scenario>
	When I click the <Category> submit/save button
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\ResponsibleGaming.xlsx
Examples: 
	| Browser | QAsites | LoginDetails | Details | Category | Scenario |
