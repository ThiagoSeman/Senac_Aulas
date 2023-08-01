// See https://aka.ms/new-console-template for more information

using Aula1.Model;
using System;

namespace Aula1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static Pessoa Cliente { get; set; }=new Pessoa();

        static void Main(string[] args)
        {
            Cliente.id = 1;
            Cliente.nome = "Gilberto";
            Cliente.DataNac = (new DateTime(31 / 08 / 2023));
            Cliente.CPF = "222.222.222-22";
            Cliente.endereco = new Endereco();
            Cliente.endereco.id = 1;
            Cliente.endereco.logradouro = "Rua Brasil";
            Cliente.endereco.numero = "ao lado do 500";
            
        Console.WriteLine($"ID = {Cliente.id}");
        }
    }
}


