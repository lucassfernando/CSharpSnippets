using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Projeto4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {

                Console.WriteLine("Digite seu nome:");
                string Nome = Console.ReadLine();

                Console.WriteLine("Digite sua idade:");
                UInt16 Idade = Convert.ToUInt16(Console.ReadLine());

                Console.WriteLine("Digite seu sexo M ou F:");
                string Genero = Console.ReadKey(true).KeyChar.ToString();

                Console.WriteLine("Digite seu documento:");
                string Documento = Console.ReadLine();

                Console.WriteLine("Digite sua rua:");
                string Rua = Console.ReadLine();

                Console.WriteLine("Digite numero da sua casa:");
                UInt32 NumeroDaCasa = Convert.ToUInt32(Console.ReadLine());

                Console.WriteLine("\r\nSuas informações...");
                Console.WriteLine("\r\nNome: " + Nome);
                Console.WriteLine("Idade: " + Idade);
                Console.WriteLine("Genero: " + Genero);
                Console.WriteLine("Documento: " + Documento);
                Console.WriteLine("Rua: " + Rua);
                Console.WriteLine("Numero da casa: " + NumeroDaCasa);

                Console.ReadKey();

            }
            catch
            {

                Console.WriteLine("\r\nErro nas infomações inseridas!");

            }
            finally
            {

                Console.WriteLine("Fechando programa...");
                Console.ReadKey();

            }

        }
    }
}
