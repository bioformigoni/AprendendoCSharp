using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 5 - Caractéres e Textos");
            Console.WriteLine("");

            // apenas 1 caracter 16bits
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = ' ';
            Console.WriteLine(primeiraLetra);

            // numero inteiro tem 32bits, por isso é necessária a conversão
            primeiraLetra = (char)65;
            Console.WriteLine(primeiraLetra);

            // É possivel fazer manipulações numéricas com os caractéres
            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine(primeiraLetra);

            // A transformação de numero para caractere segue a Tabela ASC (ex: 61 é "=")
            primeiraLetra = (char)61;
            Console.WriteLine(primeiraLetra);

            string titulo = "Alura cursos de tecnologia";
            Console.WriteLine(titulo);

            Console.WriteLine("");

            titulo = "Alura cursos de tecnologia " + 2020;
            Console.WriteLine(titulo);

            string cursosProgramacao = " - .NET" +
                " - Java" +
                " - JavaScript";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("");

            Console.WriteLine(titulo);
            cursosProgramacao = @" - .NET   
                - Java 
                - JavaScript";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("");

            Console.WriteLine(titulo);
            cursosProgramacao = 
@" - .NET   
 - Java 
 - JavaScript";
            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("");
            Console.WriteLine("A execução acabou. Tecle ENTER para finalizar...");
            Console.ReadLine();
        }
    }
}

