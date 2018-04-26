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
*	The scope of the tests to be written should only concern the user interface controls on the page

## Output
*	You should design a set of BDD test scenarios that test the functionality of the controls in the application under test. 
* In completing your test please submit a pull request to the above repository.
  We are unable to accept a response to the code test in any way other than through a pull request in the repository detailed above.
  We cannot accept any form of compressed files due to information security implications. 
*	The scenarios should exist in a single feature file that you add into the solution.
*	You should implement an automated test framework that the Step Definitions you create use to exercise the user interface.
*	It should be possible to compile the solution into which you add the test framework and scenarios.
*	It should be possible to run the automated test scenarios by building a library from the solution using the SpecFlow test runner.
*	The implemented test scenarios must exit with the status of either Pass or Fail and a test report should be generated as an output of the scenarios.

## Technical Requirements
###	Requirements
*	Visual Studio Solution,
*	Solution is written C#,
*	A pull request is created in the GIT repository detailed above,
*	Selenium is used to automate the user interface of the application under test,
*	SpecFlow test runner or equivilent is used to implement the tests and tests are contained in a single feature file,

###	Focus On
*	Test Coverage,
*	Gherkin style,
*	Coding style,
*	Test data approach,
*	Design patterns and best  practices,
*	Levels of automated tests that can be implemented,
*	Locator approach.

## Timescales
###	Prototype
*	It doesn’t need to be complete, just demonstrate the concepts
###	Approximate Timescale
*	It should be possible to rough up a prototype in half a day if everything goes smoothly, don’t worry about spending ages on it but let me know how long you did spend
*	Feel free to drop areas of functionality if they are a significant time drain, the aim is a prototype not a finished product

## Follow Up Questions
1.	How long did you spend on the code test? 
4 hours

2.	What went well? 
Test was performed successfully. I was able to be prepare selenium version updates, several frameworks 
and driver configurations. I’ve also managed to separate layer of step definitions from framework implementation. 

3.	Was there anything that was attempted but was not possible to get working in the time so is not visible in the code? 
Appropriate reporting appeared to be a moderate challenge. After several attempts, with deadline in mind, I’ve managed to 
find proper solution Second challenge would be dependency injection. I was not fully pleased with the implementation direct class. 
Spring was used to combat these issues. Third challenge was extracting xPath data from page model class. 

4.	What would you do to improve it / continue development? 
I would suggest starting from point 3. From my understanding, there would be more changes further into the project. Soon after 
reaching all goals, time to value ratio of my work would become too low to proceed with the changes. 

With regards to further development, I would integrate it into automation server i.e. Jenkins. I would suggest creating suit 
of unit tests to verify exiting logic and functional tests to verify selenium.

