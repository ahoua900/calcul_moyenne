using System;
using System.Collections.Generic;
using System.Linq;

namespace Meslivres
{
    class Program
    {
        static void Main(string[] args)
        {


            Books livreOne = new Books();
            livreOne.Name = "Alladin";
            livreOne.Price = 15000;
            livreOne.Id = 1;

            Books livreTwo = new Books();
            livreTwo.Name = "petit prince";
            livreTwo.Price = 23000;
            livreTwo.Id = 2;

            Books livreThree = new Books();
            livreThree.Name = "TOm et jerry";
            livreThree.Price = 3000;
            livreThree.Id = 3;

            Books livreFour = new Books();
            livreFour.Name = "petit bodiel";
            livreFour.Price = 2000;
            livreFour.Id = 4;

            List<Books> MaBiblio = new List<Books>() { livreOne, livreTwo, livreThree, livreFour };

            var en = from l in MaBiblio where l.Id == 1 || l.Id == 2 || l.Id == 3 || l.Id == 4 select l;

            foreach (var item in en)
            {
                Console.WriteLine("le roman "+" "+item.Name +" coute "+" "+ item.Price);
            }

        }
    }
}
