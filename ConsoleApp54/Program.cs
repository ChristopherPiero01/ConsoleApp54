using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un número máximo de personas: ");
            int max = int.Parse(Console.ReadLine());
            int asist = 0;
            int aforo = 0;
            Console.WriteLine("=========================================");
            Console.WriteLine("El número máximo establecido es de " + max + " personas");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("===================================================");
            Console.WriteLine("| Asistentes actuales | "+ asist);
            Console.WriteLine("| Aforo               | "+ aforo+"%");
            Console.WriteLine("| Máximo              |"+ max+ " personas");
            Console.WriteLine("===================================================");
            Console.WriteLine("Presione");
            Console.WriteLine("[i] si ingresa una persona");
            Console.WriteLine("[s] si sale una persona");
            Console.WriteLine("[x] para terminar");
            ConsoleKey tecla = Console.ReadKey().Key;
            do
            {
                switch (tecla)
                {
                    case ConsoleKey.I: asist++; break;
                    case ConsoleKey.S: asist--; break;
                }
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("===================================================");
                Console.WriteLine("| Asistentes actuales | " + asist);
                Console.WriteLine("| Aforo               | " + aforo + "%");
                Console.WriteLine("| Máximo              |" + max + " personas");
                Console.WriteLine("===================================================");
                Console.WriteLine("Presione");
                Console.WriteLine("[i] si ingresa una persona");
                Console.WriteLine("[s] si sale una persona");
                Console.WriteLine("[x] para terminar");
            } while (tecla != ConsoleKey.Escape);
        }
    }
}
