Feature: SpecFlowFeature1
	In order to Add the student data nad check the duplicate data

@mytag
Scenario Outline: Add two numbers
	Given we have opened the Appication
	When we enter the details <name>, <age>,<branch>,<section>
	And we click add button
	Then the new student should be registerd into database
	Examples: 
	| name | age | branch | section |
	| saurabh| 23 |CS    |D       |
	| rajat| 27 |IT   |A      |
	
	
	
Scenario Outline: Duplicate two names
	Given we have opened the Appication
	When we enter duplicate details <name>, <age>,<branch>,<section>
	And we click add button
	Then Duplicate message error will display
	Examples: 
	| name | age | branch | section |
	| saurabh| 23 |CS    |B        |
	