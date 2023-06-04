using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse", 100);

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Nome);
            Console.WriteLine(mouse.Preco);

            Console.ReadKey();
        }
    }

    struct Product
    {
        public Product(int id, string nome, double preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public int Id;
        public string Nome;
        public double Preco;
        public double PrecoEmDolar(double dolar)
        {
            return Preco * dolar;
        }

    }
}
