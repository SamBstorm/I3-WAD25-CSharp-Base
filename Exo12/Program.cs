namespace Exo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Préparation joueurs
            string[] playerNames = new string[2];
            char[] playerSymbols = { 'X', 'O' };
            bool partieGagnee = false;
            ushort currentPlayer = default;
            Queue<ushort[]> coordToDelete = new Queue<ushort[]>();
            Stack<ushort[]> historic = new Stack<ushort[]>();

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
            
            for(ushort turnCount = 0; !partieGagnee; turnCount++)
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
                currentPlayer = (ushort)(turnCount % playerNames.Length);
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

                if (historic.Count > 0)
                {
                    ushort[] coordinate = historic.Peek();
                    grille[coordinate[0], coordinate[1]] = ' ';
                }

                coordToDelete.Enqueue(new ushort[]{row, col});
                if(coordToDelete.Count() == 7)
                {
                    ushort[] coordinate = coordToDelete.Dequeue();
                    grille[coordinate[0], coordinate[1]] = grille[coordinate[0], coordinate[1]].ToString().ToLower()[0];
                    historic.Push(coordinate);
                }


                #region Vérification grille
                if(turnCount >= 4)
                {
                    #region Vérification ligne
                    if (playerSymbols[currentPlayer] == grille[row, 0] &&
                        playerSymbols[currentPlayer] == grille[row, 1] &&
                        playerSymbols[currentPlayer] == grille[row, 2])
                    {
                        partieGagnee = true;
                    }
                    #endregion

                    #region Vérification colonne
                    if (playerSymbols[currentPlayer] == grille[0, col] &&
                        playerSymbols[currentPlayer] == grille[1, col] &&
                        playerSymbols[currentPlayer] == grille[2, col])
                    {
                        partieGagnee = true;
                    }
                    #endregion

                    #region Vérification diagonales
                    if ((col == 0 || col == 2) && (row == 0 || row == 2) || (col == 1 && row == 1))
                    {
                        #region Diagonale \
                        ushort countSymbols = 0;
                        for (int i = 0; i < TAILLE_GRILLE; i++)
                        {
                            if (grille[i, i] == playerSymbols[currentPlayer])
                            {
                                countSymbols++;
                            }
                        }
                        if(countSymbols == 3)
                        {
                            partieGagnee = true;
                        }
                        #endregion

                        #region Diagonale /
                        countSymbols = 0;
                        for (int i = 0; i < TAILLE_GRILLE; i++)
                        {
                            if (grille[i, (TAILLE_GRILLE-1)-i] == playerSymbols[currentPlayer])
                            {
                                countSymbols++;
                            }
                        }
                        if (countSymbols == 3)
                        {
                            partieGagnee = true;
                        }
                        #endregion
                    }
                    #endregion
                }
                #endregion
            }

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

            if (partieGagnee)
            {
                Console.WriteLine($"Bravo {playerNames[currentPlayer]} !");
            }
            else
            {
                Console.WriteLine("Égalité !");
            }

            Console.WriteLine("Merci d'avoir joué!");
        }
    }
}
