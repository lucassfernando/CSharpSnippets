using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_of_Repetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for
            for(int i = 0; i < 10;  i++)
            {
                Console.WriteLine(i);
            }

            //while
            int j = 0;
            while(j < 20)
            {
                Console.WriteLine("oi");
                j += 5;
            }

            //do...while
            int u = 0;
            do
            {
                Console.WriteLine("ola");
            } while(u < 0);

            //foreach
            string[] nomes = { "Lucas", "Leo", "Carlos" };
            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }
    }
}
