

/*
 * Démonstration 02 - Types de données 
 */

// 1.  Type C# vs CTS (.NET)

// Types valeur (structures)
// → travaille avec la valeur brute

using System.Text;

int a;
Int32 b;
char c = '\''; // L'échappement
char f = '\\';

Console.WriteLine($"A:\t{c}\t{(int)c}");
Console.WriteLine($"A:\t{c}\t{(int)c}");

// Types reference (classes)
// → travaille avec la référence en mémoire (adresse)
string d;
object e;


// 2.  Mot-clef "var"
// Laisse C# décider du type à prendre

var maVariable = 42; // Inférence de type

// 3.  Valeurs littérales 

// Suffixes
// long → L
// uint → U
// ulong → UL
// float → F
// double → D
// decimal → M

//var variableLong = 42; // type: Int32
//var variableLong = 40_000_000; // type: Int32
//var variableLong = 40_000_000_000; // type: Int64
var variableLong = 42L; // type: Int64


// 4.  Concaténation de chaînes de caractères

// 4.1. Opérateur +
string str1 = "Ma chaine" + " " + "de" + " " + "caractères" + 12;
string str2 = "12" + 12; // 1212

// 4.2. Classe StringBuilder
// Instancier: [verbe] créer une instance (créer un objet en mémoire)
StringBuilder builder = new StringBuilder();

// "." : Opérateur d'accès aux membres 

builder.AppendLine("Nouvelle ligne 1");
builder.AppendLine("Nouvelle ligne 2");
builder.AppendLine("Nouvelle ligne 3");
builder.Append("Nouvelle ligne 4");
builder.Append("A la suite de la ligne 4");

Console.WriteLine(builder);

// 4.3. Méthode string.Format

string nom = "Geerts", prenom = "Quentin";

//                                                              0     1
string str3 = string.Format("Bonjour, je m'appelle {0} {1}", prenom, nom);

// 4.4. Interpolation de chaînes de caractères

string str4 = $"Bonjour, je m'appelle {prenom} {nom}";




