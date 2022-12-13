// See https://aka.ms/new-console-template for more information

using Mediator;

var chatRoom = new ChatRoom();
var logger = new Logger(chatRoom);

var alice = new Participant();
var bob = new Participant();

alice.Join(chatRoom);
bob.Join(chatRoom);

alice.Send("Hello, I am Alice");
bob.Send("Hi Alice!");