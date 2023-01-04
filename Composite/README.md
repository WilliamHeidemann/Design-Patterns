# Composite

Source of information: https://refactoring.guru/design-patterns/composite

The structural pattern is a guide to implement systems that 
can be abstracted to a tree-data structure with classes containing
instances of themselves. Commonly, a such class would 
have some traversing method for iterating over it's 
nested objects. 

The reason it's a design pattern and not a data structure is 
because instead of holding references to specific objects
(of its own type) it holds a reference to a collection of an 
interface. Anything implementing the interface becomes 
composite and can be part of the tree-like structure. 

The pattern follows the open/close principle, as a new 
implementation of the interface can always be added. 

The visitor pattern can be used in conjunction with the composite
pattern to execute logic on the entire composite tree.