using System;
using System.ComponentModel.Design;

namespace Calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
           // soma();
            //subtracao();
            //divisao();
            //multiplicacao();
        }

        static void menu()
        {
            Console.Clear();
            Console.WriteLine("qual operação matemática  que deseja fazer : ");
            Console.WriteLine("1-soma \n" + "2-subtração\n" + "3-divisão\n" + "4-multiplicação\n");
            Console.WriteLine("***--------------*****-------------***");
            Console.WriteLine("por favor escolha uma opção: ");
            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    soma();
                    break;
                case 2:
                    subtracao();
                    break;
                case 3:
                    divisao();
                    break;
                case 4:
                    multiplicacao();
                    break;
                
                default: menu(); break;
            }
        }

        static void soma()
            {
                Console.Clear();
                Console.WriteLine("digite o primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.WriteLine(" digite o segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                float resultado = v1 + v2;
                Console.WriteLine("o resultado da soma é: " + resultado);
                // Console.WriteLine($" o resultado da soma é:{ resultado} ");
                //Console.WriteLine($"o resultado da soma é: { v1+v2 } ");
                // Console.WriteLine("o resultado da soma é:" + (v1+v2));
            }

            static void subtracao()
            {
                 Console.Clear();
                Console.WriteLine("digite o primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.WriteLine("digite o segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                float resultado = v1 - v2;
                Console.WriteLine("o resultado da subtração é: " + resultado);
            }

            static void divisao()
            {
                 Console.Clear();
                Console.WriteLine("primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.WriteLine("segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());
                float resultado = (v1 / v2);
                Console.WriteLine("o resultado da divisaõ é: " + resultado);
            }

            static void multiplicacao()
            {
                 Console.Clear();
                Console.WriteLine("primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.WriteLine("segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());
                float resultado = v1 * v2;
                Console.WriteLine("o resultado da multiplicação é: " + resultado);
            }
        }
    }
    
