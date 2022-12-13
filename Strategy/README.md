# Strategy Pattern

Source of information: https://refactoring.guru/design-patterns/strategy

A behavioral design pattern.

The Strategy pattern suggests that you take a class that does 
something specific in a lot of different ways and extract all 
of these algorithms into separate classes called strategies.

Use the Strategy pattern when you want to use different variants 
of an algorithm within an object and be able to switch from one 
algorithm to another during runtime. 

Use the Strategy when you have a lot of similar classes that only 
differ in the way they execute some behavior.

Use the pattern when your class has a massive conditional 
statement that switches between different variants of the same algorithm.

The Strategy pattern lets you do away with such a conditional by 
extracting all algorithms into separate classes, all of which 
implement the same interface. The original object delegates execution 
to one of these objects, instead of implementing all variants of the algorithm.

The pattern uses composition as opposed to inheritance. 

The pattern enforces the Open/Closed Principle. You can introduce 
new strategies without having to change the context.