namespace Adapter;

public class StringToRomanAdapter
{
    private RomanNumbersLibrary _library = new RomanNumbersLibrary();

    public string StringToRoman(string input)
    {
        if (int.TryParse(input, out var number))
        {
            return _library.IntToRoman(number);
        }
        throw new InvalidDataException();
    }
}