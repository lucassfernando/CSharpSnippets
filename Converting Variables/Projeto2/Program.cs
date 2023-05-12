using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite: ");
            string Idade = Console.ReadLine();
            int IdadeInt = Convert.ToInt32(Idade);

            Console.WriteLine(IdadeInt);

            string Tecla = Console.ReadKey(true).KeyChar.ToString();
            Console.WriteLine("Tecla pressionada: " + Tecla);
            Console.ReadKey();

        }
    }
}
