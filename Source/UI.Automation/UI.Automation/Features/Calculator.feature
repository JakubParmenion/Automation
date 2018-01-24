Feature: Parmenion
	Tests of Application Under Test (AUT) calculator 

Scenario Outline: Divide two numbers
	Given I have navigated to the "http://localhost:51077/" page
	And entered <dividend> and <divisor> into page fields
	When I press Divide button
	Then the resoult showed on the screen should be equal to <fraction>

	Examples: 
	| dividend             | divisor              | fraction             |
	| 4                    | 2                    | 2                    |
	| 1                    | 2                    | 0.5                  |
	| 1                    | 128                  | 0.0078125            |
	| 1                    | 1920                 | 0.000520833333333333 |
	| 2                    | 3                    | 0.666666666666667    |
	| 8                    | 3                    | 2.66666666666667     |
	| 7                    | 3                    | 2.33333333333333     |
	| -1                   | 2                    | -0.5                 |
	| 8                    | -3                   | -2.66666666666667    |
	| -2                   | -3                   | 0.666666666666667    |
	| 1                    | 0                    | ∞                    |
	| 0                    | 1                    | null                 |
	| 1                    |                      | ∞                    |
	|                      | 1                    | null                 |
	| a                    | b                    | NaN                  |
	| 1                    | b                    | NaN                  |
	| a                    | 1                    | NaN                  |
	| 1                    | 999999999999999999   | 999999999999999999   |
	| 999999999999999999   | 1                    | 0.000000000000000001 |