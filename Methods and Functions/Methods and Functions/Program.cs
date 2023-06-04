using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeuMetodo();
            string meuNome = RetornaNome("Lucas", "Fernando");
            Console.WriteLine(meuNome);
            Console.ReadKey();
        }

        static void MeuMetodo()
        {
            Console.WriteLine("C#");
        }

        static string RetornaNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }
    }
}
