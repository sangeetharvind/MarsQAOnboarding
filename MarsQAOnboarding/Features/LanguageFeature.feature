Feature: LanguageFeature

A short summary of the feature

@order(1)
Scenario Outline: Add language record with valid data
	Given User is logged into localhost successfully
	When Adding new <Language> and <LanguageLevel> to the language list
	Then New record with <Language> and <LanguageLevel> are added successfully

	Examples:
	| Language  | LanguageLevel |
	| 'Kannada' | 'Basic'       |
	| 'Telugu'  | 'Fluent'      |
	
	@order(2)
Scenario Outline: Update existing language record with valid data
	Given User is logged into localhost successfully
	When Update <Language> and <LanguageLevel> on an existing language record
	Then the record with <Language> and <LanguageLevel> should update successfully

	Examples: 
	| Language | LanguageLevel |
	| 'Spanish' | 'Fluent'     |
	
	
@order(3)
Scenario Outline: Delete the language record from the language list
	Given User is logged into localhost successfully
	When Delete the record <Language> and <LanguageLevel>
	Then The record <Language> and <LanguageLevel> should be deleted successfully
