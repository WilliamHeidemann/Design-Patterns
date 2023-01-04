# Facade 

Source of information: https://refactoring.guru/design-patterns/facade

## Connection to SOLID


Facade is a structural design pattern that provides a 
simplified interface to a library, a framework, or any other 
complex set of classes.

Use the Facade pattern when you need to have a limited 
but straightforward interface to a complex subsystem.

Often, subsystems get more complex over time. Even applying 
design patterns typically leads to creating more classes. 
A subsystem may become more flexible and easier to reuse in 
various contexts, but the amount of configuration and 
boilerplate code it demands from a client grows ever larger. 
The Facade attempts to fix this problem by providing a shortcut 
to the most-used features of the subsystem which fit most client 
requirements.

Use the Facade when you want to structure a subsystem into layers.

Create facades to define entry points to each level of a subsystem. 
You can reduce coupling between multiple subsystems by requiring 
them to communicate only through facades.

A facade pattern can end up being one object that is too tightly 
coupled to all other classes of the system.  