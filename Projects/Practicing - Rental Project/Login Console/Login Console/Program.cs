using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Login_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dicionarioDeLogin = new Dictionary<string, string>();
         
            string Login(string usuario, string senha)
            {
                if (dicionarioDeLogin.ContainsKey(usuario))
                {
                    if (senha == dicionarioDeLogin[usuario])
                    {
                        return "Login com sucesso!\r\n";
                    }
                    else
                    {
                        return "Senha invalida.\r\n";
                    }
                }
                else
                {
                    return "Usuario não encontrado.\r\n";
                }
            }

            string Registrar(string usuario, string senha)
            {
                dicionarioDeLogin.Add(usuario, senha);
                return ("Usuario cadastrado!\r\n");
            }

            while (true)
            {
                Console.Write("1 - Login\r\n2 - Registrar\r\n3 - Sair\r\n>>>");
                string opcaoMenuEscolhida = Console.ReadLine();
                string usuario = "";
                string senha = "";

                switch (opcaoMenuEscolhida)
                {
                    case "1":
                        Console.Write("\r\nUsuario: ");
                        usuario = Console.ReadLine();
                        Console.Write("Senha: ");
                        senha = Console.ReadLine();

                        string loginRetorno = Login(usuario, senha);
                        Console.WriteLine(loginRetorno);
                        break;
                    case "2":
                        Console.Write("\r\nUsuario: ");
                        usuario = Console.ReadLine();
                        Console.Write("Senha: ");
                        senha = Console.ReadLine();

                        string cadastrarRetorno = Registrar(usuario, senha);
                        Console.WriteLine(cadastrarRetorno);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Tecla incorreta...");
                        break;
                }

                
            }


        }


    }
}
