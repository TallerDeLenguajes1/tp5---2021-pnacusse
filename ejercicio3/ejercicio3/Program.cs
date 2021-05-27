using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor Absoluto = {0}", Math.Abs(num));
            Console.WriteLine("Cuadrado = {0}", Math.Pow(num, 2));
            Console.WriteLine("Raiz Cuadrada = {0}", Math.Sqrt(num));
            Console.WriteLine("Seno = {0}", Math.Sin(num));
            Console.WriteLine("Coseno = {0}", Math.Cos(num));
            Console.WriteLine("Parte entera = {0}", Math.Truncate(num));

            Console.WriteLine("Ingrese dos numeros");
            Console.WriteLine("numero 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("numero 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Maximo entre los numeros = {0}", Math.Max(num1,num2));
            Console.WriteLine("Minimo entre los numeros = {0}", Math.Min(num1, num2));

        }
    }
}
