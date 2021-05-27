using System;

namespace ejercicio1
{
    class Program
    {
        private static int OrdenInverso(int numero)
        {
            int resultado = 0;
            while (numero > 0)
            {
                resultado = resultado * 10 + numero % 10;
                numero /= 10;
            }
            return resultado;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());
            int numeroInverso = OrdenInverso(numero);

            Console.WriteLine("El numero inverso de {0}, es {1}", numero, numeroInverso);
            Console.ReadLine();
        }
    }
}
