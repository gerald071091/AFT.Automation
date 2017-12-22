@MyDetails
Feature: MyDetails

Scenario Outline: MyDetails_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
    And I login using the following <LoginDetails>
	And I click the my account link
	And I click the my details link
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\MyDetails.xlsx
Examples: 
	| Browser | QAsites | LoginDetails | Scenario |