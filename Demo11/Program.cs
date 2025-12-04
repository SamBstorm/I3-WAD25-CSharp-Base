namespace Demo11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Si les structures n'existaient pas...
            string? birthdateName = "Date naissance Samuel";
            ushort birthdateDay = 27;
            ushort birthdateMonth = 9;
            int birthdateYear = 1987;
            //Peu pratique, beaucoup de déclaration, etc...

            DateCalendrier aujourdhui;
            aujourdhui.annee = 2025;
            aujourdhui.mois = 12;
            aujourdhui.jour = 4;
            aujourdhui.nomEvenement = null;
            Console.WriteLine($"L'anniversaire d'Anaïs est le {aujourdhui.jour}/{aujourdhui.mois:D2}/{aujourdhui.annee}.");

            DateCalendrier birthdate;
            birthdate.nomEvenement = "Date de naissance de Samuel";
            birthdate.jour = 27;
            birthdate.mois = 9;
            birthdate.annee = 1987;

            /* On peut copier directement les valeurs de variables en variables
            DateCalendrier anniversaire;
            anniversaire.nomEvenement = "Anniversaire Samuel";
            anniversaire.jour = birthdate.jour;
            anniversaire.mois = birthdate.mois;
            anniversaire.annee = 2026;*/
            
            /*Mais on peut aussi copier toute la structure !*/

            DateCalendrier anniversaire = birthdate;
            anniversaire.nomEvenement = "Anniversaire Samuel";
            anniversaire.annee = 2026;

            Console.WriteLine($"Si Samuel est né en {birthdate.annee}, son anniversaire est prévu pour {anniversaire.annee}, le {anniversaire.jour}/{anniversaire.mois:D2}, alors il a {anniversaire.annee - birthdate.annee} ans!");

            //DateCalendrier finDuMonde; //Ne permet pas d'obtenir de valeur par défaut...

            DateCalendrier finDuMonde = new DateCalendrier();
            //L'opérateur new permet d'initialiser en mémoire les variables de votre structure. ATTENTION, les valeurs seronts celles par défault.
            Console.WriteLine($"La fin du monde est prévue pour l'année {finDuMonde.annee}");
        }
    }
}
