using System;

namespace OlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.ForegroundColor=ConsoleColor.DarkRed;
            Console.Write("Digite seu nome: ");
            string textoDigitado = Console.ReadLine();
            Console.ForegroundColor=ConsoleColor.Green;
            Console.Write("Olá, ");
            Console.Write(textoDigitado);
            Console.WriteLine("!");
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadLine();
            Console.WriteLine("Obrigada por ajudar com meu exercício :) ");
            Console.ResetColor();
          
        }
        }
}
