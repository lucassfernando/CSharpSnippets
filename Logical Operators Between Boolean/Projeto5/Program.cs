using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool Var1 = true;
            bool Var2 = false;

            //Negação
            bool negacao1 = !Var1;
            bool negacao2 = !Var2;  

            Console.WriteLine("A negacao de " +  Var1 + " é " + negacao1);
            Console.WriteLine("A negacao de " + Var2 + " é " + negacao2);

            //Operador E (AND) - &
            bool ResultadoE1 = Var1 & Var1;
            bool ResultadoE2 = Var2 & Var2;
            bool ResultadoE3 = Var1 & Var2;
            bool ResultadoE4 = Var2 & Var1;

            Console.WriteLine("\r\n"+ResultadoE1);
            Console.WriteLine(ResultadoE2);
            Console.WriteLine(ResultadoE3);
            Console.WriteLine(ResultadoE4);

            //Operador OU (OR) - |
            bool ResultadoOu1 = Var1 | Var1;
            bool ResultadoOu2 = Var2 | Var2;
            bool ResultadoOu3 = Var1 | Var2;
            bool ResultadoOu4 = Var2 | Var1;

            Console.WriteLine("\r\n" + ResultadoOu1);
            Console.WriteLine(ResultadoOu2);
            Console.WriteLine(ResultadoOu3);
            Console.WriteLine(ResultadoOu4);

            //Operador OU EXCLUSIVO (XOR) - ^
            bool ResultadoXor1 = Var1 ^ Var1;
            bool ResultadoXor2 = Var2 ^ Var2;
            bool ResultadoXor3 = Var1 ^ Var2;
            bool ResultadoXor4 = Var2 ^ Var1;

            Console.WriteLine("\r\n" + ResultadoXor1);
            Console.WriteLine(ResultadoXor2);
            Console.WriteLine(ResultadoXor3);
            Console.WriteLine(ResultadoXor4);

            Console.ReadKey();

        }
    }
}
