Feature: Synchronous map and reduce

@nullableint
Scenario: Mapping of nullable int which is null (cast)
	Given the nullable integer is null
	When I map and reduce the nullable integer
	Then I get 'reduced from none'

@nullableint
Scenario: Mapping of nullable int which is null (Options.From)
	Given the nullable integer is null 
	When I map and reduce the nullable integer using Options.From
	Then I get 'reduced from none'

@nullableint
Scenario: Mapping of nullable int which is not null
	Given the nullable integer is '123'
	When I map and reduce the nullable integer
	Then I get '123'

@nullableclass
Scenario: Mapping of class which is null
	Given the class is null
	When I map and reduce the nullable class
	Then I get 'reduced from none'

@nullableclass
Scenario: Mapping of class which is not null
	Given the class is not null
	When I map and reduce the nullable class
	Then I get 'I am Foo'
