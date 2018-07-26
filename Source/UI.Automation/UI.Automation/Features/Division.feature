Feature: Division

Scenario Outline: Verify various division scenarios
	Given I have launched the calculator application
	When I divide <x> by <y>
	Then the result is <result>
	Examples: 
	| x   | y  | result		|
	| 4   | 2  | 2			|
	| a   | b  | NaN		|
	| 100 | 10 | 10			|
	| 0   | 10 | 0			|
	| 1   | 0  | infinity   |
	|     |    | NaN		|

