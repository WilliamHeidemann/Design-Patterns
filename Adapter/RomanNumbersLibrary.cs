namespace Adapter;

public class RomanNumbersLibrary
{
    public string IntToRoman(int number)
    {
        if (number == 10) return "X";
        if (number ==  5) return "V";
        if (number ==  1) return "I";
        return "...";
    }
}