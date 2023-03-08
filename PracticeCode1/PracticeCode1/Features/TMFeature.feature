Feature: TMFeature

As TurnUp Portal admin 
I would like to create,edit and delete time and material records
so that I can manage employee record successfully

@tag1
Scenario: Create time and material record with valid details
	Given I logged into turnUp portal successfully
	When I navigate to Time and Material page
	And I create new Time and Material record
	Then The record should be created successfully
