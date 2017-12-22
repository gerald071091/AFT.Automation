@MyBonuses
Feature: MyBonuses

Scenario Outline: MyBonuses_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
    And I login using the following <LoginDetails>
	And I click the my account link
	And I click the my bonuses link
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\MyBonuses.xlsx
Examples: 
	| Browser | QAsites | LoginDetails | Scenario |