using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Condicionais2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 8 - Condicionais 2");
            Console.WriteLine("");

            int idadeJoao = 16;
            int quantidadePessoas = 2;
            if (idadeJoao >= 18 || quantidadePessoas >= 2)
            {
                Console.WriteLine("João pode entrar.");
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }

            if (idadeJoao >= 18 && quantidadePessoas >= 2)
            {
                Console.WriteLine("João pode entrar.");
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }

            idadeJoao = 18;
            bool acompanhando = quantidadePessoas >= 2;
            if (idadeJoao >= 18 && acompanhando)
            {
                Console.WriteLine("João pode entrar.");
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }

            Console.WriteLine("");
            Console.WriteLine("A execução acabou. Tecle ENTER para finalizar...");
            Console.ReadLine();
        }
    }
}

