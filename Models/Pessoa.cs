using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; } 
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void Apresentar()
        {
            Console.WriteLine($"Olá, sou {Nome} e tenho {Idade} anos!");
        }
    }
}
