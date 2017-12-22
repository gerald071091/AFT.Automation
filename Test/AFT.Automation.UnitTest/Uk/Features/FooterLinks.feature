@FooterLinks
Feature: FooterLinks

Scenario Outline: FooterLinks_Scenario
	Given I am on the home page of <QAsites> and using <Browser>
	When I click this footer link <Link>
	Then I should see a message, redirect to another page, or see a details depending on <Scenario>

@source:Source\FooterLinks.xlsx
Examples: 
	| Browser | QAsites | Link | Scenario |