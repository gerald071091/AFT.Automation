﻿@GameHistory
Feature: GameHistory

Scenario Outline: GameHistory_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
    And I login using the following <LoginDetails>
	And I click the my account link
	And I click game history link
	And I provide the following <Details>
	When I click the submit button
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\GameHistory.xlsx
Examples: 
	| Browser | QAsites | LoginDetails | Details | Scenario |