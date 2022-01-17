using Internal;
using System;

namespace Demos
{
    class Program
    {
        static int Adicionar(int num, int qtd){
            return num+qtd;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a =2;
            Console.WriteLine($"Número: {Adicionar(a, 222)}");
        }
    }
}
