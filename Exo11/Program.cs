namespace Exo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] tab = new bool[10];

            int position = 0;

            tab[position] = true;
            ConsoleKey lettre;
            do
            {
                Console.Clear();
                Console.WriteLine("Appuyez sur 'D' pour aller à droite ou 'G' pour aller à gauche");
                Console.Write('[');
                foreach (bool isPresent in tab)
                {
                    if (isPresent) Console.Write('o');
                    else Console.Write('-');
                }
                Console.WriteLine(']');
                lettre = Console.ReadKey(true).Key;
                tab[position] = false;
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
                tab[position] = true;
            } while (lettre != ConsoleKey.Escape);
        }
    }
}
