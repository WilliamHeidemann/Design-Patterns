# Adapter

Source of information: https://refactoring.guru/design-patterns/adapter

The adapter pattern is a structural design pattern, that
enables classes with incompatible interfaces to communicate
by providing the necessary conversion methods.

Often times, a third party class library is used to solve
various problems. But those classes may be incompatible
with the input data that the client can provide, and the
client usually will not have the option to modify the
extern classes. Instead, the client can introduce a new
class whose response is to act as a translator between
the client code and the library code.

The newly introduced class will have a field to store
a reference to the class(es) it acts as an adaptor for.
The adaptor will be responsible for calling the correct
methods, without performing their logic, but to only
change the format of the input.

The pattern respects the single responsibility principle
by separating input management and logic into separate
classes.
It also respects the open/close principle, as an adapter
can be introduced to a system, without breaking existing
code. 