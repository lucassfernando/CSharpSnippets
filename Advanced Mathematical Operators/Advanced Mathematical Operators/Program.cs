using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Mathematical_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Potenciação
            double Potencia = Math.Pow(4, 2);
            Console.WriteLine(Potencia);

            //Radiciação
            double Raiz = 3;
            double Radiacao = Math.Pow(27, 1/Raiz);
            Console.WriteLine(Radiacao);

            //Maximo e minimo
            double Maximo = Math.Max(4, 8);
            double Minimo = Math.Min(4, 8);
            Console.WriteLine(Maximo);
            Console.WriteLine(Minimo);

            //Modulo
            double Modulo = Math.Abs(-10);
            Console.WriteLine(Modulo);

            //Operações trigonometricas
            /*
             Seno = sin
            Cosseno = cos
            Tangente = tan
             */
            double Angulo = 30 * (2 * Math.PI) / 360;
            double Seno = Math.Sin(Angulo);
            Console.WriteLine(Seno);

            /*
             Arcseno = Asin
            Arccosseno = Acon
            Arctangente = Ata
             */
            double Arseno = Math.Asin(Seno);
            Console.WriteLine(Arseno);
            double ArcsenoGraus = Arseno * 360 / (2 * Math.PI);
            Console.WriteLine(ArcsenoGraus);

            //Arredondando numeros
            double numero = 3.33;
            double arredondandoParaCima = Math.Ceiling(numero);
            double arredondandoParaBaixo = Math.Floor(numero);
            Console.WriteLine(arredondandoParaCima);
            Console.WriteLine(arredondandoParaBaixo);

            //Logaritmo
            double logaritmo = Math.Log10(100);
            Console.WriteLine(logaritmo);

            double baseE = Math.Log(Math.E * Math.E * Math.E);
            Console.WriteLine(baseE);

            Console.ReadKey();


        }
    }
}
