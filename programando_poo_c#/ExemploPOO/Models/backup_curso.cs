// using System;
// using ExemploPOO.Helper;
// using ExemploPOO.Interfaces;
// using ExemploPOO.Models;
// using System.Collections.Generic;

// namespace ExemploPOO
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var caminho = "C:\\TrabalhandoComArquivos";
//             var caminhoPathCombine = Path.Combine(caminho, "Pasta teste 1"); 
//             var caminhoArquivo = Path.Combine(caminho, "arquivo-teste-stream.txt");
//             var caminhoArquivoTeste = Path.Combine(caminho, "arquivo-teste.txt");
//             var caminhoArquivoTesteCopia = Path.Combine(caminho, "arquivo-teste-bkp.txt");
//             var listaString = new List<string> {"Linha 1", "Linha 2", "Linha 3"};
//             var listaStringContinuacao = new List<string> {"Linha 4", "Linha 5", "Linha 6"};
//             var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2", "arquivo-teste-stream.txt");    

//             FileHelper helper = new FileHelper();
//             // helper.ListarDiretorios(caminho);
//             // helper.ListarArquivosDiretorios(caminho);
//             //helper.CriarDiretorio(caminhoPathCombine);
//             //helper.ApagarDiretorio(caminhoPathCombine, true);
//             //helper.CriarArquivoTexto(caminhoArquivo, "Criando arquivo txt teste");
//             //helper.CriarAquivoTextoStream(caminhoArquivo, listaString);
//             //helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
//             //helper.LerArquivoStream(caminhoArquivo);
//             //helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo, false);
//             //helper.CopiarArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
//             helper.DeletarArquivo(caminhoArquivoTesteCopia);
            
            
            
            
            
//             // ICalculadora calc = new Calculadora();
//             // System.Console.WriteLine(calc.Somar(6, 2));

//             // Corrente c = new Corrente();
//             // c.Creditar(100);
//             // c.ExibirSaldo();

//             // Calculadora calc = new Calculadora();
//             // System.Console.WriteLine("Resultado da primeira soma" + calc.Somar(10,10));
//             // System.Console.WriteLine("Resultado da segunda soma" + calc.Somar(10,10,10));

//             // Aluno p1 = new Aluno();

//             // p1.Nome = "Nicolas";
//             // p1.Idade = 20;
//             // p1.Documento = "122435";
//             // p1.Nota = 8;
//             // p1.Apresentar();

//             // Professor p2 = new Professor();

//             // p2.Nome = "Nicolas";
//             // p2.Idade = 20;
//             // p2.Documento = "122435";
//             // p2.Salario = 10000;
//             // p2.Apresentar();


//             // Retangulo r = new Retangulo();
//             // r.DefinirMedidas(20,20);
//             // System.Console.WriteLine($"Área:{r.ObterArea()}"); 

//             // Retangulo r2 = new Retangulo();
//             // r2.DefinirMedidas(0,0);
//             // System.Console.WriteLine($"Área:{r2.ObterArea()}"); 
//             // Pessoa p1 = new Pessoa();

//             // p1.Nome = "Nicolas";
//             // p1.Idade = 20;

//             // p1.Apresentar();

//         }
//     }
// }
