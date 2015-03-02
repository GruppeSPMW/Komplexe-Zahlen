using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KomplexeZahlen;


namespace Komplexrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            
            Rechner A = new Rechner();
            A.eingeben();
            A.Auswahl();
            Console.ReadKey(); 
           
        }
    }
}
