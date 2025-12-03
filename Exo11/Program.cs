namespace Exo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] tab = new char[10];

            int position = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = '-';
            }

            tab[position] = 'o';
            ConsoleKey lettre;
            do
            {
                Console.Clear();
                Console.WriteLine("Appuyez sur 'D' pour aller à droite ou 'G' pour aller à gauche");
                Console.WriteLine(tab);
                lettre = Console.ReadKey(true).Key;
                tab[position] = '-';
                switch (lettre)
                {
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        if (position < tab.Length - 1)
                        {
                            position++;
                        }
                        break;
                    case ConsoleKey.G:
                    case ConsoleKey.LeftArrow:
                        if (position > 0)
                        {
                            position--;
                        }
                        break;
                }
                tab[position] = 'o';
            } while (lettre != ConsoleKey.Escape);
        }
    }
}
