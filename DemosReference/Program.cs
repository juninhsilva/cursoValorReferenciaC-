using System;

namespace DemosReference
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = "Juninh";
            pessoa.Idade = 32;
            pessoa.Documento = "12027160";

            pessoa.Alterar("Juninh Silva");
            Console.WriteLine($"Nome: {pessoa.Nome}\nIdade: {pessoa.Idade}\nDocumento: {pessoa.Documento}");
        }
    }
}
