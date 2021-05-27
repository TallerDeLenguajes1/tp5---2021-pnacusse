using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("Calculadora");
            Console.WriteLine("\n");
            while(num != 5)
            {
                Console.WriteLine("1.Sumar");
                Console.WriteLine("2.Restar");
                Console.WriteLine("3.Multiplicar");
                Console.WriteLine("4.Dividir");
                Console.WriteLine("\n");
                Console.WriteLine("5.Salir");

                num = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();
        }
    }
}
