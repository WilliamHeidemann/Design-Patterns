# Visitor

Source of information: https://refactoring.guru/design-patterns/visitor

The visitor pattern is a behavioural design pattern that 
allows a set of classes to interact with another set of
classes. 

Instead of having an actor class determine which subject 
of an object it is working with, the visitor is passed to 
the subject. The subject will then call the correct visitor 
method and pass itself as a parameter. 

The pattern is implemented by making a visitor interface,
and make concrete classes implement the interface.
Each object that can be visited should have a method to 
accept a visitor, and call the proper visiting method. 
There should be a visiting method in the IVisitor interface
for each subclass that can be visited. 

The pattern respects the open/close principle, as new visitors
can easily be implemented, as visitable objects already have
an accept method. 
