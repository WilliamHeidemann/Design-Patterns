# Observer 

Source of information: https://refactoring.guru/design-patterns/observer

The observer pattern is a behavioural design pattern that 
acts as a one-way communication channel for objects waiting 
for specific events to occur.

Instead of having a objects constantly asking if an event 
occurs, the interaction can be flipped by utilizing the
observer pattern. 

It differs from the mediator pattern, as the observer does
not receive information from its listeners/subscribers. 

The pattern respects the open/closed principle as new 
objects can be introduced to subscribe to the observer 
without having to change any existing code. 