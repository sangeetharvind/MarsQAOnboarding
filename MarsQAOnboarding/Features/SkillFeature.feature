Feature: SkillFeature

A short summary of the feature


Scenario: 1 Add skill record with valid data
	Given User logged into skills page successfully
	When Adding new <Skill> and <SkillLevel> into the record
	Then New <Skill> and <SkillLevel> are added successfully

	Examples: 
	| Skill  | SkillLevel |
	| 'C'    | 'Expert'   |

Scenario: 2 Add skill record with valid skill and invalid skill level
	Given User logged into skills page successfully
	When Adding valid <Skill> and invalid <SkillLevel> into the record
	Then User should get an error in popup

	Examples: 
	| Skill     | SkillLevel |
	| 'Spanish' | ''         |

Scenario: 3 Add skill record with invalid skill and valid skill level
	Given User logged into skills page successfully
	When Adding invalid <Skill> and valid <SkillLevel> into the record
	Then User should get an error in popup accordingly

	Examples: 
	| Skill     | SkillLevel |
	| ''		| 'Expert'   |

Scenario: 4 Add skill record with invalid skill and invalid skill level
	Given User logged into skills page successfully
	When Adding invalid <Skill> and invalid <SkillLevel> into the record
	Then User should get an error in popup accordingly

	Examples: 
	| Skill     | SkillLevel |
	| ''		| ''		 |

Scenario: 5 Update existing skill record with valid data
	Given User logged into skills page successfully
	When Update <Skill> and <SkillLevel> on an <UpdatedSkill> with <UpdatedSkillLevel> record
	Then The skill record <Skill> and <SkillLevel> on an <UpdatedSkill> with <UpdatedSkillLevel> recordshould be updated successfully

	Examples: 
	| Skill | SkillLevel | UpdatedSkill | UpdatedSkillLevel |
	| 'kannada' | 'Beginner' | 'CS++'       | 'Expert'          |

Scenario: 6 Update existing skill record with valid skill and invalid skill level
	Given User logged into skills page successfully
	When Update valid <Skill> and invalid <SkillLevel> on an <UpdatedSkill> with <UpdatedSkillLevel> existing skill record
	Then Error message should be displayed accordingly

	Examples: 
	| Skill | SkillLevel | UpdatedSkill | UpdatedSkillLevel |
	| 'C++' | 'Expert'   | 'C++'       | 'Skill Level'     |

Scenario: 7 Update existing skill record with invalid skill and valid skill level
	Given User logged into skills page successfully
	When Updating invalid <Skill> and valid <SkillLevel> on an existing <UpdatedSkill> with <UpdatedSkillLevel> skill record
	Then Error message should be display in popup

	Examples: 
	| Skill | SkillLevel | UpdatedSkill | UpdatedSkillLevel |
	| 'Selenium' | 'Intermediate' | ''           | 'Intermediate'        | 

Scenario: 8 Update existing skill record with invalid skill and invalid skill level
	Given User logged into skills page successfully
	When Update invalid <Skill> and invalid <SkillLevel> on an existing <UpdatedSkill> with <UpdatedSkillLevel>skill record
	Then Error message has to be displayed

	Examples: 
	| Skill  | SkillLevel | UpdatedSkill | UpdatedSkillLevel |
	| 'Java' | 'Expert'   | ''           | 'Skill Level'     | 
	


Scenario: 9 Delete Skill record successfully
	Given User logged into skills page successfully
	When Delete the record <Skill> on <SkillLevel> record 
	Then The record <Skill>  should be deleted successfully

	Examples: 
	| Skill | SkillLevel |
	| 'File Deleted' | 'Expert'   | 

Scenario Outline: 10 Add skill record with duplicate valid skill and valid skill level
	Given User is logged into localhost successfully
	When Adding duplicated valid <Skill> and valid <SkillLevel> to the <DuplicateSkill> with <DuplicateSkillLevel> language list
	Then User should get an duplicated error

	Examples:
	| Skill  | SkillLevel | DuplicateSkill | DuplicateSkillLevel |
	| 'java' | 'Beginner' | 'java' | 'Beginner' |
