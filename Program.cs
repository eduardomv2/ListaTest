using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Ingrese 5 números para ordenar:");

            for (int i = 0; i < 5; i++)
            {
                int input;
                do
                {
                    Console.Write($"Número {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out input))
                    {
                        numbers.Add(input);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Número inválido. Ingrese un número válido.");
                    }
                } while (true);
            }

            // Ordenar la lista de mayor a menor
            numbers.Sort((a, b) => b.CompareTo(a));

            Console.WriteLine("Lista ordenada de mayor a menor:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
                Console.ReadLine(); 
            }
        }
    }
}
