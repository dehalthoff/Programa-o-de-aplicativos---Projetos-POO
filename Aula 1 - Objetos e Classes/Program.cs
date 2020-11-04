using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1___Objetos_e_Classes
{
    class Program
    {        
        static void Main(string[] args)
        {
            //william e golle são objetos da classe Funcionario
            //Funcionario william = new Funcionario();
            //william.nome = "william chenta";
            //william.email = "email@email.com";
            //william.idade = 44;

            //Console.WriteLine($"o telefone do {william.nome} é: {william.telefone}");

            //Funcionario golle = new Funcionario();
            //golle.nome = "jorge golle";
            //golle.idade = 40;
            //golle.telefone = "444-4444";

            //Console.WriteLine($"Deseja imprimir a idade do {william.nome} ?");
            //if (bool.Parse(Console.ReadLine()))
            //{
            //    Console.WriteLine($"a idade do {william.nome} é: {william.idade}");
            //}

            Casa casas = new Casa();
            casas.numComodos = 2;
            casas.numPortas = 4;
            casas.preco = 200000.00;
            casas.endereco = "Rua dos Alfeneiros, nº4";
            casas.cor = "Tijolo a vista";

            casas.imprimirCaracteristicas();

            Console.WriteLine("valor da casa!");
           
                casas.ImprimirPreco();
            Console.ReadKey();
        }
    }
}
