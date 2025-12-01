namespace Exo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort nombre;

            do
            {
                Console.Write("Bonjour, veuillez indiquer le nombre de nombres premiers que vous voulez afficher : ");                 
            } while (!ushort.TryParse(Console.ReadLine(), out nombre) || nombre <= 0);


            for (int nbATester = 2, compteurNbPremier = 0; compteurNbPremier < nombre; nbATester++)
            {
                bool estPremier = true;                

                for (int diviseur = 2; diviseur <= Math.Sqrt(nbATester) && estPremier; diviseur++)
                {
                    if (nbATester % diviseur == 0) estPremier = false;
                }

                if (estPremier)
                {
                    Console.WriteLine($"Le nombre {nbATester} est un nombre premier!");
                    compteurNbPremier++;
                }
            }
        }
    }
}
