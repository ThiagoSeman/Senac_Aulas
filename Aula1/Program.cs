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
            Console.WriteLine($"Digite 1 para inserir:");
            Console.WriteLine($"Digite 2 para Ver lista:");
            var linha = Console.ReadLine();
            if (linha == "1")
            {
               // Cliente.endereco = new Endereco();
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
            /*
            Cliente.id = Guid.NewGuid();
            Cliente.nome = "Gilberto";
            Cliente.DataNac = new DateTime(2023,7,31,08,20,20);
            Cliente.CPF = "222.222.222-22";
            Cliente.endereco = new Endereco();
            Cliente.endereco.id = Guid.NewGuid();
            Cliente.endereco.idCliente = Cliente.id;
            Cliente.endereco.logradouro = "Rua Brasil";
            Cliente.endereco.numero = "ao lado do 500";
            */
        }

        private static void InserirPessoa()
        {
            Pessoa Cliente = new Pessoa();
            Cliente.id = Guid.NewGuid();
            Console.WriteLine($"Digite o Nome :");
            Cliente.nome = Console.ReadLine();
            Console.WriteLine($"Digite o CPF :");
            Cliente.CPF = Console.ReadLine();
            /*
            Console.WriteLine($"Digite o Logradouro :");
            Cliente.endereco.logradouro = Console.ReadLine();
            Console.WriteLine($"Digite o Numero :");
            Cliente.endereco.numero = Console.ReadLine();
            */

            Pessoas.Add(Cliente);
        }

        public static void PrintarPessoas()
        {
            if (Pessoas.Count == 0)
            {

                Console.WriteLine($"Nao tem pessoas cadatradas");
            }
            else { 

                foreach (var p in Pessoas)
                {
                    Console.WriteLine($"ID = {p.id}");
                    Console.WriteLine($"Nome = {p.nome}");
                    Console.WriteLine($"CPF = {p.CPF}");
                    //Console.WriteLine($"Data de Nascimento: {Cliente.DataNac}");
                    // Console.WriteLine($"Endereço ID = {Cliente.endereco.id}");
                    //  Console.WriteLine($"Endereço Logradouro  = {Cliente.endereco.logradouro}");
                    //  Console.WriteLine($"Endereço Numero  = {Cliente.endereco.numero}");
                }
            }

        }
    }
}


