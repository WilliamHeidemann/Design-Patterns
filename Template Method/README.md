# Template Method Pattern

Source of information: https://refactoring.guru/design-patterns/template-method

A behavioral design pattern.

Template Method is a behavioral design pattern that 
defines the skeleton of an algorithm in the superclass 
but lets subclasses override specific steps of the 
algorithm without changing its structure.

Use the Template Method pattern when you want to let 
clients extend only particular steps of an algorithm, 
but not the whole algorithm or its structure.

The Template Method lets you turn a monolithic algorithm 
into a series of individual steps which can be easily 
extended by subclasses while keeping intact the structure 
defined in a superclass.

Use the pattern when you have several classes that contain 
almost identical algorithms with some minor differences. 
As a result, you might need to modify all classes when 
the algorithm changes.

The template method pattern uses inheritance as opposed to composition. 

The pattern might violate the Liskov Substitution Principle by
suppressing a default step implementation via a subclass.

The pattern does not allow for changing functionality at runtime.