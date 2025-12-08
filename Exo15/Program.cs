using System.Text;

namespace Exo15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Initialisation
            Console.OutputEncoding = Encoding.Unicode;
            TransactionsJournaliere trToday = new TransactionsJournaliere();
            trToday.transactions = new List<Transaction>();

            ConsoleKey key; 
            #endregion

            #region Boucle du programme
            do
            {
                #region Affichage
                Console.Clear();
                Console.WriteLine(
            @$"Gestion des transactions :
--------------------------");

                if (trToday.transactions.Count == 0)
                {
                    Console.WriteLine("\nAucune transaction\n");
                }
                else
                {
                    Console.WriteLine(
@"Heure | Communication     | Type | Montant
------------------------------------------");
                    foreach(Transaction tr in trToday.transactions)
                    {
                        Console.WriteLine($"{tr.temps.heure}:{tr.temps.minute:D2} | {tr.communication ?? "Pas de com."} | {((tr.estUneRentree) ?  "↑" : "↓")} | {tr.montant:C2}");
                    }
                }

                    Console.WriteLine(
    $@"--------------------------
Totaux: Rentrées :  {trToday.totalRentrees:C2}
        Dépenses :  {trToday.totalDepenses:C2}
        Final :     {trToday.totalRentrees - trToday.totalDepenses:C2}

(A)jouter une Transaction - (Q)uitter");
                #endregion
                #region Contrôle des touches
                do
                {
                    key = Console.ReadKey(true).Key;
                } while (key != ConsoleKey.A && key != ConsoleKey.Q);
                #endregion

                #region Si A alors Ajout
                if (key == ConsoleKey.A)
                {
                    Transaction tr = new Transaction();
                    #region Rentrée ou dépenses ?
                    Console.WriteLine("Quelle type de transaction ?");
                    Console.WriteLine("(D)épense - (R)entrée");
                    do
                    {
                        key = Console.ReadKey(true).Key;
                    }
                    while (key != ConsoleKey.D && key != ConsoleKey.R);
                    tr.estUneRentree = key == ConsoleKey.R;
                    #endregion

                    #region Le montant ?
                    string input;
                    do
                    {
                        Console.WriteLine("Quelle somme ? ");
                        input = Console.ReadLine();
                    } while (!decimal.TryParse(input, out tr.montant) || tr.montant <= 0);
                    #endregion

                    #region Mise à jour Totaux
                    if (tr.estUneRentree)
                    {
                        trToday.totalRentrees += tr.montant;
                    }
                    else
                    {
                        trToday.totalDepenses += tr.montant;
                    }
                    #endregion

                    #region Enregistrement temps
                    Temps tp = new Temps();
                    do
                    {
                        Console.WriteLine("Quelle heure ? ");
                        input = Console.ReadLine();
                    } while (!ushort.TryParse(input, out tp.heure) || tp.heure > 23);
                    do
                    {
                        Console.WriteLine("Quelles minutes ? ");
                        input = Console.ReadLine();
                    } while (!ushort.TryParse(input, out tp.minute) || tp.minute > 59);
                    tr.temps = tp;
                    #endregion

                    #region Enregistrement communication
                    Console.WriteLine("Une communication? (Appuyez sur 'Enter' pour ignorer)");
                    tr.communication = Console.ReadLine()?.Trim();
                    tr.communication = (tr.communication?.Length > 0) ? tr.communication : null;
                    #endregion
                    #region Insertion au bon endroit dans la liste
                    int index = 0;
                    for (int i = 0; i < trToday.transactions.Count; i++)
                    {
                        if ((tp.heure == trToday.transactions[i].temps.heure &&
                            tp.minute >= trToday.transactions[i].temps.minute) ||
                            (tp.heure > trToday.transactions[i].temps.heure))
                        {
                            index++;
                        }
                    }
                    trToday.transactions.Insert(index,tr);
                    #endregion
                }
                #endregion

                //Quitte le programme
            } while (key != ConsoleKey.Q); 
            #endregion

        }
    }
}
