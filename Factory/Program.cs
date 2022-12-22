// See https://aka.ms/new-console-template for more information

using Factory;

ICookieFactory factory = new MachineLearningCookieFactory();
ICookie cookie = factory.CreateCookie("chocolate");
Console.WriteLine($"Badass {cookie}");