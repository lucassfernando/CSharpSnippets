using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digging_Into_The_Datetime_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime data = new DateTime(2023, 05, 23);
            DateTime dataHora = new DateTime(2023, 05, 23, 12, 00, 00);


            Console.WriteLine("Data: " + dataHora);
            Console.WriteLine("Dia: " +  dataHora.Day);
            Console.WriteLine("Mes: " + dataHora.Month);
            Console.WriteLine("Ano: " + dataHora.Year);
            Console.WriteLine("Hora: " + dataHora.Hour);
            Console.WriteLine("Minutos: " + dataHora.Minute);
            Console.WriteLine("Segundos: " + dataHora.Second);
            Console.WriteLine("Dia da semana: " + dataHora.DayOfWeek);

            //Pegando a data e a hora atual
            DateTime dataAtual = DateTime.Now;
            Console.WriteLine("Data atual: " + dataAtual);

            //Convertendo uma string em datetime
            DateTime dataConvertida = Convert.ToDateTime("02/05/2003 12:00:00");
            Console.WriteLine(dataConvertida);
            
            //Formatando data e hora impressa
            Console.WriteLine(dataConvertida.ToString("D"));
            Console.WriteLine(dataConvertida.ToString("dd-MM-yyyy"));
            Console.WriteLine(dataConvertida.ToString("HH:mm:ss"));

            //Operações com as variaveis datetime
            DateTime dataNova = dataConvertida;
            dataNova = dataNova.AddDays(5);
            dataNova = dataNova.AddYears(1);
            dataNova = dataNova.Add(new TimeSpan(1, 1, 1));
            Console.WriteLine(dataNova);

            //Subtraindo datas
            DateTime datasSub = dataConvertida;
            datasSub = datasSub.Subtract(new TimeSpan(1, 1, 1));
            datasSub = datasSub.AddDays(-1);
            Console.WriteLine(datasSub);

            Console.ReadKey();





        }
    }
}
