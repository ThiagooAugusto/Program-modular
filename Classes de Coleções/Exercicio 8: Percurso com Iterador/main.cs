using System;
using System.Collections;

class Program {
  public static void Main (string[] args) {

    //instanciar lista linear
    ArrayList frutas = new ArrayList();
    frutas.Add("Banana");
    frutas.Add("Maça");
    frutas.Add("Pera");
    frutas.Add("Melancia");

    //instanciar iterador
    IEnumerator iterador = frutas.GetEnumerator();
    //mover para proxima posição
    iterador.MoveNext();

    //percorrer lista
    for(int i = 0; i < frutas.Count;i++){
      Console.WriteLine(iterador.Current);
      iterador.MoveNext();
    }

    
   
  }
}