using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array de 1 dimensão
            int[] meuArray1 = new int[] {1};
            meuArray1 = meuArray1.Append(2).ToArray();
            Console.WriteLine(meuArray1[1]);

            //Outras maneiras de criar um array
            int[] meuArray2 = {1, 2, 3};
            Console.WriteLine(meuArray2[0]);

            //Array de 2 dimensões
            string[ , ] meuArray3 = new string[2, 3];
            meuArray3[0, 0] = "1";
            meuArray3[0, 1] = "2";
            meuArray3[1, 0] = "3";
            meuArray3[1, 1] = "4";

            Console.WriteLine(meuArray3[0, 0]);
            Console.WriteLine(meuArray3[0, 1]);
            Console.WriteLine(meuArray3[1, 0]);
            Console.WriteLine(meuArray3[1, 1]);

            //Outras maneiras de iniciar um array de 2 dimensões
            string[,] meuArray4 = { { "1", "2", "3" }, { "11", "12", "13" } };
            Console.Write(meuArray4[0, 0]);

            //O numero de elementos do array

            int tamanhoArray = meuArray4.GetLength(0);
            Console.WriteLine(tamanhoArray);

            Console.ReadKey();

        }
    }
}
