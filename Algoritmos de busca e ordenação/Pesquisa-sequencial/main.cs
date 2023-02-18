using System;

class Program {
  public static void Main (string[] args) {
    int [] vetor = new int[10];
    int pesquisa,comparacoes = 0;

    Random rnd = new Random();

    //preencher vetor
    for(int i = 0;i < vetor.Length;i++){
      vetor[i] = rnd.Next(10);
    }

    //ler chave
    Console.Write("Digite elemento a buscar:");
    pesquisa = int.Parse(Console.ReadLine());

    //pesquisar e mostrar custo
    for(int i = 0;i < vetor.Length;i++){
      if(vetor[i] == pesquisa){
        Console.WriteLine($"{pesquisa} foi encontrado na posiçao {i}");
        i = vetor.Length;
      }
      comparacoes++;
    }

    Console.WriteLine("Numero de comparaçoes: {0}",comparacoes);

     //mostrar vetor
    Console.Write("[");
    foreach(int ele in vetor){
      Console.Write(ele + " ");
    }
    Console.WriteLine("]");
  }
}