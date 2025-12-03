namespace Demo09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            Console.WriteLine("Gestionnaire des étudiants");

            string? choix;

            do
            {

                for (int i = 0; i < students.Count; i++)
                {
                    Console.WriteLine($"{i} : {students[i]}");
                }
                Console.WriteLine("Que voulez-vous faire ?");
                Console.WriteLine("(A)jouter - (S)upprimer - (M)odifier - (Q)uitter");

                choix = Console.ReadLine()?.ToUpper();

                switch (choix)
                {
                    case "A":
                        Console.WriteLine("Veuillez citer le nom de votre étudiant :");
                        students.Add(Console.ReadLine()!);
                        break;
                    case "M":
                        Console.WriteLine("Veuillez identifer l'étudiant à l'aide du numéro :");
                        int indexModified = int.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Quelle est la nouvelle valeur pour {students[indexModified]} :");
                        students[indexModified] = Console.ReadLine()!;
                        break;
                    case "S":
                        Console.WriteLine("Veuillez identifer l'étudiant à l'aide du numéro :");
                        int indexDeleted = int.Parse(Console.ReadLine()!);
                        Console.WriteLine($"Êtes-vous sûr de vouloir supprimer {students[indexDeleted]} : (O)ui - (N)on");
                        if (Console.ReadLine()?.ToLower() == "o") students.RemoveAt(indexDeleted);
                        break;
                    case "Q":
                        Console.WriteLine("Merci d'avoir utiliser le gestionnaire d'étudiants.");
                        break;
                    default:
                        Console.WriteLine($"La lettre {choix} n'est pas prévue...");
                        break;
                }
            } while (choix != "Q");

        }
    }
}
