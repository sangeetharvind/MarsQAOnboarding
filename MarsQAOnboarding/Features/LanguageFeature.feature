Feature: LanguageFeature

A short summary of the feature


Scenario Outline: 1 Add language record with valid data
	Given User is logged into localhost successfully
	When Adding new <Language> and <LanguageLevel> to the language list
	Then New record with <Language> and <LanguageLevel> are added successfully

	Examples:
	| Language  | LanguageLevel    |
	| 'Kannada' | 'Conversational' |
	| 'Telugu'  | 'Fluent'         |

Scenario Outline: 2 Add language record with valid langauge and invalid language level
	Given User is logged into localhost successfully
	When Adding valid <Language> and invalid <LanguageLevel> to the language list
	Then User should get an error

	Examples:
	| Language                   | LanguageLevel |
	| 'Telugu'                   | ''            |
	

Scenario Outline: 3 Add language record with invalid langauge and valid language level
	Given User is logged into localhost successfully
	When Adding invalid <Language> and valid <LanguageLevel> to the language list
	Then User should have an error

	Examples:
	| Language                   | LanguageLevel |
	| ''                         | 'Basic'       |

Scenario Outline: 4 Add language record with invalid langauge and invalid language level
	Given User is logged into localhost successfully
	When Adding invalid <Language> and invalid <LanguageLevel> to the language list
	Then User should get an error popup

	Examples:
	| Language | LanguageLevel |
	| ''       | ''            |

Scenario Outline: 5 Add language record with duplicate valid langauge and valid language level
	Given User is logged into localhost successfully
	When Adding duplicate valid <Language> and valid <LanguageLevel> to the language list
	Then User should get an duplicate error

	Examples:
	| Language | LanguageLevel |
	| 'Telugu'       | 'Basic'            |

	
Scenario Outline: 6 Update existing language record with valid data
	Given User is logged into localhost successfully
	When Update <Language> and <LanguageLevel> on an existing language record
	Then the record with <Language> and <LanguageLevel> should update successfully

	Examples: 
	| Language | LanguageLevel |
	| 'tamil'  | 'Fluent'      |

Scenario Outline:7 Update existing language record with valid language and invalid language level
	Given User is logged into localhost successfully
	When Update valid <Language> and invalid <LanguageLevel> on an existing language record
	Then User should get an error system cannot accept record with valid language and invalid language level

	Examples: 
	| Language					 | LanguageLevel    |
	| 'tamil'					 | 'Language Level' |
	

Scenario Outline: 8 Update language record with invalid language and valid language level
	Given User is logged into localhost successfully
	When Updating invalid <Language> and valid <LanguageLevel> to the languages list
	Then User should have a error system cannot accept record with invalid language and valid language level

	Examples:
	| Language		| LanguageLevel |
	| ''	        | 'Fluent'      |

Scenario Outline: 9 Update language record with invalid language and invalid language level
	Given User is logged into localhost successfully
	When Updating invalids <Language> and invalid <LanguageLevel> to the languages list
	Then User should get a error popups system cannot accept record with invalid language and invalid language level

	Examples:
	| Language	| LanguageLevel       |
	| ''        | 'Language Level'    |
	
Scenario Outline: 10 Delete the language record from the language list
	Given User is logged into localhost successfully
	When Delete the <Language> record
	Then The record <Language> should be deleted successfully

	Examples: 
	| Language | LanguageLevel>  |
	|  'french' | 'Fluent'       |

Scenario Outline: 11 After adding four languages record with data
	Given User is logged into localhost successfully
	When After adding four new <Language> and <LanguageLevel> to the language list
	Then User should not be able to add new record

	Examples:
	| Language  | LanguageLevel    |
	| 'Spanish' | 'Fluent'         |
	