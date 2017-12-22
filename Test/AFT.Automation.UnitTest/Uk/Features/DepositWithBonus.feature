@DepositWithBonus
Feature: DepositWithBonus

@ignore
Scenario Outline: Deposit_With_Bonus_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
	And I login using the following <LoginDetails>
	And I click the deposit link
	And I click the neteller check box
	And I click the next button
	And I provide the following <Details> depending on <Scenario>
	When I click the deposit button
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\DepositWithBonus.xlsx
Examples: 
	| Browser | QAsites | LoginDetails | Details | Scenario |

