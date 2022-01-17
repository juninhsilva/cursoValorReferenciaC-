using System;
using System.Globalization;
namespace DemosReference
{
    public class Pessoa
    {
        public string Nome{get;set;}
        public int Idade{get;set;}
        public string Documento{get;set;}

        public void Alterar(string nome){
            Nome = nome;
        }
    }
}