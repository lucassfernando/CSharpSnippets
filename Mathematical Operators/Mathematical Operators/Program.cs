using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Soma +
            double Numero1 = 10;
            double Numero2 = 15.5;
            double Soma = Numero1 + Numero2;
            Console.WriteLine("Soma: " + Soma);

            //Subtração - 
            double Subtracao = Numero1 - Numero2;
            Console.WriteLine("Subtracao: " + Subtracao);

            //Multiplicação *
            double Multiplicacao = Numero1 * Numero2;
            Console.WriteLine("Multiplicacao: " + Multiplicacao);

            //Divisão / 
            double Divisao = Numero1 / Numero2;
            Console.WriteLine("Divisao: " + Divisao);

            //Resto %
            int Numero3 = 4;
            int Numero4 = 3;
            int ResultadoResto = 4 % 3;
            Console.WriteLine("Resto: " + ResultadoResto);

            //Somar ou subtrair um valor ao conteudo de uma variavel
            double Numero5 = 10;
            Numero5 += Numero5;
            Console.WriteLine(Numero5);

            //Dividir e multiplicar o conteudo de uma variavel por outro valor
            Numero5 = 10;
            Numero5 *= Numero5;
            Numero5 /= Numero5;
            Console.WriteLine(Numero5);

            //Incremento
            Numero5++; //Assim ele soma um na variavel

            //Decremento
            Numero5--; //Assim ele subtrai um na variavel

            Console.ReadKey();



        }
    }
}
