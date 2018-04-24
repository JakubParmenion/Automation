Feature: TestFeature


Scenario Outline: Division Calculation
	Given I am on the Parmenion Calculator Page
	When I enter two numbers <Numerator> and <Denominator>
	And perform the division
	Then I should expect the result to be <Result>
	Examples: 
	| Numerator | Denominator | Result   |
	| 10        | 2           | 5        |
	| 1         | 1           | 1        |
	| 1         | 0           | infinity |
	| abc       | abc         | NaN      |