using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 10)// execution de la boucle tant que counter est en dessous de 10
            {
                Console.WriteLine("Bonjour, je ne suis qu'un simple message.");
                counter++; //incrémentation de la boucle
            }
            /*
            do
            {
                Console.WriteLine("Bonjour, je ne suis qu'un simple message.");
                counter++;
            }
            while (counter < 10);
            */
        }
    }
}
