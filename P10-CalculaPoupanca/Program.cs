using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");
            Console.WriteLine("");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                // 0.36% = 0.0036
                valorInvestido += valorInvestido * 0.0036;

                if (contadorMes == 1)
                {
                    Console.WriteLine("Após " + contadorMes + " mês, você terá R$" + valorInvestido);
                }
                else
                {
                    Console.WriteLine("Após " + contadorMes + " mêses, você terá R$" + valorInvestido);
                }

                contadorMes ++;
            }

            Console.WriteLine("");
            Console.WriteLine("A execução acabou. Tecle ENTER para finalizar...");
            Console.ReadLine();
        }
    }
}
