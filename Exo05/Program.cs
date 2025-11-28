namespace Exo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Veuillez introduire votre BBAN (les 12 chiffres) : ");
            string bban = Console.ReadLine()!;
            if (bban.Length != 12 || !long.TryParse(bban, out _))
            {
                Console.WriteLine("Le BBAN doit contenir exactement 12 chiffres.");
            }
            else
            {
                string tenFirst = bban.Substring(0, 10);
                string twoLast = bban.Substring(10);
                long tenNumbers = long.Parse(tenFirst);
                short twoNumbers = short.Parse(twoLast);
                short modulo = (short)(tenNumbers % 97);
                if ((modulo == 0 && twoNumbers == 97) || (modulo == twoNumbers))
                {
                    Console.WriteLine("OK");
                    string concat = twoLast + twoLast + "111400";
                    long concatNumber = long.Parse(concat);
                    short ibanModulo = (short)(98 - (concatNumber % 97));
                    string iban = "BE" + ((ibanModulo < 10)? "0" : "") + ibanModulo + bban;
                    Console.WriteLine("Votre IBAN est : " + iban);
                }
                else
                {
                    Console.WriteLine("KO");
                }
            }
        }
    }
}
