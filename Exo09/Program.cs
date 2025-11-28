namespace Exo09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int table = 1; table <= 5; table++)
            {
                Console.WriteLine($"Table de {table} : ");
                for(int i = 1; i <= 20; i++)
                {
                    Console.WriteLine($"{table} X {i,2} = {table * i,3}");
                }
            }

            /* Jolie présentation
            for (int i = 1; i <= 20; i++)
            {
                for (int table = 1; table <= 5; table++)
                {
                    Console.Write($"{table} X {i,2} = {table * i,3}\t|\t");
                }
                Console.WriteLine();
            }*/
        }
    }
}
