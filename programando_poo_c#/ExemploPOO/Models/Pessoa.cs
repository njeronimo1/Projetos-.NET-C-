using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }  

        public string Rg { get; set; }

        public string Cpf { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Para se cadastrar precisa de Nome, Idade, Rg e Cpf");
        }
    }
}