using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Operators_Between_Numeric_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Negação - ~
            int Var1 = 0b11001100;
            int ResultadoNegacao = ~Var1;
            Console.WriteLine(Convert.ToString(Var1, 2) + " " + Convert.ToString(ResultadoNegacao, 2));

            //Operador OU (OR) - |
            int Var2 = 0b11001100;
            int Var3 = 0b11110000;
            int ResultadoOu = Var2 | Var3;
            Console.WriteLine(Convert.ToString(Var2, 2) + " " + Convert.ToString(Var3, 2) + " " + Convert.ToString(ResultadoOu, 2));

            //Operador E (AND) - &
            int ResultadoE = Var2 & Var3;
            Console.WriteLine(Convert.ToString(Var2, 2) + " " + Convert.ToString(Var3, 2) + " " + Convert.ToString(ResultadoE, 2));

            //Operador OU EXCLUSIVO (XOR) - ^
            int ResultadorXor = Var2 ^ Var3;
            Console.WriteLine(Convert.ToString(Var2, 2) + " " + Convert.ToString(Var3, 2) + " " + Convert.ToString(ResultadorXor, 2));

            //Operador > e <
            int Var4 = 10;
            int Var5 = 20;
            Console.WriteLine(Var4 > Var5);
            Console.WriteLine(Var4 < Var5);

            //Operador >= e <= 
            Console.WriteLine(Var4 >= Var5);
            Console.WriteLine(Var4 <= Var5);

            //Operador igual - ==
            bool ResultadoIgual = Var4 == Var4;
            Console.WriteLine(ResultadoIgual);
            Console.ReadKey();

        }
    }
}
