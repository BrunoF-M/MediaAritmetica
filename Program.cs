using System;

namespace MediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.ForegroundColor=ConsoleColor.DarkGreen;

            Console.WriteLine("Calculadora de Aritmética de 3 números");
            Console.WriteLine();
            
            Console.ResetColor();

double num1;
            Console.Write("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

double num2;
            Console.Write("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

double num3;
            Console.Write("Digite o terceiro número: ");
            num3 = double.Parse(Console.ReadLine());

double Res;            
            Res= (num1 + num2 + num3) /3;


            Console.ForegroundColor=ConsoleColor.DarkGreen;

            Console.WriteLine();
            Console.WriteLine($"Média: {Res}");
            Console.ResetColor();


            Console.WriteLine();

            Console.WriteLine("Aperte qualquer tecla para finalizar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
