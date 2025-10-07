using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Introduza o número:  ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int maximo = numeros[0];
            Console.WriteLine("maximo: {1}", maximo);
            
            int indice = 0;

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                    indice = i;
                }
            }
            Console.WriteLine("O maior valor é {0} e encontra-se no índice {1}.", maximo, indice);
            Console.WriteLine("Maior número: {0}, índice: {1}.", maximo, indice);
            Console.WriteLine("**************************");
            Console.ReadKey();
        }
    }
}
