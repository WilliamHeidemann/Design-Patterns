# Singleton 

Source of information: https://refactoring.guru/design-patterns/singleton

Singleton is a creational design pattern that lets you ensure 
that a class has only one instance, while providing a global 
access point to this instance.

The singleton pattern is implemented to avoid creating multiple
instances of some object, which should hold all relevant data 
for the system during it's lifetime. 

The singleton pattern is recognized in a class by having a 
private constructor, and a static instance object, that is only 
instantiated the first time the static instance is called. 
For the rest of the lifetime of the system, only the singleton 
will be returned.

The singleton pattern violates the single-responsibility principle
as it solves two problems at the same time. The first problem 
it solves is to ensure that only one instance of the object
ever exists at any time. Further, it acts as a global access point
for all other objects in the system. 
The creates an issue, where anything in the system may accidentally
go in and overwrite some data previously put in the singleton object. 

The singleton creates another problem, where it often acts as a god
object in the code. This can make the code troublesome to unit test.

The singleton is sometimes considered to be an anti-pattern, as it
violates the principles of object-oriented programming. 