using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Cliente("Lucas", EEstadoCivil.Divorciado);
            Console.WriteLine(cliente.Nome);
            Console.WriteLine(cliente.Type);

            Console.ReadKey();
        }
    }

    struct Cliente
    {

        public Cliente(string nome, EEstadoCivil type)
        {
            Nome = nome;
            Type = type;
        }
        public string Nome;
        public EEstadoCivil Type;

    }
    enum EEstadoCivil
    {
        Solteiro = 1,
        Casado = 2,
        Divorciado = 3
    }

}
