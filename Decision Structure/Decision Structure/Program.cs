using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Structure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite sua idade: ");
            UInt32 Idade = Convert.ToUInt32(Console.ReadLine());

            //if... else...
            if(Idade >= 18)
            {
                Console.WriteLine("Voce é maior de idade!");
            }
            else
            {
                Console.WriteLine("Voce é menor de idade!");
            }

            Console.WriteLine("Digite seu salario: ");
            UInt32 Salario = Convert.ToUInt32(Console.ReadLine());

            //if... else... if
            if(Salario < 1000)
            {
                Console.WriteLine("Salario é menor que 1000");
            }
            else if(Salario < 2000)
            {
                Console.WriteLine("Salario é menor que 2000");
            }
            else
            {
                Console.WriteLine("vc tem grana");
            }

            char Tecla = Console.ReadKey(true).KeyChar;

            //switch
            switch(Tecla)
            {
                case 'a':
                    Console.WriteLine("Tecla: a");
                    break;
                case 'b':
                    Console.WriteLine("Tecla: b");
                    break;
                default:
                    Console.WriteLine("Tecla: " + Tecla + " :)");
                    break;
            }

        }
    }
}
