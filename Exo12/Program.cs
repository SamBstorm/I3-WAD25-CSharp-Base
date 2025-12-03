namespace Exo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Préparation joueurs
            string[] playerNames = new string[2];
            char[] playerSymbols = { 'X', 'O' };
            int currentPlayer = 0;

            Console.WriteLine("Bienvenue dans le jeu du Morpion");

            for (int i = 0; i < playerNames.Length; i++)
            {
                Console.Write($"Joueur {i + 1} : Veuillez indiquer votre nom : ");
                playerNames[i] = Console.ReadLine();
            } 
            #endregion

            #region Initialisation grille
            const ushort TAILLE_GRILLE = 3;

            char[,] grille = new char[TAILLE_GRILLE, TAILLE_GRILLE];

            for (int ligne = 0; ligne < TAILLE_GRILLE; ligne++)
            {
                for (int colonne = 0; colonne < TAILLE_GRILLE; colonne++)
                {
                    grille[ligne, colonne] = ' ';
                }
            }
            #endregion
            

            
            do
            {
                #region Affichage grille
                Console.Clear();

                Console.Write("   ");
                for (int repereColone = 0; repereColone < TAILLE_GRILLE; repereColone++)
                {
                    Console.Write($"{repereColone}  ");
                }
                Console.WriteLine();

                for (int ligne = 0; ligne < TAILLE_GRILLE; ligne++)
                {
                    Console.Write($"{ligne} ");
                    for (int colonne = 0; colonne < TAILLE_GRILLE; colonne++)
                    {
                        Console.Write($"[{grille[ligne, colonne]}]");
                    }
                    Console.WriteLine();
                }
                #endregion

                #region Tour du joueur
                Console.WriteLine($"{playerNames[currentPlayer]} à vous de jouer !");
                string input;
                bool isConverted;
                ushort col, row;
                do
                {
                    do
                    {
                        Console.Write("Indiquez la colonne : ");
                    } while (!ushort.TryParse(Console.ReadLine(), out col) || col > TAILLE_GRILLE - 1);
                    do
                    {
                        Console.Write("Indiquez la ligne : ");
                        input = Console.ReadLine();
                        isConverted = ushort.TryParse(input, out row);
                    }
                    while (!isConverted || row > TAILLE_GRILLE - 1);
                    if (grille[row, col] != ' ')
                    {
                        Console.WriteLine("! Case déjà occupée !");
                    }
                } while (grille[row, col] != ' ');

                grille[row, col] = playerSymbols[currentPlayer];
                #endregion

                //Changement de joueur 
                currentPlayer = (currentPlayer == 0) ? 1 : 0;
            } while (true);
        }
    }
}
