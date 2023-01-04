// See https://aka.ms/new-console-template for more information

using Proxy;

var endPoint = new PublicEndPoint();
var result = endPoint.RequestData("Costumer/1");
Console.WriteLine(result);