using System;

namespace Calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            soma();
            subtracao();
            divisao();
            multiplicacao();
        }
        static void soma()
        {
            //Console.Clear();
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
           // Console.Clear();
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
           // Console.Clear();
            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float  resultado = (v1 / v2);
            Console.WriteLine("o resultado da divisaõ é: " + resultado);
        }
        static void multiplicacao()
        {
           // Console.Clear();
            Console.WriteLine("primeiro valor: ");
            float v1 = float.Parse( Console.ReadLine());
            Console.WriteLine("segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());
            float resultado = v1 * v2;
            Console.WriteLine("o resultado da multiplicação é: "+ resultado);
        }
    }
}
    
