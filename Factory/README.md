# Factory Pattern

Source: Agile Principles, Patterns, and Practices in C#, 
Chapter 29, Martin


The factory pattern is a creational design pattern. 
The factory patterns is implemented to follow the dependency
inversion principle. In theory, the principle is broken 
every time an object is instantiated using the "new" 
key word. E.g. var circle = new Circle(origin, 1);
If circle is a volatile class whose constructor might 
change at anytime, all instances of = new Circle(...) 
will have to be updated. 

The creation of objects can be masked behind an abstract
interface - the factory. 

Further, the factory pattern can be used to make sure
that a group of objects created fit together. 
Different concrete implementations of an abstract 
interface factory can be used to make sure that the 
objects created from each factory fit together/follow
the same rules. 

The design pattern can, however, quickly add a lot of 
classes to a system which leads to unnecessary complexity. 
It is often a good idea to use the factory pattern when
the proxy pattern must be implemented. 