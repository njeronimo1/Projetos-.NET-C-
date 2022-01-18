using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10]{100,1,4,0,8,15,19, 19, 4, 100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var distinct = arrayNumeros.Distinct().ToArray();

            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Maximo: {maximo}");
            System.Console.WriteLine($"Médio: {medio}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array original: {string.Join(",", arrayNumeros)}");
            System.Console.WriteLine($"Array unico: {string.Join(",", distinct)}");

            // var numerosPares =
            //         from num in arrayNumeros
            //         where num % 2 == 0
            //         orderby num
            //         select num;

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("Números pares query " + string.Join(", ", numerosPares));
            // System.Console.WriteLine("Números pares metodo " + string.Join(", ", numerosParesMetodo));

            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("SP", "São Paulo");
            // estados.Add("MG", "Minas Gerais");
            // estados.Add("BA", "Bahia");

            // foreach (var item in estados)
            // {
            // //   System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }

            // string valorProcurado ="SC";

            // //var teste = estados["SC"];

            // if (estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }else{
            //     System.Console.WriteLine($"Chave {valorProcurado} não existe");
            //}

            // System.Console.WriteLine($"Removendo o valor: {valorProcurado}");



            // estados.Remove(valorProcurado);



            // foreach (var item in estados)
            // {
            //   System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            // }
            // System.Console.WriteLine("Valor original");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "BA - TESTE";
            // System.Console.WriteLine(estados[valorProcurado]);
            // Stack<string> pilhaLivros = new Stack<string>();
            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("C#");
            // pilhaLivros.Push("DDD");

            // System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count()}");
            // while(pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Proximo livro : {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} Lido com sucesso");
            // }
            // System.Console.WriteLine($"Livros para leitura: {pilhaLivros.Count()}");

            // Queue<string> fila = new Queue<string>();
            // fila.Enqueue("Nicolas");
            // fila.Enqueue("Karol");
            // fila.Enqueue("Luciana");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");
            // while(fila.Count > 0)
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");

            // }
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string> { "sp", "mg", "ba" };
            // string[] estadosArray = new string[2]{ "SC", "MT" };

            // System.Console.WriteLine($"Quantidade de elementos na lista {estados.Count}");

            // // System.Console.WriteLine("Removendo o elemento");
            // // estados.Remove("MG");
            // //estados.AddRange(estadosArray);
            // estados.Insert(1, "RJ");

            // opLista.ImprimirListaString(estados);

            // OperacoesArray op = new OperacoesArray();
            // int[] array = new int[5] { 6,3,8,4,3 };
            // int[] arrayCopia = new int[10];
            // string[] arrayString = op.ConverterParaArrayString(array);

            // System.Console.WriteLine($"Capacidade atual do array {array.Length}");

            // op.RedimencionarArray(ref array, array.Length * 2);

            // System.Console.WriteLine($"Após redimencionar {array.Length}");
            // int indexOf = op.ObterIndice(array, valorProcurado);
            // if(indexOf > -1)
            // {
            //     System.Console.WriteLine("O indice do elemento {0} é: {1}", valorProcurado, indexOf);
            // }else{
            //     System.Console.WriteLine("Não encontrei {0}", valorProcurado);
            // }

            // int valorAchado = op.ObterValor(array, valorProcurado);
            // if(valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }else{
            //     System.Console.WriteLine("Não encontrei");
            // }

            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            // if(todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos valores são maior que {0}", valorProcurado);
            // }
            // else{
            //     System.Console.WriteLine("Existe valores que não são maiores que {0}", valorProcurado);
            // }
            // bool existe = op.Existe(array, valorProcurado);

            // if(existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor {0}", valorProcurado);
            // }else{
            //     System.Console.WriteLine("Não encontrei o valor {0}", valorProcurado);
            // }

            // System.Console.WriteLine("Array original");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array com bubble");
            // //op.OrdenarBubbleSort(ref array);
            // //op.Ordenar(ref array);


            // System.Console.WriteLine("Array ordenado");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia");
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a cópia");
            // op.ImprimirArray(arrayCopia);

            // int [,] matriz = new int[4,2]
            // {
            //     { 8, 8 },
            //     { 7, 7 },
            //     { 6, 6 },
            //     { 5, 5 }
            // };

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i, j]);
            //     }
            // }

            // int[] arrayInteiros = new int[3];
            // arrayInteiros[0] = 1;
            // arrayInteiros[1] = 2;
            // arrayInteiros[2] = int.Parse("40");
            // arrayInteiros[3] = 30;

            // System.Console.WriteLine("For");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("ForEach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}
