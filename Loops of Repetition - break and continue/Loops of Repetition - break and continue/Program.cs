using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loops_of_Repetition___break_and_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pessione C para continuar");
                Console.WriteLine("Pressione B para parar");
                string tecla = Console.ReadKey(true).KeyChar.ToString();

                if( tecla == "c" )
                {
                    Console.WriteLine("Continuando...");
                    continue;

                } 
                else if( tecla == "b" )
                {
                    Console.WriteLine("Parando...");
                    Thread.Sleep(2000); 
                    break;
                }
                else
                {
                    Console.WriteLine("Tecla incorreta");
                }
            }

        }
    }
}
