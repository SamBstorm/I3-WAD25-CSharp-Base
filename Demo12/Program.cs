namespace Demo12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom wad25;
            wad25.className = "Web Applications Developpers 2025";
            wad25.students = new List<Student>();

            Student stu1 = new Student();
            stu1.firstName = "Laura";
            stu1.lastName = "Coudyzer";
            wad25.students.Add(stu1);

            Student stu2 = new Student();
            stu2.firstName = "Chuong";
            stu2.lastName = "Tran";
            wad25.AjouterEtudiant(stu2);

            wad25.AjouterEtudiant("Sihame", "Amarouchi");
            wad25.AjouterEtudiant("Orsula", "Karmous");
            wad25.AjouterEtudiant("Akwa", "Poinambalom");
            wad25.AjouterEtudiant(null,null);
            if(wad25.VerifierEtudiant("Akwa", "Poinambalom"))
            {
                Console.WriteLine("Déjà ajoutée");
            }
            else
            {
                wad25.AjouterEtudiant("Akwa", "Poinambalom");
            }


            Console.WriteLine(wad25.className);

            Console.WriteLine($"Actullement, il y a {wad25.AfficherNombreEtudiants()} élèves :");

            wad25.AfficherEtudiants();
        }
    }
}
