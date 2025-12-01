namespace Demo10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            Console.WriteLine("Gestionnaire des étudiants");

            string? choix;

            do
            {

                foreach (KeyValuePair<string, List<double>> stud in students)
                {
                    Console.WriteLine($"{stud.Key} : {stud.Value.Count} note(s)");
                }
                Console.WriteLine("Que voulez-vous faire ?");
                Console.WriteLine("(A)jouter - (S)upprimer - (M)odifier - (Q)uitter");

                choix = Console.ReadLine()?.ToUpper();

                switch (choix)
                {
                    case "A":
                        Console.WriteLine("Veuillez citer le nom de votre étudiant :");
                        students.Add(Console.ReadLine()!, new List<double>());
                        break;
                    case "M":
                        Console.WriteLine("Veuillez indiquer l'étudiant à modifier :");
                        string key = Console.ReadLine();
                        if (students.ContainsKey(key))
                        {
                            List<double> notes = students[key];
                            Console.WriteLine("(A)jouter une note - Afficher la (M)oyenne");
                            choix = Console.ReadLine();
                            switch (choix)
                            {
                                case "A":
                                    Console.WriteLine("Veuillez indiquer une nouvelle note");
                                    notes.Add(double.Parse(Console.ReadLine()));
                                    break;
                                case "M":
                                    double average = 0;
                                    foreach (double note in notes)
                                    {
                                        average += note;
                                    }
                                    Console.WriteLine($"La moyenne de l'étudiant est de {average / notes.Count}.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Étudiant inexistant...");
                        }
                        break;
                    case "S":
                        Console.WriteLine("Veuillez indiquer l'étudiant à supprimer :");
                        string keyDelete = Console.ReadLine()!;

                        if (students.ContainsKey(keyDelete))
                        {
                            students.Remove(keyDelete);
                        }
                        else
                        {
                            Console.WriteLine("Étudiant inexistant");
                        }
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
