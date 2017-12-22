@Deposit
Feature: Deposit

@ignore
Scenario Outline: Deposit_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
	And I login using the following <LoginDetails>
	And I click the deposit link
	And I click the neteller check box
	And I click the next button
	And I provide the following <Details>
	When I click the deposit button
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\Deposit.xlsx
Examples: 
	| Browser | QAsites | LoginDetails | Details | Scenario |

Scenario Outline: Deposit_Neteller_Link
	Given I am on the home page of <QAsites> and using <Browser>
	And I login using the following <LoginDetails>
	And I click the deposit link
	And I click the neteller check box
	And I click the next button
	When I click the click here hyperlink
	Then I should see the neteller page

@source:Source\Deposit.xlsx
Examples: 
	| Browser | QAsites | LoginDetails |
