using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo");
            Console.WriteLine("");

            int idadeJoao = 18;
            bool acompanhando = true;
            string mensagemAdicional;

            if (acompanhando == true)
            {
                mensagemAdicional = "João está acompanhado";
                Console.WriteLine(mensagemAdicional);
            }
            else 
                mensagemAdicional = "João não está acompanhado";
            

            if (idadeJoao >= 18 || acompanhando)
            {
                Console.WriteLine("João pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else Console.WriteLine("João não pode entrar.");
            

            Console.WriteLine("");
            Console.WriteLine("A execução acabou. Tecle ENTER para finalizar...");
            Console.ReadLine();
        }
    }
}
