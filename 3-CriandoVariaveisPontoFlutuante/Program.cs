using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CriandoVariaveisPontoFlutuante
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 3 - Criando Variaveis de Ponto Flutuante");
            Console.WriteLine("");

            double salario;
            salario = 1200.70;
            Console.WriteLine(salario);

            // Inteiros não admitem double, mas double admite inteiros
            double idade;
            idade = 15;
            Console.WriteLine(idade);

            // O C# verifica apenas oq está na expressão, por isso se dividir um numero inteiro por outro inteiro
            // o resultado perde a precisão mesmo q esteja classificado como double
            idade = 15 / 2;
            Console.WriteLine("15/2 = " + idade);

            idade = 5 / 3;
            Console.WriteLine("5/3 = " + idade);

            // Se tiver um double envolvido na operação o resultado é double
            idade = 15.0 / 2;
            Console.WriteLine("15.0/2 = " + idade);

            idade = 15 / 2.0;
            Console.WriteLine("15/2.0 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0/3 = " + idade);


            Console.WriteLine("");
            Console.WriteLine("A execução acabou. Tecle ENTER para finalizar...");
            Console.ReadLine();
        }
    }
}
