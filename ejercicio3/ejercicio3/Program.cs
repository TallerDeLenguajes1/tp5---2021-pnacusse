using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            double num = int.Parse(Console.ReadLine());

            double valorAbsoluto = Math.Abs(num);
            double cuadrado = Math.Pow(num, 2);
            double raizCuadrada = Math.Sqrt(num);
            double seno = Math.Sin(num);

        }
    }
}
