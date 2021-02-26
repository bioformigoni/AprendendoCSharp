using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 2 - Criando Variaveis");
            Console.WriteLine("");

            // CShap é fortemente tipado, ou seja, é necessário declarar o tipo da variável
            int idade;

            idade = 32;

            Console.WriteLine(idade);

            idade = 10;
            Console.WriteLine("");
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine("");
            Console.WriteLine(idade);

            idade = 10 + 5 * 2;
            Console.WriteLine("");
            Console.WriteLine(idade);

            idade = (10 + 5) * 2;
            Console.WriteLine("");
            Console.WriteLine("Sua idade é " + idade + "!");

            Console.WriteLine("");
            Console.WriteLine("A execução acabou. Tecle ENTER para finalizar...");
            Console.ReadLine();
        }
    }
}
