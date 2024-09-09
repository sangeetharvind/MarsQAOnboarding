Feature: SkillFeature

A short summary of the feature

@Order1
Scenario: Add skill record with valid data
	Given User logged into skill page successfully
	When Adding new '<Skill>' and '<Skill level>' into the record
	Then New '<Skill>' and '<Skill level>' are added successfully

	Examples: 
	| Skill | Skill Level        |
	|       | Expert             |
	|       | Choose Skill level |
	| 3qr&& | Intermediate       |
	| C#    | Choose Skill Level |
	|       | Beginner           |

@Order2
Scenario: Update existing skill record with valid data
	Given User logged into skill page successfully
	When Update '<Skill>' and '<Skill level>' on an existing skill record
	Then The skill record '<Skill>' and '<Skill level>' should be updated successfully

	Examples: 
	| Skill | Skill Level |
	|       | Beginner    |
	|       | Skill level |

@Order3
Scenario: Delete Skill record successfully
	Given User logged into skill page successfully
	When Delete the record '<Skill>' and '<Skill level>'
	Then The record '<Skill>' and '<Skill level>' should be deleted successfully

	Examples: 
	| Skill      | Skill Level |
	| Salesforce | Beginner    |
