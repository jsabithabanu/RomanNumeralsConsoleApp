using RomanNumeralsConverter;

// See https://aka.ms/new-console-template for more information

Converter converter = new();

Console.WriteLine("Please enter a Roman Numeral and press enter key: ");

// Creating a string variable and getting the user input from
// the keyboard and store it in the variable
string romanNumeral = Console.ReadLine();

int number = converter.RomanToInteger(romanNumeral);
Console.WriteLine($"You converted the Roman Numeral {romanNumeral.Trim()} to the number " + number);
