using System.Linq;
using System;
using Colecoes.Helper;

namespace Coleçoes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();


            System.Console.WriteLine($"minimo {minimo} ");
            System.Console.WriteLine($"maximo {maximo} ");
            System.Console.WriteLine($"medio {medio} ");
            System.Console.WriteLine($"soma {soma} ");
            System.Console.WriteLine($"array original {string.Join(", ", arrayNumeros)}");
            System.Console.WriteLine($"array distinto {string.Join(", ", arrayUnico)}");

            // var numerosParesQuery = 
            //         from num in arrayNumeros
            //         where num % 2 == 0
            //         orderby num
            //         select num;

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            // System.Console.WriteLine("numeros pares query: " + string.Join(", ",numerosParesQuery));
            // System.Console.WriteLine("numeros pares metodo: " + string.Join(", ",numerosParesMetodo));



            // Dictionary<string, string> estados = new Dictionary<string, string>();

            // estados.Add("SP", "Sao Paulo");
            // estados.Add("MG", "Minas Gerais");
            // estados.Add("RJ","Rio de Janeiro");

            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     //System.Console.WriteLine($"Chave: {item.Key}, valor {item.Value}");
            // }

            // string valorProcurado = "SP";

            
            // if(estados.TryGetValue(valorProcurado, out string estadoEncontrado))
            // {
            //     System.Console.WriteLine(estadoEncontrado);
            // }else
            // {
            //     System.Console.WriteLine($"Chave {valorProcurado} nao existe no dicionario");
            // }

    
            // System.Console.WriteLine($"Removendo o valor: {valorProcurado}");

            // estados.Remove(valorProcurado);


            // foreach (KeyValuePair<string, string> item in estados)
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, valor {item.Value}");
            // }

            // System.Console.WriteLine("Valor original: ");
            // System.Console.WriteLine(estados[valorProcurado]);

            // estados[valorProcurado] = "SP - teste atualizaçao";

            // System.Console.WriteLine("Valor atualizado: ");
            // System.Console.WriteLine(estados[valorProcurado]);

            // Stack<string> pilhaLivros = new Stack<string>();

            // pilhaLivros.Push(".NET");
            // pilhaLivros.Push("DDD");
            // pilhaLivros.Push("Codigo limpo");

            // System.Console.WriteLine($"livros para a leitura {pilhaLivros.Count}");

            // while (pilhaLivros.Count > 0)
            // {
            //     System.Console.WriteLine($"Proximo livro para leitura {pilhaLivros.Peek()}");
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso!");

            // }

            // System.Console.WriteLine($"livros para a leitura {pilhaLivros.Count}");



            // Queue<String> fila = new Queue<string>();

            // fila.Enqueue("Fred");
            // fila.Enqueue("Adam");
            // fila.Enqueue("Atenor");


            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // while (fila.Count > 0)
            // {
            //     System.Console.WriteLine($" vez de: {fila.Peek()}");
            //     System.Console.WriteLine($"{fila.Dequeue()} foi atendido ");
            // }

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

            // OperacoesLista opLista = new OperacoesLista();
            // List<string> estados = new List<string>{"SP", "MG", "BA"};
            // string[] estadosArray = new string[2] {"SC", "MT"};

           
            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

            // opLista.ImprimirListaString(estados);

            // //System.Console.WriteLine("Removendo o elemento ");

            // //estados.Remove("MG");

            // //estados.AddRange(estadosArray);
            // estados.Insert(1, "RJ");

            // opLista.ImprimirListaString(estados);


           
            //  OperacoesArray op = new OperacoesArray();

            //  int[] array = new int[5] {6,8,5,2,9};
            //  int[] arrayCopia = new int[10];
            //  string[] arrayString = op.ConverterParaArrayString(array);

             //int valorProcurado = 9;


            //  System.Console.WriteLine($"capacidade atual do array: {array.Length} ");

            //  op.RedimencionarArray(ref array, array.Length * 2 );

            //  System.Console.WriteLine($"capacidade atual do array apos redimencionar: {array.Length}");

            //  int indice = op.ObterIndice(array, valorProcurado);

            //  if (indice > -1)
            //  {
            //      System.Console.WriteLine("o indice do elemento {0} é: {1} ", valorProcurado, indice);
            //  }else
            //  {
            //      System.Console.WriteLine("valor nao exixtente no array");
            //  }

            //  int valorAchado = op.ObterValor(array, valorProcurado);

            //  if (valorAchado > 0)
            //  {
            //      System.Console.WriteLine("Encontrei o valor");
            //  }else
            //  {
            //      System.Console.WriteLine("Nao encontrei o valor");
            //  }



            //  bool TodosMaiorQue = op.TodosMaiorQue(array, valorProcurado);

            //  if (TodosMaiorQue)
            //  {
            //      System.Console.WriteLine("Todos os valores sao maiores que {0}", valorProcurado);
            //  }else
            //  {
            //      System.Console.WriteLine("Existe valores que nao sao maiores que {0}", valorProcurado);
            //  }

            //  bool  existe = op.Existe(array, valorProcurado);

            //  if (existe)
            //  {
            //      System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
            //  }else
            //  {
            //      System.Console.WriteLine("Nao encontrei o valor: {0}", valorProcurado);
            //  }

             //System.Console.WriteLine("array original: ");
             //op.ImprimirArray(array);

             //op.OrdenarBublleSort( ref array);
             //op.Ordenar(ref array);

             //System.Console.WriteLine("array ordenado: ");
             //op.ImprimirArray(array);

            //  System.Console.WriteLine("array antes da copia ");
            //  op.ImprimirArray(arrayCopia);

            //  op.Copiar(ref array, ref arrayCopia);
            //  System.Console.WriteLine("array apos a copia");
            //  op.ImprimirArray(arrayCopia);

            // int[,] matriz = new int[4, 2]
            // {
            //     {8,8},
            //     {10,20},
            //     {9,7},
            //     {6,2}, 
            //};

            // for (int i = 0; i < matriz.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matriz.GetLength(1); j++)
            //     {
            //         System.Console.WriteLine(matriz[i,j]);
            //     }
            // }

            // int[] arrayInteiros = new int[3];

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = 30;

            // System.Console.WriteLine("percorrendo o array com For");
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("percorrendo o array com ForEach");
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }

        
        }
    }
}
