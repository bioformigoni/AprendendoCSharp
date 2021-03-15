using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4 - Conversões e outros tipos numéricos");
            Console.WriteLine("");

            double salario = 1200.50;
            Console.WriteLine(salario);

            // Fazer cast : transformar um tipo numérico em outro mesmo perdendo a precisão
            int salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            // int é um número de 32bits valores maiores não podem ser armazenados em variaveis tipo int,
            // mesmo q esse valor seja um número inteiro
            int idade;
            // idade = 13000000000; // Não cabe.
            idade = 1300000000;
            Console.WriteLine(idade);

            // long aceita números inteiros bem maiores 64bits
            long idadeUniverso;
            idadeUniverso = 13000000000;
            Console.WriteLine(idadeUniverso);

            // short tem 16bits, serve para inteiros curtos
            short quantidadeProdutos = 150;
            Console.WriteLine(quantidadeProdutos);

            // float numero de ponto flutuante com baixa precisão
            float altura = 1.70f;
            Console.WriteLine(altura);

            Console.WriteLine("");
            Console.WriteLine("A execução acabou. Tecle ENTER para finalizar...");
            Console.ReadLine();
        }
    }
}
