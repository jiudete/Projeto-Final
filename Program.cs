using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jiudete_TF
{
    internal class Program
    {
        public static double[] motores = new double[14];
        public static string lancarGasto(double[] motor)
        {
            Console.WriteLine("Informe o Motor [1-15]");


            int indice = int.Parse(Console.ReadLine());
            if (indice > motor.Length || indice < 0)
            {
                Console.WriteLine("motor não consta!");
            }
            else
            {
                Console.WriteLine("informe o valor gasto:");
                double valor = double.Parse(Console.ReadLine());
                motor[indice] = valor;
            }
            return "";
        }
        public static double mostrarGastos(double[] motor, double total)
        {
            for (int ii = 0; ii < motor.Length; ii++)
            {
                Console.WriteLine("motor {0} gastou R${1}", ii + 1, motor[ii]);
                total += motor[ii];
            }
            Console.WriteLine("o total é: R$" + total);
            return total;
        }
        public static string maiorGasto(double[] motor, double maiorvalor)
        {
            int maior = 0;
            for (int ii = 0; ii < (motor.Length); ii++)
            {
             
                if (motor[maior] < motor[ii])
                {
                    maior += ii;
                    maiorvalor = motor[maior];
                }
            }
            Console.WriteLine("O motor " + maior + "gastou mais: R$" + maiorvalor);
            return "";
        }

        static void Main(string[] args)
        {
            int seletor = 1;
            double total = 0;
            double maiorvalor = 0;
            Console.WriteLine("Escolha uma opção: \n 0 - sair\n 1 - lancar\n 2 - total\n 3 - maior gasto");

            while (seletor != 0)
            {

                Console.WriteLine("Escolha uma opção:");
                seletor = int.Parse(Console.ReadLine());
                if (seletor == 1)
                {
                    Console.WriteLine("Sua opção: " + seletor);
                    lancarGasto(motores);
                }
                else if (seletor == 2)
                {
                    Console.WriteLine("Sua opção: " + seletor);
                    mostrarGastos(motores, total);

                }
                else if (seletor == 3)
                {
                    Console.WriteLine("Sua opção: " + seletor);
                    maiorGasto(motores, maiorvalor);

                }
                else if (seletor == 0)
                {
                    Console.WriteLine("Sua opção: " + seletor);
                    Console.WriteLine("**************-Fim-*************");
                }
                else
                    Console.WriteLine("opção inválida");
            }

        }
    }
}




