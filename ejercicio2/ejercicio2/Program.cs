using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finalizar = false;

            do
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("Seleccionar una opcion");

                Console.WriteLine("1.Sumar");
                Console.WriteLine("2.Restar");
                Console.WriteLine("3.Multiplicar");
                Console.WriteLine("4.Dividir");
                Console.WriteLine("5.Salir");

                int opcion = int.Parse(Console.ReadLine());
                double resultado = 0;

                Console.WriteLine("Primer numero");
                double n1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Segundo numero");
                double n2 = double.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        resultado = n1 + n2;
                        break;
                    case 2:
                        resultado = n1 - n2;
                        break;
                    case 3:
                        resultado = n1 * n2;
                        break;
                    case 4:
                        resultado = n1 / n2;
                        break;
                }

                Console.WriteLine("Resultado = {0}", resultado);

                Console.WriteLine("Desea realizar otro calculo?(s/n)");
                char c = char.Parse(Console.ReadLine());

                if (c == 's')
                {
                    finalizar = false;
                }
                else
                {
                    finalizar = true;
                }

            } while (!finalizar);

        }
    }
}
