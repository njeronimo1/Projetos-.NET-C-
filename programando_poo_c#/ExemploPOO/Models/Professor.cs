using System;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public string Materia { get; set; }

        public override void Apresentar()
        {
                        
        }
    }
}