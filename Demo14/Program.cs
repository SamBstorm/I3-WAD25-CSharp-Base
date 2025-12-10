namespace Demo14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parmis cette liste de couleurs, choississez la couleur de fond de la console :");
            //Comme dans les slides
            //foreach (string color in Enum.GetNames(typeof(ConsoleColor)))
            //OU
            foreach (string color in Enum.GetNames<ConsoleColor>())
                {
                Console.WriteLine($"\t- {color}");
            }

            ConsoleColor backgroundColor;
            /* Exemple avec parse
            //string input= Console.ReadLine();

            //ConsoleColor backgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), input);
            //OU
            //ConsoleColor backgroundColor = Enum.Parse<ConsoleColor>(input);
            */
            do { } while (!Enum.TryParse<ConsoleColor>(Console.ReadLine(), out backgroundColor));

            Console.BackgroundColor = backgroundColor;
            Console.Clear();
            Console.WriteLine("Taddaaa!!");
        }
    }
}
