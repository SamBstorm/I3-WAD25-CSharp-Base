using System.Text;

namespace Exo13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialisation
            Dictionary<string, string?> taches = new Dictionary<string, string?>();

            #region Premier affichage
            Console.WriteLine($"Liste des tâches({taches.Count}) :");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.WriteLine("Aucune tâche encodée, en ajouter une ?\n(O)ui - (N)on");
            #endregion

            #region Controle de touches
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            } while (key != ConsoleKey.O && key != ConsoleKey.N); 
            #endregion
        
            if(key == ConsoleKey.O)
            {
                #region Encoder première tâche
                Console.WriteLine("Quel est l'objet de la tâche ?");
                string? tacheName = Console.ReadLine()?.Trim();
                //while(tacheName is null || tacheName.Length <= 0)
                while(string.IsNullOrWhiteSpace(tacheName))
                {
                    Console.WriteLine("! Nom de tâche invalide !");
                    Console.WriteLine("Quel est l'objet de la tâche ?");
                    tacheName = Console.ReadLine()?.Trim();
                }
                taches.Add(tacheName, null);
                #endregion

                #region Boucle d'utilisation
                do
                {
                    #region Affichage
                    Console.Clear();
                    Console.WriteLine($"Liste des tâches({taches.Count}) :");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine();
                    foreach (KeyValuePair<string, string?> tache in taches)
                    {
                        Console.Write($" - {tache.Key}");
                        if (tache.Value is not null)
                        {
                            Console.Write($" (Terminée par {tache.Value})");
                        }
                        Console.WriteLine();
                        // OU
                        //Console.WriteLine($" - {tache.Key}{((tache.Value is not null)? $" (Terminée par {tache.Value})" : "")}");
                    }
                    Console.WriteLine();
                    #endregion

                    #region Controle des touches
                    Console.WriteLine("Que faire ? (A)jouter - (T)erminée tâche - (Q)uitter");
                    do
                    {
                        key = Console.ReadKey(true).Key;
                    } while (key != ConsoleKey.A && key != ConsoleKey.T && key != ConsoleKey.Q);
                    #endregion

                    #region Gérer tâches
                    bool exist;
                    switch (key)
                    {
                        case ConsoleKey.A:
                            #region Ajouter une tâche
                            do
                            {
                                Console.WriteLine("Quel est l'objet de la tâche ?");
                                tacheName = Console.ReadLine()?.Trim();
                                //while(tacheName is null || tacheName.Length <= 0)
                                while (string.IsNullOrWhiteSpace(tacheName))
                                {
                                    Console.WriteLine("! Nom de tâche invalide !");
                                    Console.WriteLine("Quel est l'objet de la tâche ?");
                                    tacheName = Console.ReadLine()?.Trim();
                                }
                                exist = false;
                                foreach (string tache in taches.Keys)
                                {
                                    if (tache.ToUpper() == tacheName.ToUpper())
                                    {
                                        Console.WriteLine("! Tâche déjà présente !");
                                        exist = true;
                                    }
                                }
                            } while (exist);
                            taches.Add(tacheName, null);
                            #endregion
                            break;
                        case ConsoleKey.T:
                            #region Terminer une tâche
                            do
                            {
                                Console.WriteLine("Quelle tâche terminée ?");
                                tacheName = Console.ReadLine()?.Trim();
                                //while(tacheName is null || tacheName.Length <= 0)
                                while (string.IsNullOrWhiteSpace(tacheName))
                                {
                                    Console.WriteLine("! Nom de tâche invalide !");
                                    Console.WriteLine("Quelle tâche terminée ?");
                                    tacheName = Console.ReadLine()?.Trim();
                                }
                                exist = false;
                                foreach (string tache in taches.Keys)
                                {
                                    if (tache.ToUpper() == tacheName.ToUpper())
                                    {
                                        exist = true;
                                        tacheName = tache;
                                    }
                                }
                                if (!exist)
                                {
                                    Console.WriteLine("! Tâche non-existante !");
                                }
                            } while (!exist);
                            Console.WriteLine("Qui l'a terminée ?");
                            string? userName = Console.ReadLine()?.Trim();
                            while (string.IsNullOrWhiteSpace(userName))
                            {
                                Console.WriteLine("! Nom d'utilisateur invalide !");
                                Console.WriteLine("Qui l'a terminée ?");
                                userName = Console.ReadLine()?.Trim();
                            }
                            taches[tacheName] = userName;
                            #endregion
                            break;
                    }
                    #endregion
                } while (key != ConsoleKey.Q);
                #endregion
            }

            Console.WriteLine("Merci d'avoir utiliser Tâches 3000!");
        }
    }
}
