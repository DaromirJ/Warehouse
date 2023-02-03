using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    internal class WorkerList
    {
        static void Main(string[] args)
        {
            string firstName = "Dariusz";
            string lastName = "Jóźwicki";
            int Age = 64;
            string sex = "mężczyzna";
            string pesel = "59010122222";
            int nrWork = 16859;            

            Console.WriteLine("Nr prasownika " + nrWork);
            Console.WriteLine(firstName+ " " + lastName);
            Console.WriteLine("wiek " + Age + ", płeć " + sex + ", PESEL: " + pesel);
        }
    }
}
