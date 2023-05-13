using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_About_Logic_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool Var1 = true;
            bool Var2 = false;
            bool ResultadoOu1 = Var1 | Var2;
            bool ResultadoOu2 = Var1 || Var2;  //Utilizar assim o resultado é o mesmo, porém ele é mais rápido

            bool ResultadoE1 = Var1 & Var2;
            bool ResultadoE2 = Var1 && Var2;   //Utilizar assim o resultado é o mesmo, porém ele é mais rápido

        }
    }
}
