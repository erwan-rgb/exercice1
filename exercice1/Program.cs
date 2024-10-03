using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom = "menez";
            string prenom = "erwan ";
            int age = 23, cal1 = 5, cal2 = 10;

            Console.WriteLine("Bonjour " + prenom + nom + " vous avez " + age + " ans");
            Console.WriteLine("résultat = " + (cal1 + cal2));
            Console.ReadLine();
        }
    }
}
