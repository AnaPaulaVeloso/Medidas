using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            double metros, metrosCm, metrosKm;
            Console.Write("Entre com a medida em (m):");
            metros = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEquivalência");

            metrosCm = metros*100;

            Console.WriteLine($"{metrosCm} cm");
            Console.WriteLine($"{metros} m");

            metrosKm = metros/1000;

            Console.WriteLine($"{metrosKm} Km");


        }
    }
}
