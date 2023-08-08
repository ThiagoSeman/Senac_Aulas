// See https://aka.ms/new-console-template for more information

using Aula1.Model;

namespace Aula1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static Pessoa Cliente { get; set; } = new Pessoa();

        static void Main(string[] args)
        {
            Cliente.id = Guid.NewGuid();
            Cliente.nome = "Gilberto";
            Cliente.DataNac = new DateTime(2023,7,31,08,20,20);
            Cliente.CPF = "222.222.222-22";
            Cliente.endereco = new Endereco();
            Cliente.endereco.id = Guid.NewGuid();
            Cliente.endereco.idCliente = Cliente.id;
            Cliente.endereco.logradouro = "Rua Brasil";
            Cliente.endereco.numero = "ao lado do 500";

            InserirPessoa();
            PrintarPessoas(Cliente.id);
        }

        private static void InserirPessoa()
        {
            Console.WriteLine($"Digite o Nome :");
            Cliente.nome = Console.ReadLine();
            Console.WriteLine($"Digite o CPF :");
            Cliente.CPF = Console.ReadLine();
            Console.WriteLine($"Digite o Logradouro :");
            Cliente.endereco.logradouro = Console.ReadLine();
            Console.WriteLine($"Digite o Numero :");
            Cliente.endereco.numero = Console.ReadLine();
        }

        public static void PrintarPessoas(Guid id)
        {
            if(Cliente.endereco.idCliente == id)
            {                
                Console.WriteLine($"ID = {Cliente.id}");
                Console.WriteLine($"Nome = {Cliente.nome}");
                Console.WriteLine($"Data de Nascimento: {Cliente.DataNac}");
                Console.WriteLine($"CPF = {Cliente.CPF}");
                Console.WriteLine($"Endereço ID = {Cliente.endereco.id}");
                Console.WriteLine($"Endereço Logradouro  = {Cliente.endereco.logradouro}");
                Console.WriteLine($"Endereço Numero  = {Cliente.endereco.numero}");
            }
        }
    }
}


