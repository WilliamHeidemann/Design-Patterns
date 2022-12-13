# Mediator Pattern

Source of information: https://refactoring.guru/design-patterns/mediator

Mediator is a behavioral design pattern that lets you 
reduce chaotic dependencies between objects. The pattern 
restricts direct communications between the objects and 
forces them to collaborate only via a mediator object.

The mediator is implemented to reduce coupling between
various objects in the system, by only relying on the mediator
for communication between objects. 

A downside of the pattern is that the mediator acts as a 
bottleneck to the system, as all communication must pass through
it. 
Further, the system becomes harder to unit test, as all objects
have to communicate through the mediator. 