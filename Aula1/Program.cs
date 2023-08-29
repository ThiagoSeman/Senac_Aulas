// See https://aka.ms/new-console-template for more information

using Aula1.Model;

namespace Aula1 // Note: actual namespace depends on the project name.
{

    internal class Program
    {
        //public static Pessoa Cliente { get; set; } 
        public static List<Pessoa> Pessoas { get; set; } = new();

        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        static bool MainMenu()
        {
            Console.WriteLine($"-----------Menu Pessoa -----------");
            Console.WriteLine($"Digite 1 para inserir:");
            Console.WriteLine($"Digite 2 para Ver lista:");
            var linha = Console.ReadLine();
            if (linha == "1")
            {               
                InserirPessoa();
                return true;
            }
            else if (linha == "2")
            {
                PrintarPessoas();
                return true;
            }
            else
            {
                return true;
            }
        }
        private static void InserirPessoa()
        {
            Pessoa Cliente = new Pessoa();
            Cliente.id = Guid.NewGuid();
            Console.WriteLine($"Digite o Nome :");
            Cliente.nome = Console.ReadLine();
            Console.WriteLine($"Digite o CPF :");
            Cliente.CPF = Console.ReadLine();

            Cliente.endereco = new List<Endereco> {};

            bool showMenuend = true;
            while (showMenuend)
            {
                Console.WriteLine($"-----------Menu Endereço -----------");
                Console.WriteLine($"Digite 1 para inserir Endereço:");
                Console.WriteLine($"Digite 2 para Sair");
                var linha = Console.ReadLine();
                if (linha == "1")
                {
                    Cliente.endereco.Add(InserirEndereco());
                    showMenuend = true;
                }
                else if (linha == "2")
                {
                    showMenuend = false;
                }
            }
            Pessoas.Add(Cliente);
        }

        private static Endereco InserirEndereco()
        {
            Endereco endereco = new Endereco();

            endereco.id = Guid.NewGuid();
            Console.WriteLine($"Digite o Logradouro :");
            endereco.logradouro = Console.ReadLine();
            Console.WriteLine($"Digite o Numero ou uma Referencia :");
            endereco.numero = Console.ReadLine();

            return endereco;
        }

        public static void PrintarPessoas()
        {
            if (Pessoas.Count == 0)
            {
                Console.WriteLine($"Nao tem pessoas cadatradas");
            }
            else
            {
                foreach (var p in Pessoas)
                {
                    Console.WriteLine($"ID = {p.id}");
                    Console.WriteLine($"Nome = {p.nome}");
                    Console.WriteLine($"CPF = {p.CPF}");
                    if (p.endereco.Count > 0)
                    {
                        foreach (var en in p.endereco)
                        {
                            Console.WriteLine($"Endereço Logradouro  = {en.logradouro}");
                            Console.WriteLine($"Endereço Numero  = {en.numero}");
                        }
                    }
                }
            }

        }
    }
}


