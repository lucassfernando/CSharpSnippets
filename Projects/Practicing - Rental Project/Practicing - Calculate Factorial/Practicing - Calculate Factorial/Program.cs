using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing___Calculate_Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            Int64 numeroInseridoTotal = Convert.ToInt64(Console.ReadLine());
            Int64 numeroInserido = numeroInseridoTotal;
            Int64 fatorial = 1;

            while (numeroInserido > 0)
            {
                fatorial = fatorial * numeroInserido;
                numeroInserido = numeroInserido - 1;
                Console.WriteLine(fatorial);
            }

            if (numeroInserido >= 0)
            {
                Console.WriteLine("Fatorial(" + numeroInseridoTotal + ") =" + " " + fatorial);
            }
            else
            {
                Console.WriteLine("Não existe fatorial para este numero!");
            }
            
            Console.ReadKey();
        }
    }
}
