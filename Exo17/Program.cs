namespace Exo17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menuPrincipal = new Menu();
            menuPrincipal.message = "Menu Principal";
            menuPrincipal.choix = new string[] { "Jouer", "Continuer", "Options", "Quitter" };

            ushort choix = menuPrincipal.Afficher();

            switch (choix)
            {
                case 0:
                    Console.WriteLine("Commençons une partie!");
                    Menu chapitre1 = new Menu();
                    chapitre1.message = "Vous entrez dans un sombre manoir, que faites-vous?";
                    chapitre1.choix = ["Demi-tour!", "On avance...", "On hurle!"];
                    choix = chapitre1.Afficher();
                    switch (choix)
                    {
                        case 0:
                            Console.WriteLine("Bravo, vous êtes le seul survivant!");
                            break;
                        case 1:
                            Console.WriteLine("Pour avancer plus loin, veuillez payer l'éditeur du jeu...");
                            break;
                        default:
                            Console.WriteLine("Un fantôme vous surprend, vous mourrez...");
                            break;
                    }
                    break;
                case 1:
                    Console.WriteLine("Où en étions-nous ?");
                    break;
                case 2:
                    Console.WriteLine("Réglons ça!");
                    break;
                default:
                    Console.WriteLine("Au revoir!");
                    break;
            }
        }
    }
}
