using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_take_skip
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> stud = new List<Student>()
            {
                new Student("Mika", 1997, "210/2016", 9),
                new Student("Pera", 1996, "132/2014", 7.8),
                new Student("Marko", 1995, "98/2013", 6.12),
                 new Student("Nikola", 1998, "106/2016", 8.80),
                 new Student("Sara", 1995, "301/2013", 9.7),
                 new Student("Sanja", 1994, "489/2013",7.00),
                 new Student("Milos", 1998, "68/2016", 10),
                 new Student("Nemanja", 1994, "155/2013", 8.6),
                 new Student("Zika", 1998, "55/2016", 6.70),
                new Student("Uros", 1998, "158/2016", 9.50),
            };

            var rezultat = from s in stud //UZIMAMO PODATKE IZ LISTE 
                           orderby s.ProsecnaOcena descending //SORTIRAMO U OPADAJUCEM REDOSLEU (OD Z DO A)
                           select new { s.Ime, s.ProsecnaOcena }; //MORAJU {} KADA SELEKTUJEMO VISE POLJA
            Console.WriteLine("Prva tri studenta sa najvisim ocenama su: ");
            foreach (var s in rezultat.Take(3))
                Console.WriteLine(s);
            Console.WriteLine("================================================");

            Console.WriteLine("Ostali studenti su: ");
            foreach (var s in rezultat.Skip(3))
                Console.WriteLine(s);
            Console.WriteLine("================================================");

            Console.ReadLine();

        }
    }
}
