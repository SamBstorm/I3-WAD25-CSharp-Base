using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo12
{
    public struct ClassRoom
    {
        public string className;
        public List<Student> students;

        public int AfficherNombreEtudiants()
        {
            return students.Count;
        }
        public void AfficherEtudiants()
        {
            foreach (Student stu in students)
            {
                Console.WriteLine($"\t- {stu.firstName} {stu.lastName}");
            }
        }

        public void AjouterEtudiant(string firstname, string lastname)
        {
            if (!TryTrim(firstname, out firstname))
            {
                Console.WriteLine("Erreur : Le prénom n'est pas correct");
                return;
            }
            if (!TryTrim(lastname, out lastname))
            {
                Console.WriteLine("Erreur : Le nom de famille n'est pas correct");
                return;
            }
            Student stu;
            stu.firstName = firstname;
            stu.lastName = lastname;
            AjouterEtudiant(stu);
        }

        public void AjouterEtudiant(Student etudiant)
        {
            students.Add(etudiant);
        }

        public bool VerifierEtudiant(string firstname, string lastname)
        {
            foreach (Student stu in students)
            {
                if(stu.firstName == firstname && stu.lastName == lastname)
                {
                    return true;
                }
            }
            return false;
        }

        public bool TryTrim(string text, out string trimmedText)
        {
            trimmedText = null;

            if(text.Trim().Length != text.Length)
            {
                trimmedText = text.Trim();
                return true;
            }

            return false;
        }
    }
}
