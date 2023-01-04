using Adapter;

string[] jsonNumbers = {"10", "5", "1"};

StringToRomanAdapter adapter = new();

foreach (var jsonNumber in jsonNumbers)
{
    var romanNumber = adapter.StringToRoman(jsonNumber);
    Console.WriteLine(romanNumber);
}