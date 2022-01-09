using System;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public decimal Nota { get; set; }

        public string Classe { get; set; }

        public int Numero { get; set; }

        public override void Apresentar()
        {   
            System.Console.WriteLine($"");
        }

    }
}