# Automation

## Technical Test - Automation Specialist
The technical test consists of a coding test and a few follow-up questions. 
You can take as long as you want but we would allow at least 4 hours.

## Code Test
We need to develop automated tests to exercise the application under test.
Consideration should be given to not only implementing a running set of tests but also to test maintainability and scalability.
Implement tests at levels you feel most appropriate.

## Inputs
A simple calculator application web site has been provided as the application under test (AUT), 
this consists of a simple UI which is the end point against which automated tests are required.

The UI consists of: 2 input text fields, 1 output text field,	1 calculate button

## Assumptions
o	The scope of the tests to be written should only concern the user interface controls on the page

## Output
o	You should design a set of BDD test scenarios that test the functionality of the controls in the application under test. 
o	The scenarios should exist in a single feature file that you add into the solution.
o	You should implement an automated test framework that the Step Definitions you create use to exercise the user interface.
o	It should be possible to compile the solution into which you add the test framework and scenarios.
o	It should be possible to run the automated test scenarios by building a library from the solution using the SpecFlow test runner.
o	The implemented test scenarios must exit with the status of either Pass or Fail and a test report should be generated as an output of the scenarios.

## Technical Requirements
###	Requirements
o	Visual Studio Solution,
o	Solution is written C#,
o	A pull request is created in the GIT repository detailed above,
o	Selenium is used to automate the user interface of the application under test,
o	SpecFlow test runner is used to implement the tests and tests are contained in a single feature file,

###	Focus On
o	Test Coverage,
o	Cucumber style,
o	Coding style,
o	Test data approach,
o	Design patterns and best  practices,
o	Levels of automated tests that can be implemented,
o	Locator approach.

## Timescales
###	Prototype
o	It doesn’t need to be complete, just demonstrate the concepts
###	Approximate Timescale
o	It should be possible to rough up a prototype in half a day if everything goes smoothly, don’t worry about spending ages on it but let me know how long you did spend
o	Feel free to drop areas of functionality if they are a significant time drain, the aim is a prototype not a finished product

## Follow Up Questions
1.	How long did you spend on the code test?
2.	What went well?
3.	Was there anything that was attempted but was not possible to get working in the time so is not visible in the code?
4.	What would you do to improve it / continue development?

