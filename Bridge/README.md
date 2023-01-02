# Bridge

Source of information: https://refactoring.guru/design-patterns/bridge

The bridge pattern is a structural design pattern, that helps the
developer write more easily maintainable and extendable code. 
It is based on composition, which is delegating work to other objects.

The bridge pattern is used to separate a large class into abstraction 
and implementation. It follows the open/close principle and 
helps each class follow the single responsibility principle.

The main idea is to take independent pieces of functionality 
out of a class, and save each module and save it in a member variable.
The variable is an interface that declares the functionality 
of the module. Concrete implementations are then instantiated 
and stored. Notably, this object can be swapped at runtime 
for additional or new functionality. 

A similar use case is for dividing a cluttered class 
hierarchy into separate class hierarchies with one referencing 
the other. 
If a class hierarchy look liked this: 
Class A1 A2 A3 B1 B2 B3 C1 C2 C3
Adding a new type of functionality, say D, would mean creating 
3 new classes, D1, D2, D3, and so on. 
Instead the bridge pattern could be utilized to have e.g. 
class A, B, C, D each with a reference to either class 1, 2, 3. 
Further, class 1, 2 and 3 should implement the same interface. 

The bridge pattern is often used in combination with the builder
pattern or factory pattern.