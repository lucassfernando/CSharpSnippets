using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int Idade = 20;            
            string Nome = "Lucas Fernando";
            //byte b = 1000; O valor é muito grande para essa variavel o maximo é 255
            var Salario = 1200;
            DateTime data = new DateTime(2003, 5, 2, 8, 5, 10);
            string NumeroCasa = "100";
            int NumeroCasaInt = Convert.ToInt32(NumeroCasa);
            Type type = NumeroCasa.GetType();

            //Vou brincar um pouco com a tabela ASCII abaixo:

            int Numero2 = 50;
            char NumeroDois = Convert.ToChar(Numero2);
            int Voltando2 = Convert.ToInt32(NumeroDois);


            Console.WriteLine(Voltando2);
            Console.ReadKey();


        }
    }
}
