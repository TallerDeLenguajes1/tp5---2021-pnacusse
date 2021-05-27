using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase");
            string frase = Console.ReadLine();
            Console.WriteLine("La frase ingresada es: {0}", frase);
            Console.WriteLine("Longitud de la cadena = {0}", frase.Length);

        }
    }
}
