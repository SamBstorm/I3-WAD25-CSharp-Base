namespace Exo18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carte[] paquet = new Carte[52];

            int i = 0;

            /*Pas fonctionnelle car cette boucle ne traite pas les cartes du paquet, mais une copie des cartes...
            foreach (Carte carte in paquet)
            {
                carte.couleur = (Couleurs)(i % Enum.GetNames<Couleurs>().Length); 
                carte.valeur = (Valeurs)((i % Enum.GetNames<Valeurs>().Length) + 2);
            }*/
            foreach (string couleur in Enum.GetNames<Couleurs>())
            {
                Couleurs couleurEnum = Enum.Parse<Couleurs>(couleur);
                foreach (Valeurs valeurEnum in Enum.GetValues<Valeurs>())
                {
                    Carte c;
                    c.valeur = valeurEnum;
                    c.couleur = couleurEnum;
                    paquet[i] = c;
                    i++;
                }
            }

            foreach (Carte carte in paquet)
            {
                Console.WriteLine($"Le {carte.valeur} de {carte.couleur}");
            }
        }
    }
}
