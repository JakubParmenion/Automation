Feature: Calculator
  As an end user
  I want a  Parmenion calculator page
  So that I can use calculator for my test!!


Scenario Outline: Verify Valid Submission
    Given I am on the Parmenion Calculator page
	When I send the "<Numerator>" Numerator "<Denominator>" Denominator 
    Then I should see the correct answer
	Examples: 
	| Numerator | Denominator |
	| 80        | 8           |  

Scenario Outline: Verify InValid Submission Validation
    Given I am on the Parmenion Calculator page
	When I send the "<Numerator>" Numerator "<Denominator>" Denominator 
    Then I should see the NaN 
	Examples: 
	| Numerator | Denominator |
	| farhan    | shaikh      |

   
