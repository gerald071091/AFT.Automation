@Withdraw
Feature: Withdraw

@ignore
Scenario Outline: Withdraw_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
    And I login using the following <LoginDetails>
	And I click the my account link
	And I click the withdraw link
	And I provide the withdraw amount <Amount>
	And I click the withdraw next button
	And I provide the following <Details>
	When I click the withraw button
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\Withdraw.xlsx
Examples: 
	| Browser | QAsites | LoginDetails | Amount | Details | Scenario |

Scenario Outline: Withdraw_Validation
	Given I am on the home page of <QAsites> and using <Browser>
    And I login using the following <LoginDetails>
	And I click the my account link
	And I click the withdraw link
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\Withdraw.xlsx
Examples: 
	| Browser | QAsites | LoginDetails | Scenario |