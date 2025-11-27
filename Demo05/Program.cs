namespace Demo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? message = null;
            Console.WriteLine("Veuillez introduire un nombre");
            string input = Console.ReadLine()!;
            int nombre = int.Parse(input);
            int div = nombre / 2;

            /*
            if(div + div == nombre)
            {
                message = $"Le nombre {nombre} est pair";
            }
            else
            {
                message = $"Le nombre {nombre} est impair";
            }*/


            /*Exemple ternaire simple*/

            message = (div + div == nombre) 
                ? $"Le nombre {nombre} est pair" 
                : $"Le nombre {nombre} est impair";

            Console.WriteLine(message);

            /*Exemple ternaire dans opération*/

            Console.WriteLine($"Vous avez donc acheté {nombre} livre{((nombre > 1) ? "s" : "")}.");

            /*Exemple ternaire dans ternaire*/

            int jour = 3;

            Console.WriteLine(
                (jour == 1) ? "Lundi" : 
                (jour == 2) ? "Mardi" : 
                (jour == 3) ? "Mercredi" : "Le reste de la semaine");
        }
    }
}
