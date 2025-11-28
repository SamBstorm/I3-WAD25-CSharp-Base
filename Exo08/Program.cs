namespace Exo08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint fibonacci = 25;

            uint a = 0;
            uint b = 1;

            Console.WriteLine($"Suite de Fibonacci jusqu'à {fibonacci} :");

            for (uint i = 0; i <= fibonacci; i++)
            {
                Console.Write(a + " ");
                uint next = a + b;
                a = b;
                b = next;
            }
        }
    }
}
