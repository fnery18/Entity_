using Fiap.Exemplo03.UI.Console.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exemplo03.UI.Console
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Digite uma opção: 0 - Cadastrar, 1 - Listar, 2 - Sair");
            int opcao = 0;
            opcao = Convert.ToInt32(System.Console.ReadLine());

            if (opcao == 0)
            {
               
            }
            else if (opcao == 1)
            {

            }
            else
            {
                Environment.Exit(2);
            }


           

        }
    }
}
