﻿Feature: TMFeature

As TurnUp Portal admin 
I would like to create,edit and delete time and material records
so that I can manage employee record successfully

@tag1
Scenario: Create time and material record with valid details
	Given I logged into turnUp portal successfully
	When I navigate to Time and Material page
	And I create new Time and Material record
	Then The record should be created successfully

Scenario Outline: Edit existing time and material record with valid details
	Given I logged into turnUp portal successfully
	When I navigate to Time and Material page
	And I update '<Description>','<Code>','<Price>' on existing time and material record
	Then The record should have updated '<Description>','<Code>','<Price>'

	Examples: 
	| Description  | Code     | Price |
	| Time         | test     | 20    |
	| Material     | Keyboard | 100   |
	| Editedrecord | Mouse    | 500   |



