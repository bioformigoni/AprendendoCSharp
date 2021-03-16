using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 7 - Condicionais");
            Console.WriteLine("");

            int idadeJoao = 16;
            if (idadeJoao > 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar.");
            }

            idadeJoao = 18;
            if (idadeJoao > 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar.");
            }

            idadeJoao = 19;
            if (idadeJoao > 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar.");
            }

            idadeJoao = 18;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar.");
            }

            idadeJoao = 16;
            if (idadeJoao > 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar.");
            }
            else
            {
                Console.WriteLine("João não possui mais de 18 anos de idade, não pode entrar.");
            }

            int quantidadePessoas = 2;
            if (idadeJoao >= 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade, pode entrar.");
            }
            else
            {
                if (quantidadePessoas >= 2)
                {
                    Console.WriteLine("João não possui mais de 18 anos de idade, mas está acompanhando, pode entrar.");
                }
                else
                {
                    Console.WriteLine("João não possui mais de 18 anos de idade, não pode entrar.");
                }
            }


            Console.WriteLine("");
            Console.WriteLine("A execução acabou. Tecle ENTER para finalizar...");
            Console.ReadLine();
        }
    }
}
