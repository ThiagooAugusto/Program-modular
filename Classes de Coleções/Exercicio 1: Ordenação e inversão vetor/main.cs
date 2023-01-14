using System;

public class MaisMetodosArray{
  public static void ImprimirVetor(int [] numeros, string ordem){
    Console.WriteLine(ordem);
    foreach(int i in numeros){
      Console.Write(i+" ");
    }
    Console.WriteLine();
  }
}

class Program {
  public static void Main (string[] args) {
    //instanciar vetor
    int [] vetor = new int [5]{10,9,20,15,4};

    //imprimir em ordem crescente
    Array.Sort(vetor);
    MaisMetodosArray.ImprimirVetor(vetor,"Ordem Crescente");

    //imprimir em ordem decrescente
    Array.Reverse(vetor);
    MaisMetodosArray.ImprimirVetor(vetor,"Ordem Decrescente");
    
  }
}