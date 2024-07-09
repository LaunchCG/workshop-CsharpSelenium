Feature: Mart
Purchase Items from Greenkart
@BDDframework
Scenario: Vegetables
	Given I open the browser and enter url
	Given I click on practicepage
	Given Enter
		| name       | mail     |
		| prathyusha | prathyusha.goriparthi9@gmail.com |
	Given click on Submit button
	Given click on practice1
	Then open Greenkart page