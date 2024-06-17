Feature: getStudent
	In order to get the deatils of student fron valid and invalid id's

@mytag
Scenario: Get student details by valid id
	Given we have opened the Appication
	When we enter the details <name>, <age>,<branch>,<section>
	When the user provide a valid <id>
	Then the data of student will display
	Examples: 
	| id | name    | age | branch | section |
	| 1  | saurabh | 23  | CS     | A       |
	
Scenario: Get student details by invalid id
	Given we have opened the Appication
	When we enter the details <name>, <age>,<branch>,<section>
	When the user provide a invalid <id>
	Then the error will display
	Examples: 
	| id | name    | age | branch | section |
	| 3  | saurabh | 23  | CS     | A       |
	
	