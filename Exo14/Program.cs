namespace Exo14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const ushort TAILLE_GRILLE = 5;
            Point?[,] grille = new Point?[TAILLE_GRILLE, TAILLE_GRILLE];

            for (int i = 0; i < TAILLE_GRILLE; i++)
            {
                Point p;
                p.X = i + 1;
                p.Y = i + 1;
                grille[i, i] = p;
                /* OU
                grille[i,i] = new Point() { X = i + 1, Y = i + 1 };*/
            }

            for (int i = 0; i < TAILLE_GRILLE; i++)
            {
                for(int j = 0; j < TAILLE_GRILLE; j++)
                {
                    if (grille[i,j] is null)
                    {
                        Console.Write("\t");
                    }
                    else
                    {
                        Point p = (Point)grille[i, j];
                        Console.Write($"X : {p.X} - Y : {p.Y}");
                        /*OU
                        Console.Write($"X : {grille[i, j]?.X} - Y : {grille[i, j]?.Y}");*/
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
