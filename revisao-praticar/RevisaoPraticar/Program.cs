using System;
using RevisaoPraticar;

namespace RevisaoPraticar
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario.ToUpper() != "X")
            {
                switch( opcaoUsuario )
                {
            
                    case "1":
                        //Inserir novo aluno;
                        Console.WriteLine("Insira o nome do aluno");
                        Aluno aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Insira a nota do Aluno");

                        if(decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                            aluno.Nota = nota;
                        }
                        else
                        {
                            throw new ArithmeticException("Valor da nota deve ser decimal");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;

                        break;
                    
                    case "2":

                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Nome))
                            {
                                Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                            }
                        }


                        //Listar alunos;
                        break;

                    case "3":

                        decimal notaTotal = 0;
                        var nrAlunos = 0;    

                        for(var i = 0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Nome))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                nrAlunos++;
                            }                            
                        }

                        var mediaGeral = notaTotal / nrAlunos;
                        Console.WriteLine($"MEDIA GERAL DOS ALUNOS {mediaGeral}");

                        //Calcular a média
                        break;    
                    
                    default:
                        throw new ArgumentOutOfRangeException();
                }    

                opcaoUsuario = ObterOpcaoUsuario();
            
            }
            
            
        }

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();

            return opcaoUsuario;
        }
            
    }
}
