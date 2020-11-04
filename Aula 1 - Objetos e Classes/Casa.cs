using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1___Objetos_e_Classes
{
    class Casa
    {
        public int numComodos;
        public int numPortas;
        public double preco;
        public string endereco;
        public string cor;

        public void imprimirCaracteristicas()
        {
            Console.WriteLine($"Numeros dos Comodos: {numComodos}\nNumeros das Portas: {numPortas}\n" +
                $"Endereço: {endereco}\nCor: {cor}");
        }
        public void ImprimirPreco()
        {
            Console.WriteLine($"O valor da casa é: R${preco}");
        }
    }
}
