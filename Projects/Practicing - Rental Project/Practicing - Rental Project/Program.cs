using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing___Rental_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual seu nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Olá " + Nome);
            Console.WriteLine("Bem-vindo a locadora MultiFilmes!");
            Console.WriteLine("Qual sua idade: ");
            UInt16 Idade = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("\r\n↓ Filmes disponiveis para a sua idade ↓\r\n");

            List<string> ListaFilmes12Anos = new List<string>()
            {
                "O Rei Leão",
                "Toy Story",
                "Procurando Nemo"
            };

            List<string> ListaFilmes16Anos = new List<string>()
            {
                "Harry Potter",
                "Jogos Vorazes",
                "A Culpa é das Estrelas"
            };

            List<string> ListaFilmes18Anos = new List<string>()
            {
                "O Poderoso Chefão",
                "Clube da Luta",
                "Matrix"
            };

            UInt16 Contador = 1;

            if (Idade <= 12)
            {
                foreach (var Filmes in ListaFilmes12Anos)
                {
                    Console.WriteLine(Contador + " - " + Filmes);
                    Contador++;
                }
                Console.WriteLine("\r\nEscolha: ");
                UInt16 FilmeEscolhido = Convert.ToUInt16(Console.ReadLine());
                Console.WriteLine("\r\nFilme escolhido: " + ListaFilmes12Anos[FilmeEscolhido - 1]);
            }
            else if (Idade <= 16) 
            {
                foreach (var Filmes in ListaFilmes16Anos)
                {
                    Console.WriteLine(Contador + " - " + Filmes);
                    Contador++;
                }
                Console.WriteLine("\r\nEscolha: ");
                UInt16 FilmeEscolhido = Convert.ToUInt16(Console.ReadLine());
                Console.WriteLine("\r\nFilme escolhido: " + ListaFilmes16Anos[FilmeEscolhido - 1]);
            }
            else
            {
                foreach (var Filmes in ListaFilmes18Anos)
                {
                    Console.WriteLine(Contador + " - " + Filmes);
                    Contador++;
                }
                Console.WriteLine("\r\nEscolha: ");
                UInt16 FilmeEscolhido = Convert.ToUInt16(Console.ReadLine());
                Console.WriteLine("\r\nFilme escolhido: " + ListaFilmes18Anos[FilmeEscolhido - 1]);
            }

            Console.ReadKey();



        }
    }
}
