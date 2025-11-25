/*
 * Démonstration 03 - Conversions
 */

// 1.  Type valeur → chaîne de caractères (string)
// Utilisation d'une méthode: .ToString()

int a = 42;
double b = 4.2;
bool c = true;

var aToString = a.ToString(); // "42"
var bToString = b.ToString(); // "4.2"
var cToString = c.ToString(); // "True"

// 2. Type valeur → type valeur
// > Classe "Convert"

Console.WriteLine(Convert.ToInt32('A')); // retourne un int avec la valeur convertie
Console.WriteLine(Convert.ToChar(65)); // retourne un char avec la valeur convertie
// Console.WriteLine(Convert.ToInt32("a")); // FormatException
// Console.WriteLine(Convert.ToInt32("5000000000")); // OverflowException
Console.WriteLine(Convert.ToInt32("42")); // OK

// 3.  string → type valeur

// 3.1. Méthode "Parse"
// typeCible typeCible.Parse(str)

var convertedValue = int.Parse("42"); // "42": argument
// convertedValue = int.Parse(null); // ArgumentNullException
//convertedValue = int.Parse("a"); // FormatException
//convertedValue = int.Parse("2147483648"); // FormatException

Console.WriteLine($"Entrez une valeur à convertir: ");
string userInput = Console.ReadLine();

//convertedValue = int.Parse(userInput);


// 3.2. Méthode "TryParse"
// bool typeCible.TryParse(str, out [typeCible] nomVariable)

//bool conversionReussie = int.TryParse(userInput, out int convertedValue2);
bool conversionReussie = int.TryParse(userInput, out convertedValue);

Console.WriteLine($"Réussi: {conversionReussie} - {convertedValue}");

// -- Exemple

int value = 0;
bool isValidValue = false;

Console.WriteLine($"Entrez un nombre: ");
while (!isValidValue)
{
    while(!int.TryParse(Console.ReadLine(), out value))
    {
        Console.WriteLine("Erreur, réessayez: ");
    }

    if (value >= 1 && value <= 10) 
    { 
        isValidValue = true; 
    }
    else
    {
        Console.WriteLine($"La valeur doit être comprise entre 1 et 10 !!!");
    }
}

Console.WriteLine($"Valeur de l'utilisateur: {value}");

// ---



Console.WriteLine();

// 4.  Conversions implicites / explicites
// - implicite: C# arrive de lui-même à convertir
// - explicite: forcez la conversion

int monEntier = 150000;
long monLong = monEntier; // Conversion implicite
//short monShort = monEntier; // Un entier prend plus de place qu'un short
short monShort = (short)monEntier; // Conversion explicite

// int : 150_000: 00000000000000100100100111110000
// short: 18_928:                  100100111110000 

// 5.  Boxing / Unboxing (sera revu un peu plus tard [polymorphisme])
// Boxing   : Envelopper un type valeur dans un type référence
// Unboxing : Déballer un type valeur d'un type référence

int variable = 5; // type valeur
object variableObject = variable; // Boxing (implicite)
int variable2 = (int)variableObject; // Unboxing (explicite)


Console.WriteLine();