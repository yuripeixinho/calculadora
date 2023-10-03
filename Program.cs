using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace pratica1
{
    internal class Program
    {

  

        static void Main(string[] args)
        {
            double num1, num2;
            char operacao;
            double resultado = 0.0;

            Console.WriteLine("-------------------------------");
            Console.WriteLine("--- CALCULADORA DO PEIXINHO ---");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("Digite a operação:");
            Console.WriteLine("[+] SOMA");
            Console.WriteLine("[-] SUBTRAÇÃO");
            Console.WriteLine("[*] MULTIPLICAÇÃO");
            Console.WriteLine("[/] DIVISÃO");
            operacao = Convert.ToChar(Console.ReadLine());

            switch (operacao)
            {
                case '+':
                    Console.Clear();
                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num1 + num2;
                    break;

                case '-':
                    Console.Clear();
                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num1 - num2;
                    break;

                case '*':
                    Console.Clear();
                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
                    resultado = num1 * num2;
                    break;

                case '/':
                    Console.Clear();
                    Console.WriteLine("Digite o primeiro número: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite o segundo número: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Erro: Divisão por zero!");
                        return;
                    }

                default:
                    Console.WriteLine("Operação inválida!");
                    return;
            }

            Console.WriteLine($"Resultado: {num1} {operacao} {num2} = {resultado}");


        }



    }
}
 