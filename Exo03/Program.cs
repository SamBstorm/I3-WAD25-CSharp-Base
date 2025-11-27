namespace Exo03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez entrer un premier nombre : ");
            int nombre1 = int.Parse(Console.ReadLine()!);
            Console.Write("Veuillez entrer un deuxième nombre : ");
            int nombre2 = int.Parse(Console.ReadLine()!);

            int div = nombre1 / nombre2;
            int modulo = nombre1 % nombre2;
            double division = (double)nombre1 / nombre2;

            Console.WriteLine($"Divsion entière : {div} ; Modulo : {modulo} ; Division classique : {division}");
        }
    }
}
