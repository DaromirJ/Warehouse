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
            string imie = "Darisz";
            string nazwisko = "Jóźwicki";
            int wiek = 64;
            string sex = "męszczyzna";
            string pesel = "59010112288";
            int nrPrac = 168;

            Console.Write(nrPrac + "." + imie + nazwisko + wiek + sex + pesel);
        }
    }
}
