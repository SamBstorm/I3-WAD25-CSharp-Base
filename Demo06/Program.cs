namespace Demo06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "012345678910";

            string word1 = message.Substring(0, 5);
            string word2 = message.Substring(7);

            Console.WriteLine(word1);
            Console.WriteLine(word2);
        }
    }
}
