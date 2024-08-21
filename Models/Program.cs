using System;
using Exemplo.Models;


namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("João", 30);
            p.Apresentar();
        }
    }
}