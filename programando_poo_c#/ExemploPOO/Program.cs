using System;
using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Models;
using System.Collections.Generic;

namespace ExemploPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            Professor[] professors = new Professor[5];
            
            var indiceAluno = 0;
            var indiceProfessor = 0;
            string opcaoUsuario = ObterOpcaoUsuario();
            
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                    Console.WriteLine("Insira um aluno");
                    Aluno aluno = new Aluno();
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("Insira a Classe do aluno");
                    aluno.Classe = Console.ReadLine();
                    aluno.Rg = "543.987.793-3";
                    aluno.Cpf = "345.323.456-32";

                    
                    Console.WriteLine("Insira a nota do Aluno");
                    if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {
                        aluno.Nota = nota;
                    }
                    else
                    {
                        throw new ArithmeticException("Valor da nota deve ser decimal");
                    }

                    Console.WriteLine("Insira o numero do Aluno");
                    if(int.TryParse(Console.ReadLine(), out int numero))
                    {
                        aluno.Numero = numero;
                    }else{
                        throw new ArithmeticException("Valor do número deve ser decimal");
                    }

                    alunos[indiceAluno] = aluno;
                    indiceAluno++;

                        break;
                    //INSERIR ALUNOS

                    case "2":
                        Console.WriteLine("Insira um professor");
                        Professor prof = new Professor();
                        prof.Nome = Console.ReadLine();
                        
                        Console.WriteLine("Insira a matéria que professora atuará");
                        prof.Materia = Console.ReadLine();

                        Console.WriteLine("Insira o salário do professor");
                        if(double.TryParse(Console.ReadLine(), out double salario))
                        {
                            prof.Salario = salario;
                        }
                        
                        break;
                    //INSERIR PROFESSORES
                    case "3":

                        foreach (var item in alunos)
                        {
                            if(!string.IsNullOrEmpty(item.Nome))
                            {
                                Console.WriteLine($"Aluno {item.Nome}, classe {item.Classe} com RG de número {item.Rg} e CPF {item.Cpf}, de número {item.Numero} tem nota {item.Nota} em todas as matérias");
                            }
                        }
                        break;
                    //LISTAR ALUNOS
                    case "4":

                        foreach (var profers in professors)
                        {
                            if(!string.IsNullOrEmpty(profers.Nome))
                            {
                                Console.WriteLine($"O nome do Professor é {profers.Nome}, ele vai ganhar {profers.Salario} e dará aula de {profers.Materia}");
                            }
                        }
                        break;
                    //LISTAR PROFESSORES
                    default: 
                        throw new ArgumentOutOfRangeException();     
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }

        }
        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir novo Aluno");
            Console.WriteLine("2 - Inserir novo Professor");
            Console.WriteLine("3 - Listar Alunos");
            Console.WriteLine("4 - Listar Professores");

            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();

            return opcaoUsuario;
        }
    }
}
