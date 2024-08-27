Feature: MarsQAFeature1

As a MarsQA admin user
I would like to create, edit and delete Langauge and Skill records
So that I can manage Education and Certification successfully 

@regression
Scenario: 1 create Signin page with valid credentials
	Given I logged into MarsQA successfuly
	When I logged into SignIn page successfully
	Then I navigate to Profile page successfully
	
Scenario: 2 create Langauge module with valid data
	Given I logged into MarsQA successfully
	When I add into a langauge
	When I add into a langauge level
	Then I created a new Language successfully

Scenario: 3 edit Language module with valid data
	Given I logged into MarsQA successfully
	When I navigate into a Language module
	When I update an existing '<Language>' and '<Language level>'
	Then the record should have updated '<Language>' and '<Language level>' successfully

	Examples:
	| Language      | Language level |
	| Kannada		| 
	| English		|
	| Telugu		|
	| Hindi			|

Scenario: 4 delete a Language
	Given I logged into MarsQA successfully
	When I navigate into langauge module
	When I delete an existing record
	Then the record should be deleted successfully

Scenario: 5 create Skill module with valid data
	Given I logged into MarsQA successfully
	When I add into a Skill
	When I add into a Skill level
	Then I created a new Skill successfully

Scenario: 6 edit Skill module with valid data
	Given I logged into MarsQA successfully
	When I navigate into a Skill module
	When I update an existing '<Skill>' and '<Skill level>'
	Then the record should have updated '<Skill>' and '<Skill level>' successfully

	Examples:
	| Skill         | Skill level |
	| Selenium		| 
	| C#		    |
	| OOPS		    |
	| DotNet		|
	| Java			

Scenario: 4 delete a Language
	Given I logged into MarsQA successfully
	When I navigate into langauge module
	When I delete an existing record
	Then the record should be deleted successfully






